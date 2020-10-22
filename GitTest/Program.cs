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
                WriteLine("sqrt{0} = {1}", i, Math.Pow(2, i));
            }

            ReadKey();
        }
    }
}
