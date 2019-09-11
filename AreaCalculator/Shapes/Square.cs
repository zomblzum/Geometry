using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Shapes
{
    /// <summary>
    /// Реализация фигуры "Квадрат"
    /// </summary>
    public class Square: Rectangle
    {
        /// <summary>
        /// Конструктор фигуры "Квадрат"
        /// </summary>
        /// <param name="side">Сторона квадрата</param>
        public Square(double side) : base(side, side) { }
    }
}
