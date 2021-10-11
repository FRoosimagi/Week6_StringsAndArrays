using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses nulliga - 0
            //programm asendab kõik 'a' tähed lauses 4

            string dontpanic = "Don't Panic!";

            dontpanic = dontpanic.Replace('o', '0');
            dontpanic = dontpanic.Replace('a', '4');
            Console.WriteLine(dontpanic);
        }
    }
}
