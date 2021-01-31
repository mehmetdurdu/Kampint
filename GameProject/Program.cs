using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1995,
                FirstName = "Mehmet",
                LastName = "Durdu",
                IdentityNumber = 123456
            });


            Console.WriteLine("Hello World!");
        }
    }
}
