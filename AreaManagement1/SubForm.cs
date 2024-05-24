using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using AreaManagement.Model;
using AreaManagement.Controller;
using System.Windows.Forms;
using AreaManagement1;
using AreaManagement1.Model;

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
            int inputLength = int.Parse(textBox1.Text);
            int inputhUpperBaseLength = int.Parse(textBox2.Text);
            int inputhLowerBaseLength = int.Parse(textBox3.Text);

            if(QuadRazio.Checked)
            {
                var quad = new Quadrilarea(inputLength);
                quad.SetArea();
                shapeMana.AddShapeList(quad);
                DialogResult = DialogResult.OK;
                Close();
            }
            else if(TriangleRazio.Checked)
            {
                var triangle = new Triangle(inputLength);
                triangle.SetArea();
                shapeMana.AddShapeList(triangle);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                var trapezoid = new Trapezoid(inputLength, inputhUpperBaseLength, inputhLowerBaseLength);
                trapezoid.SetArea();
                shapeMana.AddShapeList(trapezoid);
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
