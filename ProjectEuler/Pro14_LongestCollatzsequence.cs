using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Pro14LongestCollatzsequence
    {
        private static Dictionary<long, long> dict = new Dictionary<long, long>();
        public static void test()
        {
            long longetst = 0;
            int longestI = 0;
            for (int i = 3; i <= 1000000; i++)
            {
                var result = LongestCollatzSequence(i);
                if (result > longetst)
                {
                    longetst = result;
                    longestI = i;
                }
            }
            Console.WriteLine(longestI);
            Console.ReadKey();
        }

        public static long LongestCollatzSequence(long startNum)
        {
            // Console.Write(":{0}", startNum);
            if (startNum == 1)
            {
                //    Console.WriteLine();
                return 0;
            }
            startNum = startNum % 2 == 0 ? startNum / 2 : startNum * 3 + 1;
            if (dict.ContainsKey(startNum))
            {
                //    Console.WriteLine(" Hit");
                return dict[startNum];
            }
            long result = LongestCollatzSequence(startNum) + 1;
            dict.Add(startNum, result);
            return result;
        }
    }
}
