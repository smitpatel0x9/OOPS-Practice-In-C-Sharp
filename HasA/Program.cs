using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasA
{
    public class Address
    {
        public string _addressLine, _city, _state;
        public Address(string addressLine, string city, string state)
        {
            _addressLine = addressLine;
            _city = city;
            _state = state;
        }
    }
    public class Employee
    {
        public Address _address;
        public int _id;
        public string _name;
        public Employee(Address address, int id, string name)
        {
            _address = address; // HasA Relationship : Employee HasA Address
            _id = id;
            _name = name;
        }
        public void Display()
        {
            Console.WriteLine($"Employee ID : {_id}");
            Console.WriteLine($"Employee name : {_name}");
            Console.WriteLine($"Employee Address : {_address._addressLine} {_address._city} { _address._state}");
        }
    }
    public class Program
    {
        public static void Main()
        {
            Address a1 = new("#703 8th Main Road SomeNagar", "Bengaluru", "Karnataka");
            Employee e1 = new(a1, 1, "ABC");
            e1.Display();
        }
    }
}
