using System;

namespace ExplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 12345.67;
            int roundedSalary = (int)salary;  

            Console.WriteLine("Original salary (double): " + salary);
            Console.WriteLine("Converted salary (int): " + roundedSalary);

            float marks = 89.75f;
            int intMarks = (int)marks;

            Console.WriteLine("Marks (float): " + marks);
            Console.WriteLine("Marks after conversion (int): " + intMarks);
        }
    }
}
