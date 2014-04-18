using System;

class SortThreeNumbers
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
        if (a > b)
        {
            if (b > c)
            {
                Console.WriteLine("{0} {1} {2}",a,b,c);
            }
            else if (c > b)
            {
                Console.WriteLine("{0} {1} {2}",a,c,b);
            }
            else if (b == c)
            {
                Console.WriteLine("{0} {1} {2}",a,b,c);
            }
            else if (a == c)
            {
                Console.WriteLine("{0} {1} {2}",a,c,b);
            }
        }
        else if (a < b)
        {
            if (a > c)
            {
                Console.WriteLine("{0} {1} {2}",b,a,c);
            }
            else if (c > a)
            {
                Console.WriteLine("{0} {1} {2}",b,c,a);
            }
            else if (a == c)
            {
                Console.WriteLine("{0} {1} {2}",b,a,c);
            }
            else if (b == c)
            {
                Console.WriteLine("{0} {1} {2}",b,c,a);
            }
        }
        else if (a == b)
        {
            if (a > c)
            {
                Console.WriteLine("{0} {1} {2}",a,b,c);
            }
            else if (a < c)
            {
                Console.WriteLine("{0} {1} {2}",c,a,b);
            }
            else if (a == c)
            {
                Console.WriteLine("{0} {0} {0}",a);
            }
        }

    }
}

