using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Pro19_CountingSundays
    {
        private static int[] _dayCountInts = {31, 0, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        public static void CountingSundays()
        {
            var lastMonthLastWeekDay = 1;
            var sum = 0;
            for (int i = 1901; i < 2001; i++)
            {
                var thisMonthLastWeekDay = 0;
                var yearCount = CountSundays(lastMonthLastWeekDay, i, out thisMonthLastWeekDay);
                sum += yearCount;
                Console.WriteLine("Year:{0},count{1}",i,yearCount);
                lastMonthLastWeekDay = thisMonthLastWeekDay;
            }
            Console.WriteLine(sum);
        }

        public static int CountSundays(int lastMonthLastWeekDay, int yearNumber, out int thisMonthLastWeekDay)
        {
            _dayCountInts[1] = yearNumber.IsLeapYear() ? 29 : 28;
            var totalDays = lastMonthLastWeekDay;
            var count = 0; 
            for (int i = 0; i < 12; i++)
            {
                totalDays += _dayCountInts[i];
                lastMonthLastWeekDay = totalDays % 7;
                if (lastMonthLastWeekDay == 6)
                {
                    Console.WriteLine("monthID:{0}",i+2);
                    count++;
                }
            }
            thisMonthLastWeekDay = lastMonthLastWeekDay;
            return count;
        }

        private static bool IsLeapYear(this int yearNumber)
        {
            if (yearNumber%4 == 0)
            {
                if (yearNumber%100 != 0)
                    return true;
                if (yearNumber%1000 == 0)
                    return true;
            }
            return false;
        }

    }
}
