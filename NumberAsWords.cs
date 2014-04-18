using System;

class NumbersToWords
{
    private static void NumTransformation(int num)
    {
        string[] NumOnes = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        string[] NumDec = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] NumDecTwo = { " ", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety", "Hundred" };

        int hund = num / 100;
        int decone = num % 100;
        int dec = decone / 10;
        int ones = decone % 10;

        if (num < 10)
        {
            switch (num)
            {
                case 0: Console.WriteLine(NumOnes[0]);
                    break;
                case 1: Console.WriteLine(NumOnes[1]);
                    break;
                case 2: Console.WriteLine(NumOnes[2]);
                    break;
                case 3: Console.WriteLine(NumOnes[3]);
                    break;
                case 4: Console.WriteLine(NumOnes[4]);
                    break;
                case 5: Console.WriteLine(NumOnes[5]);
                    break;
                case 6: Console.WriteLine(NumOnes[6]);
                    break;
                case 7: Console.WriteLine(NumOnes[7]);
                    break;
                case 8: Console.WriteLine(NumOnes[8]);
                    break;
                case 9: Console.WriteLine(NumOnes[9]);
                    break;

            }
        }
        int h = hund;
        int d = dec;
        int o = ones;

        if (h == 0 && o > 0 && o <= 9 && d > 0 && d <= 9)
        {
            Console.WriteLine("{0} {1}", NumDecTwo[d - 1], NumOnes[o]);
        }

        if (h >= 1 && h <= 9)
        {
            if (d == 0 && o == 0)
            {
                Console.WriteLine("{0} {1}", NumOnes[h], NumDecTwo[9]);
            }
        }
        if ((h >= 1 && h <= 9) && (d == 1 && o <= 9))
        {

            switch (o)
            {
                case 0: Console.WriteLine("{0} {1} {2}", NumOnes[h], NumDecTwo[9], NumDec[o]);
                    break;
                case 1: Console.WriteLine("{0} {1} {2}", NumOnes[h], NumDecTwo[9], NumDec[o]);
                    break;
                case 2: Console.WriteLine("{0} {1} {2}", NumOnes[h], NumDecTwo[9], NumDec[o]);
                    break;
                case 3: Console.WriteLine("{0} {1} {2}", NumOnes[h], NumDecTwo[9], NumDec[o]);
                    break;
                case 4: Console.WriteLine("{0} {1} {2}", NumOnes[h], NumDecTwo[9], NumDec[o]);
                    break;
                case 5: Console.WriteLine("{0} {1} {2}", NumOnes[h], NumDecTwo[9], NumDec[o]);
                    break;
                case 6: Console.WriteLine("{0} {1} {2}", NumOnes[h], NumDecTwo[9], NumDec[o]);
                    break;
                case 7: Console.WriteLine("{0} {1} {2}", NumOnes[h], NumDecTwo[9], NumDec[o]);
                    break;
                case 8: Console.WriteLine("{0} {1} {2}", NumOnes[h], NumDecTwo[9], NumDec[o]);
                    break;
                case 9: Console.WriteLine("{0} {1} {2}", NumOnes[h], NumDecTwo[9], NumDec[o]);
                    break;
            }

        }
        else if ((h >= 1 && h <= 9) && (d > 1 && o <= 9))
        {
            if (o == 0)
            {
                Console.WriteLine("{0} {1} {2}", NumOnes[h], NumDecTwo[9], NumDecTwo[d - 1]);
            }
            if (o != 0)
            {
                Console.WriteLine("{0} {1} and {2} {3}", NumOnes[h], NumDecTwo[9], NumDecTwo[d - 1], NumOnes[o]);
            }
        }
        else if ((h >= 1 && h <= 9) && (d == 0 && o <= 9))
        {
            Console.WriteLine("{0} {1} and {2}", NumOnes[h], NumDecTwo[9], NumOnes[o]);
        }
        if (num >= 1000)
        {
            Console.WriteLine("\n\nError!!!\nPlease Enter an integer number between 0 and 1000");
        }
    }
    static void Main()
    {
        
        Console.WriteLine("Please enter an integer number between 0-999");
        string input = Console.ReadLine();
        int num;
        while (int.TryParse(input, out num) == false)
        {
            Console.WriteLine("Invalid Input! Please enter an integer number between 0-999");
            input = Console.ReadLine();
        }
        NumTransformation(num);
 
    }
 
}


