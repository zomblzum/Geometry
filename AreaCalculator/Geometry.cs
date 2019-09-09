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
        /// Выводит результат вычислений для фигуры
        /// </summary>
        /// <param name="shape">Фигура для вычислений</param>
        /// <returns>Возвращает площадь фигуры</returns>
        public static double Area(Shape shape)
        {
            return new AreaCalculator().Calculate(shape);
        }
    }
}
