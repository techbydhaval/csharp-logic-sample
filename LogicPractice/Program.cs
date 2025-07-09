using LogicPractice;
using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Logic Practice Program!\n");
        Console.WriteLine("1. Method Overloading Example");
        Console.WriteLine("2. Method Overriding Example");
        Console.WriteLine("3. Substring Example");
        Console.WriteLine("4. Method Extension Example");
        Console.WriteLine("5. Fibonacci Series Example");
        Console.WriteLine("6. Swapping Numbers Example");


        bool keepRunning = true;
        while (keepRunning)
        {
            Console.WriteLine("\nPlease enter the number corresponding to the example you want to run (1-6):");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    MethodOverloading();
                    break;
                case "2":
                    MethodOverRidding();
                    break;
                case "3":
                    Substring();
                    break;
                case "4":
                    MethodExtenston();
                    break;
                case "5":
                    FibonanciSeris();
                    break;
                case "6":
                    SwappingNumber();
                    break;
                case "q":
                    keepRunning = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }

        }
    }

    // Method Overloading Example
    static void MethodOverloading()
    {
        Console.WriteLine("-----------Method Overloading Example-----------\n");
        MethodOverloading methodOverloading = new MethodOverloading();
        Console.WriteLine(methodOverloading.Add(10, 20)); // Output: 30
        Console.WriteLine(methodOverloading.Add(10, 20, 30)); // Output: 60
        Console.WriteLine(methodOverloading.Add(10.5, 20.5)); // Output: 31
        Console.WriteLine(methodOverloading.Add(10.5, 20.5, 30.5)); // Output: 61.5

    }
    // Method Overriding Example
    static void MethodOverRidding()
    {
        Console.WriteLine("\n-----------Method Overriding Example ---------------\n");
        Animal myDog = new Dog();
        Animal myCat = new Cat();
        myDog.Speak(); // Dog barks
        myCat.Speak(); // Dog barks
    }
    // Substring Example
    static void Substring()
    {
        Console.WriteLine("\n-----------Substring Example -------------------\n");
        string strValue = "Hello";
        Console.WriteLine(strValue.Substring(0, 1)); // He
        Console.WriteLine(strValue.Substring(0, 2)); // Hel
        Console.WriteLine(strValue.Substring(0, 3)); // Hell
        Console.WriteLine(strValue.Substring(0, 4)); // Hello
    }
    // Method Extension Example
    static void MethodExtenston()
    {
        Console.WriteLine("\n-----------Method Extension Example ------------\n");
        string stringBB = "world";
        Console.WriteLine(stringBB.ToUpperFirstLetter()); // World
    }
    // FibonanciSeris Example
    static void FibonanciSeris()
    {
        Console.WriteLine("\n-----------FibonanciSeris Example --------------\n");
        int num = 10;
        FiboSeries series = new FiboSeries(); // Creating an instance of FiboSeries
        series.FibonacciSeries(num);
    }
    //Swapping number Example
    static void SwappingNumber()
    {
        Console.WriteLine("\n-----------Swapping Numbers Example ------------\n");
        Swapping swapping = new Swapping(); // Creating an instance of Swapping
        swapping.SwappingNumber(10, 20); // Swapping with third variable
        swapping.SwappingNumberWithoutUsingThirdVaribleAstricSign(10, 20); // Swapping without third variable using asterisk sign
        swapping.SwappingNumberWithourUsingThirdVariableButPlusSign(10, 20); // Swapping without third variable using plus sign
    }
}

