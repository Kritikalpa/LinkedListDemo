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

        internal void Append(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} appended into linked list", node.data);
        }

        internal Node InsertAtParticularPostion(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            Node temp = this.head;
            while (--position != 0)
            {
                if (position == 1)
                {
                    Node node = new Node(data);
                    node.next = temp.next;
                    temp.next = node;
                    break;
                }
                if (temp.next != null)
                    temp = temp.next;
                else
                    break;
            }
            if (position > 1)
            {
                Console.WriteLine("Position Out of Range");
            }
            return head;
        }

        internal Node RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
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
            Console.WriteLine("\n");
        }

    }
}
