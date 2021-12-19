﻿// See https://aka.ms/new-console-template for more information

using iEFCore.Fundamentals;
using iEFCore.Fundamentals.DAL;

using (var ctx = new PersonDb())
{
    //CRUD_Test(ctx);

    Display_List(ctx);
}

void Display_List(PersonDb ctx)
{
    var people = ctx.People.Where(c => c.FirstName.StartsWith("Y")).ToList();
    foreach (var item in people)
    {
        Console.WriteLine($"{item.FirstName} | {item.LastName} | {item.BirthDate}");
    }
}

static void CRUD_Test(PersonDb ctx)
{
    var person = new Person
    {
        FirstName = "Yasser",
        LastName = "Fereidouni",
        BirthDate = DateTime.Now,
    };
    person.Contacts.Add(new Contact { PhoneNumber = "09102343434" });
    //var yfo = ctx.People.Find(3); // Read and Find
    //yfo.FirstName = "Yasser"; //Update
    //ctx.People.Remove(yfo); // Delete
    ctx.People.Add(person); // Create
    ctx.SaveChanges();
}