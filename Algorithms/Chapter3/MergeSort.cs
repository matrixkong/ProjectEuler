using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MergeSort
    {
        public static void test()
        {
            Console.WriteLine(string.Join(",", MergeSortAlgorithms(new int[] { 1, 2, 3, 45, 3 })));
            Console.ReadKey();
        }

        public static int[] MergeSortAlgorithms(int[] array)
        {
            var length = array.Length;
            if (length == 1)
            {
                return array;
            }
            var mid = length / 2;
            var partA = new int[mid];
            var partB = new int[length - mid];
            partA = array.SubArray(0, mid); 
            partB = array.SubArray(mid, length - mid); 
            partA = MergeSortAlgorithms(partA);
            partB = MergeSortAlgorithms(partB);
            var newArray = new int[length];
            var j = 0;
            var k = 0;
            for (var i = 0; i < length; i++)
            {
                if (k < partB.Length && j < partA.Length)
                {
                    if (partA[j] <= partB[k])
                    {
                        newArray[i] = partA[j];
                        j++;
                    }
                    else if (partA[j] > partB[k])
                    {
                        newArray[i] = partB[k];
                        k++;
                    }
                }
                else
                {
                    if (k == partB.Length)
                    {
                        newArray[i] = partA[j];
                        j++;
                    }
                    else if (j == partA.Length)
                    {
                        newArray[i] = partB[k];
                        k++;
                    }

                }
            }
            return newArray;
        }
    }
}
