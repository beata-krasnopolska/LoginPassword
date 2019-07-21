using System;

namespace LoginPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program asks the user for the login and password (both must be integer numbers), until the entered login is -12- and the password is -1234-. The user has 3 attempts maximum. ");

            int user;
            int password;
            int counter = 0;

            do
            {
                Console.WriteLine("Enter the login: ");
                user = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the password: ");
                password = int.Parse(Console.ReadLine());
                if (user != 12 || password != 1234)
                {
                    Console.WriteLine("Error!");
                    counter++;
                    Console.WriteLine(counter);
                }
            }
            while ((user != 12 || password != 1234) && counter != 3);

            if (user != 12 && password != 1234)
            {
                Console.WriteLine("Wrong data");
            }
            else
            {
                Console.WriteLine("Correct!");
            }                 
            Console.ReadKey();
        }
    }
}
