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
    /// StokSayfası6.xaml etkileşim mantığı
    /// </summary>
    public partial class StokSayfası6 : Window
    {
        private MyVariables _variables = new MyVariables();

        public StokSayfası6()
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
                kasikcizme36etiler.Text = _variables.KasikCizmeEmirgan36.ToString();
                kasikcizme36etiler_Kopyala.Text = _variables.KasikCizmeEmirgan36.ToString();
                int ayakkabi3614 = _variables.KasikCizmeEtiler36;
                int ayakkabi3624 = _variables.KasikCizmeEmirgan36;
                int toplam364 = ayakkabi3614 + ayakkabi3624;
                kasikcizme36etiler_Kopyala1.Text = toplam364.ToString();
                kasikcizme37etiler.Text = _variables.KasikCizmeEtiler37.ToString();
                kasikcizme37etiler_Kopyala.Text = _variables.KasikCizmeEmirgan37.ToString();
                int ayakkabi3714 = _variables.KasikCizmeEtiler37;
                int ayakkabi3724 = _variables.KasikCizmeEmirgan37;
                int toplam374 = ayakkabi3714 + ayakkabi3724;
                kasikcizme37etiler_Kopyala1.Text = toplam374.ToString();
                kasikcizme38etiler.Text = _variables.KasikCizmeEtiler38.ToString();
                kasikcizme38etiler_Kopyala.Text = _variables.KasikCizmeEmirgan38.ToString();
                int ayakkabi3813 = _variables.KasikCizmeEtiler38;
                int ayakkabi3823 = _variables.KasikCizmeEmirgan38;
                int toplam383 = ayakkabi3813 + ayakkabi3823;
                kasikcizme38etiler_Kopyala1.Text = toplam383.ToString();
                kasikcizme39etiler.Text = _variables.KasikCizmeEtiler39.ToString();
                kasikcizme39etiler_Kopyala.Text = _variables.KasikCizmeEmirgan39.ToString();
                int ayakkabi3913 = _variables.KasikCizmeEtiler39;
                int ayakkabi3923 = _variables.KasikCizmeEmirgan39;
                int toplam393 = ayakkabi3913 + ayakkabi3923;
                kasikcizme39etiler_Kopyala1.Text = toplam393.ToString();
                kasikcizme40etiler.Text = _variables.KasikCizmeEtiler40.ToString();
                kasikcizme40etiler_Kopyala.Text = _variables.KasikCizmeEmirgan40.ToString();
                int ayakkabi4013 = _variables.KasikCizmeEtiler40;
                int ayakkabi4023 = _variables.KasikCizmeEmirgan40;
                int toplam403 = ayakkabi4013 + ayakkabi4023;
                kasikcizme40etiler_Kopyala1.Text = toplam403.ToString();
                kasikcizme41etiler.Text = _variables.KasikCizmeEtiler41.ToString();
                kasikcizme41etiler_Kopyala.Text = _variables.KasikCizmeEmirgan41.ToString();
                int ayakkabi4113 = _variables.KasikCizmeEtiler41;
                int ayakkabi4123 = _variables.KasikCizmeEmirgan41;
                int toplam413 = ayakkabi4113 + ayakkabi4123;
                kasikcizme41etiler_Kopyala1.Text = toplam413.ToString();
                kasikcizmeetiler42.Text = _variables.KasikCizmeEtiler42.ToString();
                kasikcizmeetiler42_Kopyala.Text = _variables.KasikCizmeEmirgan42.ToString();
                int ayakkabi4213 = _variables.KasikCizmeEtiler42;
                int ayakkabi4223 = _variables.KasikCizmeEmirgan42;
                int toplam423 = ayakkabi4213 + ayakkabi4223;
                kasikcizmeetiler42_Kopyala1.Text = toplam423.ToString();
                kasikcizmeetiler43.Text = _variables.KasikCizmeEtiler43.ToString();
                kasikcizmeetiler43_Kopyala.Text = _variables.KasikCizmeEmirgan43.ToString();
                int ayakkabi4313 = _variables.KasikCizmeEtiler43;
                int ayakkabi4323 = _variables.KasikCizmeEmirgan43;
                int toplam433 = ayakkabi4313 + ayakkabi4323;
                kasikcizmeetiler43_Kopyala1.Text = toplam433.ToString();
                kasikcizmeetiler44.Text = _variables.KasikCizmeEtiler44.ToString();
                kasikcizmeetiler44_Kopyala.Text = _variables.KasikCizmeEmirgan44.ToString();
                int ayakkabi4413 = _variables.KasikCizmeEtiler44;
                int ayakkabi4423 = _variables.KasikCizmeEmirgan44;
                int toplam443 = ayakkabi4413 + ayakkabi4423;
                kasikcizmeetiler44_Kopyala1.Text = toplam443.ToString();
                kasikcizmeetiler45.Text = _variables.KasikCizmeEtiler45.ToString();
                kasikcizmeetiler45_Kopyala.Text = _variables.KasikCizmeEmirgan45.ToString();
                int ayakkabi4513 = _variables.KasikCizmeEtiler45;
                int ayakkabi4523 = _variables.KasikCizmeEmirgan45;
                int toplam453 = ayakkabi4513 + ayakkabi4523;
                kasikcizmeetiler45_Kopyala1.Text = toplam453.ToString();
                kasikcizmeetiler46.Text = _variables.KasikCizmeEtiler46.ToString();
                kasikcizmeetiler46_Kopyala.Text = _variables.KasikCizmeEmirgan46.ToString();
                int ayakkabi4613 = _variables.KasikCizmeEtiler46;
                int ayakkabi4623 = _variables.KasikCizmeEmirgan46;
                int toplam463 = ayakkabi4613 + ayakkabi4623;
                kasikcizmeetiler46_Kopyala1.Text = toplam463.ToString();
                kasikcizmeetiler47.Text = _variables.KasikCizmeEtiler47.ToString();
                kasikcizmeetiler47_Kopyala.Text = _variables.KasikCizmeEmirgan47.ToString();
                int ayakkabi4713 = _variables.KasikCizmeEtiler47;
                int ayakkabi4723 = _variables.KasikCizmeEmirgan47;
                int toplam473 = ayakkabi4713 + ayakkabi4723;
                kasikcizmeetiler47_Kopyala1.Text = toplam473.ToString();
                kasiketiler48.Text = _variables.KasikCizmeEtiler48.ToString();
                kasikcizmeetiler48_Kopyala.Text = _variables.KasikCizmeEmirgan48.ToString();
                int ayakkabi4813 = _variables.KasikCizmeEtiler48;
                int ayakkabi4823 = _variables.KasikCizmeEmirgan48;
                int toplam483 = ayakkabi4813 + ayakkabi4823;
                kasikcizmeetiler48_Kopyala1.Text = toplam483.ToString();
                ////////////////////////////////////////////////////////////////////////////////////
                ///
                YGCizme36etiler.Text = _variables.YGCizmeEtiler36.ToString();
                YGCizme36etiler_Kopyala.Text = _variables.YGCizmeEmirgan36.ToString();
                int ayakkabi3615 = _variables.YGCizmeEtiler36;
                int ayakkabi3625 = _variables.YGCizmeEmirgan36;
                int toplam365 = ayakkabi3615 + ayakkabi3625;
                YGCizme36etiler_Kopyala1.Text = toplam365.ToString();
                YGCizme37etiler.Text = _variables.YGCizmeEtiler37.ToString();
                YGCizme37etiler_Kopyala.Text = _variables.YGCizmeEmirgan37.ToString();
                int ayakkabi3715 = _variables.YGCizmeEtiler37;
                int ayakkabi3725 = _variables.YGCizmeEmirgan37;
                int toplam375 = ayakkabi3715 + ayakkabi3725;
                YGCizme37etiler_Kopyala1.Text = toplam375.ToString();
                YGCizme38etiler.Text = _variables.YGCizmeEtiler38.ToString();
                YGCizme38etiler_Kopyala.Text = _variables.YGCizmeEmirgan38.ToString();
                int ayakkabi3815 = _variables.YGCizmeEtiler38;
                int ayakkabi3825 = _variables.YGCizmeEmirgan38;
                int toplam385 = ayakkabi3815 + ayakkabi3825;
                YGCizme38etiler_Kopyala1.Text = toplam385.ToString();
                YGCizme39etiler.Text = _variables.YGCizmeEtiler39.ToString();
                YGCizme39etiler_Kopyala.Text = _variables.YGCizmeEmirgan39.ToString();
                int ayakkabi3915 = _variables.YGCizmeEtiler39;
                int ayakkabi3925 = _variables.YGCizmeEmirgan39;
                int toplam395 = ayakkabi3915 + ayakkabi3925;
                YGCizme39etiler_Kopyala1.Text = toplam395.ToString();
               YGCizme40etiler.Text = _variables.YGCizmeEtiler40.ToString();
                YGCizme40etiler_Kopyala.Text = _variables.YGCizmeEmirgan40.ToString();
                int ayakkabi4015 = _variables.YGCizmeEtiler40;
                int ayakkabi4025 = _variables.YGCizmeEmirgan40;
                int toplam405 = ayakkabi4015 + ayakkabi4025;
                YGCizme40etiler_Kopyala1.Text = toplam405.ToString();
                YGCizme41etiler.Text = _variables.YGCizmeEtiler41.ToString();
                YGCizme41etiler_Kopyala.Text = _variables.YGCizmeEmirgan41.ToString();
                int ayakkabi4115 = _variables.YGCizmeEtiler41;
                int ayakkabi4125 = _variables.YGCizmeEmirgan41;
                int toplam415 = ayakkabi4115 + ayakkabi4125;
                YGCizme41etiler_Kopyala1.Text = toplam415.ToString();
                YGCizmeetiler42.Text = _variables.YGCizmeEtiler42.ToString();
                YGCizmeetiler42_Kopyala.Text = _variables.YGCizmeEmirgan42.ToString();
                int ayakkabi4215 = _variables.YGCizmeEtiler42;
                int ayakkabi4225 = _variables.YGCizmeEmirgan42;
                int toplam425 = ayakkabi4215 + ayakkabi4225;
                YGCizmeetiler42_Kopyala1.Text = toplam425.ToString();
                YGCizmeetiler43.Text = _variables.YGCizmeEtiler43.ToString();
                YGCizmeetiler43_Kopyala.Text = _variables.YGCizmeEmirgan43.ToString();
                int ayakkabi4315 = _variables.YGCizmeEtiler43;
                int ayakkabi4325 = _variables.YGCizmeEmirgan43;
                int toplam435 = ayakkabi4315 + ayakkabi4325;
                YGCizmeetiler43_Kopyala1.Text = toplam435.ToString();
                YGCizmeetiler44.Text = _variables.YGCizmeEtiler44.ToString();
                YGCizmeetiler44_Kopyala.Text = _variables.YGCizmeEmirgan44.ToString();
                int ayakkabi4415 = _variables.YGCizmeEtiler44;
                int ayakkabi4425 = _variables.YGCizmeEmirgan44;
                int toplam445 = ayakkabi4415 + ayakkabi4425;
                YGCizmeetiler44_Kopyala1.Text = toplam445.ToString();
                YGCizmeetiler45.Text = _variables.YGCizmeEtiler45.ToString();
                YGCizmeetiler45_Kopyala.Text = _variables.YGCizmeEmirgan45.ToString();
                int ayakkabi4515 = _variables.YGCizmeEtiler45;
                int ayakkabi4525 = _variables.YGCizmeEmirgan45;
                int toplam455 = ayakkabi4515 + ayakkabi4525;
                YGCizmeetiler45_Kopyala1.Text = toplam455.ToString();
                YGCizmeetiler46.Text = _variables.YGCizmeEtiler46.ToString();
                YGCizmeetiler46_Kopyala.Text = _variables.YGCizmeEmirgan46.ToString();
                int ayakkabi4615 = _variables.YGCizmeEtiler46;
                int ayakkabi4625 = _variables.YGCizmeEmirgan46;
                int toplam465 = ayakkabi4615 + ayakkabi4625;
                YGCizmeetiler46_Kopyala1.Text = toplam465.ToString();
                YGCizmeetiler47.Text = _variables.YGCizmeEtiler47.ToString();
                YGCizmeetiler47_Kopyala.Text = _variables.YGCizmeEmirgan47.ToString();
                int ayakkabi4715 = _variables.YGCizmeEtiler47;
                int ayakkabi4725 = _variables.YGCizmeEmirgan47;
                int toplam475 = ayakkabi4715 + ayakkabi4725;
                YGCizmeetiler47_Kopyala1.Text = toplam475.ToString();
                YGCizmeetiler48.Text = _variables.YGCizmeEtiler48.ToString();
                YGCizmeetiler48_Kopyala.Text = _variables.YGCizmeEmirgan48.ToString();
                int ayakkabi4815 = _variables.YGCizmeEtiler48;
                int ayakkabi4825 = _variables.YGCizmeEmirgan48;
                int toplam485 = ayakkabi4815 + ayakkabi4825;
                YGCizmeetiler48_Kopyala1.Text = toplam485.ToString();
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StokSayfası7 stokSayfası7 = new StokSayfası7();
            stokSayfası7.Show();
            this.Close();
        }
    }
}