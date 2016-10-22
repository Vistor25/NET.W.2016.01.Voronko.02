using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class SearchingIndexLogic
    {
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
