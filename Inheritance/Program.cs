// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var cube = new Cube();
var triangle = new Triangle();
var rectangle = new Rectangle();

Console.WriteLine("Enter Length: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter height: ");
int height = Convert.ToInt32(Console.ReadLine());

cube.Length = length;
cube.Height = height;
cube.Width = width;

triangle.Height = height;
triangle.Length = length;

rectangle.Width = width;
rectangle.Length = length;

Console.WriteLine("Cube area is: " + cube.getArea());
Console.WriteLine("Cube volume is: " + cube.getVolume());

Console.WriteLine("Triangle area is: " + triangle.getArea());
Console.WriteLine("Rectangle area is: " + rectangle.getArea());
