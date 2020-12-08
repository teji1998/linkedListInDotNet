using System;
using System.Collections.Generic;
using System.Text;

namespace linkedListInDotNet
{
    public class Queue
    {
        LinkedList linkedList;
        Stack stack;

        public Queue()
        {
            linkedList = new LinkedList();
            stack = new Stack();
        }

        /// <summary>
        /// Enqueues the data into queue.
        /// </summary>
        /// <param name="data">The data.</param>
        public void EnqueueData(int data)
        {
            Node node = new Node(data);
            if (IsEmpty())
            {
                linkedList.AddData(data);
            }
            else
            {
                linkedList.AppendData(data);
            }
        }

        /// <summary>
        /// Gives the topmost element in queue.
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            return linkedList.head.data;
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            return stack.IsEmpty();
        }


        /// <summary>
        /// Dequeues the data in the queue.
        /// </summary>
        public void DequeueData()
        {
            stack.EmptyingTheStack();
        }

        /// <summary>
        ///gives size of queue.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return linkedList.Size();
        }
    }
}
