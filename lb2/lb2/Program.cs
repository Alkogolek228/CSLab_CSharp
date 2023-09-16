namespace lb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a < 10 || a > 99)
            {
                Console.WriteLine("Error! Enter 2-digit number");
                a = Convert.ToInt32(Console.ReadLine());
            }

            if(a / 10 > a % 10)
            {
                Console.WriteLine("1 num is greater");
            }

            else if (a / 10 < a % 10)
            {
                Console.WriteLine("2 num is greater");
            }

            else
            {
                Console.WriteLine("nums are equal");
            }
        }
    }
}