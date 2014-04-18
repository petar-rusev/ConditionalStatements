using System;

class DigitAsWord
{
    static void Main()
    {
        Console.WriteLine("Please enter a number in the diapazon(0-9).");
        string firstnum = Console.ReadLine();
        
        
        string check;
        string num;

        if (firstnum != "0" & firstnum != "1" & firstnum != "2" & firstnum != "3" & firstnum != "4" & firstnum != "5" & firstnum != "6" & firstnum != "7" & firstnum != "8" & firstnum != "9")
        {

            check = "not a digit";
            Console.WriteLine("{0}-{1}", firstnum, check);
        }
         
        switch (firstnum)
            {
            
            case "1":
                    Console.WriteLine("{0}-one",firstnum);
                    break;
            case "2":
                    Console.WriteLine("{0}-two",firstnum);
                    break;
            case "3":
                    Console.WriteLine("{0}-three",firstnum);
                    break;
            case "4":
                    Console.WriteLine("{0}-four",firstnum);
                    break;
            case "5":
                    Console.WriteLine("{0}-five",firstnum);
                    break;
            case "6":
                    Console.WriteLine("{0}-six",firstnum);
                    break;
            case "7":
                    Console.WriteLine("{0}-seven",firstnum);
                    break;
            case "8":
                    Console.WriteLine("{0}-eight",firstnum);
                    break;
            case "9":
                    Console.WriteLine("{0}-nine",firstnum);
                    break;
            case"0":
                    Console.WriteLine("{0}-zero",firstnum);
                    break;
            }
        
    }
}

