using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using AreaManagement.Model;
using System.Windows.Forms;

namespace Subform
{
    public partial class SubForm : Form
    {
        public SubForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubForm_Load(object sender, EventArgs e)
        {
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(QuadRazio.Checked)
            {
                ShapeManager
            }
            else
            {

            }
        }
    }
}
