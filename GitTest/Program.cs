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
            for (int b = 2; b < 5; b++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    WriteLine("{0}^{1} = {2}", b, i, Math.Pow(b, i));
                }
            }

            ReadKey();
        }
    }
}
