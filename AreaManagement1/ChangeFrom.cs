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

            double[] lineLength = getList.GetLength();

            if (shapeName == ShapeEnum.ShapeNameEnum.台形)
            {
                TrapezoidRadio.Checked = true;

                textBox2.Enabled = true;
                textBox3.Enabled = true;

                textBox2.Text = lineLength[1].ToString();
                textBox3.Text = lineLength[2].ToString();
            }
            if (shapeName == ShapeEnum.ShapeNameEnum.三角形)
            {
                TriangleRadio.Checked = true;
            }
            textBox1.Text = lineLength[0].ToString();
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
                var getlist = shapeMana.GetShape(selectedIndex);
                int inputLength = int.Parse(textBox1.Text);

                if (QuadRadio.Checked)
                {
                    ((Quadrilarea)getlist).SetLength(inputLength);
                }
                else if (TriangleRadio.Checked)
                {
                    ((Triangle)getlist).SetLength(inputLength);
                }
                else
                {
                    int inputhUpperBaseLength = int.Parse(textBox2.Text);
                    int inputhLowerBaseLength = int.Parse(textBox3.Text);
                    ((Trapezoid)getlist).SetLength(inputLength, inputhUpperBaseLength, inputhLowerBaseLength);
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
