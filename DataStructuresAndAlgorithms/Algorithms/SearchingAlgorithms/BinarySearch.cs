using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Algorithms.SearchingAlgorithms
{
    internal class BinarySearch<T> where T : IComparable<T>
    {

        public int Search(T targetValue, List<T> list)
        {
            int low = 0;
            int high = list.Count - 1;


            while (low <= high)
            {

                int middle = (low + high) / 2;

                if (list[middle].Equals(targetValue))
                {
                    return middle;
                }
                else if (list[middle].CompareTo(targetValue) > 0)
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }

            }

            return -1;

        }
    }
}
