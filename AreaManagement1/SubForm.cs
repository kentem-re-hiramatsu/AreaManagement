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

            if(QuadRazio.Checked)
            {
                var quad = new Quadrilarea(inputLength);
                quad.SetArea();
                shapeMana.AddShapeList(quad);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                var triangle = new Triangle(inputLength);
                triangle.SetArea();
                shapeMana.AddShapeList(triangle);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
