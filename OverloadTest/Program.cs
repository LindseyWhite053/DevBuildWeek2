using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

        int sum1 = Add(5, 3);
        Console.WriteLine(sum1);

        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static double Add(double x, double y)
        {
            return x + y;
        }

    }

}
