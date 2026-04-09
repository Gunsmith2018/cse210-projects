public class Shape
{
    protected string _color; // variables
    public Shape() // constructor   
    {
        _color = "red";
    }

    public string GetColor()
    {
        return _color;
    }

    public void Setcolor(string color) // This method is redundant as it can be done within the constructor
    {
        _color = color;
    }

    public double GetArea()
    {
        return 0;
    }





}


