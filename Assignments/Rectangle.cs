using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Rectangle : Shape, IDraw
    {
        public double length {  get; set; }
        public double breadth { get; set; }
        public double rar, rpe;
        public override double CalculateArea()
        {
            rar = length * breadth;
            return rar;
        }

        public override double CalculatePerimeter()
        {
            rpe =  2 *(length + breadth);
            return rpe;
        }
        public void Draw()
        {
            Console.WriteLine(" Area of Rectangle is: {0}, Perimeter of Rectangle is: {1}", CalculateArea(), CalculatePerimeter());
        }
    }
}
