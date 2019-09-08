# Geometry

Вычисление площади геометрических фигур

## Примеры

### Площадь треугольника

```c#
double side1 = 3;
double side2 = 4;
double side3 = 5;

Triangle triangle = new Triangle(side1,side2,side3);

double triangleArea = new AreaCalculator().Calculate(triangle);
```

### Площадь окружности

```c#
double radius = 2;

Circle circle = new Circle(radius);

double circleArea = new AreaCalculator().Calculate(circle);
```
