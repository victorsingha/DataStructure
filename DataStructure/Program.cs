using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(34);
            list.Add(40);
            list.Add(78);
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.AddInReverseOrder(99);
            list.AddInReverseOrder(999);
            list.InsertAtParticularPosition(2, 000);
            list.RemoveFirstNode();
            list.RemoveLastNode();
            list.Search(000);
            list.Display();

            Console.ReadKey();
        }
    }
}
