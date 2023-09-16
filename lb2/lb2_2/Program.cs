namespace lb2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the x coordinate of the point:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the y coordinate of the point:");
            int y = int.Parse(Console.ReadLine());

            double distance = Math.Sqrt(x * x + y * y);

            if (distance > 3 && distance < 7)
            {
                Console.WriteLine("Yes");
            }
            else if (distance < 3 || distance > 7)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("On the border");
            }

        }
    }
}