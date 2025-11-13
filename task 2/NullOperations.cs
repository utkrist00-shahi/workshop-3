using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class NullOperations
    {
        public static void PerformNullCheck()
        {

            string username = null;
            string value1 = (username == null ? "Username is not available" : $"Username is {username}");
            Console.WriteLine(value1);


            string value2 = username ?? "Username is not available"; 
            

            username ??= "DefaultUser"; 
            Console.WriteLine($"After Null-coalescing assignment operator Username is {username}");
        }
    }
}