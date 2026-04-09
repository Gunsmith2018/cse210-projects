using System;


public class Circle
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;

    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}