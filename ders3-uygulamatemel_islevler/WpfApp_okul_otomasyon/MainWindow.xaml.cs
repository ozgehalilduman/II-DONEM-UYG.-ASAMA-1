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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary_okulotomasyon;
namespace WpfApp_okul_otomasyon
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        ders_islemleri Dersislem=new ders_islemleri();
        sinif_islemleri Sinifislem = new sinif_islemleri();
        dersprg_islemleri DersPrgislem = new dersprg_islemleri();
        Not_islemleri Notislem = new Not_islemleri();
        ogretmen_islemleri Ogretmenislem = new ogretmen_islemleri();
        ogrenci_islemleri Ogrenciislem = new ogrenci_islemleri();

        public MainWindow()
        {
            InitializeComponent();
            #region DataGrid AYARLARI
            Dgrid_dersler.ItemsSource = Dersislem.Ders_listeleme();
            Dgrid_siniflar.ItemsSource = Sinifislem.Sinif_listeleme();
            Dgrid_notlar.ItemsSource = Notislem._Not_listeleme();
            Dgrid_dersprogramlari.ItemsSource = DersPrgislem.Dprg_listeleme();
            Dgrid_ogretmenler.ItemsSource = Ogretmenislem.Ogretmen_listeleme();
            Dgrid_ogrenciler.ItemsSource = Ogrenciislem.Ogrenci_listeleme();
            Dgrid_dersler.CanUserAddRows = false;
            Dgrid_siniflar.CanUserAddRows = false;
            Dgrid_notlar.CanUserAddRows = false;
            Dgrid_dersprogramlari.CanUserAddRows = false;
            Dgrid_ogretmenler.CanUserAddRows = false;
            Dgrid_ogrenciler.CanUserAddRows = false;

            #endregion
            #region Combobox AYARLARI
            //derslerle ilgili comboboxlar
            Cbox_ogrt_brans_ust.ItemsSource = Dersislem.Ders_listeleme();
            Cbox_ogrt_brans_ust.DisplayMemberPath = "ad";
            Cbox_ogrt_brans_ust.SelectedValuePath = "id";
            Cbox_ogrt_brans.ItemsSource = Dersislem.Ders_listeleme();
            Cbox_ogrt_brans.DisplayMemberPath = "ad";
            Cbox_ogrt_brans.SelectedValuePath = "id";
            Cbox_not_ders.ItemsSource= Dersislem.Ders_listeleme();
            Cbox_not_ders.DisplayMemberPath = "ad";
            Cbox_not_ders.SelectedValuePath = "id";
            Cbox_dp_ders.ItemsSource= Dersislem.Ders_listeleme();
            Cbox_dp_ders.DisplayMemberPath = "ad";
            Cbox_dp_ders.SelectedValuePath = "id";
            //siniflarla ilgili comboboxlar
            Cbox_ogr_sinif.ItemsSource = Sinifislem.Sinif_listeleme();
            Cbox_ogr_sinif.DisplayMemberPath = "sinifad";
            Cbox_ogr_sinif.SelectedValuePath = "id";
            Cbox_ogr_sinif1.ItemsSource = Sinifislem.Sinif_listeleme();
            Cbox_ogr_sinif1.DisplayMemberPath = "sinifad";
            Cbox_ogr_sinif1.SelectedValuePath = "id";
            Cbox_not_sinif.ItemsSource = Sinifislem.Sinif_listeleme();
            Cbox_not_sinif.DisplayMemberPath = "sinifad";
            Cbox_not_sinif.SelectedValuePath = "id";
            Cbox_dp_sinif.ItemsSource = Sinifislem.Sinif_listeleme();
            Cbox_dp_sinif.DisplayMemberPath = "sinifad";
            Cbox_dp_sinif.SelectedValuePath = "id";
            Cbox_dp_sinif_sag.ItemsSource = Sinifislem.Sinif_listeleme();
            Cbox_dp_sinif_sag.DisplayMemberPath = "sinifad";
            Cbox_dp_sinif_sag.SelectedValuePath = "id";
            //ogrencilerle ilgili comboboxlar
            Cbox_not_okulno.ItemsSource = Ogrenciislem.Ogrenci_listeleme();
            Cbox_not_okulno.DisplayMemberPath = "okulno";
             #endregion

        }
        private void kaynak_yenile()
        {  //Dersler
            Dgrid_dersler.ItemsSource = null;
            Dgrid_dersler.ItemsSource = Dersislem.Ders_listeleme();
            Dgrid_siniflar.ItemsSource = null;
            Dgrid_siniflar.ItemsSource = Sinifislem.Sinif_listeleme();
            Dgrid_notlar.ItemsSource = null;
            Dgrid_notlar.ItemsSource = Notislem._Not_listeleme();
            Dgrid_dersprogramlari.ItemsSource = null;
            Dgrid_dersprogramlari.ItemsSource = DersPrgislem.Dprg_listeleme();
            Dgrid_ogretmenler.ItemsSource = null;
            Dgrid_ogretmenler.ItemsSource = Ogretmenislem.Ogretmen_listeleme();
            Dgrid_ogrenciler.ItemsSource = null;
            Dgrid_ogrenciler.ItemsSource = Ogrenciislem.Ogrenci_listeleme();
            //ogretmen
            Cbox_ogrt_brans_ust.ItemsSource = null;
            Cbox_ogrt_brans_ust.ItemsSource = Dersislem.Ders_listeleme();
            Cbox_ogrt_brans.ItemsSource = null;
            Cbox_ogrt_brans.ItemsSource = Dersislem.Ders_listeleme();
            //dersprog
            Cbox_dp_ders.ItemsSource = null;
            Cbox_dp_ders.ItemsSource = Dersislem.Ders_listeleme();
            Cbox_dp_sinif_sag.ItemsSource = null;
            Cbox_dp_sinif_sag.ItemsSource = Sinifislem.Sinif_listeleme();
            Cbox_dp_sinif.ItemsSource = null;
            Cbox_dp_sinif.ItemsSource = Sinifislem.Sinif_listeleme();
            //notlar
            Cbox_not_okulno.ItemsSource = null;
            Cbox_not_okulno.ItemsSource = Ogrenciislem.Ogrenci_listeleme();           
            Cbox_not_ders.ItemsSource = null;
            Cbox_not_ders.ItemsSource = Dersislem.Ders_listeleme();
            Cbox_not_sinif.ItemsSource = null;
            Cbox_not_sinif.ItemsSource = Sinifislem.Sinif_listeleme();
            //ogrenciler
            Cbox_ogr_sinif.ItemsSource = null;
            Cbox_ogr_sinif.ItemsSource = Sinifislem.Sinif_listeleme();
            Cbox_ogr_sinif1.ItemsSource = null;
            Cbox_ogr_sinif1.ItemsSource = Sinifislem.Sinif_listeleme();

        }
        private void Btn_ders_kaydet_Click(object sender, RoutedEventArgs e)
        {
            ders yeniders = new ders();
            yeniders.ad = Tbox_ders_ad.Text;
            if ((bool)CheckBox_ders_yeni.IsChecked)
            {
                int yeni_id=ders_id_olustur(Dersislem.Ders_listeleme());
                yeniders.id = yeni_id;
                Dersislem.Ders_ekleme(yeniders);
            }
            else
            {
                if (Dgrid_dersler.SelectedItem != null)
                {
                    ders secilen = (ders)Dgrid_dersler.SelectedItem;
                    yeniders.id = secilen.id;
                    Dersislem.Ders_Guncelleme(secilen, yeniders);
                }
                else {
                    MessageBox.Show("HER HANGİ DERS SEÇİLMEDİ");
                }

            }
            kaynak_yenile();
        }
        private void Btn_sinif_kaydet_Click(object sender, RoutedEventArgs e)
        {
            sinif yenisinif = new sinif();
            if (Cbox_sinif_seviye.Text != "Hazırlık")
            {
                yenisinif.seviye = Int32.Parse(Cbox_sinif_seviye.Text);
            }
            else { yenisinif.seviye = 0; }
            yenisinif.sube = Tbox_sinif_sube.Text;
            if ((bool)CheckBox_sinif_yeni.IsChecked)
            {
                yenisinif.id = sinif_id_olustur(Sinifislem.Sinif_listeleme());
                Sinifislem.Sinif_ekleme(yenisinif);
            }
            else
            {
                if (Dgrid_siniflar.SelectedItem != null)
                {
                    sinif secilen= (sinif)Dgrid_siniflar.SelectedItem;
                    yenisinif.id = secilen.id;
                    Sinifislem.Sinif_Guncelleme(secilen, yenisinif);
                }
                else { MessageBox.Show("SINIF SEÇİMİ YAPILMADI"); }
            }


            kaynak_yenile();
        }
        private void Btn_dp_kaydet_Click(object sender, RoutedEventArgs e)
        {
            dersprogrami yeni = new dersprogrami();
            yeni.gun = Cbox_dp_gun_sag.Text;
            yeni.saat = Int32.Parse(Cbox_dp_saat.Text);
            yeni.ders = (ders)Cbox_dp_ders.SelectedItem;
            yeni.sinif =(sinif)Cbox_dp_sinif_sag.SelectedItem;
            if ((bool)CheckBox_dersprogrami_yeni.IsChecked)
            {
                int yeni_id = dersprogmi_id_olustur(DersPrgislem.Dprg_listeleme());
                yeni.id = yeni_id;
                DersPrgislem.Dprg_ekleme(yeni);
            }
            else
            {
                if (Dgrid_dersler.SelectedItem != null)
                {
                    dersprogrami secilen = (dersprogrami)Dgrid_dersprogramlari.SelectedItem;
                    yeni.id = secilen.id;
                    DersPrgislem.Dprg_Guncelleme(secilen, yeni);
                }
                else
                {
                    MessageBox.Show("HER HANGİ DERSPROGRAMI SEÇİLMEDİ");
                }

            }
            kaynak_yenile();
        }
        private void Btn_not_kaydet_Click(object sender, RoutedEventArgs e)
        {
            _not yeni = new _not();
            yeni.ogrenci = (ogrenci)Cbox_not_okulno.SelectedItem;
            yeni.donem = Cbox_not_donem.Text;
            yeni.ders = (ders)Cbox_not_ders.SelectedItem; ;
            yeni.sinif =(sinif)Cbox_not_sinif.SelectedItem;
            yeni._not1 = Int32.Parse(Tbox_not_1.Text);
            yeni._not2 = Int32.Parse(Tbox_not_2.Text);
            yeni._not3 = Int32.Parse(Tbox_not_3.Text);
            yeni.performans = Int32.Parse(Tbox_not_proje.Text);
            yeni.p_not1 = Int32.Parse(Tbox_performans_1.Text);
            yeni.p_not2 = Int32.Parse(Tbox_performans_2.Text);
            yeni.p_not3 = Int32.Parse(Tbox_performans_3.Text);
            if ((bool)CheckBox_not_yeni.IsChecked)
            {
                int yeni_id = not_id_olustur(Notislem._Not_listeleme());
                yeni.id = yeni_id;
                Notislem._Not_ekleme(yeni);
            }
            else
            {
                if (Dgrid_notlar.SelectedItem != null)
                {
                    _not secilen = (_not)Dgrid_notlar.SelectedItem;
                    yeni.id = secilen.id;
                    Notislem._Not_Guncelleme(secilen, yeni);
                }
                else
                {
                    MessageBox.Show("HER HANGİ NOT SEÇİLMEDİ");
                }

            }
            kaynak_yenile();
        }
        private void Btn_ogrt_kaydet_Click(object sender, RoutedEventArgs e)
        {
            ogretmen yeni = new ogretmen();
            yeni.ad = Tbox_ogrt_ad.Text;
            yeni.soyad = Tbox_ogrt_soyad.Text;
            yeni.tc = Tbox_ogrt_tc.Text;
            yeni.brans = (ders)Cbox_ogrt_brans.SelectedItem;
            if ((bool)CheckBox_ogretmen_yeni.IsChecked)
            {
                int yeni_id = ogretmen_id_olustur(Ogretmenislem.Ogretmen_listeleme());
                yeni.id = yeni_id;
                Ogretmenislem.Ogretmen_ekleme(yeni);
            }
            else
            {
                if (Dgrid_ogretmenler.SelectedItem != null)
                {
                    ogretmen secilen = (ogretmen)Dgrid_ogretmenler.SelectedItem;
                    yeni.id = secilen.id;
                    Ogretmenislem.Ogretmen_Guncelleme(secilen, yeni);
                }
                else
                {
                    MessageBox.Show("HER HANGİ ÖĞRETMEN SEÇİLMEDİ");
                }

            }
            kaynak_yenile();
        }
        private void Btn_ogr_kaydet_Click(object sender, RoutedEventArgs e)
        {
            ogrenci yeni = new ogrenci();
            yeni.okulno = Int32.Parse(Tbox_ogr_okulno.Text);
            yeni.ad = Tbox_ogr_ad.Text;
            yeni.soyad = Tbox_ogr_soyad.Text;
            yeni.tc = Tbox_ogr_tc.Text;
            yeni.sinif = (sinif)Cbox_ogr_sinif.SelectedItem;
            if ((bool)CheckBox_ogrenci_yeni.IsChecked)
            {
                int yeni_id = ogrenci_id_olustur(Ogrenciislem.Ogrenci_listeleme());
                yeni.id = yeni_id;
                Ogrenciislem.Ogrenci_ekleme(yeni);
            }
            else
            {
                if (Dgrid_ogrenciler.SelectedItem != null)
                {
                    ogrenci secilen = (ogrenci)Dgrid_ogrenciler.SelectedItem;
                    yeni.id = secilen.id;
                    Ogrenciislem.Ogrenci_Guncelleme(secilen, yeni);
                }
                else
                {
                    MessageBox.Show("HER HANGİ ÖĞRENCİ SEÇİLMEDİ");
                }

            }
            kaynak_yenile();
        }

        private void Btn_ders_sil_Click(object sender, RoutedEventArgs e)
        {
            ders secilen = (ders)Dgrid_dersler.SelectedItem;
            Dersislem.Ders_Silme(secilen);
            kaynak_yenile();

        }
        private void Btn_dersprogrami_sil_Click(object sender, RoutedEventArgs e)
        {
            dersprogrami secilen = (dersprogrami)Dgrid_dersprogramlari.SelectedItem;
            DersPrgislem.Dprg_Silme(secilen);
            kaynak_yenile();

        }
        private void Btn_sinif_sil_Click(object sender, RoutedEventArgs e)
        {
            sinif secilen = (sinif)Dgrid_siniflar.SelectedItem;
            Sinifislem.Sinif_Silme(secilen);
            kaynak_yenile();

        }
        private void Btn_not_sil_Click(object sender, RoutedEventArgs e)
        {
            _not secilen = (_not)Dgrid_notlar.SelectedItem;
            Notislem._Not_Silme(secilen);
            kaynak_yenile();

        }
        private void Btn_ogretmen_sil_Click(object sender, RoutedEventArgs e)
        {
            ogretmen secilen = (ogretmen)Dgrid_ogretmenler.SelectedItem;
            Ogretmenislem.Ogretmen_Silme(secilen);
            kaynak_yenile();

        }
        private void Btn_ogrenci_sil_Click(object sender, RoutedEventArgs e)
        {
            ogrenci secilen = (ogrenci)Dgrid_ogrenciler.SelectedItem;
            Ogrenciislem.Ogrenci_Silme(secilen);
            kaynak_yenile();

        }

        private int ders_id_olustur(List<ders> liste)
        {
            int id;
            if (liste.Count > 0)
            {
                id = ((ders)liste.Last()).id + 1;
            }
            else { id = 1; }
            return id;
        }
        private int sinif_id_olustur(List<sinif> liste)
        {
            int id;
            if (liste.Count > 0)
            {
                id = ((sinif)liste.Last()).id + 1;
            }
            else { id = 1; }
            return id;
        }
        private int not_id_olustur(List<_not> liste)
        {
            int id;
            if (liste.Count > 0)
            {
                id = ((_not)liste.Last()).id + 1;
            }
            else { id = 1; }
            return id;
        }
        private int dersprogmi_id_olustur(List<dersprogrami> liste)
        {
            int id;
            if (liste.Count > 0)
            {
                id = ((dersprogrami)liste.Last()).id + 1;
            }
            else { id = 1; }
            return id;
        }
        private int ogretmen_id_olustur(List<ogretmen> liste)
        {
            int id;
            if (liste.Count > 0)
            {
                id = ((ogretmen)liste.Last()).id + 1;
            }
            else { id = 1; }
            return id;
        }
        private int ogrenci_id_olustur(List<ogrenci> liste)
        {
            int id;
            if (liste.Count > 0)
            {
                id = ((ogrenci)liste.Last()).id + 1;
            }
            else { id = 1; }
            return id;
        }

        private void Cbox_ogr_sinif1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Dgrid_ogrenciler.ItemsSource = null;
            Dgrid_ogrenciler.ItemsSource = Ogrenciislem.Ogrenci_Arama((sinif)Cbox_ogr_sinif1.SelectedItem);

        }

        private void Cbox_not_ders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sinif _s = (sinif)Cbox_not_sinif.SelectedItem;
            ders _d = (ders)Cbox_not_ders.SelectedItem;
            string donem = Cbox_not_donem.Text;

            Dgrid_notlar.ItemsSource = null;
            Dgrid_notlar.ItemsSource = Notislem._Not_Arama(_d,_s,donem);
        }

        private void Cbox_not_sinif_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sinif _s = (sinif)Cbox_not_sinif.SelectedItem;
            ders _d = (ders)Cbox_not_ders.SelectedItem;
            string donem = Cbox_not_donem.Text;

            Dgrid_notlar.ItemsSource = null;
            Dgrid_notlar.ItemsSource = Notislem._Not_Arama(_d, _s, donem);
        }

        private void Cbox_not_donem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sinif _s = (sinif)Cbox_not_sinif.SelectedItem;
            ders _d = (ders)Cbox_not_ders.SelectedItem;
            string donem = Cbox_not_donem.Text;

            Dgrid_notlar.ItemsSource = null;
            Dgrid_notlar.ItemsSource = Notislem._Not_Arama(_d, _s, donem);
        }

        private void Cbox_dp_gun_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Dgrid_dersprogramlari.Items.Count > 0)
            {
                Dgrid_dersprogramlari.ItemsSource = null;
                Dgrid_dersprogramlari.ItemsSource = DersPrgislem.Dprg_arama(Cbox_dp_gun.Text, (sinif)Cbox_dp_sinif.SelectedItem);
            }
        }

        private void Cbox_dp_sinif_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Dgrid_dersprogramlari.ItemsSource = null;
            Dgrid_dersprogramlari.ItemsSource = DersPrgislem.Dprg_arama(Cbox_dp_gun.Text, (sinif)Cbox_dp_sinif.SelectedItem);
        }

        private void Cbox_ogrt_brans_ust_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Cbox_ogrt_brans_ust.SelectedIndex != -1){
                Dgrid_ogretmenler.ItemsSource = null;
                Dgrid_ogretmenler.ItemsSource = Ogretmenislem.Ogretmen_Arama((ders)Cbox_ogrt_brans_ust.SelectedItem);
            }
            
        }

        private void Dgrid_ogretmenler_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "id") {e.Column.Header = "ID"; }
            if (e.PropertyName == "ad") {e.Column.Header = "ADI"; }
            if (e.PropertyName == "soyad") {e.Column.Header = "SOYADI"; }
            if (e.PropertyName == "tc") {e.Column.Header = "TC Kimlik No"; }
            if (e.PropertyName == "brans"){
                e.Column.Header = "BRANŞ";
                var c = (DataGridTextColumn)e.Column;
                var b = (Binding)c.Binding;
                b.Path = new PropertyPath("brans.ad");
            }
        }

        private void Dgrid_siniflar_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "id") { e.Column.Header = "ID"; }
            if (e.PropertyName == "sube") { e.Column.Header = "ŞUBE"; }
            if (e.PropertyName == "seviye") { e.Column.Header = "SEVİYE"; }
            if (e.PropertyName == "sinifad") { e.Column.Header = "SINIF AD"; }
        }

        private void Dgrid_dersler_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "id") { e.Column.Header = "ID"; }
            if (e.PropertyName == "ad") { e.Column.Header = "DERSİN ADI"; }
        }

        private void Dgrid_dersprogramlari_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "id") { e.Column.Header = "ID"; }
            if (e.PropertyName == "gun") { e.Column.Header = "HAFTANIN GÜNÜ"; }
            if (e.PropertyName == "saat") { e.Column.Header = "KAÇINCI SAAT"; }
            if (e.PropertyName == "sinif")
            {
                e.Column.Header = "SINIF";
                var c = (DataGridTextColumn)e.Column;
                var b = (Binding)c.Binding;
                b.Path = new PropertyPath("sinif.sinifad");
            }
            if (e.PropertyName == "ders")
            {
                e.Column.Header = "DERSİN ADI";
                var c = (DataGridTextColumn)e.Column;
                var b = (Binding)c.Binding;
                b.Path = new PropertyPath("ders.ad");
            }
        }

        private void Dgrid_notlar_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "id") { e.Column.Header = "ID"; }
            if (e.PropertyName == "donem") { e.Column.Header = "OKUL DÖNEMİ"; }
            if (e.PropertyName == "_not1") { e.Column.Header = "NOT 1"; }
            if (e.PropertyName == "_not2") { e.Column.Header = "NOT 3"; }
            if (e.PropertyName == "_not3") { e.Column.Header = "NOT 3"; }
            if (e.PropertyName == "performans") { e.Column.Header = "PROJE"; }
            if (e.PropertyName == "p_not1") { e.Column.Header = "PERFORMANS 1"; }
            if (e.PropertyName == "p_not2") { e.Column.Header = "PERFORMANS 2"; }
            if (e.PropertyName == "p_not3") { e.Column.Header = "PERFORMANS 3"; }
            if (e.PropertyName == "ortalama") { e.Column.Header = "ORTALAMA"; }
            if (e.PropertyName == "ders")
            {
                e.Column.Header = "DERSİN ADI";
                var c = (DataGridTextColumn)e.Column;
                var b = (Binding)c.Binding;
                b.Path = new PropertyPath("ders.ad");
            }
            if (e.PropertyName == "sinif")
            {
                e.Column.Header = "SINIF";
                var c = (DataGridTextColumn)e.Column;
                var b = (Binding)c.Binding;
                b.Path = new PropertyPath("sinif.sinifad");
            }
            if (e.PropertyName == "ogrenci")
            {
                e.Column.Header = "Okul No";
                var c = (DataGridTextColumn)e.Column;
                var b = (Binding)c.Binding;
                b.Path = new PropertyPath("ogrenci.okulno");
            }
        }

        private void Dgrid_ogrenciler_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "id") { e.Column.Header = "ID"; }
            if (e.PropertyName == "okulno") { e.Column.Header = "OKUL NO"; }
            if (e.PropertyName == "ad") { e.Column.Header = "ADI"; }
            if (e.PropertyName == "soyad") { e.Column.Header = "SOYADI"; }
            if (e.PropertyName == "tc") { e.Column.Header = "TC Kimlik No"; }
            if (e.PropertyName == "sinif")
            {
                e.Column.Header = "SINIFI";
                var c = (DataGridTextColumn)e.Column;
                var b = (Binding)c.Binding;
                b.Path = new PropertyPath("sinif.sinifad");
            }
        }

        private void Btn_ogrt_sifirla_Click(object sender, RoutedEventArgs e)
        {
            Dgrid_ogretmenler.ItemsSource = null;
            Dgrid_ogretmenler.ItemsSource = Ogretmenislem.Ogretmen_listeleme();
        }

        private void Btn_dp_sifirla_Click(object sender, RoutedEventArgs e)
        {
            Dgrid_dersprogramlari.ItemsSource = null;
            Dgrid_dersprogramlari.ItemsSource = DersPrgislem.Dprg_listeleme();
        }

        private void Btn_not_sifirla_Click(object sender, RoutedEventArgs e)
        {
            Dgrid_notlar.ItemsSource = null;
            Dgrid_notlar.ItemsSource =Notislem._Not_listeleme();
        }

        private void Btn_ogrenci_sifirla_Click(object sender, RoutedEventArgs e)
        {
            Dgrid_ogrenciler.ItemsSource = null;
            Dgrid_ogrenciler.ItemsSource = Ogrenciislem.Ogrenci_listeleme();
        }

        private void Cbox_not_okulno_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Lbl_not_ograd.Content=((ogrenci)(((ComboBox)sender).SelectedItem)).ad;
            Lbl_not_ogrsoyad.Content=((ogrenci)(((ComboBox)sender).SelectedItem)).soyad;
            Lbl_not_sinif.Content=((ogrenci)(((ComboBox)sender).SelectedItem)).sinif.sinifad;
        }
    }
}
