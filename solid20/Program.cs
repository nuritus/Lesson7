using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace solid20
{
    class Program
    {
        static void Main(string[] args)
        {
            string person_0 = @"
            xxx
            xxxxxx
            x x
                x
                x
            xxxxx
            x xxxxxx x
        x  xxxxxx  x     
        x    xxxxxx  x
        x     xxxxxx  x
        x     xxxxxx  x
            xxxxxx
            xx   xx
            xx    xx
            xx    xx
            xx    xx
            xx    xx
            xxxx  xxxx
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -";

            string person_1 = @"
                xxx
            xxxxxx
                x x
                x
                x
            xxxxx
            x xxxxxx x
        x  xxxxxx  x  
        x  xxxxxx   x
            x  xxxxx    x 
            x xxxxx     x
            xxxxx
            xx   xx
            xx     xx
            xx     xx
        xx       xx
        xx        xx
        xxxx       xxxx
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ";

            do
            {
                Console.Write(person_0);
                Thread.Sleep(200); //מופעל על התהליכון שכרגע בריצה
                Console.Clear();
                Console.Write(person_1);
                Thread.Sleep(200);//ללא ההשהיות עין אנושית לא רואה את הציור על המסך
                Console.Clear();
            } while (!Console.KeyAvailable);

        }

    }
}
