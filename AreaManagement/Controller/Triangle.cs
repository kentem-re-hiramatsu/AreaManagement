﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaManagement.Controller
{
    public class Triangle : Shape
    {
        public Triangle(int sideLength) : base(sideLength)
        {
            this.sideLength = sideLength;
        }
        public override void SetArea()
        {
            this.area = this.sideLength * this.sideLength / 2;
        }
    }
}
