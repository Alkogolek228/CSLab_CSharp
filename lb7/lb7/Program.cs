namespace lb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1, 2, 3);
            Vector v2 = new Vector(4, 5, 6);
            Vector v3 = new Vector();
            Console.WriteLine($"v1 = {v1}");
            Console.WriteLine($"v2 = {v2}");
            Console.WriteLine($"v3 = {v3}");

            v3.A = 7;
            Console.WriteLine($"v3 = {v3}");
            Console.WriteLine(v3.ToString());

            Console.WriteLine($"v1 + v2 = {v1 + v2}");
            Console.WriteLine($"v1 - v2 = {v1 - v2}");
            Console.WriteLine($"v1 * 2 = {v1 * 2}");
            Console.WriteLine($"v2 / 2 = {v2 / 2}");

            Console.WriteLine($"v1 == v2: {v1 == v2}");
            Console.WriteLine($"v1 != v2: {v1 != v2}");
            Console.WriteLine($"v1 < v2: {v1 < v2}");
            Console.WriteLine($"v1 > v2: {v1 > v2}");

            Console.WriteLine($"v1++ = {v1++}");
            Console.WriteLine($"++v1 = {++v1}");
            Console.WriteLine($"v2-- = {v2--}");
            Console.WriteLine($"--v2 = {--v2}");

            Console.WriteLine($"v3 is bool: {v3 is bool}");
            Console.WriteLine($"v3 is int: {v3 is int}");
            Console.WriteLine($"(int)v1 = {(int)v1}");

            Vector v4 = (Vector)5;
            Console.WriteLine($"v4 = {v4}");
        }
    }
}