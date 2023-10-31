using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class GenExample<T>
    {
        private T val1, val2;
        public GenExample(T val1, T val2)
        {
           Val1 = val1;
           Val2 = val2;
        }
        public T Val1 { get => val1; set => val1 = value; }
        public T Val2 { get => val2; set => val2 = value; }
static void Swap<T>(ref T num1, ref T num2)
        {
            T temp;
            temp = num1;
            num1 = num2;
            num2 = temp;

        }
        int n1 = 10, n2 =20;
        char c1 = 'a', c2 = 'B';
       // Swap<int>(ref n1,ref n2);
      //  Swap<char>(ref c1, ref c2);
    }
}
