using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please enter a string.");
        string input=Console.ReadLine();
        int check=0;
        double InputDouble;
        int InputInteger;
        string InputString;

        bool isDouble = Double.TryParse(input, out InputDouble);
        bool isInteger = int.TryParse(input, out InputInteger);

        if (isDouble)
        {
            check = 1;
        }
        else if (isInteger)
        {
            check = 2;
        }
        else
        {
            check = 3;
        }

        switch (check)
        {
            case 1: Console.WriteLine("{0}",InputDouble+1);
                break;
            case 2: Console.WriteLine("{0}",InputInteger+1);
                break;
            case 3: Console.WriteLine("{0}*",input);
                break;
        }
        
    }
}

