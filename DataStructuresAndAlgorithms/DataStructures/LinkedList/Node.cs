﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedList
{
    public class Node<T>
    {

        public T Data { get; set; }
        public Node<T> NextNode { get; set; }

        public Node(T data)
        {
            Data=data;
        }
    }
}
