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
    /// Stokdetay3.xaml etkileşim mantığı
    /// </summary>
    public partial class Stokdetay3 : Window
    {
        private MyVariables _variables = new MyVariables();
        public Stokdetay3()
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
                tozemirgan.Text = _variables.tozMaskeEmirgan.ToString();
                MyTextBlock.Text = _variables.tozMaskeEtiler.ToString();
                gazetiler.Text = _variables.gazFiltreEtiler.ToString();
                gazemirgan.Text=_variables.gazFiltreEmirgan.ToString();
                int toz1 = _variables.tozMaskeEtiler;
                int toz2 = _variables.tozMaskeEmirgan;
                int toplamtoz=toz1+ toz2;
                Toplam1.Text=toplamtoz.ToString();
                int gaz1 = _variables.gazFiltreEmirgan;
                int gaz2 = _variables.gazFiltreEtiler;
                int toplamgaz = gaz1+ gaz2;
                Toplam2.Text=toplamgaz.ToString();
                etiler8.Text=_variables.isEldiveni8Etiler.ToString();
                etiler9.Text = _variables.isEldiveni9Etiler.ToString();
                etiler10.Text = _variables.isEldiveni10Etiler.ToString();
                etiler11.Text = _variables.isEldiveni11Etiler.ToString();
                emirgan8.Text = _variables.isEldiveni8Emirgan.ToString();
                emirgan9.Text = _variables.isEldiveni9Emirgan.ToString();
                emirgan10.Text = _variables.isEldiveni10Emirgan.ToString();
                emirgan11.Text = _variables.isEldiveni11Emirgan.ToString();
                kimyasaletiler.Text=_variables.kdEldivenEtiler.ToString();
                kimyasalemirgan.Text=_variables.kdEldivenEmirgan.ToString() ;
                yalıtkanetiler.Text=_variables.yalitkanEldEtiler.ToString();
                yalıtkanemirgan.Text = _variables.yalitkenEldEmirgan.ToString();
                int sekiz1 = _variables.isEldiveni8Etiler;
                int sekiz2 = _variables.isEldiveni8Emirgan;
                int toplamsekiz = sekiz1 + sekiz2;
                Toplam3.Text=toplamsekiz.ToString();
                int dokuz1 = _variables.isEldiveni9Etiler;
                int dokuz2 = _variables.isEldiveni9Emirgan;
                int toplamdokuz= dokuz1 + dokuz2;
                Toplam4.Text=toplamdokuz.ToString();
                int on1 = _variables.isEldiveni10Emirgan;
                int on2 = _variables.isEldiveni10Etiler;
                int toplamon= on1 + on2;
                Toplam5.Text=toplamon.ToString();
                int on11 = _variables.isEldiveni11Emirgan;
                int on112=_variables.isEldiveni11Etiler;
                int toplam11 = on11 + on112;
                Toplam6.Text=toplam11.ToString();
                int kimyasal1 = _variables.kdEldivenEmirgan;
                int kimyasal2 = _variables.kdEldivenEtiler;
                int toplamkimyasal= kimyasal1 + kimyasal2;
                Toplam7.Text=toplamkimyasal.ToString();
                int yalitkan1 = _variables.yalitkanEldEtiler;
                int yalitkan2 = _variables.yalitkenEldEmirgan;
                int toplamyalitkan= yalitkan1 + yalitkan2;
                Toplam8.Text=toplamyalitkan.ToString();
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
            Stokdetay4 stokdetay4 = new Stokdetay4();
            stokdetay4.Show();
            this.Close();
        }
    }
}
