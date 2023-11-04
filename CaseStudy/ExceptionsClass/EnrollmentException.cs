using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.ExceptionsClass
{
    internal class EnrollmentException : Exception
    {
        public EnrollmentException(string message):base(message) { }
    }
}
