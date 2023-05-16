using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePractices
{
    public class CRUDQueue
    {
        public void Opearations()
        {
            Queue<int> queue = new Queue<int>();
            //Adding
            queue.Enqueue(125);
            queue.Enqueue(521);
            queue.Enqueue(879);
            queue.Enqueue(100);
            foreach (var item in queue)
            {
                Console.WriteLine("Added in Queue:"+item);
            }
            //Deleting
            Console.WriteLine("Deleted element:"+queue.Dequeue());
            Console.WriteLine("Peek element:"+queue.Peek());
            foreach(var item in queue)
            {
                Console.WriteLine("Remmaining elements in Queue:"+item);
            }
        }
    }
}
