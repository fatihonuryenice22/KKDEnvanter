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
    /// Stokdetay4.xaml etkileşim mantığı
    /// </summary>
    public partial class Stokdetay4 : Window
    {
        private MyVariables _variables = new MyVariables();
        public Stokdetay4()
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
                MyTextBlock.Text=_variables.YGEldivenEtiler.ToString();
                ygemirgan.Text=_variables.YGEldivenEmirgan.ToString();
                kaynaketiler.Text=_variables.KaynakEldivenEtiler.ToString();
                kaynakemirgan.Text=_variables.KaynakEldivenEmirgan.ToString() ;
                asitöetiler.Text=_variables.asidOnlukEtiler.ToString();
                asitöemirgan.Text = _variables.asidonlukEmirgan.ToString();
                kaynaköemirgan.Text = _variables.kaynakOnlukEmirgan.ToString();
                kaynaköetiler.Text=_variables.kaynakOnlukEtiler.ToString() ;
                int yg1 = _variables.YGEldivenEtiler;
                int yg2 = _variables.YGEldivenEmirgan;
                int toplamyg = yg1 + yg2;
                Toplam1.Text= toplamyg.ToString();
                int eldiven1 = _variables.KaynakEldivenEtiler;
                int eldiven2 = _variables.KaynakEldivenEmirgan;
                int toplameldiven=eldiven1 + eldiven2;
                Toplam2.Text= toplameldiven.ToString();
                int asit1 = _variables.asidonlukEmirgan;
                int asit2 = _variables.asidOnlukEtiler;
                int toplamasit= asit1 + asit2;
                Toplam3.Text= toplamasit.ToString();
                int kaynako1 = _variables.kaynakOnlukEmirgan;
                int kaynako2 = _variables.kaynakOnlukEtiler;
                int toplamkaynak= kaynako1+ kaynako2;
                Toplam4.Text= toplamkaynak.ToString();
                SmallTyEtiler.Text=_variables.tyvekEtilerS.ToString();
                SmallTyEmirgan.Text=_variables.tyvekEmirganS.ToString();
                int tys1 = _variables.tyvekEtilerS;
                int tys2 = _variables.tyvekEmirganS;
                int toplamtys= tys1 + tys2;
                ToplamTy1.Text= toplamtys.ToString();
                MediamTyEtiler.Text=_variables.tyvekEtilerM.ToString();
                MediumTyEmirgan.Text=_variables.tyvekEmirganM.ToString();
                int tym1 = _variables.tyvekEtilerM;
                int tym2 = _variables.tyvekEmirganM;
                int toplamtym= tym1 + tym2;
                ToplamTy2.Text= toplamtym.ToString();
                LargeTyEtiler.Text=_variables.tyvekEtilerl.ToString();
                LargeTyEmirgan.Text = _variables.tyvekEmirganl.ToString();
                int tyl1 = _variables.tyvekEmirganl;
                int tyl2 = _variables.tyvekEtilerl;
                int toplamtyl= tyl1 + tyl2;
                ToplamTy3.Text= toplamtyl.ToString();
                xlargeTyEtiler.Text = _variables.tyvekEtilerXL.ToString();
                xlargeTyEmirgan.Text=_variables.tyvekEmirganXL.ToString();
                int tyxl1 = _variables.tyvekEtilerXL;
                int tyxl2 = _variables.tyvekEmirganXL;
                int toplamtyxl= tyxl1 + tyxl2;
                ToplamTy4.Text= toplamtyxl.ToString();
               xxlargeTyEtiler.Text=_variables.tyvekEtilerXXL.ToString();
                xxlargeTyEmirgan.Text=_variables.tyvekEmirganXXL.ToString();
                int tyxxl1=_variables.tyvekEtilerXXL;
                int tyxxl2=_variables.tyvekEmirganXXL;
                int toplamxxl= tyxxl1 + tyxxl2;
                ToplamTy5.Text= toplamxxl.ToString();
                ////////////////////////////////////////////////////////////////////
                ///
                SmallTyEtiler_Kopyala.Text = _variables.yelekEtilerS.ToString();
                SmallTyEmirgan_Kopyala.Text = _variables.yelekEmirganS.ToString();
                int tys11 = _variables.yelekEtilerS;
                int tys21 = _variables.yelekEmirganS;
                int toplamtys1 = tys11 + tys21;
                ToplamTy1_Kopyala.Text = toplamtys1.ToString();
                MediamTyEtiler_Kopyala.Text = _variables.yelekEtilerM.ToString();
                MediumTyEmirgan_Kopyala.Text = _variables.yelekEmirganM.ToString();
                int tym11 = _variables.yelekEtilerM;
                int tym21 = _variables.yelekEmirganM;
                int toplamtym1 = tym11 + tym21;
                ToplamTy2_Kopyala.Text = toplamtym1.ToString();
                LargeTyEtiler_Kopyala.Text = _variables.yelekEtilerl.ToString();
                LargeTyEmirgan_Kopyala.Text = _variables.yelekEmirganl.ToString();
                int tyl11 = _variables.yelekEtilerl;
                int tyl21 = _variables.yelekEmirganl;
                int toplamtyl1 = tyl11 + tyl21;
                ToplamTy3_Kopyala.Text = toplamtyl1.ToString();
                xlargeTyEtiler_Kopyala.Text = _variables.yelekEtilerXL.ToString();
                xlargeTyEmirgan_Kopyala.Text = _variables.yelekEmirganXL.ToString();
                int tyxl11 = _variables.yelekEtilerXL;
                int tyxl21 = _variables.yelekEmirganXL;
                int toplamtyxl1 = tyxl11 + tyxl21;
                ToplamTy4_Kopyala.Text = toplamtyxl1.ToString();
                xxlargeTyEtiler_Kopyala.Text = _variables.yelekEtilerXXL.ToString();
                xxlargeTyEmirgan_Kopyala.Text = _variables.yelekEmirganXXL.ToString();
                int tyxxl11 = _variables.yelekEtilerXXL;
                int tyxxl21 = _variables.yelekEmirganXXL;
                int toplamxxl1 = tyxxl11 + tyxxl21;
                ToplamTy5_Kopyala.Text = toplamxxl1.ToString();


            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Stokdetay5 stokdetay5 = new Stokdetay5();
            stokdetay5.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}