using System;

namespace DeepCodeBitWise
{
    class Program
    {
        static string ConvertToBinary(uint value)
        {
            string result = null;
            for (int i = 32; i > 0; i--)
            {
                if (value > 0)
                {
                    //appends most significant bit to leftmost
                    result = (value & 1) + result;
                    //shift value one place to the right.
                    value = value >> 1;
                }

            }
            return result;
        }
        static string IsOdd(uint value)
        {
            string result = null;
            if ((value & 1) == 1)
            {
                result = "It's odd.";
            }
            else
            {
                result = "It's even.";
            }
            return result;
        }
        static void Main(string[] args)
        {
            //11101
            Console.WriteLine(ConvertToBinary(29));
            Console.WriteLine(IsOdd(28));
        }
    }
}
