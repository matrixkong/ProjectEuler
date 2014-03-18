using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.System.IO;

namespace ProjectEuler
{
    public static class Pro18_MaximumPathSumI
    {
        public async static void MaximumPathSumI()
        {
            const int height = 15;
            var array = new int[height][];
            var stringArray = await File.ReadFileToArray(@"\Resources\Pro18_MaximumPathSumI.txt");
            for (var i = 0; i < height; i++)
            {
                var tempArray = stringArray[i].Split(' '); 
                array[i] = new int[tempArray.Length];
                for (var j = 0; j < tempArray.Length; j++)
                {
                    array[i][j] = int.Parse(tempArray[j]);
                }
            }

            Console.WriteLine(MaxPathArray(array));
            Console.ReadKey();
        }

        public static long MaxPathArray(int[][] array)
        {
            if (array.Length == 1)
            {
                return array[0][0];
            }
            var subLeft = GetSubArray(array, "left");
            var subRight = GetSubArray(array, "right");
            var leftMaxPath = MaxPathArray(subLeft);
            var rightMaxPath = MaxPathArray(subRight);
            if (leftMaxPath >= rightMaxPath)
            {
                return array[0][0] + leftMaxPath;
            }
            return array[0][0] + rightMaxPath;
        }

        public static int[][] GetSubArray(int[][] array, string subArraySide)
        {
            var newArray = new int[array.Length-1][];
            for (var i =1;i < array.Length;i++)
            {
                var templist = array[i].ToList();
                if (subArraySide == "right")
                    templist.RemoveAt(0);
                else
                {
                    templist.RemoveAt(array[i].Length - 1);
                }
                newArray[i-1] = templist.ToArray();
            }
            return newArray;
        }
    }
}
