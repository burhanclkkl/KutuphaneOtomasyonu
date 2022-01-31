using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    //Görevliye ait verilerin diğer
    //katmanlarda kullanabilmek için
    //get set işlemi yapıldı
    public class GorevliVeri
    {
        int gorevliId;
        string gorevliAd, gorevliSoyad, gorevliTc, gorevliSifre;

        public int gorevId { get => gorevliId; set => gorevliId = value; } // gorevId get set işlemi
        public string gorevAd { get => gorevliAd; set => gorevliAd = value; }// gorevAd get set işlemi
        public string gorevSoyad { get => gorevliSoyad; set => gorevliSoyad = value; }// gorevSoyad get set işlemi
        public string gorevTc { get => gorevliTc; set => gorevliTc = value; }// gorevTc get set işlemi
        public string gorevSifre { get => gorevliSifre; set => gorevliSifre = value; }// gorevSifre get set işlemi
    }
}
