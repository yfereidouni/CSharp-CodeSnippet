using System;

namespace iTypes.TType
{
    public class Newspaper : IDocument
    {
        public DateTime ReleaseDate { get; set; }

        public string Name { get; set; }

        public string GetString()
        {
            return $"{this.GetType().Name} | {Name} | {ReleaseDate}";
        }
    }
}

