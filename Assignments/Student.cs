using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Student
    {
        //    public string? studentName;
        //    int mark1, mark2, mark3;

        //    public Student(string? studentName, int mark1, int mark2, int mark3)
        //    {
        //        this.studentName = studentName;
        //        this.mark1 = mark1;
        //        this.mark2 = mark2;
        //        this.mark3 = mark3;
        //    }
        //    public double CalculateAverage()
        //    {

        //        double average = (mark1 + mark2 + mark3) / 3;

        //        return average;

        //    }


        private string? name;
        private int[] marks = new int[3];
        private string? grade;



        public Student(string? name, int[] marks, string? grade)
        {
            this.Name = name;
            this.Marks = marks;

            this.Grade = grade;
        }

        public string? Name { get => name; set => name = value; }
        public int[] Marks { get => marks; set => marks = value; }
        public string? Grade { get => grade; set => grade = value; }

        public double CalculateAverage()
        {
            double average = marks.Average();
            return average;
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine("StudentName :" + name);
            Console.WriteLine("Grade :" + grade);
            int i = 1;
            int total = 0;

            foreach (int score in marks)
            {

                Console.WriteLine("Marks: {0} {1}", i++, score);
                total += score;
            }
            Console.WriteLine("Total marks: " + total);

        }
        public void GetMarkSummary()
        {
            int highest = marks[0];
            int lowest = marks[0];
            foreach (int score in marks)
            {
                if (score > highest) highest = score;
                if (score < lowest) lowest = score;
            }
            Console.WriteLine("Highest :" + highest);
            Console.WriteLine("Lowest: " + lowest);
        }
    }
}
