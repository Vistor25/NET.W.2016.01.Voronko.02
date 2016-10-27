using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public static class DoubleExtension
    {
        /// <summary>
        /// Extension method which converts double number to a bit presentation
        /// </summary>
        /// <param name="a">Number</param>
        /// <returns>Bit presintation</returns>
        public static string ConvertToBits(this double a)
        {
            BitArray BitPresentation = new BitArray(BitConverter.GetBytes(a));
            StringBuilder result = new StringBuilder();
            for (int i = BitPresentation.Length-1; i>-1  ; i--)
            {
            //    if ((i + 1)%8 == 0)
            //    {
            //        result.Append(' ');
            //    }
                result.Append(Convert.ToByte(BitPresentation[i]));
            }
            return result.ToString();
        } 

    }
}
