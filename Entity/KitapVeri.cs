using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    //Kitap verilerini diğer katmanlarda
    //kullanabilmek için get set işlemi yapıldı
    public class KitapVeri
    {
        int kitapId;
        string kitapAd, kitapTuru, kitapSayfa, kitapYazar;//get set işlemi
        public int KitapId { get => kitapId; set => kitapId = value; }//get set işlemi
        public string KitapAd { get => kitapAd; set => kitapAd = value; }//get set işlemi
        public string KitapTuru { get => kitapTuru; set => kitapTuru = value; }//get set işlemi
        public string KitapSayfa { get => kitapSayfa; set => kitapSayfa = value; }//get set işlemi
        public string KitapYazar { get => kitapYazar; set => kitapYazar = value; }//get set işlemi
    }
}
