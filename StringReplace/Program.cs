using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "hello world!" tärniga(*)

            string helloworld = "Hello World!";

            helloworld = helloworld.Replace('o', '*');
            helloworld = helloworld.Replace('!', '1');
            Console.WriteLine(helloworld);
        }
    }
}
