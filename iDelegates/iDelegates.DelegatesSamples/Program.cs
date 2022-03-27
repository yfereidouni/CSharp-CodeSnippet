// See https://aka.ms/new-console-template for more information


using iDelegates.DelegatesSamples;

Person person = new Person { FirstName = "Yasser", LastName = "Fereidouni" };
PersonPrinter personPrinter = new PersonPrinter();

///Way-1: ----------------------------------------------------------------------------
Console.WriteLine("\r\nWay-1: ".PadRight(50, '-'));

personPrinter.Print(PersonFullName.GetPersonFullName, person);
personPrinter.Print(PersonFullNameReverse.GetPersonFullName, person);

///Way-2: ----------------------------------------------------------------------------
Console.WriteLine("\r\nWay-2: ".PadRight(50, '-'));

PersonToString myDelegate1 = PersonFullName.GetPersonFullName;
var result1 = myDelegate1.Invoke(person);
Console.WriteLine(result1);

PersonToString myDelegate2 = PersonFullNameReverse.GetPersonFullName;
var result2 = myDelegate2.Invoke(person);
Console.WriteLine(result2);

///Way-3: ----------------------------------------------------------------------------
///Using Act<T> and Func<T> 
Console.WriteLine("\r\nWay-3: ".PadRight(50, '-'));

Func<Person, string> func1 = PersonFullName.GetPersonFullName;
Console.WriteLine(func1(person));

Func<Person, string> func2 = PersonFullNameReverse.GetPersonFullName;
Console.WriteLine(func2(person));

///Way-4: ----------------------------------------------------------------------------
Console.WriteLine("\r\nWay-4: ".PadRight(50, '-'));

personPrinter.PrintFunc(PersonFullName.GetPersonFullName, person);
personPrinter.PrintFunc(PersonFullNameReverse.GetPersonFullName, person);

///Way-5: ----------------------------------------------------------------------------
Console.WriteLine("\r\nWay-5: ".PadRight(50, '-'));

Func<Person, string> funcMultiCast = PersonFullName.GetPersonFullName;
funcMultiCast += PersonFullNameReverse.GetPersonFullName;

foreach (var item in funcMultiCast.GetInvocationList()) // if we dont use GetInvocationList() we just get the last output
{
    Console.WriteLine(item.DynamicInvoke(person));
}
///-----------------------------------------------------------------------------------