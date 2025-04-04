using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> Persons { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Persons = new ObservableCollection<Person>
            {
                new Person("Андрей", 20),
                new Person("Егор", 30),
                new Person("Ангелина", 40)
            };

            DataContext = this;
        }

        private void myButtonClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Сообщение в текстбоксе: {myTextBox.Text}");
        }

        private void ShowSelectedElement(object sender, RoutedEventArgs e)
        {
            if (myListBox.SelectedItem != null)
            {
                MessageBox.Show($"Возраст выбранной персоны: {(myListBox.SelectedItem as Person).Age}");
            }
        }

        private void ShowThis(object sender, RoutedEventArgs e)
        {
            var thisButton = sender as Button;
            var person = thisButton.Tag as Person;
            MessageBox.Show($"Это {person.Name}. Возрастом {person.Age} лет");
        }
    }
}