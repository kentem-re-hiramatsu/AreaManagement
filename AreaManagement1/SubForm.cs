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
        ShapeManager shapeMana = null;
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

                if (QuadRadio.Checked)
                {
                    shape = new Quadrilarea(inputLength);
                }
                else if (TriangleRadio.Checked)
                {
                    shape = new Triangle(inputLength);
                }
                else if (TrapezoidRadio.Checked)
                {
                    int inputUpperBaseLength = int.Parse(upperBaseLengthtextBox.Text);
                    int inputLowerBaseLength = int.Parse(lowerBaseLengthtextBox.Text);
                    shape = new Trapezoid(inputLength, inputUpperBaseLength, inputLowerBaseLength);
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OkButtonChange();
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

        private void TrapezoidRadioButtonChange(object sender, EventArgs e)
        {
            TrapezoidRadioButtonChange();
            OkButtonChange();
        }
    }
}
