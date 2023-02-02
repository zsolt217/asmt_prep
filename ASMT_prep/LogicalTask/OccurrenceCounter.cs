using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalTask
{
    public static class OccurrenceCounter
    {
        public static string Count(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException(nameof(input));

            var dict= new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                    continue;

                if(dict.Keys.Contains(input[i]))
                    dict[input[i]]++;
                else
                    dict.Add(input[i], 1);
            }
            var result = String.Empty;
            foreach (var item in dict)
            {
                result += $"{item.Key} - {item.Value}" + Environment.NewLine;
            }
            return result;
        }
    }
}
