using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    internal class Queue<T>
    {

        public List<T> QueueList { get; set; }
        public int Count => QueueList.Count;

        public Queue()
        {
            QueueList = new List<T>();
        }

        public void Enqueue(T item)
        {
            QueueList.Add(item);
        }


        public T Dequeue()
        {

            if (QueueList.Count > 0)
            {
                T firstItem = QueueList[0];
                QueueList.Remove(firstItem);
                return firstItem;
            }
            else
            {
                Console.WriteLine("Queue is empty");
                return default;
            }
        }

        public T Peek()
        {
            if (QueueList.Count > 0)
            {


                return QueueList[0];
            }
            else
            {
                Console.WriteLine("Queue is empty");
                return default;
            }
        }

        public void Clear()
        {
            QueueList = new List<T>();
        }

        public void Print()
        {
            if (QueueList.Count > 0)
            {
                foreach (T item in QueueList)
                {
                    Console.WriteLine(item);
                }
            }
            else
                Console.WriteLine("Queue is empty");

        }
    }
}
