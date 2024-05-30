using AreaManagement.Model;
using AreaManagement1.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AreaManagement.Controller
{
    public class ShapeManager
    {
        private List<Shape> _shapeList;
        private string _shapeDataFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../Data/ShapeName.csv");

        public ShapeManager()
        {
            _shapeList = new List<Shape>();
        }

        public void AddShapeList(Shape shape)
        {
            _shapeList.Add(shape);
        }

        public Shape GetShape(int index)
        {
            return _shapeList[index];
        }

        public int GetShapeListCount()
        {
            return _shapeList.Count;
        }

        public double GetSumArea()
        {
            double sumArea = 0;

            for (int i = 0; i < _shapeList.Count; i++)
            {
                sumArea += _shapeList[i].GetArea();
            }
            return sumArea;
        }

        public void RemoveShapeAtIndex(int index)
        {
            _shapeList.RemoveAt(index);
        }

        public void ClearShape()
        {
            _shapeList.Clear();
        }

        public void LoadShapeDataFile()
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
                AddShapeList(shape);
            }
        }

        public void SaveShapeDataFile()
        {
            var shapeCount = GetShapeListCount();
            var shapeDataList = new List<Shape>();
            string shapeName = null;
            double sideLength = 0, upperBaseLength = 0, lowerBaseLength = 0;

            File.WriteAllText(_shapeDataFilePath, "");

            for (int i = 0; i < shapeCount; i++)
            {
                shapeDataList.Add(GetShape(i));

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

                if (!(shapeDataList[i].GetShapeName() == ShapeNameEnum.台形))
                {
                    File.AppendAllText(_shapeDataFilePath, $"{shapeName},{sideLength}" + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(_shapeDataFilePath, $"{shapeName},{sideLength},{upperBaseLength},{lowerBaseLength}" + Environment.NewLine);
                }
            }
            if (shapeCount == 0)
            {
                File.WriteAllText(_shapeDataFilePath, "");
            }
        }
    }
}
