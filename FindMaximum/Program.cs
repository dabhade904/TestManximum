using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestMax obj = new TestMax();
            Console.WriteLine("welcome");
            int intVal = obj.MaxVal(10, 20, 30);
            Console.WriteLine("bigest number is :" + intVal);
        }
    }
}
