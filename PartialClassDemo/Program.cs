namespace PartialClassDemo;
internal class Program
{
    static void Main(string[] args)
    {
        PartialEmployee obj = new PartialEmployee
        {
            _firstName = "ABC",
            _lastName = "PQR",
            _gender = "Male",
            _salary = 50000
        };
        obj.DisplayFullName();
        Console.WriteLine("\n");
        obj.DisplayEmployeeDetails();
        Console.WriteLine("\n");
    }
}
