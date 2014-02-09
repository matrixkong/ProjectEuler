using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Pro6_SumSquareDifference
    {
        public static void test(string[] args)
        {
            int i = 100;
            double result = (3*Math.Pow(i, 4) + 2*Math.Pow(i, 3) - 3*Math.Pow(i, 2) - 2*i)/12;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
