using System;


namespace iEvents_and_Delegates;

public class UnpackService
{
    public void OnFileDownloaded(object source, FileEventArgs e)
    {
        Console.WriteLine("Service 1: Unpacking the file... --> " + e.File.Title);
    }
}
