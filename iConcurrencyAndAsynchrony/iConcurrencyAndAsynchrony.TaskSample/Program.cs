// See https://aka.ms/new-console-template for more information

using iConcurrencyAndAsynchrony.TaskSample;


RunTaskSample runTaskSample = new RunTaskSample();
//runTaskSample.Start();
//runTaskSample.StartLongRunning();
//runTaskSample.StartColdTask();

//--------------------------------------------------
TaskResultSample resultSample = new TaskResultSample();
//resultSample.Start();

//---------------------------------------------------
ExceptionSample exceptionSample = new ExceptionSample();
//exceptionSample.Start();

//---------------------------------------------------
ContinuationSample continuationSample = new ContinuationSample();
//continuationSample.Start();
//continuationSample.Start2();

//----------------------------------------------------
Task.Delay(2000).ContinueWith(x => Console.WriteLine("Test after 2 seconds"));
Console.ReadLine();