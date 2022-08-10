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

            float res = obj.floatMax(10.00f, 2.0f, 9.0f);
            Console.WriteLine("float value " + res);
        }
    }
}
