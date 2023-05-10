using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePractices
{
    public class GenericLinkedList<T>
    {
        public T var1 , var2;
        public GenericLinkedList(T var1, T var2)
        {
           this.var1 = var1;
           this.var2 = var2;
           Console.WriteLine(var1+" "+var2);
        }
        public void CustomLinkedList(T var1 , T var2)
        {
            Console.WriteLine(var1+" "+var2);
            LinkedList<int> linkedlist = new LinkedList<int>();
            linkedlist.AddFirst(121);
            linkedlist.AddFirst(131);
            linkedlist.AddLast(141);
            linkedlist.AddLast(151);
            foreach(var item in linkedlist)
            {
                Console.WriteLine("LinkedList :"+item);
            }
        }
    }
}
