using System;
using System.IO;

namespace iFiles
{
    class Program
    {


        static void Main(string[] args)
        {
            //Current execution path of program
            var GetDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            //-----------------------------------------------------------------------------
            //Method 1 -------------------------------------------------------------------
            //-----------------------------------------------------------------------------
            string[] lines = { "first line.", "second line.", "third line." };
            File.WriteAllLines("iFile.txt", lines);
            var text = File.ReadAllText("iFile.txt");
            Console.WriteLine(text);
            //-----------------------------------------------------------------------------

            //-----------------------------------------------------------------------------
            //Method 2 --------------------------------------------------------------------
            //-----------------------------------------------------------------------------
            using (StreamWriter writer = new StreamWriter("iFile.txt"))
            {
                writer.WriteLine("Hello");
                writer.WriteLine("Yasser Fereidouni");
                writer.WriteLine("09124643426");
            }
            using (StreamReader reader = new StreamReader("iFile.txt"))
            {
                //Console.WriteLine(reader.ReadToEnd());
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
            //-----------------------------------------------------------------------------
        }
    }
}
