using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Algorithms.SortingAlgorithms
{
    public class BubbleSort<T> where T : IComparable<T>
    {
        
        public void Sort(List<T> List)
        {
            for (int i = 0; i < List.Count; i++)
            {
                for (int j = 0; j < List.Count - 1; j++)
                {
                    T temp = List[j];
                    if (List[j].CompareTo(List[j + 1]) > 0)
                    {
                        List[j] = List[j + 1];
                        List[j + 1] = temp;

                    }
                }
            }
        }
    }
}
