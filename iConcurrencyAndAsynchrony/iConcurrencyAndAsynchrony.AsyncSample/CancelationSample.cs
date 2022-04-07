using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iConcurrencyAndAsynchrony.AsyncSample
{
    public class CancelationSample
    {
        #region Sample01: TaskWithCancellationToken 

        public async Task PrintAfter20Sec(string message, CancellationToken cancellationToken)
        {
            await Task.Delay(20000, cancellationToken);
            Console.WriteLine($"\r\n{message}");
        }

        public async Task TaskWithCancellationToken()
        {
            var cts = new CancellationTokenSource();
            var task = this.PrintAfter20Sec("My Message", cts.Token);
            Console.WriteLine("Press any key or wait for '20-Seconds' to task complete");

            Console.Write("\r\nIf you want to cancel the task press c : ");
            ConsoleKeyInfo cancelResult = Console.ReadKey();
            if (cancelResult.Key == ConsoleKey.C || cancelResult.Key == ConsoleKey.C)
            {
                cts.Cancel();
            }

            try
            {
                await task;
            }
            catch (TaskCanceledException ex)
            {
                var status = task.Status;
                var isCanceled = task.IsCanceled;
                Console.WriteLine($"\r\n\r\nIs Canceled: {isCanceled} | Status: {status} | {ex.Message}");
            }
        }

        #endregion

        #region Sample02: TaskWithCancellationAndProgress

        private void Progress_ProgressChanged(object? sender, (int, int) e)
        {
            double progressPercentage = ((e.Item1 * 100) / (e.Item2));
            Console.WriteLine(string.Format("\r\n{0:0.00} % Complete", (int)progressPercentage));
        }

        private async Task Print20Numbers(IProgress<(int current, int total)> progress, CancellationToken token)
        {
            int i = 1;
            while (i < 21)
            {
                Console.Write($"{i} ");
                await Task.Delay(3000);
                i++;

                //if (token.IsCancellationRequested)
                    token.ThrowIfCancellationRequested();

                if (i % 2 == 0)
                    progress.Report((i, 20));
                
            }
        }
        
        public async Task TaskWithCancellationAndProgress()
        {
            var cts = new CancellationTokenSource();
            Progress<(int, int)> progress = new Progress<(int, int)>();
            progress.ProgressChanged += Progress_ProgressChanged;


            Console.Write("\r\nIf you want to cancel the task press c : \r\n");
            var task = this.Print20Numbers(progress, cts.Token);

            ConsoleKeyInfo cancelResult = Console.ReadKey();
            if (cancelResult.Key == ConsoleKey.C || cancelResult.Key == ConsoleKey.C)
            {
                cts.Cancel();
            }
            
            try
            {
                await task;
            }
            catch (TaskCanceledException ex)
            {
                var status = task.Status;
                var isCanceled = task.IsCanceled;
                Console.WriteLine($"\r\n\r\nIs Canceled: {isCanceled} | Status: {status} | {ex.Message}");
            }
            catch(OperationCanceledException ex)
            {
                var status = task.Status;
                var isCanceled = task.IsCanceled;
                Console.WriteLine($"\r\n\r\nIs Canceled: {isCanceled} | Status: {status} | {ex.Message}");
            }

        }
        
        #endregion
    }
}
