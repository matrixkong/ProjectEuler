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

            const string teen = "teen"; // for 10 ~ 20.
            const string ty = "ty"; // for 20 ~ 100.
            const string hundred = "hundred"; // for number bigger than 100.
            const string and = "and"; // for hundred and double digit.

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
            array[13] = "thirteen";
            array[15] = "fifteen";
            array[18] = "eighteen";
            array[20] = "twenty";
            array[30] = "thirty";
            array[40] = "forty";
            array[50] = "fifty";
            array[80] = "eighty";
            array[1000] = "onethousand";

            for (int i = 14; i <= 1000; i++)
            {
                if (string.IsNullOrEmpty(array[i]))
                {
                    var result = new StringBuilder();
                    var unitsDigit = i % 10; // get first digit
                    var doubleDigit = i % 100;  //get first two digits number
                    if (string.IsNullOrEmpty(array[doubleDigit]))
                    {
                        result.Append(array[unitsDigit]); // append the units digit

                        var tensDigit = (doubleDigit - unitsDigit) / 10; // get tens digit
                        var tensNumber = doubleDigit - unitsDigit; //tens number 

                        if (tensDigit >= 2)
                        {
                            if (string.IsNullOrEmpty(array[tensNumber])) // check if number been cached eg: twenty, thirty
                            {
                                result.Append(array[tensDigit]); // create tens number string
                                result.Append(ty);
                            }
                            else
                            {
                                result.Append(array[tensNumber]);
                            }
                        }
                        else if (tensDigit >= 1)// if number is less than 20 and bigger than 10
                        {
                            result.Append(teen);
                        }
                    }
                    else
                    {
                        result.Append(array[doubleDigit]);
                    }

                    if (i >= 100)
                    {
                        var tripleDigit = i / 100;
                        if (doubleDigit != 0) // check if only have The Hundreds 
                            result.Append(and); 
                        result.Append(array[tripleDigit]); 
                        result.Append(hundred);
                    }
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
