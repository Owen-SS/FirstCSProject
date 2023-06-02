
class Triangle : Shape, iShape
{
    public double Hypotenuese { get; set; }
    
    public double getArea()
    {
        return .5 * Length * Height;
    }
}