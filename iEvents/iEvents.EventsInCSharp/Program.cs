// See https://aka.ms/new-console-template for more information

using iEvents.EventsInCSharp;


Person person = new Person();

person.PersonDisplayToScreen += person.PersonPrinter;
person.PersonCreatedNotification += person.PersonNotification;
person.PersonCreatedEmail += person.PersonEmailSender;

person.SetPersonDetails();