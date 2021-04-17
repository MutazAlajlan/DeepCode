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
                    result = (value & 1) + result;
                    //shift value one place to the right.
                    value = value >> 1;
                }

            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write(ConvertToBinary(28));
        }
    }
}
