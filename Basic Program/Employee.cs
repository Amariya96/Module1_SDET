using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Employee
    {
        private int eid;
        private string? name, department;
        private double basicPay;
        private readonly int _bonus = 100;

        public Employee(int eid, string? name, string? department, double basicPay)
        {
            Eid = eid;
            Name = name;
            Department = department;
            BasicPay = basicPay;
        }

        public int Eid { get => eid; set => eid = value; }
        public string? Name { get => name; set => name = value; }
        public string? Department { get => department; set => department = value; }
        public double BasicPay { get => basicPay; set => basicPay = value; }

        public double CalculateSalary()
        {
            double allowance = BasicPay * 0.3 + BasicPay * 0.2 + BasicPay * 0.15;
            double netSalary, grossSalary;
            grossSalary = BasicPay + allowance;
            double deductions = BasicPay * 0.1;
            netSalary = grossSalary - deductions;
            return netSalary;

        }
    }
}
