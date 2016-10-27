using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class BitInsertion
    {

        /// <summary>
        /// Inserts second number into first number starting from firstIndex to secondIndex
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="firstIndex">Starting index which from we begin inserting</param>
        /// <param name="secondIndex">The last index where we inserting</param>
        /// <returns>An inserted number</returns>
        /// <exception cref="ArgumentException"></exception>
        public static int Insertion(int a, int b, int firstIndex, int secondIndex)
        {
            if (firstIndex < 0 || firstIndex > 31 || secondIndex < 0 || secondIndex > 31)
            
                throw new ArgumentException();
            
                
            BitArray firstNumber = new BitArray(new int[] { a });
            BitArray secondNumber = new BitArray(new int[] { b });

            for(int i=firstIndex; i<=secondIndex;i++)
            {
                firstNumber.Set(i, secondNumber.Get(i));

            }
            int[] result = new int[] { 0 };
            firstNumber.CopyTo(result, 0);
            return result[0];
        }
    }
}
