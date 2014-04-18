using System;
using System.Linq;
class TheBiggestofThreeNum
{
    static void Main()
    {
        Console.WriteLine("Please enter first number.");
        string firstnum = Console.ReadLine();
        float a;
        while (float.TryParse(firstnum, out a) == false)
        {
            Console.WriteLine("Invalid Input!Please enter an integer signed or unsigned number");
            firstnum = Console.ReadLine();

        }
        Console.WriteLine("Please enter second number.");
        string secnum = Console.ReadLine();
        float b;
        while (float.TryParse(secnum, out b) == false)
        {
            Console.WriteLine("Invalid Input!Please enter an integer signed or unsigned number");
            secnum = Console.ReadLine();

        }
        Console.WriteLine("Please enter third number.");
        string thirdnum = Console.ReadLine();
        float c;
        while (float.TryParse(thirdnum, out c) == false)
        {
            Console.WriteLine("Invalid Input!Please enter an integer signed or unsigned number");
            thirdnum = Console.ReadLine();

        }

        float []numbers={a,b,c};
        float Max = numbers.Max();
        Console.WriteLine("The biggest number is {0}",Max);
    }
}

