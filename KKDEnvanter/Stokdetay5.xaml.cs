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
    /// Stokdetay5.xaml etkileşim mantığı
    /// </summary>
    public partial class Stokdetay5 : Window
    {
        private MyVariables _variables = new MyVariables();
        public Stokdetay5()
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
                kislik36etiler.Text = _variables.kislikAyakkabiEtiler36.ToString();
                kislik36etiler_Kopyala.Text = _variables.kislikAyakkabiEmirgan36.ToString();
                int ayakkabi361 = _variables.kislikAyakkabiEtiler36;
                int ayakkabi362 = _variables.kislikAyakkabiEmirgan36;
                int toplam36 = ayakkabi361 + ayakkabi362;
                kislik36etiler_Kopyala1.Text = toplam36.ToString();
                kislik37etiler.Text = _variables.kislikAyakkabiEtiler37.ToString();
                kislik37etiler_Kopyala.Text = _variables.kislikAyakkabiEmirgan37.ToString();
                int ayakkabi371 = _variables.kislikAyakkabiEtiler37;
                int ayakkabi372 = _variables.kislikAyakkabiEmirgan37;
                int toplam37 = ayakkabi371 + ayakkabi372;
                kislik37etiler_Kopyala1.Text = toplam37.ToString();
                kislik38etiler.Text = _variables.kislikAyakkabiEtiler38.ToString();
                kislik38etiler_Kopyala.Text = _variables.kislikAyakkabiEmirgan38.ToString();
                int ayakkabi381 = _variables.kislikAyakkabiEtiler38;
                int ayakkabi382 = _variables.kislikAyakkabiEmirgan38;
                int toplam38 = ayakkabi381 + ayakkabi382;
                kislik38etiler_Kopyala1.Text = toplam38.ToString();
                kislik39etiler.Text = _variables.kislikAyakkabiEtiler39.ToString();
                kislik39etiler_Kopyala.Text = _variables.kislikAyakkabiEmirgan39.ToString();
                int ayakkabi391 = _variables.kislikAyakkabiEtiler39;
                int ayakkabi392 = _variables.kislikAyakkabiEmirgan39;
                int toplam39 = ayakkabi391 + ayakkabi392;
                kislik39etiler_Kopyala1.Text = toplam39.ToString();
                kislik40etiler.Text = _variables.kislikAyakkabiEtiler40.ToString();
                kislik40etiler_Kopyala.Text = _variables.kislikAyakkabiEmirgan40.ToString();
                int ayakkabi401 = _variables.kislikAyakkabiEtiler40;
                int ayakkabi402 = _variables.kislikAyakkabiEmirgan40;
                int toplam40 = ayakkabi401 + ayakkabi402;
                kislik40etiler_Kopyala1.Text = toplam40.ToString();
                kislik41etiler.Text = _variables.kislikAyakkabiEtiler41.ToString();
                kislik41etiler_Kopyala.Text = _variables.kislikAyakkabiEmirgan41.ToString();
                int ayakkabi411 = _variables.kislikAyakkabiEtiler41;
                int ayakkabi412 = _variables.kislikAyakkabiEmirgan41;
                int toplam41 = ayakkabi411 + ayakkabi412;
                kislik41etiler_Kopyala1.Text = toplam41.ToString();
                kisliketiler42.Text = _variables.kislikAyakkabiEtiler42.ToString();
                kisliketiler42_Kopyala.Text = _variables.kislikAyakkabiEmirgan42.ToString();
                int ayakkabi421 = _variables.kislikAyakkabiEtiler42;
                int ayakkabi422 = _variables.kislikAyakkabiEmirgan42;
                int toplam42 = ayakkabi421 + ayakkabi422;
                kisliketiler42_Kopyala1.Text = toplam42.ToString();
                kisliketiler43.Text = _variables.kislikAyakkabiEtiler43.ToString();
                kisliketiler43_Kopyala.Text = _variables.kislikAyakkabiEmirgan43.ToString();
                int ayakkabi431 = _variables.kislikAyakkabiEtiler43;
                int ayakkabi432 = _variables.kislikAyakkabiEmirgan43;
                int toplam43 = ayakkabi431 + ayakkabi432;
                kisliketiler43_Kopyala1.Text = toplam43.ToString();
                kisliketiler44.Text = _variables.kislikAyakkabiEtiler44.ToString();
                kisliketiler44_Kopyala.Text = _variables.kislikAyakkabiEmirgan44.ToString();
                int ayakkabi441 = _variables.kislikAyakkabiEtiler44;
                int ayakkabi442 = _variables.kislikAyakkabiEmirgan44;
                int toplam44 = ayakkabi441 + ayakkabi442;
                kisliketiler44_Kopyala1.Text = toplam44.ToString();
                kisliketiler45.Text = _variables.kislikAyakkabiEtiler45.ToString();
                kisliketiler45_Kopyala.Text = _variables.kislikAyakkabiEmirgan45.ToString();
                int ayakkabi451 = _variables.kislikAyakkabiEtiler45;
                int ayakkabi452 = _variables.kislikAyakkabiEmirgan45;
                int toplam45 = ayakkabi451 + ayakkabi452;
                kisliketiler45_Kopyala1.Text = toplam45.ToString();
                kisliketiler46.Text = _variables.kislikAyakkabiEtiler46.ToString();
                kisliketiler46_Kopyala.Text = _variables.kislikAyakkabiEmirgan46.ToString();
                int ayakkabi461 = _variables.kislikAyakkabiEtiler46;
                int ayakkabi462 = _variables.kislikAyakkabiEmirgan46;
                int toplam46 = ayakkabi461 + ayakkabi462;
                kisliketiler46_Kopyala1.Text = toplam46.ToString();
                kisliketiler47.Text = _variables.kislikAyakkabiEtiler47.ToString();
                kisliketiler47_Kopyala.Text = _variables.kislikAyakkabiEmirgan47.ToString();
                int ayakkabi471 = _variables.kislikAyakkabiEtiler47;
                int ayakkabi472 = _variables.kislikAyakkabiEmirgan47;
                int toplam47 = ayakkabi471 + ayakkabi472;
                kisliketiler47_Kopyala1.Text = toplam47.ToString();
                kisliketiler48.Text = _variables.kislikAyakkabiEtiler48.ToString();
                kisliketiler48_Kopyala.Text = _variables.kislikAyakkabiEmirgan48.ToString();
                int ayakkabi481 = _variables.kislikAyakkabiEtiler48;
                int ayakkabi482 = _variables.kislikAyakkabiEmirgan48;
                int toplam48 = ayakkabi481 + ayakkabi482;
                kisliketiler48_Kopyala1.Text = toplam48.ToString();
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                yazlik36etiler.Text = _variables.yazlikAyakkabiEtiler36.ToString();
                yazlik36etiler_Kopyala.Text = _variables.yazlikAyakkabiEmirgan36.ToString();
                int ayakkabi3612 = _variables.yazlikAyakkabiEtiler36;
                int ayakkabi3622 = _variables.yazlikAyakkabiEmirgan36;
                int toplam362 = ayakkabi3612 + ayakkabi3622;
                yazlik36etiler_Kopyala1.Text = toplam362.ToString();
                yazlik37etiler.Text = _variables.yazlikAyakkabiEtiler37.ToString();
                yazlik37etiler_Kopyala.Text = _variables.yazlikAyakkabiEmirgan37.ToString();
                int ayakkabi3712 = _variables.yazlikAyakkabiEtiler37;
                int ayakkabi3722 = _variables.yazlikAyakkabiEmirgan37;
                int toplam372 = ayakkabi3712 + ayakkabi3722;
                yazlik37etiler_Kopyala1.Text = toplam372.ToString();
                yazlik38etiler.Text = _variables.yazlikAyakkabiEtiler38.ToString();
                yazlik38etiler_Kopyala.Text = _variables.yazlikAyakkabiEmirgan38.ToString();
                int ayakkabi3812 = _variables.yazlikAyakkabiEtiler38;
                int ayakkabi3822 = _variables.yazlikAyakkabiEmirgan38;
                int toplam382 = ayakkabi3812 + ayakkabi3822;
                yazlik38etiler_Kopyala1.Text = toplam382.ToString();
                yazlik39etiler.Text = _variables.yazlikAyakkabiEtiler39.ToString();
                yazlik39etiler_Kopyala.Text = _variables.yazlikAyakkabiEmirgan39.ToString();
                int ayakkabi3912 = _variables.yazlikAyakkabiEtiler39;
                int ayakkabi3922 = _variables.yazlikAyakkabiEmirgan39;
                int toplam392 = ayakkabi3912 + ayakkabi3922;
                yazlik39etiler_Kopyala1.Text = toplam392.ToString();
                yazlik40etiler.Text = _variables.yazlikAyakkabiEtiler40.ToString();
                yazlik40etiler_Kopyala.Text = _variables.yazlikAyakkabiEmirgan40.ToString();
                int ayakkabi4012 = _variables.yazlikAyakkabiEtiler40;
                int ayakkabi4022 = _variables.yazlikAyakkabiEmirgan40;
                int toplam402 = ayakkabi4012 + ayakkabi4022;
                yazlik40etiler_Kopyala1.Text = toplam402.ToString();
                yazlik41etiler.Text = _variables.yazlikAyakkabiEtiler41.ToString();
                yazlik41etiler_Kopyala.Text = _variables.yazlikAyakkabiEmirgan41.ToString();
                int ayakkabi4112 = _variables.yazlikAyakkabiEtiler41;
                int ayakkabi4122 = _variables.yazlikAyakkabiEmirgan41;
                int toplam412 = ayakkabi411 + ayakkabi412;
                yazlik41etiler_Kopyala1.Text = toplam412.ToString();
                yazliketiler42.Text = _variables.yazlikAyakkabiEtiler42.ToString();
                yazliketiler42_Kopyala.Text = _variables.yazlikAyakkabiEmirgan42.ToString();
                int ayakkabi4212 = _variables.yazlikAyakkabiEtiler42;
                int ayakkabi4222 = _variables.yazlikAyakkabiEmirgan42;
                int toplam422 = ayakkabi421 + ayakkabi422;
                yazliketiler42_Kopyala1.Text = toplam422.ToString();
                yazliketiler43.Text = _variables.yazlikAyakkabiEtiler43.ToString();
                yazliketiler43_Kopyala.Text = _variables.yazlikAyakkabiEmirgan43.ToString();
                int ayakkabi4312 = _variables.yazlikAyakkabiEtiler43;
                int ayakkabi4322 = _variables.yazlikAyakkabiEmirgan43;
                int toplam432 = ayakkabi4312 + ayakkabi4322;
                yazliketiler43_Kopyala1.Text = toplam432.ToString();
                yazliketiler44.Text = _variables.yazlikAyakkabiEtiler44.ToString();
                yazliketiler44_Kopyala.Text = _variables.yazlikAyakkabiEmirgan44.ToString();
                int ayakkabi4412 = _variables.yazlikAyakkabiEtiler44;
                int ayakkabi4422 = _variables.yazlikAyakkabiEmirgan44;
                int toplam442 = ayakkabi4412 + ayakkabi4422;
                yazliketiler44_Kopyala1.Text = toplam442.ToString();
                yazliketiler45.Text = _variables.yazlikAyakkabiEtiler45.ToString();
                yazliketiler45_Kopyala.Text = _variables.yazlikAyakkabiEmirgan45.ToString();
                int ayakkabi4512 = _variables.yazlikAyakkabiEtiler45;
                int ayakkabi4522 = _variables.yazlikAyakkabiEmirgan45;
                int toplam452 = ayakkabi4512 + ayakkabi4522;
                yazliketiler45_Kopyala1.Text = toplam452.ToString();
                yazliketiler46.Text = _variables.yazlikAyakkabiEtiler46.ToString();
                yazliketiler46_Kopyala.Text = _variables.yazlikAyakkabiEmirgan46.ToString();
                int ayakkabi4612 = _variables.yazlikAyakkabiEtiler46;
                int ayakkabi4622 = _variables.yazlikAyakkabiEmirgan46;
                int toplam462 = ayakkabi4612 + ayakkabi4622;
                yazliketiler46_Kopyala1.Text = toplam46.ToString();
                yazliketiler47.Text = _variables.yazlikAyakkabiEtiler47.ToString();
                yazliketiler47_Kopyala.Text = _variables.yazlikAyakkabiEmirgan47.ToString();
                int ayakkabi4712 = _variables.yazlikAyakkabiEtiler47;
                int ayakkabi4722 = _variables.yazlikAyakkabiEmirgan47;
                int toplam472 = ayakkabi4712 + ayakkabi4722;
                yazliketiler47_Kopyala1.Text = toplam472.ToString();
                yazliketiler48.Text = _variables.yazlikAyakkabiEtiler48.ToString();
                yazliketiler48_Kopyala.Text = _variables.yazlikAyakkabiEmirgan48.ToString();
                int ayakkabi4812 = _variables.yazlikAyakkabiEtiler48;
                int ayakkabi4822 = _variables.yazlikAyakkabiEmirgan48;
                int toplam482 = ayakkabi481 + ayakkabi482;
                yazliketiler48_Kopyala1.Text = toplam482.ToString();
                /////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///
                cizme36etiler.Text = _variables.CizmeEtiler36.ToString();
                cizme36etiler_Kopyala.Text = _variables.CizmeEmirgan36.ToString();
                int ayakkabi3613 = _variables.CizmeEtiler36;
                int ayakkabi3623 = _variables.CizmeEmirgan36;
                int toplam363 = ayakkabi3613 + ayakkabi3623;
                cizme36etiler_Kopyala1.Text = toplam363.ToString();
                cizme37etiler.Text = _variables.CizmeEtiler37.ToString();
                cizme37etiler_Kopyala.Text = _variables.CizmeEmirgan37.ToString();
                int ayakkabi3713 = _variables.CizmeEtiler37;
                int ayakkabi3723 = _variables.CizmeEmirgan37;
                int toplam373 = ayakkabi3713 + ayakkabi3723;
                cizme37etiler_Kopyala1.Text = toplam373.ToString();
                cizme38etiler.Text = _variables.CizmeEtiler38.ToString();
                cizme38etiler_Kopyala.Text = _variables.CizmeEmirgan38.ToString();
                int ayakkabi3813 = _variables.CizmeEtiler38;
                int ayakkabi3823 = _variables.CizmeEmirgan38;
                int toplam383 = ayakkabi3813 + ayakkabi3823;
                cizme38etiler_Kopyala1.Text = toplam383.ToString();
                cizme39etiler.Text = _variables.CizmeEtiler39.ToString();
                cizme39etiler_Kopyala.Text = _variables.CizmeEmirgan39.ToString();
                int ayakkabi3913 = _variables.CizmeEtiler39;
                int ayakkabi3923 = _variables.CizmeEmirgan39;
                int toplam393 = ayakkabi3913 + ayakkabi3923;
                cizme39etiler_Kopyala1.Text = toplam393.ToString();
                cizme40etiler.Text = _variables.CizmeEtiler40.ToString();
                cizme40etiler_Kopyala.Text = _variables.CizmeEmirgan40.ToString();
                int ayakkabi4013 = _variables.CizmeEtiler40;
                int ayakkabi4023 = _variables.CizmeEmirgan40;
                int toplam403 = ayakkabi4013 + ayakkabi4023;
                cizme40etiler_Kopyala1.Text = toplam403.ToString();
                cizme41etiler.Text = _variables.CizmeEtiler41.ToString();
                cizme41etiler_Kopyala.Text = _variables.CizmeEmirgan41.ToString();
                int ayakkabi4113 = _variables.CizmeEtiler41;
                int ayakkabi4123 = _variables.CizmeEmirgan41;
                int toplam413 = ayakkabi4113 + ayakkabi4123;
                cizme41etiler_Kopyala1.Text = toplam413.ToString();
                cizmeetiler42.Text = _variables.CizmeEtiler42.ToString();
                cizmeetiler42_Kopyala.Text = _variables.CizmeEmirgan42.ToString();
                int ayakkabi4213 = _variables.CizmeEtiler42;
                int ayakkabi4223 = _variables.CizmeEmirgan42;
                int toplam423 = ayakkabi4213 + ayakkabi4223;
                cizmeetiler42_Kopyala1.Text = toplam423.ToString();
                cizmeetiler43.Text = _variables.CizmeEtiler43.ToString();
                cizmeetiler43_Kopyala.Text = _variables.CizmeEmirgan43.ToString();
                int ayakkabi4313 = _variables.CizmeEtiler43;
                int ayakkabi4323 = _variables.CizmeEmirgan43;
                int toplam433 = ayakkabi4313 + ayakkabi4323;
                cizmeetiler43_Kopyala1.Text = toplam433.ToString();
                cizmeetiler44.Text = _variables.CizmeEtiler44.ToString();
                cizmeetiler44_Kopyala.Text = _variables.CizmeEmirgan44.ToString();
                int ayakkabi4413 = _variables.CizmeEtiler44;
                int ayakkabi4423 = _variables.CizmeEmirgan44;
                int toplam443 = ayakkabi4413 + ayakkabi4423;
                cizmeetiler44_Kopyala1.Text = toplam443.ToString();
                cizmeetiler45.Text = _variables.CizmeEtiler45.ToString();
                cizmeetiler45_Kopyala.Text = _variables.CizmeEmirgan45.ToString();
                int ayakkabi4513 = _variables.CizmeEtiler45;
                int ayakkabi4523 = _variables.CizmeEmirgan45;
                int toplam453 = ayakkabi4513 + ayakkabi4523;
                cizmeetiler45_Kopyala1.Text = toplam453.ToString();
                cizmeetiler46.Text = _variables.CizmeEtiler46.ToString();
                cizmeetiler46_Kopyala.Text = _variables.CizmeEmirgan46.ToString();
                int ayakkabi4613 = _variables.CizmeEtiler46;
                int ayakkabi4623 = _variables.CizmeEmirgan46;
                int toplam463 = ayakkabi4613 + ayakkabi4623;
                cizmeetiler46_Kopyala1.Text = toplam463.ToString();
                cizmeetiler47.Text = _variables.CizmeEtiler47.ToString();
                cizmeetiler47_Kopyala.Text = _variables.CizmeEmirgan47.ToString();
                int ayakkabi4713 = _variables.CizmeEtiler47;
                int ayakkabi4723 = _variables.CizmeEmirgan47;
                int toplam473 = ayakkabi4713 + ayakkabi4723;
                cizmeetiler47_Kopyala1.Text = toplam473.ToString();
                cizmeetiler48.Text = _variables.CizmeEtiler48.ToString();
                cizmeetiler48_Kopyala.Text = _variables.CizmeEmirgan48.ToString();
                int ayakkabi4813 = _variables.CizmeEtiler48;
                int ayakkabi4823 = _variables.CizmeEmirgan48;
                int toplam483 = ayakkabi4813 + ayakkabi4823;
                cizmeetiler48_Kopyala1.Text = toplam483.ToString();




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
            StokSayfası6 stokSayfası6 = new StokSayfası6();
            stokSayfası6.Show();
            this.Close();
        }
    }
}