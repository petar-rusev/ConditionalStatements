using System;

class CheckForPlayCard
{
    static void Main()
    {
        
        Console.WriteLine("Please enter a char.");
        string sign=Console.ReadLine();
        if (sign != "A" & sign != "2" & sign != "3" & sign != "4" & sign != "5" & sign != "6" & sign != "7" & sign != "8" & sign != "9" & sign != "10")
        {
            Console.WriteLine("{0}-No",sign);
        }
        switch (sign)
        {
            case "A":
                Console.WriteLine("{0}-yes",sign);
                break;
            case "2":
               Console.WriteLine("{0}-yes",sign);
               break;
            case "3":
               Console.WriteLine("{0}-yes",sign);
               break;
            case "4":
               Console.WriteLine("{0}-yes", sign);
               break;
            case "5":
               Console.WriteLine("{0}-yes", sign);
               break;
            case "6":
               Console.WriteLine("{0}-yes", sign);
               break;
            case "7":
               Console.WriteLine("{0}-yes", sign);
               break;
            case "8":
               Console.WriteLine("{0}-yes", sign);
               break;
            case "9":
               Console.WriteLine("{0}-yes", sign);
               break;
            case "10":
               Console.WriteLine("{0}-yes", sign);
               break;
        }
        
        
    }
}

