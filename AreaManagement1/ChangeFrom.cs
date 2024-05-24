using AreaManagement.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Subform;
using AreaManagement.Model;
using AreaManagement1.Model;

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
            var getList = shapeMana.GetShapeList();
            var shapeName = getList[selectedIndex].ShapeName;
            double lineLength = 0;
            double lineLength2 = 0;
            double lineLength3 = 0;

            if (shapeName == "四角形" || shapeName == "三角形")
            {
                lineLength = getList[selectedIndex].LineLength;

                if (shapeName == "四角形") { QuadRazio.Checked = true; }
                else{ TriangleRazio.Checked = true; }
            }
            else
            {
                lineLength = getList[selectedIndex].LineLength;
                lineLength2 = getList[selectedIndex].LineLength2;
                lineLength3 = getList[selectedIndex].LineLength3;

                TrapezoidRazio.Checked = true;
            }

            textBox1.Text = lineLength.ToString();
            textBox2.Text = lineLength2.ToString();
            textBox3.Text = lineLength3.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OkButton.Enabled = (TrapezoidRazio.Checked && textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0) || ((TriangleRazio.Checked || QuadRazio.Checked) && textBox1.Text.Length > 0);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (QuadRazio.Checked)
            {
                try
                {
                    int inputLength = int.Parse(textBox1.Text);
                    var quad = new Quadrilarea(inputLength);

                    quad.SetArea();
                    quad.SetLineLength();

                    shapeMana.ChangeShape(quad, selectedIndex);
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
            else if (TriangleRazio.Checked)
            {
                try
                {
                    int inputLength = int.Parse(textBox1.Text);
                    var triangle = new Triangle(inputLength);

                    triangle.SetArea();
                    triangle.SetLineLength();

                    shapeMana.ChangeShape(triangle, selectedIndex);
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

                    trapezoid.SetArea();
                    trapezoid.SetLineLength();

                    shapeMana.ChangeShape(trapezoid, selectedIndex);
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
    }
}
