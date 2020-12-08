using System;
using System.Collections.Generic;
using System.Text;

namespace linkedListInDotNet
{
    public class LinkedList
    {
        public Node head;
        public Node endNode;
         public LinkedList()
        {
            this.head = null;
            this.endNode = null;
        }

        
        public void AddData(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            if (this.endNode == null)
            {
                endNode = node;
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
            if (this.endNode == null)
            {
                this.endNode = node;
            }
            else
            {
                this.endNode.next = node;
                this.endNode = node;
            }
        }

        public void InsertData(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("The position is not valid !!!!");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temporary = head;
                try
                {
                    while (position > 2)
                    {
                        temporary = temporary.next;
                        position--;
                    }
                    node.next = temporary.next;
                    temporary.next = node;
                }
                catch (NullReferenceException)
                {
                    System.Console.WriteLine("The index given is out of range !!!");
                }
            }
        }

        public Node Pop()
        {
            if (head == null)
            {
         /**/       Console.WriteLine("There is no value present in the list");
                return null;
            }

            Node temporaryNode = head;
            head = head.next;
            return temporaryNode;
        }

        public Node PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is  empty!!!!");
                return null;
            }
            else
            {
                Node temporary = head;
                while (temporary.next.next != null)
                {
                    temporary = temporary.next;
                }
                Node finNode = temporary.next;
                temporary.next = null;
                this.endNode = temporary;
                return finNode;
            }
        }

        public int SearchData(int data)
        {
            Node temporary = head;
            while (temporary != null)
            {
                if (temporary.data == data)
                {
                    return temporary.data;
                }
                temporary = temporary.next;
            }
            return 1;
        }

        public int Size()
        {
            Node tempNode = this.head;
            int size = 0;
            while (tempNode != null)
            {
                size++;
                tempNode = tempNode.next;
            }
            return size;
        }

        public void DeleteData(int element)
        {
            Node temp = head, previous = null;
            if (temp != null && temp.data == element)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != element)
            {
                previous = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            previous.next = temp.next;
        }

    }
}
