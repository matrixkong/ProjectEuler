using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Pro10SummationOfPrimes
    {
        public static void SummationOfPrimes()
        {
            long sum = 5;
            var current = 5;
            while (current < 2000000) 
            {
                if (CheckPrime (current))
                    sum += current;
                if (CheckPrime(current + 2) && current+2<2000000)
                    sum += current+2;
                current = current+6; 
            } 

            Console.WriteLine(current);
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        public static bool CheckPrimeOld(long num)
        {
            for (var i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public static bool CheckPrime(long n)
        {
            if (n == 1) return false;
            if (n < 4)
                return true;
            if (n % 2 == 0)
                return true;
            if (n < 9) return true;
            if (n % 3 == 0) return false;
            var r = Math.Floor(Math.Sqrt(n));
            var f = 5;
            while (f <= r)
            {
                if (n % f == 0) return false;
                if (n % (f + 2) == 0) return false;
                f = f + 6;
            }
            return true;
        }
    }
}
