namespace Lab5;

public class Animal //Step 1 – Create a Base Class Named Animal
{
    public virtual void animalSound() //Virual method allows overriding in drived classes
    {
        Console.WriteLine("The animal makes a sound");
    }
}

public class Cat : Animal //Step 2 – Create Derived Classes. This is for Cat
{
    public override void animalSound() //Override the animalSound method
    {
        Console.WriteLine("The cat says: meow");
    }
}

public class Dog : Animal // Created Derived Class Dog
{
    public override void animalSound() //Override the animalSound method
    {
        Console.WriteLine("The dog says: bow wow");
    }

}

public class Program //Step 3 – Test in Main()
{
    public static void Main()
    {
        //Create one object each of Animal, Cat and Dog using Animal as reference type to demonstrate polymorphism
        Animal myAnimal = new Animal();     //Base class object
        Animal myCat = new Cat();           //Derived class cat using Animal reference
        Animal myDog = new Dog();           //Derived class Dog using Animal reference

        //Call the animalSound() method on each object
        Console.WriteLine("Animal Sounds"); //Output: Animal Sounds
        myAnimal.animalSound();             //Output: The animal makes a sound
        myCat.animalSound();                //Output: The cat says: meow
        myDog.animalSound();                //Output: The dog says: bow wow
    }
}