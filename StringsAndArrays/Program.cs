using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime
            //programm kuvab kasutaja eesnime pikkust

            Console.WriteLine("Sisesta eesnimi:");
            string firstname = Console.ReadLine();

            //int firstNameLength = firstname.Length;
            Console.WriteLine($"Sinu eesnimes on  {firstname.Length} sümbolit.");
            
        }
    }
}
