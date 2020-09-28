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
        /// В этом классе я решил инкапсулировать логику обработки 
        /// недопустимых значений, чтобы не обрабатывать неверные значения в каждом классе.
        /// Изменение логики обработки значений не затронет остальные классы.
        /// Кроме того, класс расширяем - если будет необходимость хранить ещё и координаты.
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