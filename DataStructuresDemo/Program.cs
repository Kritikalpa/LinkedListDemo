using System;

namespace DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List demo!!!");
            LinkedList list = new LinkedList();
            //list.Add(70);
            //list.Add(30);
            //list.Add(56);
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();
        }
    }
}
