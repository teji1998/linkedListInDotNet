using System;

namespace linkedListInDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of linkedlist !!!!");
            LinkedList linkedList = new LinkedList();
            int firstNode = 56;
            int secondNode = 30;
            int thirdNode = 40;
            int fourthNode = 70;
            linkedList.AppendData(firstNode);
            linkedList.AppendData(secondNode);
            linkedList.AppendData(fourthNode);
            linkedList.InsertData(3, thirdNode);
            linkedList.DisplayData();
            Console.WriteLine("Data is added !!" );
            //linkedList.Pop();
            //linkedList.PopLast();
            Console.WriteLine(linkedList.SearchData(30));
            linkedList.DisplayData();
            
        }
    }
}
