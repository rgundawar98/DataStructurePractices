using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePractices
{
    public class GenericQueue<T>
    {
        T var1, var2;
        public GenericQueue(T var1 ,T var2)
        {
            this.var1 = var1;
            this.var2 = var2;
            Console.WriteLine(var1 +" "+var2);
        }
        public void GenricQueueMethod(T value1 , T value2)
        {
            Queue<T> queue = new Queue<T>();
            queue.Enqueue(value1);
            queue.Enqueue(value2);
            Console.WriteLine(value1 +" "+ value2);
        }
    }
}
