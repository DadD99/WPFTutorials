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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> ListData;
        public MainWindow()
        {
            InitializeComponent();
            ListData = new List<String>();
            for(int i = 0; i < 5; i++)
            {
                ListData.Add(i.ToString());
            }
            cbBox.ItemsSource = ListData;
            lsBox.ItemsSource = ListData;
        }
    }
}
