using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace iEvents_and_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new File() { Title = "ReadMe.txt" };
            var downloadHelper = new DownloadHelper();       //Publisher

            var unpackService = new UnpackService();         //Receiver
            var notifiService = new NotificationService();   //Receiver

            downloadHelper.FileDownloaded += unpackService.OnFileDownloaded;
            downloadHelper.FileDownloaded += notifiService.OnFileDownloadedNotification;

            downloadHelper.Download(file);
        }
    }
}