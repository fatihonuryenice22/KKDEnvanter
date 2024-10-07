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
using System.Windows.Shapes;

namespace KKDEnvanter
{
    /// <summary>
    /// UrunEkleWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class UrunEkleWindow : Window
    {
        public UrunEkleWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EtilerKategoriEkle etilerKategoriEkle = new EtilerKategoriEkle();
            etilerKategoriEkle.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EmirganKategoriEkle emirganKategoriEkle = new EmirganKategoriEkle();
            emirganKategoriEkle.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
