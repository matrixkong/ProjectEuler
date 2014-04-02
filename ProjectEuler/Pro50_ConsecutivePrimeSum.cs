using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Rock.System.Math;

namespace ProjectEuler
{
    public class Pro50_ConsecutivePrimeSum
    {
        public static int MaxLength = 80000;

        public static void ConsecutivePrimeSum()
        {
            var primeArray = new int[MaxLength];
            var index = -1;
            var longest = 0;
            var sum = 0;
            for (var i = 2; i < 1000000; i++)
            {
                if (index >= MaxLength - 1)
                    throw new StackOverflowException();
                if (i.IsPrime())
                {
                    index++;
                    primeArray[index] = i;
                }
            }

            var start = 0;
            var end = index;
            index = 0;
            var length = 0;
            while (true)
            {
                while (index <= end)
                {
                    var tempSum = primeArray[index] + sum;
                    if (tempSum >= primeArray[end])
                        break;
                    sum = tempSum;
                    index++;
                    if (sum.IsPrime() && index - start > length && longest<sum)
                    {
                        longest = sum;
                        length = index - start;
                    }
                }
                start++;
                if (end - start < length)
                    break;
                index = start;
                sum = 0;
            }
            var value = primeArray.Select(i => i == 997651).ToList();
            Console.Write("{0},{1}", longest, length);
        }
    }
}
