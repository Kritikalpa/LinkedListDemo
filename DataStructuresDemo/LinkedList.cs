using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    class LinkedList
    {
        internal Node head;
        
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head != null)
                node.next = this.head;
            this.head = node;
            Console.WriteLine("{0} added into linked list", node.data);
        }


        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}
