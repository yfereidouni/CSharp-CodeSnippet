using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEvents.EventSamples;

public class TeacherNameChangeArgs : EventArgs
{
    public string OldName { get; set; }
    public string NewName { get; set; }
    public TeacherNameChangeArgs(string oldName, string newName)
    {
        this.OldName= oldName;
        this.NewName= newName;
    }
}

public class Teacher
{
    public event EventHandler<TeacherNameChangeArgs> TeacherNameChange;

    private string _Name;
    public Teacher(string name)
    {
        _Name = name;
    }
    public void SetName(string newName)
    {
        var args = new TeacherNameChangeArgs(_Name, newName);
        _Name = newName;
        TeacherNameChange.Invoke(newName, args);
    }
}


public class TeacherNameChangeLogger
{
    public void Log(object sender,TeacherNameChangeArgs args)
    {
        Console.WriteLine($"Old Name: {args.OldName} New Name:{args.NewName}");
    }
}