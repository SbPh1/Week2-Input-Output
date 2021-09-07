using System;

namespace GreetingV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja käest nime
            //programm küsib kasutaja käest perekonanime
            //programm tervitab kasutajat, kasutades neid andmeid
            Console.WriteLine("Mis on sinu eesnimi?");
            String FirstName = Console.ReadLine();

            Console.WriteLine("Mis on sinu perekonnanimi?");
            String LastName = Console.ReadLine();

            Console.WriteLine($"Hello, {FirstName} {LastName}");

            // Console.WriteLine("Hello, " + FirstName + " " + LastName);

            Console.Read();
        }
    }
}
