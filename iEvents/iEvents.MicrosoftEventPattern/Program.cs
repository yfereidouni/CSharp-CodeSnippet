// See https://aka.ms/new-console-template for more information


MyClass myClass1 = new MyClass();
myClass1.MyEvent += new MyClass.MyDelegate(myClass1_MyEvent);

Console.WriteLine("Please enter a message\n");
string msg = Console.ReadLine();

//here is we raise the event.
myClass1.RaiseEvent(msg);
Console.Read();



void myClass1_MyEvent(object sender, MyClass.MyEventArgs e)
{
    if (sender is MyClass)
    {
        MyClass myClass = (MyClass)sender;
        Console.WriteLine("Your Message is: {0}", e.message);

    }
}