namespace Lab4;

using System;
class Car
{
    public string model;
    public string color;
    public int year;

    // Example method to display car details.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }
    // Problem 1: Add a Method with No Parameters
    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }
    // Problem 2: Add a Method with Parameters
    public void Drive(int miles)
    {
        Console.WriteLine($"The car drove {miles} miles.");
    }
    //Problem 3: Add a Method with a Return Value
    public string GetDescription()
    {
    return $"{year} {color} {model}";
    }
    // Problem 4: Add a Method that Updates a Field
    public void Repaint(string newColor)
    {
        color = newColor;
        Console.WriteLine($"The car has been repainted to {newColor}.");
    }
}


class Program
{
    static void Main()
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        myCar.Display(); // Calling the Display method

        myCar.Start();   // Problem 1: Call Start() method

        myCar.Drive(50);  // Problem 2: Call Drive(int miles) method

        string description = myCar.GetDescription(); // Problem 3: Call GetDescription() and store the result
        Console.WriteLine("Description: " + description);

        myCar.Repaint("red"); // Problem 4: Call Repaint(string newColor) method
        Console.WriteLine($"Updated color: {myCar.color}");

    }
}