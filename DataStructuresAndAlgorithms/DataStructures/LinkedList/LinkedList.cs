using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedList
{
    public class LinkedList<T>
    {
       // Node<int> head;
        public Node<T> Head { get; set; }

        public void AddToFront(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.NextNode = Head;
            Head = newNode;

        }

        public void Print()
        {
            Node<T> runner = Head;

            while (runner != null) {
                Console.WriteLine(runner.Data);
                runner = runner.NextNode;
            }
        }
    }
}
