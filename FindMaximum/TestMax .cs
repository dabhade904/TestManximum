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

        public float floatMax(float firstNumber, float secondNumber, float thirdNumber)
        {
            float longest = firstNumber;
            if (secondNumber > longest)
            {
                longest = secondNumber;
            }
            else if (thirdNumber > longest)
            {
                longest = thirdNumber;
            }
            return longest;
        }

        public string GetMaxString(string first, string second, string third)
        {
            string str = first;
            if (second.Length > str.Length)
            {
                 str=second;
            }
            else if(third.Length>str.Length)
            {
                str = third;
            }
            return str;
        }
    }
}
