// See https://aka.ms/new-console-template for more information

using iEvents.EventSamples;


ProcessBusinessLogic bl = new ProcessBusinessLogic();
bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
bl.StartProcess();
bl.ProcessCompleted -= bl_ProcessCompleted; // Unregister with an event

// event handler
static void bl_ProcessCompleted()
{
    Console.WriteLine("Process Completed!");
}