using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculatorLib
{
    public abstract class FigureArea : IArea
    {
        public abstract double Area { get; }

        public override string ToString()
        {
            return Area.ToString();
        }
    }
}
