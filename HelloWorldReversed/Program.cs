using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab helloworld tagurpidi

            string helloworld = "Hello World";

            for (int i = helloworld.Length - 1; i >= 0; i--)
            {
                Console.Write(helloworld[i]);
            }
        }
    }
}
