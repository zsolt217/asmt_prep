using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalTask
{
    public static class ReverseWords
    {
        public static string ReverseWordsM(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                throw new ArgumentNullException(nameof(sentence));

            var result = String.Empty;
            var lenght = 1;

            for (int i = (sentence.Length - 1); i >= 0; i--)
            {
                if (sentence[i] == ' ')
                {
                    result += sentence.Substring(i+1, lenght-1);
                    result += " ";
                    lenght = 1;
                    continue;
                }
                lenght++;
            }

            if (result.Length != sentence.Length)
                result += sentence.Substring(0, lenght);

            return result;
        }

        /*
         internal static void ReverseWordOrder(string str)  
{  
    int i;  
    StringBuilder reverseSentence = new StringBuilder();  
  
    int Start = str.Length - 1;  
    int End = str.Length - 1;  
  
    while (Start > 0)  
    {  
        if (str[Start] == ' ')  
        {  
            i = Start + 1;  
            while (i <= End)  
            {  
                reverseSentence.Append(str[i]);  
                i++;  
            }  
            reverseSentence.Append(' ');  
            End = Start - 1;  
        }  
        Start--;  
    }  
  
    for (i = 0; i <= End; i++)  
    {  
        reverseSentence.Append(str[i]);  
    }  
    Console.WriteLine(reverseSentence.ToString());  
}*/
    }
}
