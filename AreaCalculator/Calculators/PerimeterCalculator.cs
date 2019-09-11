using GeometryLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Calculators
{
    public class PerimeterCalculator: Calculator
    {
        public override double Calculate(Shape shape)
        {
            return shape.Perimeter();
        }
    }
}
