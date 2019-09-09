using GeometryLibrary.Shapes;

namespace GeometryLibrary.Calculators
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
        /// <returns>Возвращает результат вычислений</returns>
        double Calculate(Shape shape);
    }
}
