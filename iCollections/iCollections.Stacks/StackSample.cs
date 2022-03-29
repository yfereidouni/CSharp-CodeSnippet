using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCollections.Stack;

public class StackSample
{
    Stack<string> stack = new Stack<string>();

    public void Push(string input)
    {
        stack.Push(input);
        Console.WriteLine($"Message => \"{input}\" was Pushed to Stack.");
    }

    public string Pop() =>
        $"Message => \"{stack.Pop()}\" was Poped from Stack.";


    public void CountAndCapacity()
    {
        Console.WriteLine($"\r\nCount: {stack.Count} \r\n");
    }

    public string Peek() => $"Message => \"{stack.Peek()}\" is on the Stack's Top";

}
