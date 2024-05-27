using AreaManagement.Controller;
using AreaManagement.Model;
using ChangeForm;
using Subform;
using System;
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

            if (DialogResult.OK == subfrom.ShowDialog())
            {
                UpdateView();
            }
            DeleteAndChangeButtonChange();
        }

        public void UpdateView()
        {
            listView1.Items.Clear();

            var shapeListCount = shapeMana.GetShapeListCount();

            for (int i = 0; i < shapeListCount; i++)
            {
                Shape shapeList = shapeMana.GetShape(i);
                listView1.Items.Add(shapeList.GetShapeName().ToString()
                    ).SubItems.Add(shapeList.GetArea().ToString());
            }

            var sumArea = shapeMana.GetSumArea();
            TotalLabel.Text = $"Total： {sumArea}";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
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
