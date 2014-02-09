using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Pro7_Prime10001
    {
        public static void test()
        {
            var watch = Stopwatch.StartNew();
            watch.Start();
            bool flag = false;
            long number = 1;
            var array = new long[10001];
            array[0] = 2;
            int i = 1;
            do
            {
                number += 2;
                for (var k = 0; k < i; k++)
                {
                    if (number%array[k] == 0)
                    {
                        flag = false;
                        break;
                    }
                    flag = true;
                }
                if (flag)
                {
                    array[i] = number;
                    i++;
                } 
                flag = false;
            } while (i <= 10000);
            watch.Stop();
            Console.WriteLine(watch.ElapsedTicks);
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
