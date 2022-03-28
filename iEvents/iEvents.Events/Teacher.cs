using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEvents.Events;

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

    private string _name;
    private string _description;
    public Teacher(string name,string description)
    {
        _name = name;
        _description = description;
    }
    public void SetName(string newName)
    {
        var args = new TeacherNameChangeArgs(_name, newName);
        this._name = newName;
        TeacherNameChange.Invoke(newName, args);
    }
}

public class TeacherNameChangeLogger
{
    public void Log(object sender,TeacherNameChangeArgs args)
    {
        Console.WriteLine("Event log started:");
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Old-Name: {args.OldName} | New-Name: {args.NewName}");
    }
}