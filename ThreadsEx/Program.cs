using ThreadsEx;

WareHouse wareHouse = new WareHouse();

Thread worker1 = new Thread(() => wareHouse.AddBox(1));
Thread worker2 = new Thread(() => wareHouse.AddBox(2));

worker1.Start();
worker2.Start();

worker1.Join();
worker2.Join();

Console.WriteLine("Work Completed. Total boxes added: " + wareHouse.GetBoxCount());



//Thread thread1 = new Thread(Method);
//Thread thread2 = new Thread(Method);
//Thread thread3 = new Thread(Method);

//thread1.Start();
//thread2.Start();
//thread3.Start();

//thread1.Join();
//thread2.Join();

//Console.WriteLine("Both threads completed their work");
//static void Method()
//{

//    for(int i = 0; i < 10; i++)
//    {
//        Console.WriteLine("Thread" + Thread.CurrentThread.ManagedThreadId + "Is Working." + i);
//    }
//}