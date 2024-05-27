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
        ShapeManager shapeMana;
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
            if (QuadRadio.Checked)
            {
                try
                {
                    int inputLength = int.Parse(LengthTextBox.Text);
                    var quad = new Quadrilarea(inputLength);

                    shapeMana.AddShapeList(quad);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch
                {
                    MessageBox.Show(
                        Consts.MESSAGE_PLEASENUMVER,
                        Consts.ERROR_MESSAGE,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Hand
                        );
                }
            }
            else if (TriangleRadio.Checked)
            {
                try
                {
                    int inputLength = int.Parse(LengthTextBox.Text);
                    var triangle = new Triangle(inputLength);

                    shapeMana.AddShapeList(triangle);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch
                {
                    MessageBox.Show(
                        Consts.MESSAGE_PLEASENUMVER,
                        Consts.ERROR_MESSAGE,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Hand
                     );
                }
            }
            else
            {
                try
                {
                    int inputLength = int.Parse(LengthTextBox.Text);
                    int inputhUpperBaseLength = int.Parse(upperBaseLengthtextBox.Text);
                    int inputhLowerBaseLength = int.Parse(lowerBaseLengthtextBox.Text);

                    var trapezoid = new Trapezoid(inputLength, inputhUpperBaseLength, inputhLowerBaseLength);

                    shapeMana.AddShapeList(trapezoid);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch
                {
                    MessageBox.Show(
                        Consts.MESSAGE_PLEASENUMVER,
                        Consts.ERROR_MESSAGE,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Hand
                        );
                }
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
