using System;

namespace ADO.NET
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTime BirthDate { get; set; }
        public string ShSh { get; set; }
        public Person()
        {

        }
        public Person(int id)
        {
            this.Id = id;
        }
        public Person(int id, string name) : this(id)
        {
            this.Name = name;
        }
        public Person(int id, string name, string family) : this(id, name)
        {
            this.Family = family;
        }
        public Person(int id, string name, string family, DateTime birthdate) : this(id, name, family)
        {
            this.BirthDate = birthdate;
        }
        public Person(int id, string name, string family, DateTime birthdate, string shsh) : this(id, name, family, birthdate)
        {
            this.ShSh = shsh;
        }
        public override string ToString()
        {
            return string.Format($"Name : {this.Name}, Family : {this.Family}, BirthDate : {this.BirthDate.Date}, ShSh : {this.ShSh}  ");
        }
    }

}
