// See https://aka.ms/new-console-template for more information


using iConcurrencyAndAsynchrony.AsyncSample;

PrimeNumberSample primeNumberSample = new PrimeNumberSample();

///Function was Sync but Execution is Async
//Task.Run(() =>
//primeNumberSample.DisplayPrimeNumberV1()
//);

//Console.WriteLine("Console Application was Finished!");

//Console.ReadLine();

//--------------------------------------------------
///Function was Async and execution is Async too
//primeNumberSample.DisplayPrimeNumberV2();
//primeNumberSample.DisplayPrimeNumberV3();
//primeNumberSample.DisplayPrimeNumberV4();
//primeNumberSample.DisplayPrimeNumberV5();
//await primeNumberSample.DisplayPrimeNumberV6();
//Console.WriteLine("Console Application was Finished!");
//Console.ReadLine();

//---------------------------------------------------
AsyncTasksSample asyncTasksSample = new AsyncTasksSample();
//await asyncTasksSample.Start();

//---------------------------------------------------
//var hello = asyncTasksSample.PrintMessage("Hello");
//var world = asyncTasksSample.PrintMessage("world");
//var yasser = asyncTasksSample.PrintMessage("yasser");
//var fereidouni = asyncTasksSample.PrintMessage("Fereidouni");

//await hello;
//await world;
//await yasser;
//await fereidouni;

//---------------------------------------------------
CancelationSample cancelationSample = new CancelationSample();
//await cancelationSample.TaskWithCancellationToken();
await cancelationSample.TaskWithCancellationAndProgress();
//---------------------------------------------------
//var after3 = asyncTasksSample.PrintAfter3Seconds();
//var after4 = asyncTasksSample.PrintAfter4Seconds();
//var after5 = asyncTasksSample.PrintAfter5Seconds();

////await Task.WhenAll(after3,after4,after5);
//await Task.WhenAny(after3, after4, after5);

