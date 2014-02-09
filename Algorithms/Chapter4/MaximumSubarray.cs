using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Chapter4
{
    public class MaximumSubarray
    {
        public static void test()
        {

            int[] array = new[] { 13, -21, 125, -20};
            var result = FindMaxSubarray(new SubarrayDetail {Low = 0, High = 3, Array = array});
            Console.WriteLine(result.Sum);
            Console.ReadKey();
        }

         

        public static SubArrayResult FindMaxSubarray(SubarrayDetail start)
        {
            if (start.High == start.Low)
                return new SubArrayResult { High = start.High, Low = start.Low, Sum = start.Array[start.Low] };
            var leftResult = FindMaxSubarray(new SubarrayDetail { High = start.Mid, Low = start.Low, Array = start.Array });
            var rightResult = FindMaxSubarray(new SubarrayDetail { High = start.High, Low = start.Mid + 1, Array = start.Array });
            var crossResult = FindMaxCrossSubarray(new SubarrayDetail { High = start.High, Low = start.Low, Array = start.Array });
            if (leftResult.Sum >= rightResult.Sum && leftResult.Sum >= crossResult.Sum)
                return leftResult;
            if (rightResult.Sum >= leftResult.Sum && rightResult.Sum >= crossResult.Sum)
                return rightResult;
            return crossResult;
        }

        public static SubArrayResult FindMaxCrossSubarray(SubarrayDetail start)
        {
            int leftSum = int.MinValue;
            int rightSum = int.MinValue;
            int sum = 0;
            int maxLeft = start.Low;
            int maxRight = start.High;
            for (int i = start.Mid; i >= 0; i--)
            {
                sum = sum + start.Array[i];
                if (sum > leftSum)
                {
                    leftSum = sum;
                    maxLeft = i;
                }
            }
            sum = 0;
            for (int i = start.Mid + 1; i <= start.High; i++)
            {
                sum = sum + start.Array[i];
                if (sum > rightSum)
                {
                    rightSum = sum;
                    maxRight = i;
                }
            }
            return new SubArrayResult { High = maxRight, Low = maxLeft, Sum = leftSum + rightSum };
        }
    }

    public class SubarrayDetail
    {
        public int[] Array { get; set; }
        public int Low { get; set; }
        public int High { get; set; }
        public int Mid
        {
            get { return (Low + High) / 2; }
        }
    }

    public class SubArrayResult
    {
        public int Low { get; set; }
        public int High { get; set; }
        public int Sum { get; set; }
    }
}
