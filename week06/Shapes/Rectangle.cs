public class Rectangle
{
    private double _length;
    private double _width;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }

    public double GetArea()
    {
        return _length * _width;
    }
}