using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            CollectionView collectionView = new CollectionView(this.People);
            listBox1.ItemsSource = collectionView;
        }
        ObservableCollection<Person> _people = new ObservableCollection<Person>()
        {
            new Person() { Age = 10, Name = "Dung" },
            new Person() { Age = 11, Name = "The Door" },
            new Person() { Age = 15, Name = "Dung Dep Trai The Door" }
        };
        public ObservableCollection<Person> People
        {
            get { return _people; }
        }
        
    }
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return string.Format("{0} - age {1}", Name, Age);
        }
    }
}
