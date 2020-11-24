using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/// <summary>
/// הפעולות new sleep start
/// </summary>
namespace solid25
{
    class Program
    {
        private static void runA()
        {
            while (true)
            {
                Console.WriteLine("A");
                Thread.Sleep(1000);
                //התהליכון לא יסתיים לעולם. אם נסיים את התכנית הראשית יכפה עליו כיבוי
            }
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(runA);
            thread.Start();
        }
    }
}
