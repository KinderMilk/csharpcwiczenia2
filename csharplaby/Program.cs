using System;

namespace csharplaby
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Witaj!");
            Console.WriteLine("Podaj swoję Imię: ");

            string imie = Console.ReadLine();
            Console.WriteLine("Podaj swoje nazwisko");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Witaj {0}, {1}" , imie,nazwisko);
            

    }
    }
}
