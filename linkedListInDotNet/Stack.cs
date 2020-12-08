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
    }
}
