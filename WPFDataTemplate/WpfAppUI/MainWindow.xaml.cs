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
            List<Person> persons = new List<Person>();
            persons.Add(new Person() { Age = 21, Name="Xin Jinping"});
            persons.Add(new Person() { Age = 22, Name = "Joe Biden" });
            persons.Add(new Person() { Age = 23, Name = "Dung Le" });
            this.DataContext = persons;



        }
    }
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
