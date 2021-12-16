using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace iWPF_Calculator
{
    /// <summary>
    /// Interaction logic for InotifyPropertyChangedInterface.xaml
    /// </summary>
    public partial class InotifyPropertyChangedInterface : Window
    {
        public Sum SumObj { get; set; }

        public InotifyPropertyChangedInterface()
        {
            InitializeComponent();
            SumObj = new Sum { Num1 = "1", Num2 = "3" };
            this.DataContext = SumObj;
        }
    }
}
