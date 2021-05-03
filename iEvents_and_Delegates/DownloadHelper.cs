using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace iEvents_and_Delegates
{
    public class FileEventArgs : EventArgs
    {
        public File File { get; set; }
    }

    public class DownloadHelper
    {
        // Step 1 - Create Delegate
        //public delegate void FileDownloadedEventHandler(object source, FileEventArgs args);

        // Step 2 - Create an Evenet based on that Delegate
        //public event FileDownloadedEventHandler FileDownloaded;
        public event EventHandler<FileEventArgs> FileDownloaded;

        // Step 3 - Raise the Event
        protected virtual void OnFileDownloaded(File file)
        {
            if (FileDownloaded != null)
            {
                FileDownloaded(this, new FileEventArgs() { File = file });
            }
        }

        public void Download(File file)
        {
            Console.WriteLine("Downloading file...");
            Thread.Sleep(4000);

            // Step 3.1 call the method to raise the evenet
            OnFileDownloaded(file);
        }

    }
}