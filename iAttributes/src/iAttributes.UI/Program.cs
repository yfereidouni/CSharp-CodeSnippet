// See https://aka.ms/new-console-template for more information

using iAttributes.Domain;

Person yasser = new Person()
{
    FirstName ="Shervin",
    LastName = "Souri",
    Age = 36
};

PersonPrinter personPrinter = new PersonPrinter(yasser);

personPrinter.Print();

personPrinter.PrintAge(); // This method is OBSOLETED

