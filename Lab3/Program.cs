namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1: Simple For Loop

        Console.WriteLine("\nAnswer 1: ");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Problem 2: Even Numbers from 1 to 20 (Using Modulus Operator)

        Console.WriteLine("\nAnswer 2: ");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        //Problem 3: While Loop Countdown

        Console.WriteLine("\nAnswer 3: ");
        int countdown = 5;
        while (countdown >= 1)
        {
            Console.WriteLine(countdown);
            countdown--;
        }

        //Problem 4: While Loop – Multiples of 10 from 10 to 1000

        Console.WriteLine("\nAnswer 4: ");
        int multiples = 10;
        while (multiples <= 1000)
        {
            Console.WriteLine(multiples);
            multiples += 10;
        }

        //Problem 5: Seasons of the Year

        Console.WriteLine("\nAnswer 5: ");
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }

        //Problem 6: Days of the Week (1–7)

        Console.WriteLine("\nAnswer 6: ");
        string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        Console.Write("Enter a number from 1 to 7: ");
        string input = Console.ReadLine();

        int dayOfTheWeekNumber;
        if (int.TryParse(input, out dayOfTheWeekNumber) && dayOfTheWeekNumber >= 1 && dayOfTheWeekNumber <= 7)
        {
            Console.WriteLine("Day : " + daysOfTheWeek[dayOfTheWeekNumber - 1]);
        }
        else
        {
            Console.WriteLine("Invalid input, Please enter a number from 1 to 7.");
        }

        //Problem 7: Favorite Books and Authors

        Console.WriteLine("\nAnswer 7: ");
        string[] favoriteBooks = { "Rich Dad, Poor Dad ", "Without A Silver Spoon ", "Richest Man in Babylon" };
        string[] favoriteBooksAuthors = { "Robert Kiyosaki & Sharon Lechter", "Eddie Iroh", "George Samuel Clason" };
        for (int i = 0; i < favoriteBooks.Length; i++)
        {
            Console.WriteLine(favoriteBooks[i] + "by " + favoriteBooksAuthors[i]);
        }

        //Problem 8: Temperature Tracker

        Console.WriteLine("\nAnswer 8: ");
        int[] temps = { 32, 50, 62, 70, 82 };
        Array.Sort(temps);
        Console.WriteLine("Temperatures in ascending order: ");

        foreach (int temp in temps)
        {
            Console.WriteLine(temp);
        }
        Console.WriteLine("Lowest Temperature: " + temps[0]);
        Console.WriteLine("Highest Temperature: " + temps[temps.Length - 1]);

        //Problem 9: Reverse Countdown

        Console.WriteLine("\nAnswer 9: ");
        int[] values = { 5, 4, 3, 2, 1 };
        Array.Reverse(values);

        for (int i = 0; i < values.Length; i++)
        {
            Console.WriteLine(values[i]);
        }



    }

}
