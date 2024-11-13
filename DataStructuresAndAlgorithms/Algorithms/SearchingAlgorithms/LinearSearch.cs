using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Algorithms
{
    public class LinearSearch<T>
    {
        public int Search(T targetValue, List<T> list)
        {
           
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(targetValue))
                {
                    return i;                  
                }
            }
            return -1;

        }
    }
}
