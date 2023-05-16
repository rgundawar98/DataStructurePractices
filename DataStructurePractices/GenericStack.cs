using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePractices
{
    public class GenericStack<T>
    {
        T value3, value4;
        public GenericStack(T value3 , T value4)
        {
            this.value3 = value3;
            this.value4 = value4;
            Console.WriteLine(value3+" "+value4);
        }
        public void GenericStackMethod(T value1, T value2)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(121);
            stack.Push(122);
            stack.Push(123);
            foreach (var item in stack)
            {
                Console.WriteLine("Added in stack:"+item);
            }
        }
    }
}
