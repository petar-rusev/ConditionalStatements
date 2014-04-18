using System;

class ExchangeIfGrater
{
    static void Main()
    {
        Console.WriteLine("Please enter number A.");
        string firstnum = Console.ReadLine();
        double a;
        while(double.TryParse(firstnum,out a)==false)
        {
            Console.WriteLine("Invalid Input! Please enter a number!");
            firstnum=Console.ReadLine();
        }

        string secnum = Console.ReadLine();
        double b;
        while (double.TryParse(secnum, out b) == false)
        {
            Console.WriteLine("Invalid Input! Please enter a number!");
            secnum = Console.ReadLine();
        }
        Console.WriteLine("{0},{1}",a,b);
        if (a > b)
        {
            double c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a = {0}\nb = {1}", a, b);
        }
        else
        {
            Console.WriteLine("a = {0}\nb = {1}",a,b);
        }
    }
}

