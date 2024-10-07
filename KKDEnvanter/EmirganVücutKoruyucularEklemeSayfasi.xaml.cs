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
    /// EmirganVücutKoruyucular.xaml etkileşim mantığı
    /// </summary>
    public partial class EmirganVücutKoruyucular : Window
    {
        public EmirganVücutKoruyucular()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmirganİsEldiveniEkleme emirganİsEldiveniEkleme = new EmirganİsEldiveniEkleme();
            emirganİsEldiveniEkleme.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EmirganTyvekEkleme emirganTyvekEkleme = new EmirganTyvekEkleme();
            emirganTyvekEkleme.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EmirganYelekEkleme emirganYelekEkleme = new EmirganYelekEkleme();
            emirganYelekEkleme.Show();
            this.Close();   
        }
    }
}
