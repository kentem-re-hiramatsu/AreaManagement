using AreaManagement;
using AreaManagement.Controller;
using AreaManagement.Model;
using AreaManagement1.Model;
using ChangeForm;
using Subform;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AreaManagement1
{
    public partial class MainForm : Form
    {
        private ShapeManager shapeMana = new ShapeManager();
        private int _digitCount = 4;
        private string _shapeDataFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Data/ShapeName.txt");

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Shape shape = null;
            List<string> shapeList = new List<string>();

            using (StreamReader streamReader = new StreamReader(_shapeDataFilePath, Encoding.UTF8))
            {
                while (streamReader.EndOfStream == false)
                {
                    string line = streamReader.ReadLine();
                    shapeList.Add(line);
                }
            }

            var shapeCount = shapeList.Count;

            for (int i = 0; i < shapeCount; i++)
            {
                string[] shapeData = shapeList[i].Split(',');

                switch (double.Parse(shapeData[0]))
                {
                    case (int)ShapeNameEnum.四角形:
                        shape = new Quadrilarea(double.Parse(shapeData[1]));
                        break;

                    case (int)ShapeNameEnum.三角形:
                        shape = new Triangle(double.Parse(shapeData[1]));
                        break;

                    case (int)ShapeNameEnum.台形:
                        shape = new Trapezoid(double.Parse(shapeData[1]), double.Parse(shapeData[2]), double.Parse(shapeData[3]));
                        break;

                    case (int)ShapeNameEnum.円:
                        shape = new Circle(double.Parse(shapeData[1]));
                        break;
                }
                shapeMana.AddShapeList(shape);
            }
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
            listView1.Items.Clear();

            var shapeListCount = shapeMana.GetShapeListCount();

            for (int i = 0; i < shapeListCount; i++)
            {
                Shape shapeList = shapeMana.GetShape(i);
                listView1.Items.Add(shapeList.GetShapeName().ToString()).SubItems.Add(Math.Round(shapeList.GetArea(), _digitCount).ToString());
            }

            var sumArea = Math.Round(shapeMana.GetSumArea(), _digitCount);
            TotalLabel.Text = $"Total： {sumArea}";

            ClearButton.Enabled = shapeMana.GetShapeListCount() > 0;
            UpDigit.Enabled = _digitCount > 0;
            DownDigit.Enabled = _digitCount < 4;
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("すべて削除されますがよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.OK)
            {
                shapeMana.AllRemoveShape();
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
            var shapeCount = shapeMana.GetShapeListCount();
            var shapeDataList = new List<Shape>();
            string shapeName = null;
            double sideLength = 0, upperBaseLength = 0, lowerBaseLength = 0;

            for (int i = 0; i < shapeCount; i++)
            {
                shapeDataList.Add(shapeMana.GetShape(i));

                switch (shapeDataList[i].GetShapeName())
                {
                    case ShapeNameEnum.四角形:
                        shapeName = ((int)ShapeNameEnum.四角形).ToString();
                        sideLength = ((Quadrilarea)shapeDataList[i]).Length;
                        break;

                    case ShapeNameEnum.三角形:
                        shapeName = ((int)ShapeNameEnum.三角形).ToString();
                        sideLength = ((Triangle)shapeDataList[i]).Length;
                        break;

                    case ShapeNameEnum.台形:
                        shapeName = ((int)ShapeNameEnum.台形).ToString();
                        sideLength = ((Trapezoid)shapeDataList[i]).Height;
                        upperBaseLength = ((Trapezoid)shapeDataList[i]).UpperBaseLength;
                        lowerBaseLength = ((Trapezoid)shapeDataList[i]).LowerBaseLength;
                        break;

                    case ShapeNameEnum.円:
                        shapeName = ((int)ShapeNameEnum.円).ToString();
                        sideLength = ((Circle)shapeDataList[i]).Length;
                        break;
                }

                if (i == 0)
                {
                    if (!(shapeDataList[i].GetShapeName() == ShapeNameEnum.台形))
                    {
                        File.WriteAllText(_shapeDataFilePath, $"{shapeName},{sideLength}" + Environment.NewLine);
                    }
                    else
                    {
                        File.WriteAllText(_shapeDataFilePath, $"{shapeName},{sideLength},{upperBaseLength},{lowerBaseLength}" + Environment.NewLine);
                    }
                }
                else
                {
                    if (!(shapeDataList[i].GetShapeName() == ShapeNameEnum.台形))
                    {
                        File.AppendAllText(_shapeDataFilePath, $"{shapeName},{sideLength}" + Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(_shapeDataFilePath, $"{shapeName},{sideLength},{upperBaseLength},{lowerBaseLength}" + Environment.NewLine);
                    }
                }
            }
            if (shapeCount == 0)
            {
                File.WriteAllText(_shapeDataFilePath, "");
            }
        }
    }
}
