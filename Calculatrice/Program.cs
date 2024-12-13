// Calculator by Jibé

public class Calculator
{
    public static void Main()
    {
        bool running = true;
        string option = startApplication();
        
        while (running)
        {
            switch (option)
            {
                case "begin":
                    option = startApplication();
                    break;
                case "exit":
                    running = false;
                    break;
                case "help":
                    Console.WriteLine("Calculator made by Jibé");
                    Console.WriteLine("Made to learn more about C#");
                    Console.WriteLine("You can find the whole code on github :");
                    Console.WriteLine("https://github.com/BaptisteFran/csharp_calculator");
                    break;
                case "start":
                    Console.WriteLine("Starting calculator");
                    getInput();
                    break;
                case "multiple":
                    Console.WriteLine("Starting multiple calculators");
                    Console.WriteLine("Choose how many numbers you want to add in your calculation :");
                    string numberToCalculate = Console.ReadLine();
                    try
                    {
                        getMultipleInputs(Int32.Parse(numberToCalculate));
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid integer");
                        option = "begin";
                    }
                    break;
            }
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

    private static void getInput()
    {
        Console.WriteLine("Type your first number: ");
        string number1 = Console.ReadLine();
        Console.WriteLine("Choose an operator:");
        Console.WriteLine("1 - Addition");
        Console.WriteLine("2 - Subtraction");
        Console.WriteLine("3 - Multiplication");
        Console.WriteLine("4 - Division");
        string operator1 = Console.ReadLine();
        string number2 = Console.ReadLine();
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
    }
}