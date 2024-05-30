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
        private ShapeManager shapeMana = new ShapeManager();
        private int _digitCount = 4;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            shapeMana.LoadShapeDataFile();

            UpdateView();
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
            ShapeListView.Items.Clear();

            var shapeListCount = shapeMana.GetShapeListCount();

            for (int i = 0; i < shapeListCount; i++)
            {
                Shape shapeList = shapeMana.GetShape(i);
                ShapeListView.Items.Add(shapeList.GetShapeName().ToString()).SubItems.Add(Math.Round(shapeList.GetArea(), _digitCount).ToString());
            }

            var sumArea = Math.Round(shapeMana.GetSumArea(), _digitCount);
            TotalLabel.Text = $"Total： {sumArea}";

            ClearButton.Enabled = shapeMana.GetShapeListCount() > 0;
            UpDigit.Enabled = _digitCount > 0;
            DownDigit.Enabled = _digitCount < 4;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ShapeListView.SelectedItems.Count > 0)
            {
                int selectedIndex = ShapeListView.SelectedItems[0].Index;
                shapeMana.RemoveShapeAtIndex(selectedIndex);
                UpdateView();
                DeleteAndChangeButtonChange();
            }
        }

        public void DeleteAndChangeButtonChange()
        {
            DeleteButton.Enabled = ShapeListView.SelectedItems.Count > 0;
            ChangeButton.Enabled = ShapeListView.SelectedItems.Count > 0;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = 0;

            if (ShapeListView.SelectedItems.Count > 0)
            {
                selectedIndex = ShapeListView.SelectedItems[0].Index;
            }

            ChangeFrom changeFrom = new ChangeFrom(shapeMana, selectedIndex);

            if (DialogResult.OK == changeFrom.ShowDialog())
            {
                UpdateView();
            }
            DeleteAndChangeButtonChange();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("すべて削除されますがよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.OK)
            {
                shapeMana.ClearShape();
                UpdateView();
            }
        }

        private void UpDigit_Click(object sender, EventArgs e)
        {
            _digitCount--;

            UpdateView();
        }

        private void DownDigit_Click(object sender, EventArgs e)
        {
            _digitCount++;

            UpdateView();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            shapeMana.SaveShapeDataFile();
        }

        private void ShapeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteAndChangeButtonChange();
        }
    }
}
