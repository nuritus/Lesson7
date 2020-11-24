using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace solid25a
{
    class Program
    {

        private static void run(object obj)
        {
            while (true)
            {
                Console.WriteLine(obj);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(run);
            t1.Start("A");

            Thread t2 = new Thread(run);
            t2.Start(0);

            Thread.Sleep(6000);

            t2.Abort();//סיום כוחני של התהליכון

            Thread.Sleep(6000);

            t1.Abort();//סיום כוחני של התהליכון
            //Console.ReadKey();
        }
    }
}

