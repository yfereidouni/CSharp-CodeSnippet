using System;
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

    public class UnpackService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("Service 1: Unpacking the file... --> " + e.File.Title);
        }
    }
    public class NotificationService
    {
        public void OnFileDownloadedNotification(object source, EventArgs e)
        {
            Console.WriteLine("Service 2: Notifcation was send to all receivers...");
        }
    }
}