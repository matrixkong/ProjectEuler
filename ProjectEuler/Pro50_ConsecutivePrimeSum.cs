using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using Rock.System.Math;

namespace ProjectEuler
{
    public class Pro50_ConsecutivePrimeSum
    {
        private static int Max = 80000;
        public static void ConsecutivePrimeSum()
        {
            var BaseNum = 2;
            var longest = 0;
            var longestCount = 0; 
            while (true)
            {
                var num = BaseNum;
                var sum = 0;
                var count = 0; 
                while (sum < 1000000)
                { 
                    if (num.IsPrime())
                    {
                        sum = num + sum;
                        count++;
                        if (sum.IsPrime() && count > longestCount && sum < 1000000)
                        {
                            longestCount = count;
                            longest = sum;
                        }
                    }
                    num++;
                }
                while (!(++BaseNum).IsPrime()) ;
                if (BaseNum + longestCount >= 1000000)
                {
                    break;
                }
            }
            Console.Write("{0},{1}",longest,longestCount);
        }
    }
}
