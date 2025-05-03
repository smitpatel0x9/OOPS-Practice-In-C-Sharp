using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInAppDevelopment
{
    public class Person
    {
        public int Id;
        public string Name;
        public string Address;
        public string Phone;
    }
    public class Student : Person
    {
        public int Class;
        public int Marks;
        public string Grade;
        public double Fees;
    }
    public class Staff : Person
    {
        public string Designation;
        public double Salary;
    }
    public class TeachingStaff : Staff
    {
        public string Qualification;
        public string Subject;
    }
    public class NonTeachingStaff : Staff
    {
        public string DeptName;
        public int ManagerId;
    }
}
