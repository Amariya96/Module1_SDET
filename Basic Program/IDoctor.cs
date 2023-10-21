using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal interface IDoctor
    {
        public void AddNewDoctor(int did , string? dname);
        public void ModifyDoctor(int did , string? dname);
    }
}
