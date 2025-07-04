namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Use Comments
        /* Name: [Afolabi Adelakun]
           Title: [IT-1050 - Lab 1]
           */

        // Step 2: Basic Output

        Console.WriteLine("Afolabi Adelakun");
        Console.WriteLine("IT-1050 - Lab 1");

        // Step 3: Declare and Use Variables

        int favoriteNumber = 4;
        string favoriteLanguage = "python";
        double programsWritten = 2.5;
        bool programminngExperience = true;

        Console.WriteLine("My favorite number is " + favoriteNumber + ".");
        Console.WriteLine("My favorite programming language is " + favoriteLanguage + ".");
        Console.WriteLine("The number of programs I have written before this " + programsWritten + ".");
        Console.WriteLine("Do I have programming experience? " + programminngExperience + ".");

        // Step 4: Use Constants

        const string schoolName = " Cuyahoga Community College ";
        Console.WriteLine("My School's name is" + schoolName + ".");

        // Step 5: Type Casting

        double doubleValue = 9.78;
        int CastToInt = (int)doubleValue;

        string intToString = Convert.ToString(favoriteNumber);
        string boolToString = Convert.ToString(programminngExperience);

        Console.WriteLine("Original double value " + doubleValue + ".");
        Console.WriteLine("Explicit casting original double value to Int " + CastToInt + ".");
        Console.WriteLine("Converting Int to String " + intToString + ".");
        Console.WriteLine("Converting Bool to String " + boolToString + ".");

        // Step 6: User Input and Type Conversion

        Console.Write("Please input your name: ");
        string userName = Console.ReadLine();

        Console.Write("Please input your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello, Nice to meet you " + userName + ", you are " + userAge + " years old, thank you!");

        // Step 7: Arithmetic Operators

        int num1 = 2;
        int num2 = 4;

        int additions1 = num1 + 10;
        int additions2 = num2 + 10;
        int subtraction1 = num1 - 2;
        int subtraction2 = num2 - 2;
        int multiplication1 = num1 * 3;
        int multiplication2 = num2 * 3;
        int division1 = num1 / 2;
        int division2 = num2 / 2;
        int modulus1 = num1 % 2;
        int modulus2 = num2 % 2;

        Console.WriteLine("Addition, add 10 to num1 = " + additions1);
        Console.WriteLine("Addition, add 10 to num2 = " + additions2);
        Console.WriteLine("Subtraction, subtract 2 from num1 = " + subtraction1);
        Console.WriteLine("Subtraction, subtract 2 from num2 = " + subtraction2);
        Console.WriteLine("Multiplication, multiply 3 times num1 = " + multiplication1);
        Console.WriteLine("Multiplication, multiply 3 times num2 = " + multiplication2);
        Console.WriteLine("Division, divide num1 by 2 = " + division1);
        Console.WriteLine("Division, divide num2 by 2 = " + division2);
        Console.WriteLine("Modulus, modulus num1 by 2 = " + modulus1);
        Console.WriteLine("Modulus, modulus num2 by 2 = " + modulus2);

        // Step 8: Floating Point Precision

        float floatInput = 1.123456789f;
        double doubleInput = 1.123456789;

        Console.WriteLine("Float Value: " + floatInput); // The float input is rounded up to 1.1234568, which is only about 7 digits of precision and without f at the end you would get an error message.
        Console.WriteLine("Double Value: " + doubleInput); // The double input displays the full 1.123456789, showing it can store more precise numbers, from review 15-16 digits.

        //Step 9: Increment and Decrement

        int intValue = 10;
        
        Console.WriteLine("Initial Value " +intValue);

        intValue++;
        Console.WriteLine("After increment (++): " + intValue);

        intValue--;
        Console.WriteLine("After decrement (--): " + intValue);






    
    } 
}
