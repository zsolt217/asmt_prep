using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalTask
{
    public static class RemoveDuplication
    {
        public static string RemoveDuplicationM(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException(nameof(input));

            var result = String.Empty;

            result += input[0];

            for (int i = 1; i < input.Length; i++)
            {
                int k = 0;
                while (k < i)
                {
                    if (input[i] == input[k])
                        break;
                    k++;
                }
                if(k==i)
                    result += input[i];
            }

            return result;
        }
    }
}
