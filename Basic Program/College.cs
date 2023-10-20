using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class College
    {
        public string? ColName { get; set; }
        public string? ColType { get; set; }
        public string? ColId { get; set; }
        public void DisplayCollegeDetails()
        {
            Console.WriteLine("College Name : {0} \n College Type : {1} \n College Id : {2}", ColName, ColType, ColId);        }
    }
}
