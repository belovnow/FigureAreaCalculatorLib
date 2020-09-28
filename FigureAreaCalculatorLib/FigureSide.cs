using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculatorLib
{
    public class FigureSide : IComparable<double>
    {
        /// <summary>
        /// 
        /// </summary>
        private double sideSize;
        public double SideSize { 
            get => sideSize;
            private set
            {
                if (value <= 0) 
                {
                    throw new ArgumentException("Invalid Side Length!");
                }

                sideSize = value;
            }
        }
        public FigureSide(double side)
        {
            SideSize = side;
        }

        public static implicit operator double(FigureSide figureSide)
        {
            return figureSide.sideSize;
        }

        public static implicit operator FigureSide(double num)
        {
            return new FigureSide(num);
        }

        public int CompareTo(double other)
        {
            return CompareTo(other);
        }
    }
}