using NASACLI;
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

namespace NasaWPF
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

        private void btnMindenAdat_Click(object sender, RoutedEventArgs e)
        {

            Program.Beolvas("NASAmissions.txt");

            dtgAdatok.ItemsSource = Program.Kuldetesek;

        }

        private void dtgAdatok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            pgbHasznosTeherErtek.Value = Program.Kuldetesek[dtgAdatok.SelectedIndex].HasznosTeher;

            lbNev.Content = Program.Kuldetesek[dtgAdatok.SelectedIndex].Nev;

        }

        private void btnStatisztika_Click(object sender, RoutedEventArgs e)
        {

            

        }
    }
}