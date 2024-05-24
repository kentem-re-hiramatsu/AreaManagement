using AreaManagement.Controller;
using ChangeForm;
using Subform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaManagement1
{
    public partial class MainForm : Form
    {
        ShapeManager shapeMana = new ShapeManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SubForm subfrom = new SubForm(shapeMana);

            if(DialogResult.OK == subfrom.ShowDialog())
            {
                UpdateView();
            }
            DeleteAndChangeButtonChange();
        }

        public void UpdateView()
        {
            var shapeList = shapeMana.GetShapeList();
            double sumArea = 0;
            listView1.Items.Clear();

            if(shapeList != null)
            {
                for(int i = 0; i < shapeList.Count; i++)
                {
                    listView1.Items.Add(shapeList[i].ShapeName).SubItems.Add(shapeList[i].Area.ToString());
                    sumArea += shapeList[i].Area;
                }
                TotalLabel.Text = $"Total： {sumArea}";
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                int selectedIndex = listView1.SelectedItems[0].Index;
                shapeMana.RemoveShapeAtIndex(selectedIndex);
                UpdateView();
                DeleteAndChangeButtonChange();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteAndChangeButtonChange();
        }

        public void DeleteAndChangeButtonChange()
        {
            DeleteButton.Enabled = listView1.SelectedItems.Count > 0;
            ChangeButton.Enabled = listView1.SelectedItems.Count > 0;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = 0;

            if (listView1.SelectedItems.Count > 0)
            {
                selectedIndex = listView1.SelectedItems[0].Index;
            }

            ChangeFrom changeFrom = new ChangeFrom(shapeMana, selectedIndex);

            if (DialogResult.OK == changeFrom.ShowDialog())
            {
                UpdateView();
            }
            DeleteAndChangeButtonChange();
        }
    }
}
