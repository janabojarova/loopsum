using System;

namespace LoopSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random rnd = new Random();

            int sum = 0;
            for (int i = 0; i < 10; i++)     
            {
                int myRandom = rnd.Next(1, 11);
                sum = sum + myRandom;
                

            }
            Console.WriteLine(sum);
         


            


           

        }
    }
}
