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

        public void Push(int data)
        {
            Node node = new Node(data);
            linkedList.AddData(data);
        }

        public int Peek()
        {
            return this.linkedList.head.data;
        }

        public void Pop()
        {
            linkedList.Pop();
        }

        public void EmptyingTheStack()
        {
            while (Size() != 0)
            {
                Pop();
            }
        }

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

        public int Size()
        {
            return linkedList.Size();
        }
    }
}
