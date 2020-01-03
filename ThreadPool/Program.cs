using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AdvancedTasks
{
    public static class Program7
    {
        public static int counter;
         public static void Main()
         {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool right here...");
            });
            Console.WriteLine("Press any key to exit!");
            Console.ReadLine();
         }
    }
}
