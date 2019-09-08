# Geometry

Вычисление площади геометрических фигур

## Примеры

### Площадь треугольника

```c#
double side1 = 3;
double side2 = 4;
double side3 = 5;

Triangle triangle = new Triangle(side1,side2,side3);
Calculator calculator = new AreaCalculator();

double triangleArea = calculator.Calculate(triangle);
```

### Площадь окружности

```c#
double radius = 2;

Circle circle = new Circle(radius);
Calculator calculator = new AreaCalculator();

double circleArea = calculator.Calculate(circle);
```
