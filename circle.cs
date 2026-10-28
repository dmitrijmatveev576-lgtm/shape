using System;

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    //Спецефічний метод для зміни радіуса кола
    public void SetRadius(double newRadius)
    {
        if (newRadius > 0)
        {
            Radius = newRadius;
        }
    }
}