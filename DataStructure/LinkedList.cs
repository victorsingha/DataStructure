using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkedList
    {
        internal Node head;

        internal void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        internal void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Empty Linked List");
                return;
            }
            while(temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
            Console.WriteLine("{0} inserted into linked list", newNode.data);
        }
        internal Node InsertAtParticularPosition(int position,int data)
        {
            if(position < 1)
            {
                Console.WriteLine("Position should not be less than 1.");
            }
            if(position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while(position-- != 0)
                {
                    if(position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if(position != 1)         
                    Console.WriteLine("Position out of range");               
            }
            return head;
        }
        internal Node RemoveFirstNode()
        {
            if(this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
    }
}
