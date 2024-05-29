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
        private ShapeManager shapeMana;
        private int _selectedIndex;
        private ShapeNameEnum shapeName;

        public ChangeFrom(ShapeManager shapeMana, int selectedIndex)
        {
            InitializeComponent();
            this.shapeMana = shapeMana;
            _selectedIndex = selectedIndex;
        }

        private void ChangeFrom_Load(object sender, EventArgs e)
        {
            SetInitialValueInTextBox();
            SetInitialChecked();
        }

        public void SetInitialValueInTextBox()
        {
            var list = shapeMana.GetShape(_selectedIndex);
            var shapeName = list.GetShapeName();

            double singleLength;

            switch (shapeName)
            {
                case ShapeNameEnum.四角形:
                    {
                        singleLength = ((Quadrilarea)list).Length;
                        LengthTextBox.Text = singleLength.ToString();
                        this.shapeName = ShapeNameEnum.四角形;
                    }
                    break;

                case ShapeNameEnum.三角形:
                    {
                        singleLength = ((Triangle)list).Length;
                        LengthTextBox.Text = singleLength.ToString();
                        this.shapeName = ShapeNameEnum.三角形;
                    }
                    break;

                case ShapeNameEnum.台形:
                    {
                        upperBaseLengthtextBox.Enabled = true;
                        lowerBaseLengthtextBox.Enabled = true;

                        LengthTextBox.Text = ((Trapezoid)list).Height.ToString();
                        upperBaseLengthtextBox.Text = ((Trapezoid)list).UpperBaseLength.ToString();
                        lowerBaseLengthtextBox.Text = ((Trapezoid)list).LowerBaseLength.ToString();

                        this.shapeName = ShapeNameEnum.台形;
                    }
                    break;

                default:
                    break;
            }
        }

        public void SetInitialChecked()
        {
            TriangleRadio.Checked = shapeName == ShapeNameEnum.三角形;
            TrapezoidRadio.Checked = shapeName == ShapeNameEnum.台形;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                var slectedShape = shapeMana.GetShape(_selectedIndex);
                int inputLength = int.Parse(LengthTextBox.Text);

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
                            int inputhUpperBaseLength = int.Parse(upperBaseLengthtextBox.Text);
                            int inputhLowerBaseLength = int.Parse(lowerBaseLengthtextBox.Text);
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

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            OkButton.Enabled = OkButton.Enabled = (TrapezoidRadio.Checked && LengthTextBox.Text.Length > 0 && upperBaseLengthtextBox.Text.Length > 0 && lowerBaseLengthtextBox.Text.Length > 0) || ((TriangleRadio.Checked || QuadRadio.Checked) && LengthTextBox.Text.Length > 0);
        }
    }
}
