// See https://aka.ms/new-console-template for more information



using iCollections.Stack;

StackSample stackSample = new StackSample();

stackSample.Push("Yasser");
stackSample.CountAndCapacity();

stackSample.Push("Reza");
stackSample.Push("Hassan");
stackSample.Push("Habib");

stackSample.CountAndCapacity();

var result = stackSample.Pop();
Console.WriteLine(result);
result = stackSample.Pop();
Console.WriteLine(result);
result = stackSample.Pop();
Console.WriteLine(result);
//result = queueSample.Dequeue();
//Console.WriteLine(result);

stackSample.CountAndCapacity();

result = stackSample.Peek();
Console.WriteLine(result);

stackSample.CountAndCapacity();
