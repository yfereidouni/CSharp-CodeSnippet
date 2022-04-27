using System.ComponentModel;

namespace iEFCore.S24.E09.ChangeTrackerDebugView;

public class Teacher : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    
    private int id;
    public int Id
    {
        get { return id; }
        set
        {
            id = value;
        }
    }

    private string firstName;
    public string FirstName
    {
        get { return firstName; }
        set
        {
            firstName = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstName)));
        }
    }

    private string lastName;
    public string LastName
    {
        get { return lastName; }
        set
        {
            lastName = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));
        }
    }
}

public class News
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ShortDescription { get; set; }
    public string NewsBody { get; set; }
    public string ImageUrl { get; set; }
    public string RootTitle { get; set; }
}


