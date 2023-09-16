namespace _253505_Alkhovik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = a / b;

            Console.WriteLine("Result: " + c);

        }
    }
}