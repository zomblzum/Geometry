﻿namespace Geometry.Shapes
{
    /// <summary>
    /// Реализация фигуры "Круг"
    /// </summary>
    public class Circle: Shape
    {
        private double radius;
        private readonly double pi = 3.14;

        /// <summary>
        /// Конструктор фигуры "Круг"
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        public Circle(double radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Радиус окружности
        /// </summary>
        public double Radius() {
            return radius;
        }

        public double Area()
        {
            return pi * radius * radius;
        }
    }
}
