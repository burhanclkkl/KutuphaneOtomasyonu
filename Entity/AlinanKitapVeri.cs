using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    //Aldığımız kitapların verilerini
    //diğer katmanlarda kullanabilmek
    //için get set işlemi yapıldı
    public class AlinanKitapVeri
    {
        int ogrenciId;
        string kitapAd, kitapTeslim;
        DateTime kitapAlinma;
        bool kitapKontrol;

        public int OgrenciId { get => ogrenciId; set => ogrenciId = value; } // ogrenciId get set işlemi
        public string KitapAd { get => kitapAd; set => kitapAd = value; }// ogrenciId get set işlemi
        public DateTime KitapAlinma { get => kitapAlinma; set => kitapAlinma = value; }// KitapAd get set işlemi
        public string KitapTeslim { get => kitapTeslim; set => kitapTeslim = value; }// KitapTeslim get set işlemi
        public bool KitapKontrol { get => kitapKontrol; set => kitapKontrol = value; }// KitapKontrol get set işlemi

    }
}
