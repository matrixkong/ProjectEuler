using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Pro4LargestPalindromeProduct
    {
        public static void LargestPalindromeProduct()
        {
            var timePerParse = Stopwatch.StartNew();
            var max = 0;
            var a = 999;
            var b = 999;
            while (a>=100)
            {
                b = 999;
                while (b >= a)
                {
                    if (a*b <= max)
                        break;
                    if (IsPalindrome(a*b))
                        max = a*b;
                    b--;
                }
                a--;
            }
            timePerParse.Stop();
            var ticksThisTime = timePerParse.ElapsedTicks;
            Console.WriteLine(max);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("time:" + ticksThisTime);
            Console.ReadKey();
        }

        public static bool IsPalindrome(int num)
        {
            var temp = num;
            var reverse = 0;
            while (num >0)
            {
                reverse = 10*reverse + num%10;
                num = num/10;
            }
            return reverse == temp;
        }

        public static void Myway()
        {
            var num = 0;
            var b = 0;
            var a = 0;
            var max = 0;

            for (var l = 9; l >= 0; l--)
            {
                for (var j = 9; j >= 0; j--)
                {
                    for (var k = 9; k >= 0; k--)
                    {
                        num = l > 0
                                  ? l * 100000 + j * 10000 + k * 1000 + k * 100 + j * 10 + l
                                  : l * 10000 + j * 1000 + k * 100 + j * 10 + l;

                        for (var i = 300; i < 999; i++)
                        {
                            if (num % i == 0)
                            {
                                b = num / i;
                                if (999 > b && b > 100)
                                {
                                    max = num;
                                    a = i;
                                    goto stop;
                                }
                            }
                        }

                    }
                }
            }
            stop:
            Console.WriteLine(max);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
