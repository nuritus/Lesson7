using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace solid11a
{/// <summary>
/// מבנה של תכנית בו נשתמש בהמשך. כעת ניתן לראות בהרצה שמשך התליכון משתנה בכל הרצה.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // תהליכון יחיד
            OneThread();

        }
        //כדי לבדוק יעילות בהמשך - רשמנו זמן התחלה וסוף של הרצה סינכרונית
        static void OneThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Func1();
            }
        }
        static void Func1()//את זה עשינו מקודם בתכנית הראשית - וכאן בפונקציה.
        {
            Console.WriteLine(DateTime.Now + " : Start " + Thread.CurrentThread.ManagedThreadId + " thread");
            for (int i = 0; i < 999999999; i++)
            {
                //do something
            }
            Console.WriteLine(DateTime.Now + " : Finish " + Thread.CurrentThread.ManagedThreadId + " thread");
        }
    }
}


