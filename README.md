# Geometry Library

Библиотека для работы с геометрическими фигурами

## Примеры

### Площадь треугольника

```c#
double side1 = 3;
double side2 = 4;
double side3 = 5;

Triangle triangle = new Triangle(side1,side2,side3);

double triangleArea = Geometry.Area(triangle);
```

### Площадь окружности

```c#
double radius = 2;

Circle circle = new Circle(radius);

double circleArea = Geometry.Area(circle);
```

### Доп. информация

Сделано в качестве тестового задания
