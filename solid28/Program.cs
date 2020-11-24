using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace solid28
{
    class Program
    {
        static Stopwatch stopwatch;

        #region גרסה 0      
        static void NameFunc()
        {
            Console.WriteLine("{0,-6} : Start {1}", stopwatch.ElapsedMilliseconds, Thread.CurrentThread.Name);
            for (int i = 0; i < 999999999; i++)
            {
                //do something
            }
            Console.WriteLine("{0,-6} : Finish {1}", stopwatch.ElapsedMilliseconds, Thread.CurrentThread.Name);
        }

        /// <summary>
        /// שימוש במאפיינים של התהליכון
        /// </summary>
        static void MultiThread_v0()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t = new Thread(NameFunc);
                t.Name = "thread" + i;
                t.Start();
            }
        }
        #endregion

        #region גרסה 1
        static void ComplexFunc()
        {
            Console.WriteLine("{0,-6} : Start {1}", stopwatch.ElapsedMilliseconds, Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 999999999; i++)
            {
                //do something
            }
            Console.WriteLine("{0,-6} : Finish {1}", stopwatch.ElapsedMilliseconds, Thread.CurrentThread.ManagedThreadId);
        }

        /// <summary>
        /// ניתן להפעיל את התהליכון כבר בבנאי
        /// </summary>
        static void MultiThread_v1()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(ComplexFunc).Start();
                // t.Start();
            }
        }

        #endregion

        #region גרסה 2

        /// <summary>
        /// ניתן להפעיל ע"י שימוש בביטוי למבדה
        /// </summary>
        static void MultiThread_v2()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(() =>
                {
                    Console.WriteLine("{0,-6} : Start {1}", stopwatch.ElapsedMilliseconds, Thread.CurrentThread.ManagedThreadId);
                    for (int j = 0; j < 999999999; j++)
                    {
                        //do something
                    }
                    Console.WriteLine("{0,-6} : Finish {1}", stopwatch.ElapsedMilliseconds, Thread.CurrentThread.ManagedThreadId);
                }).Start();
            }
        }

        #endregion

        #region גרסה 3

        /// <summary>
        /// מיספור אחר של התהליכון - כמובן שזה לא מיספור של המערכת
        /// </summary>
        static void MultiThread_v3()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(() =>
                {
                    Console.WriteLine("{0,-6} : Start {1}", stopwatch.ElapsedMilliseconds, "thread " + i);
                    for (int j = 0; j < 999999999; j++)
                    {
                        //do something
                    }
                    Console.WriteLine("{0,-6} : Finish {1}", stopwatch.ElapsedMilliseconds, "thread " + i);
                }).Start();
            }
        }
        #endregion

        #region גרסה 4

        /// <summary>
        /// שימוש בבנאי של תהליכון המקבל ערך 
        /// </summary>
        static void MultiThread_v4()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread((obj) =>
                {
                    Console.WriteLine("{0,-6} : Start {1}", stopwatch.ElapsedMilliseconds, "thread " + obj);
                    for (int j = 0; j < 999999999; j++)
                    {
                        //do something
                    }
                    Console.WriteLine("{0,-6} : Finish {1}", stopwatch.ElapsedMilliseconds, "thread " + obj);
                }).Start(i);
            }
        }
        #endregion


        static void Main(string[] args)
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("main thread id: " + Thread.CurrentThread.ManagedThreadId);


            MultiThread_v4();


        }
    }
}