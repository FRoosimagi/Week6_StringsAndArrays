using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt ees- ja perekonnanime
            //programm kuvab, mitu "a" tähte on kasutaja nimedes kokku

            Console.WriteLine("sisestage eesnimi:");
            string firstname = Console.ReadLine().ToLower();
            Console.WriteLine("sisestage perekonnanimi:");
            string lastname = Console.ReadLine().ToLower();

            string fullName = $"{firstname}{lastname}".ToLower();

            int aCounter = 0;

            for(int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                {
                    aCounter++;
                }
            }

            if(aCounter != 1)
            {
                Console.WriteLine($"Sinu nimes on {aCounter} 'a' tähte. ");
            }
            else
            {
                Console.WriteLine($"Sinu nimes on {aCounter} 'a' täht. ");
            }

            
        }
    }
}
