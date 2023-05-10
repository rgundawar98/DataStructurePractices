using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePractices
{
    public class CRUDLinkedList
    {
        public void Operations()
        {
            LinkedList<string> linkedlist = new LinkedList<string>();
            //Create
            linkedlist.AddFirst("Neha");
            linkedlist.AddFirst("Shreeya");
            linkedlist.AddFirst("Rahul");
            linkedlist.AddFirst("Rajesh");
            linkedlist.AddLast("Riya");
            linkedlist.AddLast("Siva");
            //Update
            linkedlist.AddAfter(linkedlist.AddFirst("Shreeya"),"Rohan");
            linkedlist.AddAfter(linkedlist.AddFirst("Rajesh"), "Reena");
            linkedlist.AddBefore(linkedlist.AddLast("Siva"), "Pooja");
            Console.WriteLine("Contains in or not:"+linkedlist.Contains("Shreeya"));
            Console.WriteLine("Count will be:"+linkedlist.Count());
            foreach (string item in linkedlist)
            {
                Console.WriteLine("LinkedList will be:"+item);
            }
            //Delete
            linkedlist.Clear();
        }
    }
}
