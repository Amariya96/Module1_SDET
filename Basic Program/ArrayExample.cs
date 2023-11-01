using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class ArrayExample
    {
        int[] numbers = new int[5];
        int[,] nums = new int[3, 2];

        public void Onedimension()
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


        }
        public void Twodimension()
        {
            nums[0, 0] = 1;
            nums[0, 1] = 2;
            nums[1, 0] = 3;

            foreach (int num in nums)
            {

                Console.WriteLine(num);
            }
        }
        public void Jaggered()
        {
            int[][,] arr = new int[][,]
            {
                new int[,] {{1,2}, { 3,4,} },
                new int[,] {{40,10},{20,30},{55,99}},
                new int[,] {{33,22},{20,44},{45,23}}
            };
            foreach (var item in arr)
            {
                Console.WriteLine(item[0, 1]);
            }
            for (int i = 0; i < arr.Length; i++)
            {

                int x = 0;
                for (int j = 0; j < arr[i].GetLength(x); j++)
                {
                    for (int k = 0; k < arr[j].Rank; k++)
                    {
                        Console.Write(arr[i][j, k] + " ");
                    }
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();

            }
        }
    }
}
