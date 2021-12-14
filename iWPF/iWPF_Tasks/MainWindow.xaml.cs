using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace iWPF_Tasks
{
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty HtmlProperty = DependencyProperty.RegisterAttached(
                    "Html",
                    typeof(string),
                    typeof(MainWindow),
                    new FrameworkPropertyMetadata(OnHtmlChanged));

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                Debug.WriteLine($" Thread Nr. {Thread.CurrentThread.ManagedThreadId}");
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("https://www.google.com/").Result;

                MyButton.Dispatcher.Invoke(() =>
                {
                    Debug.WriteLine($" Thread Nr. {Thread.CurrentThread.ManagedThreadId}");
                    MyButton.Content = "Done";
                });
            });
        }

        private async void MyButton2_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($" Thread Nr. {Thread.CurrentThread.ManagedThreadId} before await task");

            await Task.Run(async () =>
            {
                Debug.WriteLine($" Thread Nr. {Thread.CurrentThread.ManagedThreadId} during await task");
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("https://www.google.com/").Result;
            });
            Debug.WriteLine($" Thread Nr. {Thread.CurrentThread.ManagedThreadId} after await task");

            MyButton2.Content = "Done";

        }

        private async void MyButton3_Click(object sender, RoutedEventArgs e)
        {
            string myHtml = "Bla";

            Debug.WriteLine($" Thread Nr. {Thread.CurrentThread.ManagedThreadId} before await task");
            await Task.Run(async () =>
            {
                Debug.WriteLine($" Thread Nr. {Thread.CurrentThread.ManagedThreadId} during await task");
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("https://www.google.com/").Result;
                myHtml = html;
            });
            Debug.WriteLine($" Thread Nr. {Thread.CurrentThread.ManagedThreadId} after await task");
            MyButton2.Content = "Done";
            MyWebBrowser.SetValue(HtmlProperty,myHtml);

        }
        static void OnHtmlChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser webBrowser = dependencyObject as WebBrowser;
            if (webBrowser != null)
            {
                webBrowser.NavigateToString(e.NewValue as string);
            }
        }
    }
}
