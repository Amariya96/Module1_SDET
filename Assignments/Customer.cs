using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Customer
    {
        public Customer(int custId, string? name, double phNo, double balance)
        {
            CustId = custId;
            Name = name;
            PhNo = phNo;
            Balance = balance;
        }

        public int CustId {  get; set; }
        public string? Name { get; set; }
        public double PhNo {  get; set; }
        public double Balance {  get; set; }
    }
}
