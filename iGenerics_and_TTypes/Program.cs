using System;

namespace iGenerics_and_TTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Newspaper TehranTimes = new Newspaper
            { Name = "TehranTimes", ReleaseDate = DateTime.Now };
            Book HarryPotter = new Book
            { Name = "HarryPotter", ReleaseDate = DateTime.Now };

            Console.WriteLine("\r\nGeneric without Inheritance :  --------------------------");
            PrintService<Document> printService = new PrintService<Document>();
            printService.PrintDocs(TehranTimes);
            printService.PrintDocs(HarryPotter);

            Console.WriteLine("\r\nChild-None-Generic : ------------------------------------");
            ChildNoneGeneric childNoneGeneric = new ChildNoneGeneric();
            childNoneGeneric.PrintDocs(TehranTimes);
            childNoneGeneric.PrintDocs(HarryPotter);

            Console.WriteLine("\r\nChild-Is-Generic : --------------------------------------");
            ChildIsGeneric<Document> childIsGeneric = new ChildIsGeneric<Document>();
            childIsGeneric.PrintDocs(TehranTimes);
            childIsGeneric.PrintDocs(HarryPotter);

            Console.ReadLine();
        }
    }

    public abstract class Document
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual string DisplayDetails()
        {
            return $"{Name} | {ReleaseDate}";
        }
    }
    public sealed class Newspaper : Document
    {
        public override string DisplayDetails()
        {
            return $"Newspaper : {base.DisplayDetails()}";
        }
    }
    public sealed class Book : Document
    {
        public override string DisplayDetails()
        {
            return $"Book : {base.DisplayDetails()}";
        }

    }

    public class PrintService<T> where T : Document
    {
        public virtual void PrintDocs(T document)
        {
            Console.WriteLine(document.DisplayDetails());
        }
    }

    public class ChildNoneGeneric : PrintService<Document>
    {
        public override void PrintDocs(Document document)
        {
            Console.WriteLine(document.DisplayDetails());
        }
    }

    public class ChildIsGeneric<T> : PrintService<T>
        where T : Document
    {
        public override void PrintDocs(T document)
        {
            Console.WriteLine(document.DisplayDetails());
        }
    }
}
