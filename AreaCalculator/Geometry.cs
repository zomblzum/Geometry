using GeometryLibrary.Calculators;
using GeometryLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    /// <summary>
    /// Библиотека для вызова модулей работы с фигурами
    /// </summary>
    public static class Geometry
    {
        /// <summary>
        /// Вычислить площадь фигуры
        /// </summary>
        /// <param name="shape">Фигура для вычислений</param>
        /// <returns>Площадь фигуры</returns>
        public static double Area(Shape shape)
        {
            return GetAnswerFromCalculator(new AreaCalculator(), shape);
        }

        /// <summary>
        /// Вычислить Периметр фигуры
        /// </summary>
        /// <param name="shape">Фигура для вычислений</param>
        /// <returns>Периметр фигуры</returns>
        public static double Perimeter(Shape shape)
        {
            return GetAnswerFromCalculator(new PerimeterCalculator(), shape);
        }

        private static double GetAnswerFromCalculator(Calculator calculator, Shape shape)
        {
            return calculator.Calculate(shape);
        }
    }
}
