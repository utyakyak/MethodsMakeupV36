using System;

namespace MethodsMakeupV36
{
    class Program
    {
        static void CreateCopies(string UserPhrase, int UserNumber, string separator)
        {
            int i;
            if (UserNumber >= 3 && UserNumber <= 6)
            {
                int x = UserNumber + 1;
                for (i = 1; i <= x; i++)
                {
                    Console.Write(UserPhrase + separator);
                }
            }
        }
        static void Main(string[] args)
        {
            string UserPhrase;

            Console.WriteLine("Angelica Nguyen Version = 36");
            Console.WriteLine("Please enter a string of characters.");
            UserPhrase = Console.ReadLine();


            string separator;
            Console.WriteLine("Please enter a separator.");
            separator = Console.ReadLine();

            bool valid = false;
            int UserNumber;
            Console.WriteLine("Please enter a number between 3 and 6.");
            while (valid == false)
            {
                if (int.TryParse(Console.ReadLine(), out UserNumber))
                {
                }
                if (UserNumber >= 3 && UserNumber <= 6)
                {
                    valid = true;
                    CreateCopies(UserPhrase, UserNumber, separator);
                }
                else
                {
                    Console.WriteLine("Enter an integer between 3 and 6");
                }
            }

            





            //while (int.TryParse(Console.ReadLine(), out num1)) ;
        }
    }
}
