// See https://aka.ms/new-console-template for more information


using iCollections.Queues;

QueueSample queueSample = new QueueSample();

queueSample.Enqueue("Yasser");
queueSample.CountAndCapacity();

queueSample.Enqueue("Reza");
queueSample.Enqueue("Hassan");
queueSample.Enqueue("Habib");

queueSample.CountAndCapacity();

var result = queueSample.Dequeue();
Console.WriteLine(result);
result = queueSample.Dequeue();
Console.WriteLine(result);
result = queueSample.Dequeue();
Console.WriteLine(result);
//result = queueSample.Dequeue();
//Console.WriteLine(result);

queueSample.CountAndCapacity();

result = queueSample.Peek();
Console.WriteLine(result);

queueSample.CountAndCapacity();


Console.WriteLine("\r\nPriority Queue: ----------------------------\r\n");

PriorityQueues pq = new PriorityQueues();
pq.AddWithSamePriority();
pq.AddWithDifferentPriority();
