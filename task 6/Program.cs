namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Enter a number as an input : ");
            string input = Console.ReadLine();

            try
            {
                int number = Convert.ToInt32(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number Format.");
            }
            finally
            {
                Console.WriteLine("Program Executed.");
            }


            Console.WriteLine("\n.....Another program ....");

            Console.Write("Enter a Password : ");
            string password = Console.ReadLine();

            try
            {
                if (password.Length < 6)
                {
                    throw new Exception("Pasword must be at least 6 characters.");
                }
                else
                {
                    Console.WriteLine("Password satisfied the reuirement.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
    }
}