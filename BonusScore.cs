using System;

class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Please enter your score.");
        string num = Console.ReadLine();
        int score;
        while (int.TryParse(num, out score) == false)
        {
            Console.WriteLine("Invalid Input! Please enter an integer number.");
            num = Console.ReadLine();
        }
        int bonus=0;
        if (score >= 1 & score <= 3)
        {
            bonus = score * 10;
            Console.WriteLine("Score: {0} Bonus: {1}", score, bonus);
        }
        else if (score >= 4 & score <= 6)
        {
            bonus = score * 100;
            Console.WriteLine("Score: {0} Bonus: {1}", score, bonus);
        }
        else if (score >= 7 & score <= 9)
        {
            bonus = score * 1000;
            Console.WriteLine("Score: {0} Bonus: {1}", score, bonus);
        }
        else if (score == 0|score>9)
        {
            Console.WriteLine("Score: {0} Bonus: Invalid Score!",score);
        }
        
    }
}

