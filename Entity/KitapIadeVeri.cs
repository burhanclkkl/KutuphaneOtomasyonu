using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    //Kİtap iade işlemleri için
    //verilerini diğer katmanlarda
    //kullanabilmek amacı ile get set işlemi yapıldı
    public class KitapIadeVeri
    {
        int kitapKayitId, ogrenciId, kitapId;
        DateTime kitapTeslim;
        DateTime kitapAlinma;
        bool kitapKontrol;
        float ogrenciCeza;


        public int KitapKayitId { get => kitapKayitId; set => kitapKayitId = value; }// KitapKayitId get set işlemi
        public int KitapId { get => kitapId; set => kitapId = value; }// KitapId get set işlemi
        public int OgrenciId { get => ogrenciId; set => ogrenciId = value; }// OgrenciId get set işlemi
        public DateTime KitapAlinma { get => kitapAlinma; set => kitapAlinma = value; }// KitapAlinma get set işlemi
        public DateTime KitapTeslim { get => kitapTeslim; set => kitapTeslim = value; }// KitapTeslim get set işlemi
        public bool KitapKontrol { get => kitapKontrol; set => kitapKontrol = value; }// KitapKontrol get set işlemi
        public float OgrenciCeza { get => ogrenciCeza; set => ogrenciCeza = value; }// OgrenciCeza get set işlemi
    }
}
