using FigureAreaCalculatorLib.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculatorLib
{
    class Program
    {
        static void Main(string[] args)
        {
            FigureArea circle = new CircleArea(2);

            Console.WriteLine(circle.Area);

            TriangleArea triangle = new TriangleArea( 1, 1, 100 );
            Console.WriteLine(triangle.Area);

            Rectangle rectangle = new Rectangle();
        }
    }
}
