namespace IndexersDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new(101, "ABC", "Software Developer", 60000, "Mangalore", "IT", "Male");
            Console.WriteLine($"Employee ID : {emp[0]}");
            Console.WriteLine($"Employee Name : {emp[1]}");
            Console.WriteLine($"Employee Job : {emp[2]}");
            Console.WriteLine($"Employee Salary: {emp[3]}"); // accessing values using index
            Console.WriteLine($"Employee Location : {emp[4]}");
            Console.WriteLine($"Employee Department : {emp[5]}");
            Console.WriteLine($"Employee Gender: {emp[6]}");

            emp[0] = 201;
            emp[3] = 80000; // Modifying values using index
            emp[6] = "Female";

            Console.WriteLine("After Modification");
            Console.WriteLine($"Employee ID : {emp[0]}");
            Console.WriteLine($"Employee Name : {emp[1]}");
            Console.WriteLine($"Employee Job : {emp[2]}");
            Console.WriteLine($"Employee Salary: {emp[3]}");
            Console.WriteLine($"Employee Location : {emp[4]}");
            Console.WriteLine($"Employee Department : {emp[5]}");
            Console.WriteLine($"Employee Gender: {emp[6]}");

        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }

        public Employee(int ID, string Name, string Job, double Salary, string Location, string Department, string Gender)
        {
            this.ID = ID;
            this.Name = Name;
            this.Job = Job;
            this.Salary = Salary;
            this.Location = Location;
            this.Department = Department;
            this.Gender = Gender;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return ID;
                if (index == 1)
                    return Name;
                if (index == 2)
                    return Job;
                if (index == 3)
                    return Salary;
                if (index == 4)
                    return Location;
                if (index == 5)
                    return Department;
                if (index == 6)
                    return Gender;
                return null;
            }
            set
            {
                if (index == 0)
                    ID = Convert.ToInt32(value);
                if (index == 1)
                    Name = value.ToString();
                if (index == 2)
                    Job = value.ToString();
                if (index == 3)
                    Salary = Convert.ToDouble(value);
                if (index == 4)
                    Location = value.ToString();
                if (index == 5)
                    Department = value.ToString();
                if (index == 6)
                    Gender = value.ToString();
            }
        }
    }
}
