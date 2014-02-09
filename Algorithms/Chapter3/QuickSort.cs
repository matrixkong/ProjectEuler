using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class QuickSortLearning
    {
        static void test(string[] args)
        {
            Console.WriteLine(string.Join(" ", QuickSort(new[] { 5,44,2,15,8,47,53,4,1,56,16,81,5,161,687,4,4,5,3,6,8461,651,48,4,4,2,8,41,2,78,5 }))); 
            Console.ReadKey();
        }

        public static int[] QuickSort(int[] array)
        {
            Console.WriteLine(string.Join(" ", array)); 
            var num = array.Length;
            if (num <= 1)
                return array;
            var pivot = array[num/2]; 
            int[] arrayLess = new int[num];
            int[] arrayMore = new int[num];
            int[] arrayEqual = new int[num];
            int lessPosition = 0;
            int morePosition = 0;
            int equalPosition = 0;
            foreach (var i in array)
            {
                if (i < pivot)
                {
                    arrayLess[lessPosition] = i;
                    lessPosition++;
                }
                else if (i == pivot)
                {
                    arrayEqual[equalPosition] = i;
                    equalPosition++;
                }
                else
                {
                    arrayMore[morePosition] = i;
                    morePosition++;
                }
            }
            int[] arrayLessNew = arrayLess.SubArray(0,lessPosition);
            int[] arrayMoreNew = arrayMore.SubArray(0,morePosition);
            int[] arrayEqualNew = arrayEqual.SubArray(0, equalPosition);
            return QuickSort(arrayLessNew).Concat(arrayEqualNew).Concat(QuickSort(arrayMoreNew)).ToArray();
        }

        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
    }
}
