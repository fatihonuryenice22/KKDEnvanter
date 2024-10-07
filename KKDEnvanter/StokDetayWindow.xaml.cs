using KKDEnvanter.myModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// StokDetayWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class StokDetayWindow : Window
    {
        private MyVariables _variables = new MyVariables();
        public StokDetayWindow()
        {
            InitializeComponent();
            LoadData();
            DisplayData();
        }
        private void LoadData()
        {
            if (File.Exists("emirganData.txt"))
            {
                var json = File.ReadAllText("emirganData.txt");
                _variables = JsonConvert.DeserializeObject<MyVariables>(json);
            }
            else
            {
                _variables = new MyVariables();
            }
        }
        private void SaveData(MyVariables variables)
        {
            var json = JsonConvert.SerializeObject(variables, Formatting.Indented);
            File.WriteAllText("emirganData.txt", json);

        }
        private void updateValues()
        {
            //
        }
        private void DisplayData()
        {
            if (_variables != null) {
                MyTextBlock.Text = _variables.baretEtiler.ToString();
                baretemirgan.Text=_variables.baretEmirgan.ToString();
                RLEmirgan.Text = _variables.RLbaretEmirgan.ToString();
                RLEtiler.Text = _variables.RLbaretEtiler.ToString();
                teretiler.Text=_variables.terBandiEtiler.ToString();
                teremirgan.Text=_variables.terBandiEmirgan.ToString() ;
                lambaetiler.Text=_variables.lambaEtiler.ToString();
                lambaemirgan.Text = _variables.lambaEmirgan.ToString();
                cenebandiemirgan.Text = _variables.cenebandiEmirgan.ToString();
                cenebandietiler.Text=_variables.ceneBandiEtiler.ToString() ;
                YGemirgan.Text = _variables.YGbaretEmirgan.ToString();
                YGetiler.Text=_variables.YGbaretEtiler.ToString();
                kordonluemirgan.Text = _variables.kordonTikacEmirgan.ToString();
                kordonluetiler.Text=_variables.kordonTikacEtiler.ToString();
                mansonluetiler.Text=_variables.mansonluEtiler.ToString();
                mansonluemirgan.Text = _variables.mansonluEmirgan.ToString();
                // Toplamlar
                int etilerbaretler = _variables.baretEtiler;
                int emirganbaretler = _variables.baretEmirgan;
                int toplambarett = etilerbaretler + emirganbaretler;
                ToplamBaret.Text=toplambarett.ToString();
                int rlemirgan = _variables.RLbaretEmirgan;
                int rletiler = _variables.RLbaretEtiler;
                int toplamrlbaret= rlemirgan+rletiler;
                ToplamRLBaret.Text= toplamrlbaret.ToString();
                int terbetiler = _variables.terBandiEtiler;
                int terbemirgan = _variables.terBandiEmirgan;
                int toplamter = terbemirgan + terbetiler;
                tterbandi.Text= toplamter.ToString();
                int lmbetiler = _variables.lambaEtiler;
                int lmbemirgan=_variables.lambaEmirgan;
                int toplamlmb=lmbemirgan+lmbetiler;
                tlamba.Text= toplamlmb.ToString();
                int ceneetiler = _variables.ceneBandiEtiler;
                int ceneemirgan = _variables.cenebandiEmirgan;
                int toplamcene = ceneetiler + ceneemirgan;
                tcenebandi.Text= toplamcene.ToString();
                int ygetiler = _variables.YGbaretEtiler;
                int ygemirgan = _variables.YGbaretEmirgan;
                int toplamyg = ygetiler + ygemirgan;
                tygbaret.Text= toplamyg.ToString();
                int mansonetiler = _variables.mansonluEtiler;
                int mansonemirgan = _variables.mansonluEmirgan;
                int toplamanson = mansonetiler + mansonemirgan;
                toplammanson.Text= toplamanson.ToString();
                int kEtiler = _variables.kordonTikacEtiler;
                int kEmirgan = _variables.kordonTikacEmirgan;
                int toplamk= kEmirgan + kEtiler;
                toplamkordon.Text= toplamk.ToString();

            }


            
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            StokDetaySayfa2 stokDetaySayfa2 = new StokDetaySayfa2();
            stokDetaySayfa2.Show();
            this.Close();
        }
    }
}