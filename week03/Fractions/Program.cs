using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // // Verify that the  fraction construction are working:
        // //1.  Create an instance of the Constructor with no parameter:
        // Fraction f1 = new Fraction();
        // // Display f1 by calling the display method for the contructors in the Fraction class:
        // f1.Display(); // Expected output 1/1


        // //2. Get top number from the user:
        // Console.Write("What is the top whole number? ");
        // int topNumber = int.Parse(Console.ReadLine());

        // // Create an instance of the Constructor with one parameter:
        // Fraction f2 = new Fraction(topNumber);
        // f2.Display(); // expected topNumber/1

        // //3. Get the top and bottom numbers for the user:
        // Console.Write("What is the top integer? ");
        // int topNum = int.Parse(Console.ReadLine());
        // Console.Write("What is the bottom integer? ");
        // int bottomNum = int.Parse(Console.ReadLine());

        // // Create an instance of the Constructor with one parameter:
        // Fraction f3 = new Fraction(topNum, bottomNum);
        // f3.Display(); // expected topNumber/1


        // 1.  Create an instance of the Constructor with no parameter:
        Fraction f1 = new Fraction();
        //Apply the Getter and Setter Methods:
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // 2. Create an instance of the Constructor with one parameter:
        Fraction f2 = new Fraction(5);
        //Apply the Getter and Setter Methods:
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // 3. Create an instance of the Constructor with two parameter:
        Fraction f3 = new Fraction(3, 4);
        //Apply the Getter and Setter Methods:
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // 3. Create an instance of the Constructor with two parameter:
        Fraction f4 = new Fraction(1, 3);
        //Apply the Getter and Setter Methods:
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}