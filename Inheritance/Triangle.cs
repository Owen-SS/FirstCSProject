
class Triangle : Shape, iShape
{
    public Triangle(int length, int height, int hypotenuese)
    {
        Length = length;
        Height = height;
        Hypotenuese = Hypotenuese;

    }
    public double Hypotenuese { get; set; }
    
    public double getArea()
    {
        return .5 * Length * Height;
    }
}