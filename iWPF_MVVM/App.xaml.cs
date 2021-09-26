using iWPF_MVVM.View;
using iWPF_MVVM.ViewModel;
using System.Windows;

namespace iWPF_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //View
            MainPage window = new View.MainPage();
            //ViewModel
            UserViewModel VM = new UserViewModel();

            window.DataContext = VM;
            window.Show();
        }
    }

    
}
