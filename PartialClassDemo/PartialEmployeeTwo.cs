using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    partial class PartialEmployee
    {
        public void DisplayFullName()
        {
            Console.WriteLine($"First Name : {_firstName}\n Last Name : {_lastName}");
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"First Name : {_firstName}\n Last Name : {_lastName}\n" +
                $"Gender : {_gender}\n Salary : {_salary}");
        }
    }
}
