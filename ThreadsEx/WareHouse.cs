using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsEx
{
    internal class WareHouse
    {
        private int boxCount =0;

        public void AddBox(int workerId)
        {
            for (int i = 0; i <= 5; i++)
            {
                Thread.Sleep(1000);
                boxCount++;
                Console.WriteLine($"Worker {workerId} added a box. Total boxes: {boxCount}");

            }
        }
        public int GetBoxCount() 
        { 
            return boxCount;
        }
    }
}
