using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_okulotomasyon
{
    public class ogrenci {
        public int id { get; set;}
        public int okulno { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string tc { get; set; }
        public sinif sinif { get; set; }//sinflardan
    }
    public class ogretmen {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string tc { get; set; }
        public ders brans { get; set; }//derslerden
    }
    public class _not{
        public int id { get; set; }
        public ogrenci ogrenci { get; set; }        
        public ders ders { get; set; }
        public sinif sinif { get; set; }
        public string donem{ get; set; }
        public int _not1 { get; set; }
        public int _not2 { get; set; }
        public int _not3 { get; set; }
        public int performans { get; set; }
        public int p_not1 { get; set; }
        public int p_not2 { get; set; }
        public int p_not3 { get; set; }
        
        public double ortalama {
            get {
                double ort= (_not1 + _not2 + _not3 + performans + p_not1 + p_not2 + p_not3) / 7;
                return Math.Round(ort, 0);
            }
        }

    }
    public class dersprogrami {
        public int id { get; set; }
        public string gun { get; set; }
        public int saat{ get; set; }
        public sinif sinif{ get; set; }
        public ders ders{ get; set; }
    }
    public class sinif {
        public int id { get; set; }
        public string sube { get; set; }
        public int seviye { get; set; }
        public string sinifad { get { return seviye.ToString() + "-" + sube; } }
    }
    public class ders {
        public int id { get; set; }
        public string ad { get; set; }
    }

    public interface IOgr_islemleri
    {
        void Ogrenci_ekleme(ogrenci yeni);
        List<ogrenci> Ogrenci_listeleme();
        void Ogrenci_Silme(ogrenci ogr);
        void Ogrenci_Guncelleme(ogrenci ogr, ogrenci guncel);
        List<ogrenci> Ogrenci_Arama(sinif sinif);
        void Ogrenci_Arama(string tc);
    }
    public interface IOgrt_islemleri
    {
        void Ogretmen_ekleme(ogretmen yeni);
        List<ogretmen> Ogretmen_listeleme();
        void Ogretmen_Silme(ogretmen ogrt);
        void Ogretmen_Guncelleme(ogretmen ogrt, ogretmen guncel);
        List<ogretmen>  Ogretmen_Arama(ders ders);
    }
    public interface IDers_islemleri
    {
        void Ders_ekleme(ders yeni);
        List<ders> Ders_listeleme();
        void Ders_Silme(ders ders);
        void Ders_Guncelleme(ders ders, ders guncel);
        void Ders_Arama(string ad);
    }
    public interface ISnf_islemleri
    {
        void Sinif_ekleme(sinif yeni);
        List<sinif> Sinif_listeleme();
        void Sinif_Silme(sinif sinif);
        void Sinif_Guncelleme(sinif sinif,sinif guncel);
        void Sinif_Arama(int seviye,string sube);
    }
    public interface IDprg_islemleri
    {
        void Dprg_ekleme(dersprogrami yeni);
        List<dersprogrami> Dprg_listeleme();
        List<dersprogrami> Dprg_arama(string gun,sinif sinif);
        void Dprg_Silme(dersprogrami drpg);
        void Dprg_Guncelleme(dersprogrami drpg, dersprogrami guncel);
    }
    public interface I_Not_islemleri
    {
        void _Not_ekleme(_not yeni);
        List<_not> _Not_listeleme();
        List<_not> _Not_Arama(ders ders,sinif sinif,string donem);
        void _Not_Silme(_not _not);
        void _Not_Guncelleme(_not _not, _not guncel);
        
    }

    public class veri_kaynak {
        public List<ogrenci> ogrenciler = new List<ogrenci>();
        public List<ogretmen> ogretmenler = new List<ogretmen>();
        public List<_not> notlar = new List<_not>();
        public List<dersprogrami> dersprogramlari = new List<dersprogrami>();
        public List<sinif> siniflar = new List<sinif>();
        public List<ders> dersler=new List<ders>();
    }
    public class ogrenci_islemleri : IOgr_islemleri
    {
        veri_kaynak kaynak = new veri_kaynak();
        public List<ogrenci> Ogrenci_Arama(sinif sinif)
        {
            return kaynak.ogrenciler.FindAll(x => x.sinif == sinif);
        }

        public void Ogrenci_Arama(string tc)
        {
            throw new NotImplementedException();
        }

        public void Ogrenci_ekleme(ogrenci yeni)
        {
            kaynak.ogrenciler.Add(yeni);
        }

        public void Ogrenci_Guncelleme(ogrenci ogr, ogrenci guncel)
        {
            int index = kaynak.ogrenciler.FindIndex(x => x == ogr);
            kaynak.ogrenciler[index] = guncel;
        }

        public List<ogrenci> Ogrenci_listeleme()
        {
            return kaynak.ogrenciler;
        }

        public void Ogrenci_Silme(ogrenci ogr)
        {
            kaynak.ogrenciler.Remove(ogr);
        }
    }
    public class ogretmen_islemleri : IOgrt_islemleri
    {
        veri_kaynak kaynak = new veri_kaynak();
        public List<ogretmen> Ogretmen_Arama(ders ders)
        {
            return kaynak.ogretmenler.FindAll(x => x.brans == ders);
        }

        public void Ogretmen_ekleme(ogretmen yeni)
        {
            kaynak.ogretmenler.Add(yeni);
        }

        public void Ogretmen_Guncelleme(ogretmen ogrt, ogretmen guncel)
        {
            int index = kaynak.ogretmenler.FindIndex(x => x == ogrt);
            kaynak.ogretmenler[index] = guncel;
        }

        public List<ogretmen> Ogretmen_listeleme()
        {
            return kaynak.ogretmenler;
        }

        public void Ogretmen_Silme(ogretmen ogrt)
        {
            kaynak.ogretmenler.Remove(ogrt);
        }
    }
    public class Not_islemleri : I_Not_islemleri
    {
        veri_kaynak kaynak = new veri_kaynak();
        public void _Not_ekleme(_not yeni)
        {
            kaynak.notlar.Add(yeni);
        }

        public void _Not_Guncelleme(_not _not, _not guncel)
        {
            int index = kaynak.notlar.FindIndex(x => x == _not);
            kaynak.notlar[index] = guncel;
        }


        public void _Not_Silme(_not _not)
        {
            kaynak.notlar.Remove(_not);
        }

        public List<_not> _Not_listeleme()
        {
            return kaynak.notlar;
        }

        public List<_not> _Not_Arama(ders ders, sinif sinif, string donem)
        {
            List<_not> aramasonuc = new List<_not>();
            if (ders ==null) {
                aramasonuc = kaynak.notlar.FindAll(x => x.sinif == sinif&& x.donem== donem);
            }
            if (sinif == null)
            {
                aramasonuc = kaynak.notlar.FindAll(x => x.ders== ders&& x.donem == donem);
            }
            if (donem == "")
            {
                aramasonuc = kaynak.notlar.FindAll(x => x.ders == ders && x.sinif == sinif);
            }
            if (sinif == null && ders == null)
            {
                aramasonuc = kaynak.notlar.FindAll(x => x.donem == donem);
            }
            if (sinif == null && donem == "")
            {
                aramasonuc = kaynak.notlar.FindAll(x => x.ders== ders);
            }
            if (ders == null && donem == "")
            {
                aramasonuc = kaynak.notlar.FindAll(x => x.sinif == sinif);
            }
            if (sinif == null &&ders == null && donem == "")
            {
                aramasonuc = kaynak.notlar.ToList();
            }            
            return aramasonuc;
        }
    }
    public class dersprg_islemleri : IDprg_islemleri
    {
        veri_kaynak kaynak = new veri_kaynak();

        public List<dersprogrami> Dprg_arama(string gun, sinif sinif)
        {
            List<dersprogrami> aramasonuc = new List<dersprogrami>();
            if (gun == "") { aramasonuc = kaynak.dersprogramlari.FindAll(x =>x.sinif == sinif); }
            if (sinif == null) { aramasonuc = kaynak.dersprogramlari.FindAll(x => x.gun == gun); }
            if (gun=="" && sinif==null) { aramasonuc = kaynak.dersprogramlari.ToList(); }
            if (gun!="" && sinif!=null) { aramasonuc = kaynak.dersprogramlari.FindAll(x => x.gun == gun && x.sinif==sinif); }

            return aramasonuc;
        }

        public void Dprg_ekleme(dersprogrami yeni)
        {
            kaynak.dersprogramlari.Add(yeni);
        }

        public void Dprg_Guncelleme(dersprogrami drpg, dersprogrami guncel)
        {
            int index = kaynak.dersprogramlari.FindIndex(x => x == drpg);
            kaynak.dersprogramlari[index] = guncel;
        }

        public List<dersprogrami> Dprg_listeleme()
        {
            return kaynak.dersprogramlari;
        }

        public void Dprg_Silme(dersprogrami drpg)
        {
            kaynak.dersprogramlari.Remove(drpg); 
        }
    }
    public class sinif_islemleri : ISnf_islemleri
    {
        private veri_kaynak kaynak = new veri_kaynak();
        public void Sinif_Arama(int seviye, string sube)
        {
            throw new NotImplementedException();
        }

        public void Sinif_ekleme(sinif yeni)
        {
            kaynak.siniflar.Add(yeni);
        }

        public void Sinif_Guncelleme(sinif sinif, sinif guncel)
        {
            int index = kaynak.siniflar.FindIndex(x => x == sinif);
            kaynak.siniflar[index] = guncel;
        }

        public List<sinif> Sinif_listeleme()
        {
            return kaynak.siniflar;
        }

        public void Sinif_Silme(sinif sinif)
        {
            kaynak.siniflar.Remove(sinif);
        }
    }
    public class ders_islemleri : IDers_islemleri
    {
        private veri_kaynak kaynak = new veri_kaynak();
   
        public void Ders_Arama(string ad)
        {
            throw new NotImplementedException();
        }

        public void Ders_ekleme(ders yeni)
        {
            kaynak.dersler.Add(yeni);
        }

        public void Ders_Guncelleme(ders d, ders guncel)
        {
            int index = kaynak.dersler.FindIndex(x => x == d);
            kaynak.dersler[index] = guncel;
        }

        public List<ders> Ders_listeleme()
        {
            return kaynak.dersler;
        }

        public void Ders_Silme(ders d)
        {
            kaynak.dersler.Remove(d);
        }
    }
}
