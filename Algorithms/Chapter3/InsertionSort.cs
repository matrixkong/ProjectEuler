using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class InsertionSort
    {
        public static void Test()
        {
            Console.WriteLine(String.Join(" ", Insertion(new[] { 32, 45, 56, 45, 67, 7, 4, 345, 65, 67, 34 })));
            Console.ReadKey();
        }
        public static int[] Insertion(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
            return array;
        }
    }
}
