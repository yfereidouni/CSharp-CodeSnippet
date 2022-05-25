using iConcurrencyAndAsynchrony.ThreadSample;

//-----------------------------------------------
CharPrinter charPrinter = new CharPrinter();

Thread dashPrinterWorker = new Thread(charPrinter.PrintDash);
Thread StarPrinterWorker = new Thread(charPrinter.PrintStar);
dashPrinterWorker.Name = "DashprinterWorker";
StarPrinterWorker.Name = "StarprinterWorker";
dashPrinterWorker.Start();
StarPrinterWorker.Start();

//charPrinter.PrintStar();
//charPrinter.PrintDash();

//-----------------------------------------------
ThreadMethodSamples threadMethodSamples = new ThreadMethodSamples();
//threadMethodSamples.CreatThreadSample();
//threadMethodSamples.JoinSample();
//threadMethodSamples.SleepSample();
//threadMethodSamples.ThreadStateCheck();

//-----------------------------------------------
SharedAndLocalState localState = new SharedAndLocalState();
//localState.Start();
//localState.SafeCheckSharedState();

//------------------------------------------------
ForegroundBackgroundThread thread = new ForegroundBackgroundThread();
//thread.Start();

//------------------------------------------------
ThreadPrioritySample threadPriority = new ThreadPrioritySample();
//threadPriority.Start();

//------------------------------------------------
ThreadPoolSample threadPoolSample = new ThreadPoolSample();
//threadPoolSample.Start();




//End------------------------------------------------
Console.ReadLine();

