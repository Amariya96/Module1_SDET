using CaseStudy.ExceptionsClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    public class Course : IEnrollable
    {
        public int CsCode {  get; set; }
        public string? Title {  get; set; }
        public string? Instructor {  get; set; }
        public List<Student> EnrolledStudents { get; set; } = new List<Student>();
        public void CourseRegistration(Student student, Course course)
        {
            EnrollmentRecord enroll = new EnrollmentRecord(student, course);
            int count = 10;
            if (count <= 10)
            {
                EnrollmentRecord stud = EnrollmentRecord.enrollmentRecords.FirstOrDefault(s => s.Student.SName == student.SName);
                if (stud == null)
                {
                    EnrollmentRecord.enrollmentRecords.Add(enroll);
                }
                else
                {
                    throw new EnrollmentException("Student Already Exists");
                }
            }
            else
            {
                throw new EnrollmentException("Course is Full");
            }
        }
        public void Withdrawal(EnrollmentRecord enrollrec)
        {
            EnrollmentRecord stud = EnrollmentRecord.enrollmentRecords.FirstOrDefault(s => s.Student.StudentId == enrollrec.Student.StudentId);
            if (stud != null)
            {
                EnrollmentRecord.enrollmentRecords.Remove(stud);
            }
            else
            {
                throw new EnrollmentException("Can't Find Student");
            }
        }
    }
}
