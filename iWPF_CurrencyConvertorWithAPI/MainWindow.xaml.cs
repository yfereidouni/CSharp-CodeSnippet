using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
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

namespace iWPF_CurrencyConvertorWithAPI
{
    public class Root
    {
        public Rate rates { get; set; }
        public long timestamp { get; set; }
        public string license { get; set; }

    }
    public class Rate
    {
        public double INR { get; set; }
        //public double JPY { get; set; }
        public double USD { get; set; }
        //public double NZD { get; set; }
        public double EUR { get; set; }
        public double CAD { get; set; }
        //public double ISK { get; set; }
        //public double PHP { get; set; }
        public double DKK { get; set; }
        public double CZK { get; set; }
        public double TRY { get; set; }

    }

    public partial class MainWindow : Window
    {
        Root val = new Root();

        public MainWindow()
        {
            InitializeComponent();

            GetValue();
        }

        private async void GetValue()
        {
            val = await GetData<Root>("https://openexchangerates.org/api/latest.json?app_id=c4c6454dace4447aac8df2a1d0a5684e");
            BindCurrency();
        }

        public static async Task<Root> GetData<T>(string url)
        {
            var myRoot = new Root();
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromMinutes(1);
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var ResponseString = await response.Content.ReadAsStringAsync();
                        var ResponseObject = JsonConvert.DeserializeObject<Root>(ResponseString);

                        //MessageBox.Show("TimeStamp: " + ResponseObject.timestamp, "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                        MessageBox.Show("TimeStamp: " + ResponseString, "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                        return ResponseObject;
                    }
                    return myRoot;
                }
            }
            catch
            {
                return myRoot;
            }
        }

        private void BindCurrency()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Text");
            dt.Columns.Add("Value");

            dt.Rows.Add("--SELECT--", 0);
            dt.Rows.Add("INR", val.rates.INR);
            dt.Rows.Add("USD", val.rates.USD);
            dt.Rows.Add("EUR", val.rates.EUR);
            dt.Rows.Add("DKK", val.rates.DKK);
            dt.Rows.Add("CZK", val.rates.CZK);
            dt.Rows.Add("CAD", val.rates.CAD);
            dt.Rows.Add("TRY", val.rates.TRY);

            cmbFromCurrency.ItemsSource = dt.DefaultView;
            cmbToCurrency.ItemsSource = dt.DefaultView;

            cmbFromCurrency.DisplayMemberPath = "Text";
            cmbToCurrency.DisplayMemberPath = "Text";

            cmbFromCurrency.SelectedValuePath = "Value";
            cmbToCurrency.SelectedValuePath = "Value";

            cmbFromCurrency.SelectedIndex = 0;
            cmbToCurrency.SelectedIndex = 0;
        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            double first = double.Parse(cmbFromCurrency.SelectedValue.ToString());
            double second = double.Parse(cmbToCurrency.SelectedValue.ToString());

            txtConverted.Text = ((double.Parse(txtFirstCurrency.Text)) * (second / first)).ToString();
                                
        }
    }

    
}
