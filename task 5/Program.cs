namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Enter a number: ");
            string number_input = Console.ReadLine();
            int n = Convert.ToInt32(number_input);
            int sum = 0;

            // for-loop
            for (int i = 1; i <= n; i++)
            {
                sum += i;

            }
            Console.WriteLine($"The sum of the first {n} natural numbers is: {sum}");


            // while-loop
            int value = 1;
            while (value <= 20)
            {
                // skipping multiples of 4
                if (value % 4 == 0)
                {
                    value++;  // IMPORTANT: Increment before continue other wise it skips all the below code and it got freeze.
                    continue;
                }
                if (value == 15)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{value}");
                }

                value++;
            }


            // for-each loop

            int[] num_arr = { 2, 4, 6, 8, 10 }; // total 30
            int arr_sum = 0;

            foreach (int num in num_arr)
            {
                arr_sum += num;
            }
            Console.WriteLine($"Sum of all elements which is in an array is : {arr_sum}");
        }
    }
}