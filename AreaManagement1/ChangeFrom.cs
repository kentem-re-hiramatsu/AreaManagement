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
                    }
                    break;

                case ShapeNameEnum.三角形:
                    {
                        TriangleRadio.Checked = true;
                        singleLength = ((Triangle)getList).Length;
                        textBox1.Text = singleLength.ToString();
                    }
                    break;

                case ShapeNameEnum.台形:
                    {
                        double[] trapezoidLineLength = ((Trapezoid)getList).GetLength();
                        TrapezoidRadio.Checked = true;

                        textBox2.Enabled = true;
                        textBox3.Enabled = true;

                        textBox1.Text = trapezoidLineLength[0].ToString();
                        textBox2.Text = trapezoidLineLength[1].ToString();
                        textBox3.Text = trapezoidLineLength[2].ToString();
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

                if (QuadRadio.Checked)
                {
                    ((Quadrilarea)slectedShape).Length = inputLength;
                }
                else if (TriangleRadio.Checked)
                {
                    ((Triangle)slectedShape).Length = inputLength;
                }
                else
                {
                    int inputhUpperBaseLength = int.Parse(textBox2.Text);
                    int inputhLowerBaseLength = int.Parse(textBox3.Text);
                    ((Trapezoid)slectedShape).SetLength(inputLength, inputhUpperBaseLength, inputhLowerBaseLength);
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
