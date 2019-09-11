using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Shapes
{
    /// <summary>
    /// Реализация фигуры "Прямоугольник"
    /// </summary>
    public class Rectangle: Shape
    {
        private double side1;
        private double side2;

        /// <summary>
        /// Конструктор фигуры "Прямоугольник"
        /// </summary>
        /// <param name="side1">Первая сторона</param>
        /// <param name="side2">Вторая сторона</param>
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        /// <summary>
        /// Стороны прямоугольника
        /// </summary>
        /// <returns>Массив всех сторон</returns>
        public double[] GetSides()
        {
            return new double[] { side1, side2 };
        }

        public override double Area()
        {
            return side1 * side2;
        }

        public override double Perimeter()
        {
            return 2 * GetSides().Sum();
        }
    }
}
