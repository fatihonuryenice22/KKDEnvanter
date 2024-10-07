using System.IO;
using System.Windows;

namespace KKDEnvanter
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

        public void StokDetay_Click(object sender, RoutedEventArgs e)
        {
            StokDetayWindow stokDetayWindow = new StokDetayWindow();
            stokDetayWindow.Show();
            this.Close();

        }

        private void Urunekle_Click(object sender, RoutedEventArgs e)
        {
            UrunEkleWindow urunEkleWindow = new UrunEkleWindow();
            urunEkleWindow.Show();
            this.Close();
        }

        private void UrunSil_Click(object sender, RoutedEventArgs e)
        {
            UrunSilPencere urunSilPencere = new UrunSilPencere();
            urunSilPencere.Show();
            this.Close();
        }
    }
}