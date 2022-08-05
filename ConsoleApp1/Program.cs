using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value");
            double usersValue = Convert.ToDouble(Console.ReadLine());
            if (0 < usersValue)
            {
                if (usersValue <= 14)
                    Console.WriteLine("U entered a value in between 0 and 14");
                else if (usersValue <= 35)
                    Console.WriteLine("U entered a value in between 15 and 35");
                else if (usersValue <= 50)
                    Console.WriteLine("U entered a value in between 36 and 50");
                else if (usersValue <= 100)
                    Console.WriteLine("U entered a value in between 51 and 100");
                else
                    Console.WriteLine("You have entered a value that is bigger then 100");
            }
            else
                Console.WriteLine("You have entered a value that is smaller then 0");
        }
    }
}
