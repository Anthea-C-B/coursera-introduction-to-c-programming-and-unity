namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");

            // prompt for user input and read the input as integer

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Loading game ...");

            switch(choice)
            {
                case 1:
                    Console.WriteLine("New Game Selected");
                    break;
                case 2:
                    Console.WriteLine("Load Game Selected");
                    break;
                case 3:
                    Console.WriteLine("Options Selected");
                    break;
                case 4:
                    Console.WriteLine("Quit Selected");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
