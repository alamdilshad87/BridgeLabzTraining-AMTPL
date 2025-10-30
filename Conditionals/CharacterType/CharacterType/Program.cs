using System;

class CharacterType
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char character = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (char.IsLetter(character))
        {
            Console.WriteLine($"{character} is a letter.");
        }
        else if (char.IsDigit(character))
        {
            Console.WriteLine($"{character} is a digit.");
        }
        else if (char.IsWhiteSpace(character))
        {
            Console.WriteLine($"{character} is a whitespace character.");
        }
        else
        {
            Console.WriteLine($"{character} is a special character.");
        }
    }
}