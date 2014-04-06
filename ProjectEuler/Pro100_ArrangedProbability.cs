using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Pro100_ArrangedProbability
    {
        public static void ArrangedProbability()
        {
            long b = 15;
            long n = 21;
            long target = 1000000000000;

            while (n < target)
            {
                long btemp = 3 * b + 2 * n - 2;
                long ntemp = 4 * b + 3 * n - 3;

                b = btemp;
                n = ntemp;
            }
            Console.Write("{0},{1}",b,n);
        }
    }
}
