using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Pro12HighDivisibleTangularNmber
    {
        //there is a better solution for this.
        public static void HighDivisibleTangularNmber()
        {
            long addition = 2; 
            long triangleNumber = 1;
            while (true)
            {
                triangleNumber = addition + triangleNumber;
                addition++;
                var divisorCount = 1;
                var temp = 1;
                for (var i = 2; i < triangleNumber; i++)
                { 
                    if (triangleNumber%i == 0)
                    {
                        var result = triangleNumber/i;
                        if (result == temp)
                        {
                            break;
                        }
                        if (result == i)
                        {
                            break;
                        }
                        temp = i;
                        divisorCount++;
                    } 
                }
                if (divisorCount*2 >= 500)
                {
                    break;
                }
            }
            Console.WriteLine(triangleNumber);
            Console.ReadKey();
        }
         
    }
}
