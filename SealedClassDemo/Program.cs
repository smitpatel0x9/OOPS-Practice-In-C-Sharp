using System.Security.Cryptography;

namespace SealedClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager obj = new Manager();
            obj.GetEmployeeData();
            obj.DisplayEmployeeData();
        }
    }
    public class Employee
    {
        protected int E_id, E_age;
        protected string E_name, E_address;
        public virtual void GetEmployeeData()
        {
            Console.WriteLine("Enter Emplpyee Details:");
            Console.Write("Enter Employee ID:");
            E_id = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Name:");
            E_name = Console.ReadLine();
            Console.Write("Enter Employee Address:");
            E_address = Console.ReadLine();
            Console.Write("Enter Employee Age:");
            E_age = int.Parse(Console.ReadLine());
        }
        public virtual void DisplayEmployeeData()
        {
            Console.WriteLine("\nEmplpyee Details Are:");
            Console.WriteLine($"Employee ID: {E_id}");
            Console.WriteLine($"Employee Name: {E_name}");
            Console.WriteLine($"Employee Address: {E_address}");
            Console.WriteLine($"Employee Age: {E_age}");
        }
    }
    public sealed class Manager : Employee
    {
        double Bonus, Salary;
        public override void GetEmployeeData()
        {
            Console.WriteLine("Enter Manager Details:");
            Console.Write("Enter Manager ID:");
            E_id = int.Parse(Console.ReadLine());
            Console.Write("Enter Manager Name:");
            E_name = Console.ReadLine();
            Console.Write("Enter Manager Salary:");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Manager Bonus:");
            Bonus = double.Parse(Console.ReadLine());
        }
        public override void DisplayEmployeeData()
        {
            Console.WriteLine("\nManager Details Are:");
            Console.WriteLine($"Manager ID: {E_id}");
            Console.WriteLine($"Manager Name: {E_name}");
            Console.WriteLine($"Manager Salary: {Salary}");
            Console.WriteLine($"Manager Bonus: {Bonus}");
        }
    }
    //Further No Inheritance is Possible as we marked the class as sealed
    //public class TempManager : Manager
    //{
    //}
}
