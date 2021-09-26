using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
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
            iWPF_MVVM.MainWindow window = new MainWindow();
            UserViewModel VM = new UserViewModel();
            window.DataContext = VM;
            window.Show();
        }
    }

    
}
