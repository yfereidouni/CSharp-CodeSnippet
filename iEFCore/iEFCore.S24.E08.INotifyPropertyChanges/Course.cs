using System.ComponentModel;

namespace iEFCore.S24.E08.INotifyPropertyChanges;

public class Course : INotifyPropertyChanged, INotifyPropertyChanging
{
    public event PropertyChangedEventHandler? PropertyChanged;
    public event PropertyChangingEventHandler? PropertyChanging;

    private int id;
    public int Id
    {
        get { return id; }
        set
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(nameof(Id)));
            id = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
        }
    }

    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(nameof(Name)));
            name = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
        }
    }
}
