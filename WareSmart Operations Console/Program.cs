using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareSmart_Operations_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
                PickingTask picking1 = new PickingTask(
                    1,
                    10,
                    5,
                    7,
                    2);

                RecievingTask receiving1 = new RecievingTask(
                    2,
                    6,
                    12,
                    4,
                    5);

                RestockingTask restocking1 = new RestockingTask(
                    3,
                    8,
                    3,
                    9,
                    4);
            Console.WriteLine("Picking Task Priority: " + picking1.CalculatePriority());
            Console.WriteLine("Receiving Task Priority: " + receiving1.CalculatePriority());
            Console.WriteLine("Restocking Task Priority: " + restocking1.CalculatePriority());
        }
    }
}
