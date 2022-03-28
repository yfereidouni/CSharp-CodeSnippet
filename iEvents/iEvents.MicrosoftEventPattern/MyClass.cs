// See https://aka.ms/new-console-template for more information

public class MyClass
{
    public delegate void MyDelegate(object sender, MyEventArgs e);
    public event MyDelegate MyEvent;

    public class MyEventArgs : EventArgs
    {
        public readonly string message;
        public MyEventArgs(string message)
        {
            this.message = message;
        }
    }

    //this method will be used to raise the event.
    public void RaiseEvent(string msg)
    {
        if (MyEvent != null)
            MyEvent(this, new MyClass.MyEventArgs(msg));
    }
}