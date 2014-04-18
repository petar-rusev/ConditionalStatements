using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Please enter first number.");
        string firstnum = Console.ReadLine();
        int a;
        while (int.TryParse(firstnum, out a) == false)
        {
            Console.WriteLine("Invalid Input!Please enter an integer signed or unsigned number");
            firstnum = Console.ReadLine();

        }
        Console.WriteLine("Please enter second number.");
        string secnum = Console.ReadLine();
        int b;
        while (int.TryParse(secnum, out b) == false)
        {
            Console.WriteLine("Invalid Input!Please enter an integer signed or unsigned number");
            secnum = Console.ReadLine();

        }
        Console.WriteLine("Please enter third number.");
        string thirdnum = Console.ReadLine();
        int c;
        while (int.TryParse(thirdnum, out c) == false)
        {
            Console.WriteLine("Invalid Input!Please enter an integer signed or unsigned number");
            thirdnum = Console.ReadLine();

        }
        int[] nums = {a,b,c};
        int count=0;
        char sig='+';
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0)
            {
                count++;
            }
        }
        if (count == 1 | count == 3)
        {
            sig = '-';
            Console.WriteLine("{0} {1} {2} {3}", a, b, c, sig);
        }
        else
        {
            Console.WriteLine("{0} {1} {2} {3}", a, b, c, sig);
        }

        
        
    }
}

