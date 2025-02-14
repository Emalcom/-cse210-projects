
abstract class Shape
{
    protected string Color;
    public Shape(string color)
    {
        Color = color;
    }
    public string GetColor()
    {
        return Color;
    }
    public abstract double GetArea();
    
}