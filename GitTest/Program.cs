using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteLine("Hallå torsdag!");
            for (int i = 1; i <= 10; i++)
            {
                WriteLine("{0}^3 = {1}", i, i * i);
            }

            ReadKey();
        }
    }
}
