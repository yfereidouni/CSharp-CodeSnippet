using System;

namespace iTypes.TType
{
    public class PrintService<T> where T:IDocument
    {
        public void Print(T document)
        {
            var printableDocument = document as IDocument;

            System.Console.WriteLine(printableDocument.GetString());
        }
    }
}


