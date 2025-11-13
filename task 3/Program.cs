namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Enter your age: ");
            string age_input = Console.ReadLine();

            int age = Convert.ToInt32(age_input);

            if (age < 13)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 13 && age < 20)
            {
                Console.WriteLine("Teenager");
            }
            else
            {
                Console.WriteLine("Adult");
            }
        }
    }
}