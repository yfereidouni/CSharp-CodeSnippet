namespace iEFCore.Configurations.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public Person Person { get; set; }
    }
}
