using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalTask
{
    public class ReverseString
    {
        public static string ReverseStringM(string reverseString)
        {
            if (reverseString == null)
                throw new ArgumentNullException($"{nameof(reverseString)} can't be null.");

            var resultSB = new StringBuilder();


            for (int i = reverseString.Length-1; i >= 0; i--)
            {
                resultSB.Append(reverseString[i]);
            }
            return resultSB.ToString();
        }
    }
}
