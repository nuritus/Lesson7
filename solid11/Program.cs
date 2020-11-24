using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace solid11
{/// <summary>
/// ניתן לראות כאן שלכל תהליכון ישנו מזהה, ובפרט לתהליכון הראשי. ניתן להדפיסו ע"י שימוש במחלקה המתאימה
/// </summary>
    class Program
    {
        static void Main(string[] args)
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


