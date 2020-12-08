using System;
using System.Collections.Generic;
using System.Text;

namespace linkedListInDotNet
{
    public class Stack
    {
        LinkedList linkedList;

        public Stack()
        {
            linkedList = new LinkedList();
        }

        /// <summary>
        /// Pushes the specified data into stack.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Push(int data)
        {
            Node node = new Node(data);
            linkedList.AddData(data);
        }

        /// <summary>
        /// Gives the topmost element of stack.
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            return this.linkedList.head.data;
        }

        /// <summary>
        /// Removes the elements from stack.
        /// </summary>
        public void Pop()
        {
            linkedList.Pop();
        }

        /// <summary>
        /// Emptying the stack.
        /// </summary>
        public void EmptyingTheStack()
        {
            while (Size() != 0)
            {
                Pop();
            }
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            if (Size() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gives size of the stack.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return linkedList.Size();
        }
    }
}
