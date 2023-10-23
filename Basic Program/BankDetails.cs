using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Basic_Program
{
    internal class BankDetails
    {
       /* public BankDetails()
        {
            CustId = 0;
            AccNo = 0;
            Name = string.Empty;
            Status = "In-Active";
        }
        public BankDetails(int custId, long accNo, string? name) {
            CustId = custId;
            AccNo = accNo;
            Name = name;
            Status = "In-Active";
        } */
        public BankDetails(int custId, long accNo, string? name, string? status)
        {
            CustId = custId;
            AccNo = accNo;
            Name = name;
            Status = status;
        }

        public int CustId {  get; set; }
        public long AccNo {  get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome !!");
        }

        public static void ExitMessage()
        {
            Console.WriteLine("Done");
        }

        public void GetAccDetails(int custid)
        {
            if (CustId == custid)

                Console.WriteLine("Accno : {0} \t  Name : {1} \t  Status : {2}", AccNo, Name, Status);
            else Console.WriteLine("Custid does ot exist");
        }
        public void GetAccDetails(long accno)
        {
            if (AccNo == accno)

                Console.WriteLine("Accno : {0} \t  Name : {1} \t  Status : {2}", CustId, Name, Status);
            else Console.WriteLine("AccNo does ot exist");
        }
        public void GetAccDetails(string? name)
        {
            if (Name == name)

                Console.WriteLine("Accno : {0} \t  Name : {1} \t  Status : {2}", CustId, Name, Status);
            else Console.WriteLine("Name does ot exist");
        }
    }
}
