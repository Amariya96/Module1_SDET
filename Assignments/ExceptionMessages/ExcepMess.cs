using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.ExceptionMessages
{
    internal class ExcepMess
    {
        public static Dictionary<int, string> excep = new Dictionary<int, string>()
        {
            {1,"Patient Name or Diagnois cannot be null" },
            {2, "Total cost must be positive" }
        };
    }
        internal class InvalidPatientRecordException : Exception
        {
            public InvalidPatientRecordException(string message) : base(message) { }
        }
        internal class InvalidMedicalRecordException : Exception { 
        public InvalidMedicalRecordException(string message): base(message) { }
        }
    }

