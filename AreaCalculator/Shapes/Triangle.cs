using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GeometryLibrary.Shapes
{
    /// <summary>
    /// Реализация фигуры "Треугольник"
    /// </summary>
    public class Triangle: Shape
    {
        private double side1;
        private double side2;
        private double side3;

        /// <summary>
        /// Конструктор фигуры "Треугольник"  
        /// </summary>
        /// <param name="sideFirst">Первая сторона</param>
        /// <param name="sideSecond">Вторая сторона</param>
        /// <param name="sideThird">Третья сторона</param>
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 >= 0 || side2 >= 0 || side3 >= 0)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
            else
            {
                throw new Exception("Сторона не может быть меньше 0");
            }
        }

        /// <summary>
        /// Стороны треугольника
        /// </summary>
        /// <returns>Массив всех сторон</returns>
        public double[] GetSides()
        {
            return new double[] { side1, side2, side3 };
        }

        public override double Area()
        {
            double halfPerimeter = (side1 + side2 + side3) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
        }

        public override double Perimeter()
        {
            return GetSides().Sum();
        }

        /// <summary>
        /// Является ли прямоугольным
        /// </summary>
        /// <returns>Возвращает true, если треугольник является прямоугольным</returns>
        public bool IsRightTriangle()
        {
            double[] sides = GetSides();
            double[] sortedSides = sides.OrderBy(i => i).ToArray<double>();

            double cathetus1 = Math.Pow(sortedSides[0], 2);
            double cathetus2 = Math.Pow(sortedSides[1], 2);
            double hypotinuse = Math.Pow(sortedSides[2], 2);

            return hypotinuse == cathetus1 + cathetus2;
        }
    }
}
