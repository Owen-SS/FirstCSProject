public class Person
{
    // Properties when public
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int Age { get; set; }
    
    //Fields
    private double _salary { get; set; }

    public void setSalary(double salary)
    {
        _salary = salary;
    }

    public double getSalary()
    {
        return _salary;
    }

    public string getFullName()
    {
        return $"{FirstName} {LastName}";
    }
}