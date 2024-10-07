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
    /// StokDetaySayfa2.xaml etkileşim mantığı
    /// </summary>
    public partial class StokDetaySayfa2 : Window
    {
        private MyVariables _variables = new MyVariables();
        public StokDetaySayfa2()
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
            if (_variables != null)
            {
                MyTextBlock.Text = _variables.tozEtiler.ToString();
                tozemirgan.Text=_variables.tozEmirgan.ToString();
                gustutozetiler.Text = _variables.gustuTozEtiler.ToString();
                gustuemirgan.Text = _variables.gustuTozEmirgan.ToString();
                kaynaketiler.Text=_variables.kaynakGozEtiler.ToString() ;
                kaynakemirgan.Text=_variables.kaynakGozEmirgan.ToString() ;
                gustukaynak.Text=_variables.gustuKaynakEtiler.ToString() ;
                gustukaynakemirgan.Text=_variables.gustuKaynakEmirgan .ToString();
                karemirgan.Text=_variables.karEmirgan.ToString();
                karetiler.Text=_variables.karEtiler.ToString();
                siperetiler.Text=_variables.siperEtiler .ToString();
                siperemirgan.Text = _variables.siperEmirgan.ToString();
                tamyuzemirgan.Text = _variables.tamMaskeEmirgan.ToString();
                tamyuzetiler.Text=_variables.tamMaskeEtiler.ToString();
                aketiler.Text=_variables.akEtiler.ToString();
                akemirgan.Text = _variables.akEmirgan.ToString();
                int tozetiler1 = _variables.tozEtiler;
                int tozemirgan1 = _variables.tozEmirgan;
                int toplamtoz = tozetiler1 + tozemirgan1;
                ToplamBaret.Text= toplamtoz.ToString();
                int gustutoz1 = _variables.gustuTozEtiler;
                int gustutoz2 = _variables.gustuTozEmirgan;
                int toplamgustu= gustutoz1+ gustutoz2;
                ToplamRLBaret.Text = toplamgustu.ToString();
                int kaynak1 = _variables.kaynakGozEtiler;
                int kaynak2 = _variables.kaynakGozEmirgan;
                int toplamkaynak= kaynak1+ kaynak2;
                tterbandi.Text= toplamkaynak.ToString();
                int kaynak3 = _variables.gustuKaynakEtiler;
                int kaynak4 = _variables.gustuKaynakEmirgan;
                int toplamkaynak2 = kaynak3 + kaynak4;
                tlamba.Text= toplamkaynak2.ToString();
                int kar1 = _variables.karEtiler;
                int kar2 = _variables.karEmirgan;
                int toplamkar2= kar1 + kar2;
                tcenebandi.Text= toplamkar2.ToString();
                int siper1= _variables.siperEtiler;
                int siper2= _variables.siperEmirgan;
                int toplamsiper= siper1 + siper2;
                tygbaret.Text= toplamsiper.ToString();
                int tam1 = _variables.tamMaskeEtiler;
                int tam2=_variables.tamMaskeEmirgan;
                int toplamtam= tam1 + tam2;
                toplamkordon.Text= toplamtam.ToString();
                int ak1 = _variables.akEtiler;
                int ak2=_variables.akEmirgan;
                int toplamak= ak1 + ak2;
                toplammanson.Text= toplamak.ToString();

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
            Stokdetay3 stokdetay3 = new Stokdetay3();
            stokdetay3.Show();
            this.Close();
        }
    }
}