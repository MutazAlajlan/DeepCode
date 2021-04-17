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
                else
                {
                    result = 0 + result;
                }
            }
            return result;
        }
        static string IsOdd(uint value)
        {
            string result = null;
            //compares the last bit.
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
        static uint Pack(byte one, byte two, byte three, byte four)
        {
            uint[] uintArray = { one, two, three, four };
            uint value = 0;
            for (int index = 0; index < 4; index++)
            {
                value = (value << 8);
                value = (value | uintArray[index]);
                //shift 8 bits to the left for the other parts.
                //Console.WriteLine("Index is: "+ index + "   " + ConvertToBinary(value));

            }
            return value;
        }
        static void Main(string[] args)
        {
            //11101
            Console.WriteLine(ConvertToBinary(29));
            Console.WriteLine(IsOdd(27));

            //pack 4 bytes.
            const byte one = 5;
            const byte two = 8;
            const byte three = 201;
            const byte four = 25;
            Console.WriteLine(ConvertToBinary(Pack(one, two, three, four)));
            /*  The output should be:
             * 00000101  5 one
             * 00001000  8 two
             * 11001001  201 three
             * 00011001  25 four
             */
        }
    }
}
