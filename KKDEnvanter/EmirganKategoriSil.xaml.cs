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
    /// EmirganKategoriSil.xaml etkileşim mantığı
    /// </summary>
    public partial class EmirganKategoriSil : Window
    {
        public EmirganKategoriSil()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            KDDEmirganSayfasi kDDEmirganSayfasi = new KDDEmirganSayfasi();
            kDDEmirganSayfasi.Show(); 
            this.Close(); 

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaglikGuvenlikİsaretleriEmirganSilme saglikGuvenlikİsaretleriEmirganSilme = new SaglikGuvenlikİsaretleriEmirganSilme();
            saglikGuvenlikİsaretleriEmirganSilme.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EmirganDigerSil emirganDigerSil = new EmirganDigerSil(); 
            emirganDigerSil.Show();
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
