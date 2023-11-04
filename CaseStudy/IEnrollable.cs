using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal interface IEnrollable
    {
        void CourseRegistration(Student student, Course course) { }
        void Withdrawal(EnrollmentRecord enrollrec) { }
    }
}
