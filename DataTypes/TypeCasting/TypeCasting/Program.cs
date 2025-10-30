using System;

namespace TypeCasting
{
    class Program
    {

        public static void Main(String[] args)
        {
            int i = 12;
            double d = 765.12;
            float f = 56.123F;

            Console.WriteLine(Convert.ToString(f));
            Console.WriteLine(Convert.ToInt32(d));
            Console.WriteLine(Convert.ToUInt32(f));
            Console.WriteLine(Convert.ToDouble(i));
        }
    }
}