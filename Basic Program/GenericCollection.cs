using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class GenericCollection
    {
        public void ListHandling()
        {
           List<int> num = new List<int>();
            num.Add(12435);
            num.Add(6568);
            num.Add(30);

            /*   for(int i = 0; i < arrayList.Count; i++)
               {
                   Console.WriteLine(arrayList[i]);
               }
             */

            num.Add(9);
            num.Add(654);
            num.Add(987);
            foreach (int item in num)
            {
                Console.WriteLine(item);
            }
            num.Reverse();
            foreach (int item in num)
            {
                Console.WriteLine(item);
            }
            num.RemoveAt(3);
            foreach (int item in num)
            {
                Console.WriteLine(item);
            }
            num.Sort();
            foreach (int item in num)
            { Console.WriteLine(item); }    
            num.Clear();
            foreach (int item in num)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(num.Contains(10));
            Console.WriteLine(num.IndexOf(20));
        }
        public void DictionaryHandling()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "Ram");
            dt.Add(2, "Anu");
            dt.Add(3, "Bibi");
            dt.Add(4, "Amru");
            dt.Add(5, "Manu");
            foreach (var item in dt)
            {
                Console.WriteLine(item);
            }
            dt.Remove(3);
            foreach (var item in dt)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(dt.ContainsKey(6));
            foreach (var item in dt.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in dt.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count" + dt.Count);
        }
    }
}
