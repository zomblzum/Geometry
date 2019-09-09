using GeometryLibrary.Shapes;

namespace GeometryLibrary.Calculators
{
    /// <summary>
    /// Калькулятор площади фигур
    /// </summary>
    public class AreaCalculator: Calculator
    {
        public double Calculate(Shape shape)
        {
            return shape.Area();
        }
    }
}
