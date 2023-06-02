// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");



Console.WriteLine("Enter Length: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter height: ");
int height = Convert.ToInt32(Console.ReadLine());

var cube = new Cube(width, height, length);
var triangle = new Triangle( length, height, 10);
var rectangle = new Rectangle(length, width);

Console.WriteLine("Cube area is: " + cube.getArea());
Console.WriteLine("Cube volume is: " + cube.getVolume());

Console.WriteLine("Triangle area is: " + triangle.getArea());
Console.WriteLine("Rectangle area is: " + rectangle.getArea());
