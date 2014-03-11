using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Pro5SmallestMultiple
    {
        public static void SmallestMultiple()
        {
            var timePerParse = Stopwatch.StartNew();
            long total = 1;
            var array = new int[21];
            array[0] = 1;
            for (var i = 1; i <= 20; i++)
            {
                array[i] = i;
            }
            for (var i = 3; i <= 20; i++)
            {
                for (var j = 2; j < i; j++)
                {
                    if (array[i] % array[j] == 0 && array[j] != 1)
                    {
                        Console.WriteLine(i);
                        Console.WriteLine(array[i]);
                        array[i] = array[i] / array[j];
                        Console.WriteLine(array[i]);
                        Console.WriteLine("_____________________________");
                    }
                }
            }

            for (var i = 0; i <= 20; i++)
            {
                Console.WriteLine(array[i]);
                total = array[i] * total;
            }

            timePerParse.Stop();
            Console.WriteLine(timePerParse.ElapsedTicks);
            Console.WriteLine(total);
            timePerParse = Stopwatch.StartNew();
            Console.WriteLine(Good(20));
            timePerParse.Stop();
            Console.WriteLine(timePerParse.ElapsedTicks);
            timePerParse = Stopwatch.StartNew();
            Test(20);
            timePerParse.Stop();
            Console.WriteLine(timePerParse.ElapsedTicks);
            Console.ReadKey();
        }

        public static long Good(int k)
        {
            var total = 1.0;
            var i = 1;
            bool check = true;
            var limit = Math.Sqrt(k);
            var array = new int[21];
            var arrayTimes = new double[21];
            for (var j = 1; j <= 20; j++)
            {
                if (CheckPrime(j))
                {
                    array[i] = j;
                    i++;
                }
            }
            i = 1;
            while (array[i] <= k && array[i] > 0)
            {
                arrayTimes[i] = 1;
                if (check)
                {
                    if (array[i] <= limit)
                    {
                        arrayTimes[i] = Math.Floor(Math.Log(k) / Math.Log(array[i]));
                    }
                    else
                    {
                        check = false;
                    }
                }
                total = total * Math.Pow(array[i], arrayTimes[i]);
                if (++i > 20) break;
            }
            return (long)total;
        }

        public static bool CheckPrime(long num)
        {
            for (var i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public static void Test(int num)
        {
            int max = 20; //change this to whatever

            bool foundNum = false;
            bool stop = false;
            for (int m = max; !foundNum; m += max)
            {
                for (int i = 1; i <= max && !stop; i++)
                {
                    if (m % i != 0)
                    {
                        stop = true;
                    }
                }
                if (stop)
                {
                    stop = false;
                }
                else
                {
                    Console.WriteLine(m);
                    foundNum = true;
                }
            }
        }
    }
}
