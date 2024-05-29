using AreaManagement;
using AreaManagement.Controller;
using AreaManagement.Model;
using AreaManagement1;
using AreaManagement1.Model;
using System;
using System.Windows.Forms;

namespace ChangeForm
{
    public partial class ChangeFrom : Form
    {
        ShapeManager shapeMana;
        int selectedIndex;
        ShapeNameEnum shapeName;

        public ChangeFrom(ShapeManager shapeMana, int selectedIndex)
        {
            InitializeComponent();
            this.shapeMana = shapeMana;
            this.selectedIndex = selectedIndex;
        }

        private void ChangeFrom_Load(object sender, EventArgs e)
        {
            SetInitialValueInTextBox();
        }

        public void SetInitialValueInTextBox()
        {
            var getList = shapeMana.GetShape(selectedIndex);
            var shapeName = getList.GetShapeName();

            double singleLength;

            switch (shapeName)
            {
                case ShapeNameEnum.四角形:
                    {
                        singleLength = ((Quadrilarea)getList).Length;
                        textBox1.Text = singleLength.ToString();
                        this.shapeName = ShapeNameEnum.四角形;
                    }
                    break;

                case ShapeNameEnum.三角形:
                    {
                        TriangleRadio.Checked = true;
                        singleLength = ((Triangle)getList).Length;
                        textBox1.Text = singleLength.ToString();
                        this.shapeName = ShapeNameEnum.三角形;
                    }
                    break;

                case ShapeNameEnum.台形:
                    {
                        TrapezoidRadio.Checked = true;

                        textBox2.Enabled = true;
                        textBox3.Enabled = true;

                        textBox1.Text = ((Trapezoid)getList).Height.ToString();
                        textBox2.Text = ((Trapezoid)getList).UpperBaseLength.ToString();
                        textBox3.Text = ((Trapezoid)getList).LowerBaseLength.ToString();

                        this.shapeName = ShapeNameEnum.台形;
                    }
                    break;

                default:
                    break;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OkButton.Enabled = (TrapezoidRadio.Checked && textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0) || ((TriangleRadio.Checked || QuadRadio.Checked) && textBox1.Text.Length > 0);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                var slectedShape = shapeMana.GetShape(selectedIndex);
                int inputLength = int.Parse(textBox1.Text);

                switch (shapeName)
                {
                    case ShapeNameEnum.四角形:
                        {
                            ((Quadrilarea)slectedShape).Length = inputLength;
                        }
                        break;

                    case ShapeNameEnum.三角形:
                        {
                            ((Triangle)slectedShape).Length = inputLength;
                        }
                        break;

                    case ShapeNameEnum.台形:
                        {
                            int inputhUpperBaseLength = int.Parse(textBox2.Text);
                            int inputhLowerBaseLength = int.Parse(textBox3.Text);
                            ((Trapezoid)slectedShape).SetLength(inputLength, inputhUpperBaseLength, inputhLowerBaseLength);
                        }
                        break;
                    default: break;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message, Consts.ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
