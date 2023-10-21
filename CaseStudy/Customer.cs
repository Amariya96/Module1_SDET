using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Customer
    {
       
        public Customer(string? cName, double phoneNumber, int cId)
        {
            CName = cName;
            PhoneNumber = phoneNumber;
            CId = cId;
        }

        public string? CName { get; set; }
        public double PhoneNumber { get; set; }
        public int CId { get; set; }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine("Customer Name : {0} \n Phone Numebr : {1} \n CId : {2}", CName, PhoneNumber, CId);
        }

    } }
