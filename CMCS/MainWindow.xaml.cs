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

namespace CMCS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Home());
        }

        private void ClaimsButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Claims());
        }

        private void LecturersButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Lecturers());
        }
        private void StaffButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Staff());
        }
    }
}