using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    public class EnrollmentRecord
    {
        public Student Student { get; set; }
        public Course Course { get; set; }

        public static List<Student> students = new List<Student>();
        public static List<Course> courses = new List<Course>();
        public static List<EnrollmentRecord> enrollmentRecords = new List<EnrollmentRecord>();

        public EnrollmentRecord(Student student, Course course)
        {
            Student = student;
            Course = course;
        }
    }
}
