using System;

namespace DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List demo!!!");
            LinkedList list = new LinkedList();
            list.Append(56);
            list.Append(70);
            list.Display();
            list.InsertAtParticularPostion(2, 30);
            list.Display();
            int index = list.Search(30);
            Console.WriteLine("30 is found at : {0}", index);
            list.InsertAtParticularPostion(index + 1, 40);
            list.Display();
        }
    }
}
