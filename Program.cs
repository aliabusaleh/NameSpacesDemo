using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myNameSpaceDemo1;

namespace NameSpaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Level level = Level.Low;
            Tempreture tempreture = Tempreture.Cold;
            Console.WriteLine(level);
            Console.WriteLine(tempreture);
            Console.ReadKey();
        }
    }
}
