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
            list.RemoveFirstNode();
            list.Display();
        }
    }
}
