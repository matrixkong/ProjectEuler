using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Pro20_FactorialDigitSum
    {
        public static void FactorialDigitSum()
        {
            Console.WriteLine( FactorialResult(100).Where(i=>i!=0).Aggregate((a,b)=>a+b));
        }

        public static int[] FactorialResult(int factorialLimit)
        {
            var limit = 1000;
            var result = new int[limit];
            result[1] = 1;
            var baseNum = 10;
            var last = 1;
            for (var i = 1; i <= factorialLimit; i++)
            {
                var carry = 0;
                for (var j = 1; j <= last; j++)
                {
                    var temp = result[j] * i + carry;
                    carry = temp / baseNum;
                    result[j] = temp % baseNum;
                }
                while (carry > 0)
                {
                    if (last >= limit)
                        throw new IndexOutOfRangeException("not enough memory");
                    last += 1;
                    result[last] = carry%baseNum;
                    carry = carry/baseNum;
                }
            }
            return result;
        }
    }
}
