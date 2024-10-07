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
    /// StokSayfası7.xaml etkileşim mantığı
    /// </summary>
    public partial class StokSayfası7 : Window
    {
        private MyVariables _variables = new MyVariables();
        public StokSayfası7()
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
                SmallTyEtiler1.Text = _variables.ParasutEtilerS.ToString();
                SmallTyEmirgan1.Text = _variables.ParasutEmirganS.ToString();
                int tys1 = _variables.ParasutEtilerS;
                int tys2 = _variables.ParasutEmirganS;
                int toplamtys = tys1 + tys2;
                ToplamTy6.Text = toplamtys.ToString();
                MediamTyEtiler1.Text = _variables.ParasutEtilerM.ToString();
                MediumTyEmirgan1.Text = _variables.ParasutEmirganM.ToString();
                int tym1 = _variables.ParasutEtilerM;
                int tym2 = _variables.ParasutEmirganM;
                int toplamtym = tym1 + tym2;
                ToplamTy7.Text = toplamtym.ToString();
                LargeTyEtiler1.Text = _variables.ParasutEtilerl.ToString();
                LargeTyEmirgan1.Text = _variables.ParasutEmirganl.ToString();
                int tyl1 = _variables.ParasutEmirganl;
                int tyl2 = _variables.ParasutEtilerl;
                int toplamtyl = tyl1 + tyl2;
                ToplamTy8.Text = toplamtyl.ToString();
                xlargeTyEtiler1.Text = _variables.ParasutEtilerXL.ToString();
                xlargeTyEmirgan1.Text = _variables.ParasutEmirganXL.ToString();
                int tyxl1 = _variables.ParasutEtilerXL;
                int tyxl2 = _variables.ParasutEmirganXL;
                int toplamtyxl = tyxl1 + tyxl2;
                ToplamTy9.Text = toplamtyxl.ToString();
                xxlargeTyEtiler1.Text = _variables.ParasutEtilerXXL.ToString();
                xxlargeTyEmirgan1.Text = _variables.ParasutEmirganXXL.ToString();
                int tyxxl1 = _variables.ParasutEtilerXXL;
                int tyxxl2 = _variables.ParasutEmirganXXL;
                int toplamxxl = tyxxl1 + tyxxl2;
                ToplamTy10.Text = toplamxxl.ToString();
                BelEtiler.Text=_variables.BelEtiler.ToString();
                BelEmirgan.Text=_variables.BelEmirgan.ToString();
                int bel1 = _variables.BelEtiler;
                int bel2= _variables.BelEmirgan;
                int toplambel= bel1 + bel2;
                Toplam1.Text = toplambel.ToString();
                PerlonEmirgan.Text=_variables.perlonEmirgan.ToString() ;
                PerlonEtiler.Text=_variables.perlonEtiler.ToString() ;
                int perlon1=_variables.perlonEtiler;
                int perlon2 = _variables.perlonEmirgan;
                int toplamperlon= perlon1 + perlon2;
                Toplam2.Text = toplamperlon.ToString();
                KarabineEmirgan.Text=_variables.karabineEmirgan.ToString();
                KarabineEtiler.Text=_variables.karabinaEtiler.ToString() ;
                int kara1 = _variables.karabinaEtiler;
                int kara2 = _variables.karabineEmirgan;
                int toplamkara= kara1 + kara2;
                Toplam3.Text = toplamkara.ToString();
                SapanEtiler.Text=_variables.sapanEtiler.ToString();
                SapanEmirgan.Text = _variables.sapanEmirgan.ToString();
                int sapan1= _variables.sapanEmirgan;
                int sapan2 = _variables.sapanEtiler;
                int toplamsapan= sapan1 + sapan2;
                Toplam4.Text = toplamsapan.ToString();
                CelikHalatEmirgan.Text=_variables.celikhalatEmirgan.ToString() ;
                çelikEtiler.Text=_variables.celikHalatEtiler.ToString() ;
                int celik1 = _variables.celikhalatEmirgan;
                int celik2 = _variables.celikHalatEtiler;
                int toplamcelik= celik1 + celik2;
                Toplam5.Text = toplamcelik.ToString();
                Makara.Text=_variables.makaraEtiler.ToString();
                makaraEmirgan.Text = _variables.makaraEmirgan.ToString();
                int makara1= _variables.makaraEtiler;
                int makara2= _variables.makaraEmirgan;
                int toplammakara= makara1 + makara2;
                Toplam6.Text = toplammakara.ToString();
                halat50Etiler.Text = _variables.halat50Etiler.ToString();
                halat50emirgan.Text = _variables.halat50Emirgan.ToString();
                int halat501=_variables.halat50Etiler;
                int halat502 = _variables.halat50Emirgan;
                int toplamhalat50=halat501+ halat502;
                Toplam7.Text=toplamhalat50.ToString();
                cantaEtiler.Text = _variables.cantaEtiler.ToString() ;
                cantaEmirgan.Text=_variables.cantaEmirgan.ToString() ;
                int canta1= _variables.cantaEtiler;
                int canta2= _variables.cantaEmirgan;
                int toplamcanta= canta1 + canta2;
                Toplam8.Text=toplamcanta.ToString();
                jumarEtiler.Text = _variables.jumarEtiler.ToString();
                JumarEmirgan.Text = _variables.jumarEmirgan.ToString();
                int jumar1=_variables.jumarEmirgan;
                int jumar2 = _variables.jumarEtiler;
                int toplamjumar=jumar1+ jumar2;
                Toplam9.Text=toplamjumar.ToString();
                lanyardEmirgan.Text=_variables.lanyardEmirgan.ToString();
                LanyardEtiler.Text = _variables.lanyardEtiler.ToString();
                int lanyard1=_variables.lanyardEmirgan;
                int lanyard2 = _variables.lanyardEtiler;
                int toplamlanyard=lanyard1+ lanyard2;
                Toplam10.Text=toplamlanyard.ToString();
                halat100Emirgan.Text=_variables.halat100Emirgan.ToString() ;
                halat100Etiler.Text=_variables.halat100Etiler.ToString() ;
                int halat1001 = _variables.halat100Emirgan;
                int halat1002 = _variables.halat100Etiler;
                int toplamhalat100=halat1001+ halat1002;
                Toplam11.Text=toplamhalat100.ToString();
                bogumEtiler.Text=_variables.halatEtiler.ToString();
                bogumhalat.Text = _variables.halatEmirgan.ToString();
                int bogum1=_variables.halatEmirgan;
                int bogum2 = _variables.halatEtiler;
                int toplambogum= bogum1+ bogum2;
                Toplam12.Text=toplambogum.ToString();
                ayakEtiler.Text = _variables.ayakcakEtiler.ToString();
                ayakEmirgan.Text = _variables.ayakcakEmirgan.ToString();
                int ayak1=_variables.ayakcakEmirgan;
                int ayak2 = _variables.ayakcakEtiler;
                int toplamayak= ayak1+ ayak2;
                Toplam13.Text=toplamayak.ToString();

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
            StokSayfa8 stokSayfa8 = new StokSayfa8();
            stokSayfa8.Show();
            this.Close();
        }
    }
}
