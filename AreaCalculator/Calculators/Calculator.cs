using Geometry.Shapes;

namespace Geometry.Calculators
{
    /// <summary>
    /// Основной интерфейс для всех калькуляторов
    /// </summary>
    public interface Calculator
    {
        /// <summary>
        /// Выводит результат вычислений для фигуры
        /// </summary>
        /// <param name="shape">Фигура для вычислений</param>
        double Calculate(Shape shape);
    }
}
