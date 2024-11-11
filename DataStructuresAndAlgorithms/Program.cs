using DataStructuresAndAlgorithms.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            DataStructures.Queue<int> queue = new DataStructures.Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            int count=queue.Count;
            Console.WriteLine(count);
            queue.Clear();
            count = queue.Count;
            Console.WriteLine(count);

            queue.Peek();

        }
    }
}
