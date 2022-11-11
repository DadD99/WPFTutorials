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
            persons.Add(new Person() { Name = " Dung 1", Age = 22, Mail = "Dungpolla@gmail.com", Sex = SexType.Male });
            persons.Add(new Person() { Name = " Elisa", Age = 21, Mail = "Dungpolla@gmail.com", Sex = SexType.Female});
            persons.Add(new Person() { Name = " Cookies", Age = 22, Mail = "Dungpolla@gmail.com", Sex = SexType.Female });
            persons.Add(new Person() { Name = " Elizabeth", Age = 23, Mail = "Dungpolla@gmail.com", Sex = SexType.Female });
            persons.Add(new Person() { Name = " Trang", Age = 21, Mail = "Dungpolla@gmail.com", Sex = SexType.Female });
            persons.Add(new Person() { Name = " Dung 6", Age = 23, Mail = "Dungpolla@gmail.com",Sex = SexType.Male });
            listViewUsers.ItemsSource = persons;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(listViewUsers.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Age");
            view.GroupDescriptions.Add(groupDescription);
        }
    }
}
