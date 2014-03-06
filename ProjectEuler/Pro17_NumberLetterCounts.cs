using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Pro17_NumberLetterCounts
    {
        public static void Main()
        {
            var array = new string[1001];
            array[0] = "";
            array[1] = "one";
            array[2] = "two";
            array[3] = "three";
            array[4] = "four";
            array[5] = "five";
            array[6] = "six";
            array[7] = "seven";
            array[8] = "eight";
            array[9] = "nine";
            array[10] = "ten";


            array[11] = "eleven";
            array[12] = "twelve";

            const string teen = "teen";
            array[13] = "thirteen";
            array[15] = "fifteen";
            array[18] = "eighteen";

            const string ty = "ty";
            array[20] = "twenty";
            array[30] = "thirty";
            array[40] = "forty";
            array[50] = "fifty";
            array[80] = "eighty";

            const string hundred = "hundred";
            const string and = "and";
            array[1000] = "onethousand";

            for (int i = 14; i <= 1000; i++)
            {
                if (string.IsNullOrEmpty(array[i]))
                {
                    var result = new StringBuilder();
                    var singleDigit = i % 10;
                    var doubleDigit = i % 100;
                    if (doubleDigit > 10 && doubleDigit < 20)
                    {
                        if (string.IsNullOrEmpty(array[doubleDigit]))
                        {
                            result.Append(array[singleDigit]);
                            result.Append(teen);
                        }
                        else
                        {
                            result.Append(array[doubleDigit]);
                        }
                    }
                    if (doubleDigit >= 20)
                    {
                        if (string.IsNullOrEmpty(array[doubleDigit]))
                        {

                            result.Append(array[singleDigit]);
                            doubleDigit = doubleDigit - singleDigit;
                            if (string.IsNullOrEmpty(array[doubleDigit]))
                            {
                                doubleDigit = doubleDigit / 10;
                                result.Append(array[doubleDigit]);
                                result.Append(ty);
                            }
                            else
                            {
                                result.Append(array[doubleDigit]);
                            }
                        }
                        else
                        {
                            result.Append(array[doubleDigit]);
                        }
                    }
                    if (i >= 100)
                    {
                        var tripleDigit = i/100;
                        //result.Append(array[singleDigit]);
                        if (doubleDigit!=0) 
                            result.Append(and);
                        if (doubleDigit <= 10)
                            result.Append(array[doubleDigit]); 
                        result.Append(array[tripleDigit]);
                        result.Append(hundred);
                    }
                    //Console.WriteLine(result.ToString());
                    array[i] = result.ToString();
                }
            }
            using (var file = new StreamWriter(@"C:\txt.txt"))
            {
                foreach (string line in array)
                { 
                        file.WriteLine(line); 
                }
            }
            var sum = 0;
            foreach (var s in array)
            {
                var charArray = s.ToArray();
                sum += charArray.Count();
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
