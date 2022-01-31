using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    //Kitap ve ogrenci için kullanılan
    //ortak verilerini diğer katmanlarda
    //kullanabilmek için get set işlemi yapıldı
    public class KitapOgrenciVeri
    {
        int kitapId;
        string ogrenciAd, ogrenciSoyad, kitapAd, kitapTeslim;
        DateTime kitapAlinma;
        bool kitapKontrol;


        public int KitapId { get => kitapId; set => kitapId = value; }//get set işlemi
        public string OgrenciAd { get => ogrenciAd; set => ogrenciAd = value; }//get set işlemi
        public string OgrenciSoyad { get => ogrenciSoyad; set => ogrenciSoyad = value; }//get set işlemi
        public string KitapAd { get => kitapAd; set => kitapAd = value; }//get set işlemi
        public DateTime KitapAlinma { get => kitapAlinma; set => kitapAlinma = value; }//get set işlemi
        public string KitapTeslim { get => kitapTeslim; set => kitapTeslim = value; }//get set işlemi
        public bool KitapKontrol { get => kitapKontrol; set => kitapKontrol = value; }//get set işlemi

    }
}
