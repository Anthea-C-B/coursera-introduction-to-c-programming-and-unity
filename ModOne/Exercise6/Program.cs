namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first altitude: ");

            int promptDegree = int.Parse(Console.ReadLine());

            float degrees = (float)promptDegree;

            float radians = degrees * (float)(Math.PI / 180);

            Console.WriteLine("The cosine of the angle is: " + Math.Cos(radians));
            Console.WriteLine("The sine of the angle is: " + Math.Sin(radians));
        }
    }
}
