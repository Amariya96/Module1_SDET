using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program.ExceptionMessages
{
    internal class Number1Exception: Exception
    {
        public Number1Exception(string message): base(message) { }
    }
}
