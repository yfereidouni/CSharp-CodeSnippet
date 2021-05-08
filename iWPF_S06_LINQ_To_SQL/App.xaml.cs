using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace iWPF_S06_LINQ_To_SQL
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(1065);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            //if (Thread.CurrentThread.CurrentCulture.LCID == 1065)
            //{
            //    To show persian digits
            //    this.calendar1.FlowDirection = System.Windows.FlowDirection.RightToLeft;
            //    this.datePicker1.FlowDirection = System.Windows.FlowDirection.RightToLeft;
            //}
        }
    }
}
