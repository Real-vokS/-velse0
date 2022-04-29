using System;
using System.Threading;

namespace Øvelse0
{

    class Threprog
    {
        //laver en thread som køre metoden WorkThreadFunction
        static Thread t1 = new Thread(new ThreadStart(WorkThreadFunction));

        //laver en thread som køre metoden WorkThreadFunction
        static Thread t2 = new Thread(new ThreadStart(WorkThreadFunction));
        static void Main()
        {
            //giver t1 et navn "Thread1" og starter threaden
            t1.Name = "Thread1";
            t1.Start();

            //giver t2 et navn "Thread1" og starter threaden
            t2.Name = "Thread2";
            t2.Start();

            Console.Read();
        }


        //udskriver i en WriteLine 5 gange "Simple Thread"
        static void WorkThreadFunction()
        {
            for (int i = 0; i < 5; i++)
            {
                //tager current threads navn og indsætter det foran Simple Thread
                Console.WriteLine("[{0}] Simple Thread", Thread.CurrentThread.Name);
            }
        }
    }
}

