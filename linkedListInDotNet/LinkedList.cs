using System;
using System.Collections.Generic;
using System.Text;

namespace linkedListInDotNet
{
    public class LinkedList
    {
        internal Node head;
         public LinkedList()
        {
            this.head = null;
        }

        public void AddData(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temporaryNode = this.head;
                this.head = node;
                this.head.next = temporaryNode;
            }
            Console.WriteLine("{0} inserted  in linked list. " , node.data);
        }

        public void DisplayData()
        {
            if (this.head == null)
            {
                Console.WriteLine("The list is empty!!!!");
            }
            else
            {
                Node temporary = head;
                while(temporary != null)
                {
                    Console.WriteLine(temporary.data + " ");
                    temporary = temporary.next;
                }
            }
        }
    }
}
