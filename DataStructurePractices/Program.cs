using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePractices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Data Structure");
            Console.WriteLine("Choose the following");
            Console.WriteLine("1.Generic LinkedList\n2.Generic Stack\n3.Generic Queue\n4.CRUD Operation LinkedList\n5.CRUD" +
                " Operation Stack\n6.CRUD Operation Queue");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    GenericLinkedList<int> genericLinkedList = new GenericLinkedList<int>(45,55);
                    GenericLinkedList<string> genericLinkedList1 = new GenericLinkedList<string>("Raj", "Neha");
                    GenericLinkedList<double> generic = new GenericLinkedList<double>(45.5, 12.8);
                    genericLinkedList.CustomLinkedList(88,65);
                    break;
                case 2:
                    GenericStack<int> genericStack = new GenericStack<int>(45,88);
                    genericStack.GenericStackMethod(45, 54);
                    GenericStack<double> genericStack1 = new GenericStack<double>(44.1,11.8);
                    GenericStack<string> genericStack2 = new GenericStack<string>("Rash","Kiran");
                    break;
                case 3:
                    GenericQueue<int> genericQueue = new GenericQueue<int>(455,456);
                    genericQueue.GenricQueueMethod(141, 151);
                    GenericQueue<double> genericQueue1 = new GenericQueue<double>(44.8, 88.9);
                    GenericQueue<string> genericQueue2 = new GenericQueue<string>("first", "last");
                    break;
                case 4:
                    CRUDLinkedList linkedList = new CRUDLinkedList();
                    linkedList.Operations();
                    break;
                case 5:
                    CRUDStack stack = new CRUDStack();
                    stack.Operations();
                    break;
                case 6:
                    CRUDQueue queue = new CRUDQueue();
                    queue.Opearations();
                    break;
            }
            Console.ReadLine();
        }
    }
}
