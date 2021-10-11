using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb on pikem

            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("sisesta perekonnanimi:");
            string LastName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            int lastNameLength = LastName.Length;

            if (firstNameLength < lastNameLength)
            {
                Console.WriteLine("Perekonnanimi on pikem.");
            }
            else if (firstNameLength > lastNameLength)
            {
                Console.WriteLine("Eesnimi on pikem");
            }
            else
            {
                Console.WriteLine("Ees- ja Perekonnanimi on sama pikkused.");
            }
        }
    }
}
