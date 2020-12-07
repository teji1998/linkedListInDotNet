using System;

namespace linkedListInDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of linkedlist !!!!");
            LinkedList linkedList = new LinkedList();
            linkedList.AddData(70);
            linkedList.AddData(30);
            linkedList.AddData(56);
            Console.WriteLine("Data is added !!" );
            linkedList.DisplayData();
        }
    }
}
