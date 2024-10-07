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
    /// UrunSilPencere.xaml etkileşim mantığı
    /// </summary>
    public partial class UrunSilPencere : Window
    {
        public UrunSilPencere()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EtilerKategoriSil etilerKategoriSil = new EtilerKategoriSil();
            etilerKategoriSil.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EmirganKategoriSil emirganKategoriSil = new EmirganKategoriSil();
            emirganKategoriSil.Show();
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
