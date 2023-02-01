using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalTask
{
    public class Palindrome
    {
        public static string PalindromM(string input)
        {
            if (input == null)
                throw new ArgumentNullException($"{nameof(input)} can't be null!");

            var begin = 0;
            var end = input.Length - 1;
            while (input[begin].Equals(input[end])
                && begin < input.Length - 1)
            {
                begin++;
                end--;
            }
            if (begin == input.Length - 1)
                return "Palindrome";

            return "Not palindrome";
        }
        //elég csak a feléig menni
        public static string PalindromMv2(string input)
        {
            if (input == null)
                throw new ArgumentNullException($"{nameof(input)} can't be null!");

            var begin = 0;
            var end = input.Length - 1;
            while (input[begin].Equals(input[end])
                && begin < input.Length / 2)
            {
                begin++;
                end--;
            }
            if (begin == input.Length /2)
                return "Palindrome";

            return "Not palindrome";
        }
    }
}
