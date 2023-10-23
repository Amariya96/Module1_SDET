using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class BankDetailsNew : BankDetails
    {
        public BankDetailsNew(int custId, long accNo, string? name, string? status) : base(custId, accNo, name, status)
        {
        }
        public new void WelcomeMessage()
        {
            Console.WriteLine("Welcome : {0} !!", Name);
        }

    }
}
