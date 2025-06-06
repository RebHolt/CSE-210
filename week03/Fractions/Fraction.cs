public class Fraction
{
    private double _top;
    private double _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public double GetTop()
    {
        return _top;
    }
    public double GetBottom()
    {
        return _bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        //returns in form 3/4
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        //divide top by bottom
        double divided = _top / _bottom;
        return divided;
    }

}