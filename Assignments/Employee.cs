using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employee
    {
        public Employee(int employeeId, string? employeeName, double performanceRating)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            PerformanceRating = performanceRating;
        }

        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public double PerformanceRating { get; set; }

        public static double BonusCalculation(Employee employee)
        {


            double performance = employee.PerformanceRating;

            return performance * 10000;
        }
        public static double EmployeeCreate(Employee employee)
        {
            double performance = employee.PerformanceRating;
            return performance * 20000;
        }
    }
}
     /*
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
*/