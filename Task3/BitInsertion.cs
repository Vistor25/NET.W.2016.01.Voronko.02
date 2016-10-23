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
        public static int Insertion(int a, int b, int i, int j)
        {
            BitArray firstNumber = new BitArray(new int[] { a });
            BitArray secondNumber = new BitArray(new int[] { b });

            for(int start=i; start<=j;start++)
            {
                firstNumber.Set(start, secondNumber.Get(start));

            }
            int[] result = new int[] { 0 };
            firstNumber.CopyTo(result, 0);
            return result[0];
        }
    }
}
