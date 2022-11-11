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
        public MainWindow()
        {
            InitializeComponent();
            //Binding binding = new Binding();
            //binding.Source = textBox1;
            //binding.Path = new PropertyPath("Text");
            //binding.Mode = BindingMode.OneWay;
            //label1.SetBinding(Label.ContentProperty, binding);
            stackpanel1.DataContext = new Product() { ID = 123, Name = "Dung Dep Trai vai ca chuong" };
            stackpanel2.DataContext = new Product() { ID = 1343, Name = "Dusfang Dep Trai vai ca chuong" };
        }
        
    }
    public class Product
    {
        public int ID { get; set; }
        public string? Name { get; set; }
    }
}
