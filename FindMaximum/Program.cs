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
            int [] intArray = { 112, 456, 2443, 557, 8, 345 };
            TestMax<int> genric = new TestMax<int>(intArray);
            genric.printValue();

            double[] doubleArray = { 12.00f, 45.6f, 24.43f, 5.0f, 8f, 3.0f };
            TestMax<double> doubleGenric = new TestMax<double>(doubleArray);
            doubleGenric.printValue();

            string[] stringArray = { "123", "34", "33", "43", "2", "111" };
            TestMax<string> stringGeneric = new TestMax<string>(stringArray);
            stringGeneric.printValue();
        }

    }
}
