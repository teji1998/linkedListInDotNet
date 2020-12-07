using System;

namespace linkedListInDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of linkedlist !!!!");
            LinkedList linkedList = new LinkedList();
            linkedList.AddData(56);
            linkedList.AppendData(30);
            linkedList.AppendData(70);
            Console.WriteLine("Data is added !!" );
            linkedList.DisplayData();
            Console.WriteLine("Checking first element : " + linkedList.CheckingFirstElement());
            Console.WriteLine("Checking middle elemnet : " + linkedList.CheckingMiddleElement());
            Console.WriteLine("Checking last element : " + linkedList.CheckingLastElement());
        }
    }
}
