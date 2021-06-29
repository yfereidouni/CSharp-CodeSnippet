using System;

namespace iTType
{
    public class Magazin : IDocument
    {
        public string Name { get; set; }

        public int No { get; set; }

        public string GetString()
        {
            return $"{this.GetType().Name} | {Name} | {No}";
        }
    }

}


