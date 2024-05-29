using AreaManagement;
using AreaManagement.Controller;
using AreaManagement.Model;
using AreaManagement1;
using AreaManagement1.Model;
using System;
using System.Windows.Forms;

namespace Subform
{
    public partial class SubForm : Form
    {
        private ShapeManager shapeMana = null;
        private ShapeNameEnum shapeName;

        public SubForm(ShapeManager shapeMana)
        {
            InitializeComponent();
            this.shapeMana = shapeMana;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SubForm_Load(object sender, EventArgs e)
        {
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Shape shape = null;

            try
            {
                int inputLength = int.Parse(LengthTextBox.Text);

                switch (shapeName)
                {
                    case ShapeNameEnum.四角形:
                        {
                            shape = new Quadrilarea(inputLength);
                        }
                        break;

                    case ShapeNameEnum.三角形:
                        {
                            shape = new Triangle(inputLength);
                        }
                        break;

                    case ShapeNameEnum.台形:
                        {
                            int inputUpperBaseLength = int.Parse(upperBaseLengthtextBox.Text);
                            int inputLowerBaseLength = int.Parse(lowerBaseLengthtextBox.Text);
                            shape = new Trapezoid(inputLength, inputUpperBaseLength, inputLowerBaseLength);
                        }
                        break;

                    default: break;
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message, Consts.ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (shape != null)
            {
                shapeMana.AddShapeList(shape);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void TrapezoidRadioButtonChange()
        {
            upperBaseLengthtextBox.Enabled = TrapezoidRadio.Checked;
            lowerBaseLengthtextBox.Enabled = TrapezoidRadio.Checked;
        }

        private void OkButtonChange()
        {
            OkButton.Enabled = (TrapezoidRadio.Checked && LengthTextBox.Text.Length > 0 && upperBaseLengthtextBox.Text.Length > 0 && lowerBaseLengthtextBox.Text.Length > 0) || ((TriangleRadio.Checked || QuadRadio.Checked) && LengthTextBox.Text.Length > 0);
        }

        private void QuadRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!QuadRadio.Checked)
                return;

            TrapezoidRadioButtonChange();
            OkButtonChange();
            shapeName = ShapeNameEnum.四角形;
        }

        private void TriangleRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!TriangleRadio.Checked)
                return;

            TrapezoidRadioButtonChange();
            OkButtonChange();
            shapeName = ShapeNameEnum.三角形;
        }

        private void TrapezoidRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!TrapezoidRadio.Checked)
                return;

            TrapezoidRadioButtonChange();
            OkButtonChange();
            shapeName = ShapeNameEnum.台形;
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            OkButtonChange();
        }
    }
}
