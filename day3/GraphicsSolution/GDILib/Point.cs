﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDILib
{
    public struct Point
    {
        public int X;
        public int Y;


        public Point(int x, int y)
        {

            X = x;
            Y = y;
        }

        public override string ToString()
        {
            // return Base.ToString();
            return "(X=" + this.X + ", Y" + this.Y + ")";

        }
    }
}