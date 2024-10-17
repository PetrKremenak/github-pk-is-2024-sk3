// See https://aka.ms/new-console-template for more information
using System;

namespace Scitani_metoda1 {
    class Program {
        static void Main()
        {
          Console.Write("Enter Username: ");
          string Username = Console.ReadLine();
          Console.WriteLine("Your username is " + Username);
          Console.Write("Enter password: ");
          string password = Console.ReadLine();
          if (password == "Pica") {
            Console.WriteLine("Úspěšně přihlášen");
            }
            else Console.WriteLine("Špatné heslo");
          
        }
    }
}
