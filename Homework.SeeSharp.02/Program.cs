namespace Homework.SeeSharp._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Operation: ");
            string operation = Console.ReadLine();

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }

            Console.WriteLine($"The result is: {result}");

            Console.WriteLine("=======================================");

            Console.Write("Enter the First number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            double num5 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            double num6 = Convert.ToDouble(Console.ReadLine());

            double average = (num3 + num4 + num5 + num6) / 4;

            Console.WriteLine($"The average of {num3}, {num4}, {num5}, and {num6} is: {average}");

            Console.WriteLine("==============================================");


        }
    }
}
