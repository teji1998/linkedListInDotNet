using System;

namespace linkedListInDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of linkedlist !!!!");
            Node head = new Node(56);
            head.next = new Node(30);
            head.next.next = new Node(70);
        }
    }
}
