using AreaManagement.Controller;
using AreaManagement.Model;
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
            if(QuadRazio.Checked)
            {
                try
                {
                    int inputLength = int.Parse(textBox1.Text);
                    var quad = new Quadrilarea(inputLength);

                    shapeMana.AddShapeList(quad);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch
                {
                    MessageBox.Show(
                        "数値を入力してください。",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Hand
                        );
                }
            }
            else if(TriangleRazio.Checked)
            {
                try
                {
                    int inputLength = int.Parse(textBox1.Text);
                    var triangle = new Triangle(inputLength);

                    shapeMana.AddShapeList(triangle);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch
                {
                    MessageBox.Show(
                        "数値を入力してください。",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Hand
                     );
                }
            }
            else
            {
                try
                {
                    int inputLength = int.Parse(textBox1.Text);
                    int inputhUpperBaseLength = int.Parse(textBox2.Text);
                    int inputhLowerBaseLength = int.Parse(textBox3.Text);

                    var trapezoid = new Trapezoid(inputLength, inputhUpperBaseLength, inputhLowerBaseLength);

                    shapeMana.AddShapeList(trapezoid);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch
                {
                    MessageBox.Show(
                        "数値を入力してください。",
                        "エラー",
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
            textBox2.Enabled = TrapezoidRazio.Checked;
            textBox3.Enabled = TrapezoidRazio.Checked;
        }

        private void OkButtonChange()
        {
            OkButton.Enabled = (TrapezoidRazio.Checked && textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0) || ((TriangleRazio.Checked || QuadRazio.Checked) && textBox1.Text.Length > 0);
        }

        private void TrapezoidRadioButtonChange(object sender, EventArgs e)
        {
            TrapezoidRadioButtonChange();
            OkButtonChange();
        }
    }
}
