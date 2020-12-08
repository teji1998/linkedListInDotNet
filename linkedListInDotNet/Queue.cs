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

        public int Peek()
        {
            return linkedList.head.data;
        }
       
        public bool IsEmpty()
        {
            return stack.IsEmpty();
        }

        
        public void DequeueData()
        {
            stack.EmptyingTheStack();
        }
    }
}
