namespace iAttributes.CustomAttributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class AutoScanForDependencyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class CodeChangeHistoryAttribute : Attribute
    {
        private readonly string author;

        public string Description { get; set; }
        public DateTime ChangeDateTime { get; set; }
        public bool IsBug { get; set; }

        public CodeChangeHistoryAttribute(string author, bool isBug = false)
        {
            this.author = author;
            this.IsBug = isBug;
        }
    }
}