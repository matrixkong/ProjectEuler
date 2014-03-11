using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Pro9SpecialPythagoreanTriplet
    {
        public static void SpecialPythagoreanTriplet()
        {
            for (var a = 3; a < (1000-3)/3; a++)
            {
                for (var b = a+1; b < (1000 - a - 1)/2; b++)
                {
                    var c = 1000 - a - b;
                    if (a*a + b*b == c*c)
                    {
                        Console.WriteLine("a:{0},b{1},c{2},product{3}",a,b,c,a*b*c);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
