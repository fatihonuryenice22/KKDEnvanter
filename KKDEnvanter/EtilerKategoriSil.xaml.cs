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
    /// EtilerKategoriSil.xaml etkileşim mantığı
    /// </summary>
    public partial class EtilerKategoriSil : Window
    {
        public EtilerKategoriSil()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            KKDEtilerSayfası kKDEtilerSayfası = new KKDEtilerSayfası();
            kKDEtilerSayfası.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaglikveGuvenlikİsaretleriEtiler saglikveGuvenlikİsaretleriEtiler = new SaglikveGuvenlikİsaretleriEtiler();
            saglikveGuvenlikİsaretleriEtiler.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DigerEtiler digerEtiler = new DigerEtiler();
            digerEtiler.Show();
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
