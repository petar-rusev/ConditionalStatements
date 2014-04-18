using System;
using System.Linq;

class TheBiggestofFiveNum
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
        Console.WriteLine("Please enter third number.");
        string fourthnum = Console.ReadLine();
        float d;
        while (float.TryParse(fourthnum, out d) == false)
        {
            Console.WriteLine("Invalid Input!Please enter an integer signed or unsigned number");
            fourthnum = Console.ReadLine();

        }
        Console.WriteLine("Please enter third number.");
        string fifthnum = Console.ReadLine();
        float e;
        while (float.TryParse(fifthnum, out e) == false)
        {
            Console.WriteLine("Invalid Input!Please enter an integer signed or unsigned number");
            fourthnum = Console.ReadLine();

        }

        if (a > b & a > c & a > d&a>e)
        {
            Console.WriteLine("The biggest of the five numbers is {0}",a);
        }
        else if (b > a & b > c & b > d&b>e)
        {
            Console.WriteLine("The biggest of the five numbers is {0}",b);
        }
        else if (c > a & c > b & c > d&c>e)
        {
            Console.WriteLine("The biggest of the five numbers is {0}",c);
        }
        else if (d > a & d > b & d > c & d > e)
        {
            Console.WriteLine("The biggest of the five numbers is {0}",d);
        }
        else if (e > a & e > b & e > c & e > d)
        {
            Console.WriteLine("The biggest of the five numbers is {0}",e);
        }


    }
}

