// Calculator by Jibé

using System.Globalization;

public class Calculator
{
    
    public static void Main()
    {
        Run();
    }

    private static void Run()
    {
        string option = startApplication();
        
        switch (option)
        {
            case "exit":
                Environment.Exit(0);
                break;
            case "about":
                Console.WriteLine("Calculator made by Jibé");
                Console.WriteLine("Made to learn more about C#");
                Console.WriteLine("You can find the whole code on github :");
                Console.WriteLine("https://github.com/BaptisteFran/calculator");
                Run();
                break;
            case "start":
                Console.WriteLine("Starting calculator");
                getInput();
                Run();
                break;
            case "multiple":
                Console.WriteLine("Starting multiple calculators");
                Console.WriteLine("Choose how many numbers you want to add in your calculation :");
                string numberToCalculate = Console.ReadLine();
                checkIfNumberIsCorrect(numberToCalculate);
                Run();
                break;
        }
    }

    private static string startApplication()
    {
        Console.WriteLine("Welcome to the calculator!");
        Console.WriteLine("Type 'exit' to exit.");
        Console.WriteLine("Type 'about' to get infos about this little program.");
        Console.WriteLine("Type 'start' to start an operation.");
        Console.WriteLine("Type 'multiple' to use multiple operations.");
        return Console.ReadLine();
    }
    
    private static void checkIfNumberIsCorrect(string number)
    {
        try
        {
            Int32.Parse(number);
        }
        catch
        {
            Console.WriteLine("Please enter a valid integer");
            Run();
        }
    }

    private static void getInput()
    {
        Console.WriteLine("Type your first number: ");
        string number1 = Console.ReadLine();
        checkIfNumberIsCorrect(number1);
        Console.WriteLine("Choose an operator:");
        Console.WriteLine("1 - Addition");
        Console.WriteLine("2 - Subtraction");
        Console.WriteLine("3 - Multiplication");
        Console.WriteLine("4 - Division");
        string operator1 = Console.ReadLine();
        string[] operatorArray = ["1", "2", "3", "4"];

        if (!operatorArray.Contains(operator1))
        {
            Console.WriteLine("Please enter a valid operator");
            operator1 = Console.ReadLine();
        }
        
        Console.WriteLine("Type your second number: ");
        string number2 = Console.ReadLine();
        checkIfNumberIsCorrect(number2);
        string[] calc = [number1, number2, operator1]; 

        calculate(calc);
    }

    private static void getMultipleInputs(int numberToCalculate)
    {
        
    }

    private static void calculate(string[] calc)
    {
        Console.WriteLine("Your operation is: ");
        Console.WriteLine(calc[0] + calc[2] + calc[1]);
        switch (calc[2])
        {
            case "1":
                Console.WriteLine($"The result is {Int32.Parse(calc[0]) + Int32.Parse(calc[1])}");
                break;
            case "2":
                Console.WriteLine($"The result is {Int32.Parse(calc[0]) - Int32.Parse(calc[1])}");
                break;
            case "3":
                Console.WriteLine($"The result is {Int32.Parse(calc[0]) * Int32.Parse(calc[1])}");
                break;
            case "4":
                Console.WriteLine($"The result is {Int32.Parse(calc[0]) / Int32.Parse(calc[1])}");
                break;
        }
        
        Console.WriteLine("Thank you for using the calculator!");
        Console.WriteLine("Press any key to restart...");
        Console.ReadLine();
    }
}