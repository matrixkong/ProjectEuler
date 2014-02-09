using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Pro3_LargestPrimeFactor
    {
        static void test()
        {
            var max = 0;
            var limit = 600851475143;
            for (var i = 2; i <= limit; i++)
            {
                if (CheckPrime(i) && limit%i==0)
                { 
                    limit = limit/i;
                    max = max > i ? max : i;
                    Console.WriteLine("new limit:" + limit + "new max:"+max);
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }

        public static bool CheckPrime(long num)
        {
            for (var i = 2; i*i <= num; i++)
            {
                if (num%i == 0)
                    return false;
            }
            return true;
        }
    }
}
