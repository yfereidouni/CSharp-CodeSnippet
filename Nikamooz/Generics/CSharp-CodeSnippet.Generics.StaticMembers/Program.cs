// See https://aka.ms/new-console-template for more information


using CSharp_CodeSnippet.Generics.StaticMembers;

StaticMembers<int>.Counter = 12;
Console.WriteLine(StaticMembers<int>.Counter);

StaticMembers<bool>.Counter = 15;
Console.WriteLine(StaticMembers<bool>.Counter);

StaticMembers<string>.Counter = 11;
Console.WriteLine(StaticMembers<string>.Counter);

//------------------ Change the values ------------------

Console.WriteLine("".PadLeft(30, '-') + " After Changing values  ".PadRight(44,'-'));

StaticMembers<int>.Counter = 13;
Console.WriteLine(StaticMembers<int>.Counter);


StaticMembers<bool>.Counter = 15;
Console.WriteLine(StaticMembers<bool>.Counter);

StaticMembers<string>.Counter = 11;
Console.WriteLine(StaticMembers<string>.Counter);
