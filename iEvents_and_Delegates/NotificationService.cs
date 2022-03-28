using System;


namespace iEvents_and_Delegates;

public class NotificationService
{
    public void OnFileDownloadedNotification(object source, EventArgs e)
    {
        Console.WriteLine("Service 2: Notifcation was send to all receivers...");
    }
}
