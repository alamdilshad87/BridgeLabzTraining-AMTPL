using System;

namespace SampleCode
{
    class ImplicitConversion
    {
        static void Main(string[] args)
        {
            int num = 100;
            double convertedNum = num; //

            Console.WriteLine("Original Integer: " + num);
            Console.WriteLine("After Implicit Conversion to Double: " + convertedNum);
        }
    }
}
