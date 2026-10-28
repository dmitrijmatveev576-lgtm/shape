using System;

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[]
        {
            new Circle(3.0),
            new Circle(5.0),
            new Rectangle(4.0, 5.0),
            new Rectangle(2.0, 6.0)
        };

        foreach (Shape shape in shapes)
        {
            // Виводимо тип фігури та її параметри
            if (shape is Circle c)
            {
                Console.WriteLine($"Коло (радіус: {c.Radius}) -> Площа: {c.GetArea():F2}");
            }
            else if (shape is Rectangle r)
            {
                Console.WriteLine($"Прямокутник (ширина: {r.Width}, висота: {r.Height}) -> Площа: {r.GetArea():F2}");
            }
        }
    }
}