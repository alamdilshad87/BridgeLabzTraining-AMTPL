using System;

class Greatest2Number
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if(num1> num2)
        {
            Console.WriteLine("The greatest number is: " + num1);
        }
        else
        {
            Console.WriteLine("The greatest number is: " + num2);
        }
    }
}