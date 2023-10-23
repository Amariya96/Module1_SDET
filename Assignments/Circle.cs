using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Circle : Shape
    {
        public double Radius {  get; set; }
        public double car, cpe;

        public override double CalculateArea()
        {
          car = 3.14 * Radius * Radius;
            return car;
        }

        public override double CalculatePerimeter()
        {
            cpe = 2 * 3.14 * Radius;
            return cpe;
        }
        public void Draw()
        {
            Console.WriteLine(" Area of Circle is: {0}, Perimeter of Circle is: {1}", CalculateArea(), CalculatePerimeter());
        }
    }
}
