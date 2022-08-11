﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class TestMax<T> where T : IComparable
    {
        public T[] value;
        public TestMax(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(params T[] values)
        {
            var sorted_values = values.OrderByDescending(c => c).ToArray();
            return sorted_values[0];
        }

        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

        public void printValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("maximum Value is " + max);
        }
    }
}
