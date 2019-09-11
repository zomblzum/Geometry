namespace GeometryLibrary.Shapes
{
    /// <summary>
    /// Геометрическая фигура
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public abstract double Area();

        /// <summary>
        /// Периметр фигуры
        /// </summary>
        public abstract double Perimeter();
    }
}
