using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalTask
{
    public class PrimeTester
    {
        public static string PrimeTesterM(int number)
        {
            if (number < 2)
                return "NOT PRIME";

            int i = 2;
            while (i < number)
            {
                if (number % i == 0)
                    return "NOT PRIME";
                i++;
            }

            return "PRIME";
        }
    }
}
