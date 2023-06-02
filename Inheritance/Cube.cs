class Cube : Shape
{
    public double Width { get; set; }

    public double getArea()
    {
        return Length * Width;
    }

    public double getVolume()
    {
        return Length * Width * Height;
    }
}