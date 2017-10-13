using System;

public class Program
{
	public static void Main()
    {
        addNumbers();
        //yardToInches();

        bool people = true;
        bool f = false;
        decimal num = 10.0m;
        decimal nn = num * num;
        //Console.WriteLine(nn);

        string firstName;
        string lastName;
        int age;
        string job;
        string favoriteBand;
        string favoriteSportsTeam;

        Console.ReadLine();
    }

    private static void yardToInches()
    {
        Console.WriteLine("Please enter value in yards.");
        int val = int.Parse(Console.ReadLine());
        int valInches = val * 36;
        Console.WriteLine("The same length in inches is "+valInches+".");
        
    }
    private static void addNumbers()
    {
        //Ask for first number
        Console.WriteLine("Please enter the first number : ");

        //save the number
        int firstNumber;
        if (!int.TryParse(Console.ReadLine(), out firstNumber))
        {
            showNumberWarning();
            firstNumber = 0;
        }


        //save the second number
        Console.WriteLine("Please enter the second number : ");

        //save it
        int secondNumber;
        if (!int.TryParse(Console.ReadLine(), out secondNumber))
        {
            showNumberWarning();
            secondNumber = 0;
        }

        //add 
        int sum = firstNumber + secondNumber;

        //show
        Console.WriteLine("The result is " + sum);
    }

    private static void showNumberWarning()
    {
        Console.WriteLine("You were supposed enter a number!\nA number!!");
    }
}
