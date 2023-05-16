using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePractices
{
    public class CRUDStack
    {
        public void Operations()
        {
            Stack<int> stack = new Stack<int>();
            //Adding elements
            stack.Push(121);
            stack.Push(123);
            stack.Push(151);
            stack.Push(456);
            foreach (var item in stack)
            {
                Console.WriteLine("Added in stack:"+item);
            }
            //Deleting elements
            Console.WriteLine("Popped element:"+stack.Pop());
            Console.WriteLine("Peek element:"+stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine("Remaining items in stack:"+item);
            }
        }
    }
}
