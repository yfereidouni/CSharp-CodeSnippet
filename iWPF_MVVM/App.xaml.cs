using iWPF_MVVM.Views;
using iWPF_MVVM.ViewModels;
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
            MainPage window = new Views.MainPage();
            //ViewModel
            UserViewModels VM = new UserViewModels();

            window.DataContext = VM;
            window.Show();
        }
    }

    
}
