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

namespace Vezérlők
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

        private void bekuldes(object sender, RoutedEventArgs e)
        {

            MessageBox.Show($"Név: {nevbev.Text}\nJelszó: {jelszbev.Password}\nNeme: " + (ferfibev.IsChecked==true?"férfi":"nő") +
                $"\nFelhasználási tételeket " + (felhbev.IsChecked==true?"elfogadta":"nem fogadta el"));
        }
    }
}