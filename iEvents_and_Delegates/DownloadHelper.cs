using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace iEvents_and_Delegates
{
    public class DownloadHelper
    {
        // Step 1 - Create Delegate
        public delegate void FileDownloadedEventHandler(object source, EventArgs args);
        
        // Step 2 - Create an Evenet based on that Delegate
        public event FileDownloadedEventHandler FileDownloaded;

        // Step 3 - Raise the Event
        protected virtual void OnFileDownloaded()
        {
            if (FileDownloaded!=null)
            {
                FileDownloaded(this, EventArgs.Empty);
            }
        }

        public void Download(File file)
        {
            Console.WriteLine("Downloading file...");
            Thread.Sleep(4000);

            // Step 3.1 call the method to raise the evenet
            OnFileDownloaded();
        }

    }
}
