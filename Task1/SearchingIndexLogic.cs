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
        /// <returns>Index where the sum before equal the sum after index</returns>
        /// <exception cref="ArgumentException"></exception>
        public static int Search(int [] array)
        {
            if (array == null || array.Length < 3)
                throw new ArgumentException();
            int left = 0;
            var right = array.Sum() - array[0];
            int i;
            for (i = 0; left != right&&i<array.Length-1; i++)
            {
                left += array[i];
                right -= array[i + 1];
            }
            return left == right ? i : -1;
        }
    }
}
