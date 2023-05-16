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
            Console.WriteLine("1.Generic LinkedList\n2.Generic Stack\n4.CRUD Operation LinkedList");
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
                case 4:
                    CRUDLinkedList linkedList = new CRUDLinkedList();
                    linkedList.Operations();
                    break;

            }
            Console.ReadLine();
        }
    }
}
