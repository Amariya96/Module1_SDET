using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employee : Person, IDisplayable
    {
     
        public Employee(int empId, string? firstName,string? lastName, int age) : base(firstName,lastName, age)
        {
            EmpId = empId;
        }

        public int EmpId {  get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine("Full Name is : {0} {1}, Age is {2}", FirstName, LastName, Age);
        }
    }
}
