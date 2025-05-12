namespace MethodOverridingRealtimeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Developer();
            obj1._id = 101;
            obj1._name = "ABC";
            obj1._designation = "Developer";
            obj1._salary = 800000;
            Console.WriteLine(obj1.CalculateBonus(obj1._salary));

            Employee obj2 = new Manager();
            obj2._id = 201;
            obj2._name = "PQR";
            obj2._designation = "Manager";
            obj2._salary = 1200000;
            Console.WriteLine(obj2.CalculateBonus(obj2._salary));

            Employee obj3 = new Admin();
            obj3._id = 301;
            obj3._name = "XYZ";
            obj3._designation = "Admin";
            obj3._salary = 1500000;
            Console.WriteLine(obj3.CalculateBonus(obj3._salary));
        }
    }
    public class Employee
    {
        public int _id;
        public string _name;
        public string _designation;
        public double _salary;
        public virtual double CalculateBonus(double salary) => 50000;
    }
    public class Developer : Employee
    {
        public override double CalculateBonus(double salary)
        {
            double normalSalary = base.CalculateBonus(salary);
            double extraSalary = 0.2 * salary;
            return extraSalary > normalSalary ? extraSalary : normalSalary;
        }
    }
    public class Manager : Employee
    {
        public override double CalculateBonus(double salary)
        {
            double normalSalary = base.CalculateBonus(salary);
            double extraSalary = 0.25 * salary;
            return extraSalary > normalSalary ? extraSalary : normalSalary;
        }
    }
    public class Admin : Employee
    {
    }
}
