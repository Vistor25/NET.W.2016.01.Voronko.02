using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class SearchingIndexLogic
    {
        /// <summary>
        /// Searches the index of an element in the array where the sum before equal the sum after element
        /// </summary>
        /// <param name="array">The array where we search the index</param>
        /// <returns></returns>
        public static int Search(int [] array)
        {
            int left = 0;
            int right = array.Sum() - array[0];
            int i;
            for (i = 0; left != right&&i<array.Length; i++)
            {
                left += array[i];
                right -= array[i + 1];
            }
            return left == right ? i : -1;
        }
    }
}
