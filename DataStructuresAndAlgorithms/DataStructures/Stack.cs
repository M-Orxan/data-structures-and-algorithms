using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructuresAndAlgorithms.DataStructures
{

    public class Stack<T>
    {
        public List<T> StackList { get; set; }
       

        public Stack()
        {
            StackList = new List<T>();
        }

        /// <summary>
        /// 	Push: Add an item to the top of the stack.
        /// </summary>

        public void Push(T item)
        {
            StackList.Add(item);
        }


        /// <summary>
        /// 	Pop: Remove and return the item from the top of the stack.
        /// </summary>

        public T Pop()
        {
            if (StackList.Count > 0)
            {
                T lastItem = StackList[StackList.Count - 1];

                StackList.Remove(lastItem);
                return lastItem;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return default;
            }

        }


        /// <summary>
        /// 	Peek: Return the item at the top of the stack without removing it.
        /// </summary>

        public T Peek()
        {
            if (StackList.Count > 0)
                return StackList[StackList.Count - 1];
            else
            {
                Console.WriteLine("Stack is empty");
                return default;

            }
        }



        public void Print()
        {
            if (StackList.Count > 0)
            {
                foreach (T item in StackList)
                {

                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }


        }


        /// <summary>
        /// 	Count: Gets the number of elements in the stack.
        /// </summary>

        public int Count()
        {
            return StackList.Count;
        }


        /// <summary>
        /// 	Clear: Removes all items from the stack.
        /// </summary>

        public void Clear()
        {
            StackList = new List<T>();
        }
    }
}
