using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World"


            string helloworld = "Hello World".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < helloworld.Length; i++)
            {
                if(helloworld[i] == 'h')
                {
                    hCounter++;
                }
                else if (helloworld[i] == 'o')
                {
                    oCounter++;
                }
                else if (helloworld[i] == 'l')
                {
                    lCounter++;
                }
            }

            Console.WriteLine($"lauses {helloworld} on {hCounter} 'h' tähte, {oCounter} 'o' tähte ja {lCounter} 'l' tähte.");

        }
    }
}
