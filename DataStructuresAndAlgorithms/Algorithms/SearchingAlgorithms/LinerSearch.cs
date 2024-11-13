using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Algorithms
{
    public class LinerSearch<T>
    {
        public T TargetValue { get; set; }
        public List<T> List { get; set; }

        public LinerSearch(T targetValue, List<T> list)
        {
            TargetValue = targetValue;
            List = list;
        }
        public bool IsExists()
        {
            bool isExists = false;
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].Equals(TargetValue))
                {
                    isExists = true;
                    break;
                }
            }
            return isExists;

        }
    }
}
