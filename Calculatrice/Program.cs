// Calculator by Jibé

using System.Data;
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
                getMultipleInputs(numberToCalculate);
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
    
    private static string checkOperator(string operator1)
    {
        string op = "";
        switch (operator1)
        {
            case "1":
                op = "+";
                break;
            case "2":
                op = "-";
                break;
            case "3":
                op = "*";
                break;
            case "4":
                op = "/";
                break;
        }

        return op;
    }

    private static void getInput()
    {
        string calc = "";
        Console.WriteLine("Type your first number: ");
        string number1 = Console.ReadLine();
        checkIfNumberIsCorrect(number1);
        calc += number1;
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
        
        calc += " " + checkOperator(operator1) + " ";
        
        Console.WriteLine("Type your second number: ");
        string number2 = Console.ReadLine();
        checkIfNumberIsCorrect(number2);
        calc += number2;


        calculate(calc);
    }

    private static void getMultipleInputs(string numberToCalculate)
    {
        string number = "";
        for (int i = 0; i < Int32.Parse(numberToCalculate); i++)
        {
                Console.WriteLine($"Type your number n°{i + 1}:");
                string nb = Console.ReadLine();
                checkIfNumberIsCorrect(nb);
                number += nb;

                if (i == Int32.Parse(numberToCalculate) - 1) break;
                
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
                number += " " + checkOperator(operator1) + " ";
        }
        
        calculate(number);
    }



    private static void calculate(string calc)
    {
        Console.WriteLine("Your operation is: ");
        Console.WriteLine(calc);

        DataTable dt = new DataTable();
        Console.WriteLine($"The result is: {dt.Compute(calc, "")}");
        
        
        Console.WriteLine("Thank you for using the calculator!");
        Console.WriteLine("Press enter to restart...");
        Console.ReadLine();
        Run();
    }
}