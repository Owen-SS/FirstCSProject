
class Rectangle : Shape, iShape
{
    public double Width { get; set; }
    
    public double getArea()
    {
        return Length * Width;
    }
}