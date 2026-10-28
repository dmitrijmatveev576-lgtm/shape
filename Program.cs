using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Створення масиву типу Shape[] з об'єктами Circle та Rectangle
        Shape[] shapes = new Shape[]
        {
            new Circle(3.0),
            new Circle(5.5),
            new Rectangle(4.0, 5.0),
            new Rectangle(2.5, 10.0)
        };

        Console.WriteLine(" Початкові площі фігур");
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Фігура: {shape.GetType().Name} | Площа: {shape.GetArea():F2}");
        }

        Console.WriteLine(" Обхід масиву та модифікація кіл ");
        foreach (var shape in shapes)
        {
            if (shape is Circle circle)
            {
                circle.SetRadius(10.0);
                Console.WriteLine($"Радіус кола змінено! Нова площа: {circle.GetArea():F2}");
            }
            else if (shape is Rectangle rect)
            {
                Console.WriteLine($"Прямокутник незмінний. Площа: {rect.GetArea():F2}");
            }
        }
    }
}