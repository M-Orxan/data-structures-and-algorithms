using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Algorithms.SortingAlgorithms
{
    public class InsertionSort<T> where T : IComparable<T>
    {
        public void Sort(List<T> List)
        {

            for (int i = 1; i < List.Count; i++)
            {

                T temp = List[i];
                int j = i - 1;

                while (j >= 0 && temp.CompareTo(List[j]) < 0)
                {
                    List[j + 1] = List[j];
                    j--;
                }
                List[j + 1] = temp;

            }

        }
    }
}
