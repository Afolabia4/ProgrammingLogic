namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Operator Practice

        int a = 10;
        int b = 5;
        int c = 15;

        bool isAGreaterThanB = a > b;
        bool isALessThanC = a < c;
        bool isAGreaterThanBothBandC = a > b && a > c;
        bool combinedWithAnd = (a > b) && (a < c);
        bool combinedWithOr = (a > b) || (a < c);

        Console.WriteLine("a > b: " + isAGreaterThanB);
        Console.WriteLine("a < c: " + isALessThanC);
        Console.WriteLine("a > b && a > c: " + isAGreaterThanBothBandC);
        Console.WriteLine("a > b && a < c: " + combinedWithAnd);
        Console.WriteLine("a > b || a < c: " + combinedWithOr);

        // Part 2: Boolean Logic

        bool isRaining = true;
        bool haveUmbrella = false;

        if (isRaining && !haveUmbrella)
        {
            Console.WriteLine("Take an Umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");
        }

        // Part 3: Conditional Logic – Movie Ticket Pricing

        Console.Write("Please input your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 5)
        {
            Console.WriteLine("Ticket is free!");
        }
        else if (age >= 5 && age <= 12)
        {
            Console.WriteLine("Child ticket : $5");
        }
        else if (age >= 13 && age <= 64)
        {
            Console.WriteLine("Standard ticket : $10");
        }
        else
        {
            Console.WriteLine("Senior ticket : $6");
        }

        // Part 4: Using a switch Statement

        Console.Write("Please input the day of the week (1-7): ");
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid Day!");
                break;
        }

    }
}
