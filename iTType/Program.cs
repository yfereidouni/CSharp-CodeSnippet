using System;

namespace iTType
{
    class Program
    {
        static void Main(string[] args)
        {
            Newspaper jamejam = new Newspaper
            {
                Name = "Jam-e-Jam",
                ReleaseDate = DateTime.Now
            };
            Book harryPotter = new Book
            { 
                Name = "Harry Potter",
                ISBN = "AS123ED12" 
            };
            Magazin IranDaily = new Magazin { 
                Name = "Iran Daily", No = 101 
            };


            PrintService<IDocument> ps = new PrintService<IDocument>();

            ps.Print(jamejam);
            ps.Print(harryPotter);
            ps.Print(IranDaily);

        }
    }

}


