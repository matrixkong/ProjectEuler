using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.System.Math
{
    public static class Prime
    {
        public static bool IsPrime(this long num)
        {
            for (var i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public static bool IsPrime(this int num)
        {
            for (var i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
