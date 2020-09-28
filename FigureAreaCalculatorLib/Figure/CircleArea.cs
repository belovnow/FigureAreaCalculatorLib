using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculatorLib
{
    public class CircleArea : FigureArea
    {
        public FigureSide Radius { get; }

        public CircleArea(double radius) 
        {
            Radius = radius;
        }

        public override double Area
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }
    }
}
