using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class NonGenericCollection
    {
        public void ArrayListHandling()
        {
            ArrayList arrayList = new ArrayList();  
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);

         /*   for(int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
          */
        
            arrayList.Add("HII");
            arrayList.Add(true);
            arrayList.Add(false);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.RemoveAt(3);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Clear();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arrayList.Contains(10));
            Console.WriteLine(arrayList.IndexOf(20));
        }
        public void StackHandling()
        {
            Stack s = new Stack();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push("KK");
            s.Push(12.34);
            s.Push(true); 
            s.Push(false);
            s.Push(00);
            s.Push(65);
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
           Console.WriteLine("Pop" + s.Pop());
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek" + s.Peek());
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
        public void QueueHandling()
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue("KK");
            q.Enqueue(12.34);
            q.Enqueue(true);
            q.Enqueue(false);
            q.Enqueue(65);
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Pop" + q.Dequeue());
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek" + q.Peek());
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count" + q.Count);
        }
        public void HashTableHandling()
        {
        Hashtable ht = new Hashtable();
            ht.Add(1, 10);
            ht.Add(2, 20);
            ht.Add(3, 30);
            ht.Add("4", "Ram");
            ht.Add(5, true);
            foreach (var item in ht)
            {
                Console.WriteLine(item);
            }
            ht.Remove(3);
            foreach (var item in ht)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(ht.ContainsKey("5"));
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count" + ht.Count);
        }
        public void SortedListHandling()
        {
            SortedList sl = new SortedList();
            sl.Add(7, 99); 
            sl.Add(4, 32);
            sl.Add(1, 67);
            sl.Add(2, "Abad");
            foreach (var item in sl)
            {
                Console.WriteLine(item);
            }

        }
    }
}

