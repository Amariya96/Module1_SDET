using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class NonTeachingStaff : StaffDetails
    {
        public String? Responsibilities {  get; set; }
        public int Experience { get; set; }

        public void DisplayNTStaffDetails()
        {
            Console.WriteLine("Res : {0} \n Exp : {1}",
                Responsibilities, Experience);
        }
    }
}
