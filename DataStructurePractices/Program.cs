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
            Console.WriteLine("1.Generic LinkedList");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    GenericLinkedList<int> genericLinkedList = new GenericLinkedList<int>(45,55);
                    GenericLinkedList<string> genericLinkedList1 = new GenericLinkedList<string>("Raj", "Neha");
                    GenericLinkedList<double> generic = new GenericLinkedList<double>(45.5, 12.8);
                    genericLinkedList.CustomLinkedList(88,65);
                    break;
            }
            Console.ReadLine();
        }
    }
}
