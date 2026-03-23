public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 1;
    }

    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        if (_bottom == 0)
        {
            return "ERROR Cant have ZERO in denominator";
        }
        else
        {


            return $"{_top}/{_bottom}";
        }
    }
    public double GetDecimalValue()
    {
        if (_bottom == 0)
        {
            return 0;
        }
        else
        {

            return (double)_top / (double)_bottom;
        }
    }
}