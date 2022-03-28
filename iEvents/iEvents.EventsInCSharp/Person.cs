using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEvents.EventsInCSharp
{
    public delegate void MyDel1(Person person);
    public delegate void MyDel2();
    public class Person
    {
        public event MyDel1 PersonDisplayToScreen;
        public event MyDel1 PersonCreatedNotification;

        public event MyDel2 PersonCreatedEmail;


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person()
        {

        }

        public void SetPersonDetails(int id = 10391, string firstname = "Yasser", string lastname = "Fereidouni")
        {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;

            PersonDisplayToScreen?.Invoke(this);
            PersonCreatedNotification?.Invoke(this);
            PersonCreatedEmail?.Invoke();
        }

        public void PersonPrinter(Person person)
        {
            Console.WriteLine($"Person Info : {person.Id} | {person.FirstName} | {person.LastName}");
        }

        public void PersonNotification(Person person)
        {
            Console.WriteLine($"\r\nSystem Notification => ({person.LastName},{person.FirstName}) was created.");
        }

        public void PersonEmailSender()
        {
            Console.WriteLine($"\r\nEmail => Email was send to all receivers.");

        }
    }
}
