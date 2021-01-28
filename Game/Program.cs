using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new RegisteredManager(),new Messages());
            gamerManager.Add(new Gamer { IdentityNumber=123456,
            Name="Berat",
            LastName="Bayraktar",
            Birthday= "08/03/1996"
            });
            Console.ReadKey();
        }
    }
}
