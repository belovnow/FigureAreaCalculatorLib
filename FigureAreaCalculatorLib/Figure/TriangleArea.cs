using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculatorLib
{
    public class TriangleArea : FigureArea
    {
        private FigureSide[] triangleSides;

        public TriangleArea(double lengthOne, double lengthTwo, double lengthThree)
        {
            if (!TriangleExist(new FigureSide[] { lengthOne, lengthTwo, lengthThree }))
            {
                throw new ArgumentException("Triangle Inequality");
            }

            triangleSides = new FigureSide[] { lengthOne, lengthTwo, lengthThree };
        }

        public override double Area
        {
            get => AreaCalculator(triangleSides);
        }

        public bool IsRightTriangle
        {
            get
            {
                FigureSide[] sortSides = new FigureSide[3];
                triangleSides.CopyTo(sortSides, 0);

                return Math.Pow(sortSides[2], 2) == Math.Pow(sortSides[1], 2) + Math.Pow(sortSides[0], 2);
            }
        }

        private double AreaCalculator(FigureSide[] triangleSides)
        {
            double semiperimeter = 0;
            foreach (var currentSide in triangleSides)
            {
                semiperimeter += currentSide / 2;
            }

            double result = 1;
            foreach (var currentSide in triangleSides)
            {
                result *= semiperimeter - currentSide;
            }

            return Math.Sqrt(result * semiperimeter);
        }

        private bool TriangleExist(FigureSide[] figureSide)
        {
            return (figureSide[0] + figureSide[1] > figureSide[2] &&
                    figureSide[0] + figureSide[2] > figureSide[1] &&
                    figureSide[1] + figureSide[2] > figureSide[0]);
        }
    }
}
