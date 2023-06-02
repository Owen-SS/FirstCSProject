// See https://aka.ms/new-console-template for more information

Person person = new Person();
string middlename = string.Empty;

Console.WriteLine("Enter first name: ");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter last name: ");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter MiddleName:");
middlename = Console.ReadLine();


Console.WriteLine("Enter age: ");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your salary: ");
int salary = Convert.ToInt32(Console.ReadLine());
person.setSalary(salary);


Console.WriteLine("Full name is: " + person.getFullName());
Console.WriteLine("Age is: " + person.Age);
Console.WriteLine("Your year of birth is: " + Dateutil.YearOfBirth(person.Age));
Console.WriteLine("Salary is: " + person.getSalary());

if (string.IsNullOrEmpty(middlename))
{
    Console.WriteLine("Full name is: " + person.getFullName());
}
else
{
    Console.WriteLine("Full name is: " + person.getFullName(middlename));
}



Dateutil dateutil = new Dateutil();
