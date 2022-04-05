// See https://aka.ms/new-console-template for more information

using iConcurrencyAndAsynchrony.ThreadSample;

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
threadPoolSample.Start();