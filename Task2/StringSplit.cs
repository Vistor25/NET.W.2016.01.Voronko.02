using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class StringSplit
    {
        /// <summary>
        /// Splits two strings ,sorts the resulting string in the alphabetic order and deletes the repeating symbols
        /// </summary>
        /// <param name="a">First string</param>
        /// <param name="b">Second string</param>
        /// <returns>Splitted,sorted string excluding the repeating symbols</returns>
        public static string StringSplitting(string a, string b)
        {
            string c = a + b;
            char[] cSplitted = c.ToCharArray();
            Array.Sort(cSplitted);
            var result = new StringBuilder(cSplitted[0].ToString());
            for(int i=0; i < cSplitted.Length-1; i++)
            {
                if (cSplitted[i] != cSplitted[i + 1])
                {
                    result.Append(cSplitted[i + 1]);
                }
            }
            return result.ToString();
        }
    }
}
