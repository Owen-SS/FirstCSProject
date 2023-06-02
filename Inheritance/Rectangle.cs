
class Rectangle : Shape, iShape
{
    public Rectangle(int length, int width)
    {
        Length = length;
        Width = width;
    }
    public double Width { get; set; }
    
    public double getArea()
    {
        return Length * Width;
    }
}