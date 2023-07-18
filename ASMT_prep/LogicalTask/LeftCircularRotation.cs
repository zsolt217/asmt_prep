using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalTask
{
    public class LeftCircularRotation
    {
        public static string LeftCircularRotationM(string input)
        {
            var inputArray = input.Split(' ');

            if (inputArray.Length == 1)
                return inputArray[0];

            var result = inputArray[1];

            for (int i = 2; i < inputArray.Length; i++)
            {
                result += " " + inputArray[i];
            }

            result += " " + inputArray[0];

            return result;
        }
    }
}
