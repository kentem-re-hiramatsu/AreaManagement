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
            SetInitialValue();
            SetInitialChecked();
        }

        private void SetInitialValue()
        {
            var selectedShape = shapeMana.GetShape(_selectedIndex);
            var shapeName = selectedShape.GetShapeName();

            double singleLength;

            switch (shapeName)
            {
                case ShapeNameEnum.四角形:
                    {
                        singleLength = ((Quadrilarea)selectedShape).Length;
                        LengthTextBox.Text = singleLength.ToString();
                        this.shapeName = ShapeNameEnum.四角形;
                    }
                    break;

                case ShapeNameEnum.三角形:
                    {
                        singleLength = ((Triangle)selectedShape).Length;
                        LengthTextBox.Text = singleLength.ToString();
                        this.shapeName = ShapeNameEnum.三角形;
                    }
                    break;

                case ShapeNameEnum.台形:
                    {
                        upperBaseLengthtextBox.Enabled = true;
                        lowerBaseLengthtextBox.Enabled = true;

                        LengthTextBox.Text = ((Trapezoid)selectedShape).Height.ToString();
                        upperBaseLengthtextBox.Text = ((Trapezoid)selectedShape).UpperBaseLength.ToString();
                        lowerBaseLengthtextBox.Text = ((Trapezoid)selectedShape).LowerBaseLength.ToString();

                        this.shapeName = ShapeNameEnum.台形;
                    }
                    break;

                case ShapeNameEnum.円:
                    {
                        singleLength = ((Circle)selectedShape).Length;
                        LengthTextBox.Text = singleLength.ToString();
                        SideLengthLabel.Text = "半径の長さ";
                        this.shapeName = ShapeNameEnum.円;
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
            CircleRadio.Checked = shapeName == ShapeNameEnum.円;
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

                    case ShapeNameEnum.円:
                        {
                            ((Circle)slectedShape).Length = inputLength;
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
            OkButton.Enabled = (TrapezoidRadio.Checked && LengthTextBox.Text.Length > 0 && upperBaseLengthtextBox.Text.Length > 0 && lowerBaseLengthtextBox.Text.Length > 0) || ((TriangleRadio.Checked || QuadRadio.Checked || CircleRadio.Checked) && LengthTextBox.Text.Length > 0);
        }
    }
}
