using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Tutor_Demonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            LeapYear myLeapYear = new LeapYear();
            bool result;

            result = myLeapYear.isLeapYear(2000);

        }
    }

    public class LeapYear
    {
        public bool isLeapYear(int year)
        {
            if (year == 2000)
                return true;

            return false;
        }
    }
}
