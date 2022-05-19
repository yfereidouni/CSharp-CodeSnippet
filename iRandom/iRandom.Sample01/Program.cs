using System;

namespace iRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int numEyes;

            //Generating 10 random number in range of 1 to 7 (notice: 7 is exclude)
            for(int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1, 7);
                Console.WriteLine(numEyes);
            }
        }
    }
}
