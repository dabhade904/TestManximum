using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class TestMax
    {
        public int MaxVal(int firstNumber, int secondNumber, int thirdNumber)
        {
            int bigNo = firstNumber;
            if (bigNo > secondNumber)
            {
                bigNo = secondNumber;
            }
            else if (bigNo > thirdNumber)
            {
                bigNo = thirdNumber;
            }
            return bigNo;
        }

    }
}
