using System;
using System.Collections.Generic;
using System.Text;

namespace linkedListInDotNet
{
    public class LinkedList
    {
        public Node head;
        public Node tail;
         public LinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        
        public void AddData(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            if (this.tail == null)
            {
                tail = node;
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
                return ;
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

        public void AppendData(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            if (this.tail == null)
            {
                this.tail = node;
            }
            else
            {
                this.tail.next = node;
                this.tail = node;
            }
        }

        public int CheckingFirstElement()
        {
            return this.head.data;
        }

        public int CheckingLastElement()
        {
            return this.tail.data;
        }

        public int CheckingMiddleElement()
        {
            return this.head.next.data;
        }
    }
}
