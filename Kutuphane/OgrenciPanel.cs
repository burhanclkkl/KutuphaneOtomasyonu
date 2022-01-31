using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity; // entity eklenir
using BusinessLayer; // BusinessLayer eklenir
using ZedGraph;     //ZedGraph özelliklerini kullanabilmek için kütüphanesini ekledik
namespace Kutuphane
{
    public partial class OgrenciPanel : Form
    {
        public OgrenciPanel()
        {
            InitializeComponent();
        }
        private void ogrenciBilgilerim_Click(object sender, EventArgs e)
        {
            ogrenciKitapAlmaTeslim1.Visible = false; // ogrenciKitapAlmaTeslim1 uc' nin gizlenmesi
            ogrenciBilgilerim1.Visible = true; // ogrenciBilgilerim uc' nin görüntülenmesini sağlar
            ogrenciCezaOdeme1.Visible = false; // ogrenciAlinanKitaplarıinListesi1 uc' nin gizlenmesi
            ogrenciGrafik1.Visible = false; //ogrenciGrafik1 uc' nin gizlenmesi
            ogrenciKitapAra1.Visible = false; // ogrenciKitapAra1 uc' nin gizlenmesi
            OgrBilgiListesi(); // Ogrenci bilgilerinin tutulduğu fonksiyon çağrıldı
        }
        private void kitapAra_Click(object sender, EventArgs e)
        {
            ogrenciKitapAlmaTeslim1.Visible = false; // ogrenciKitapAlmaTeslim1 uc' nin gizlenmesi
            ogrenciBilgilerim1.Visible = false; // ogrenciBilgilerim uc' nin gizlenmesi
            ogrenciCezaOdeme1.Visible = false; // ogrenciAlinanKitaplarıinListesi1 uc' nin gizlenmesi
            ogrenciGrafik1.Visible = false; //ogrenciGrafik1 uc' nin gizlenmesi
            ogrenciKitapAra1.Visible = true; // ogrenciKitapAra1 uc' nin görüntülenmesi
        }
        private void kitapAlmaIslemi_Click(object sender, EventArgs e)
        {
            ogrenciKitapAlmaTeslim1.Visible = true; // ogrenciKitapAlmaTeslim1 uc' nin gizlenmesi
            ogrenciBilgilerim1.Visible = false; // ogrenciBilgilerim uc' nin gizlenmesi
            ogrenciCezaOdeme1.Visible = false; // ogrenciAlinanKitaplarıinListesi1 uc' nin gizlenmesi
            ogrenciGrafik1.Visible = false; //ogrenciGrafik1 uc' nin gizlenmesi
            ogrenciKitapAra1.Visible = false; // ogrenciKitapAra1 uc' nin gizlenmesi
        }
        private void grafik_Click(object sender, EventArgs e)
        {
            ogrenciKitapAlmaTeslim1.Visible = false; // ogrenciKitapAlmaTeslim1 uc' nin gizlenmesi
            ogrenciBilgilerim1.Visible = false; // ogrenciBilgilerim uc' nin gizlenmesi
            ogrenciCezaOdeme1.Visible = false; // ogrenciAlinanKitaplarıinListesi1 uc' nin gizlenmesi
            ogrenciGrafik1.Visible = true; //ogrenciGrafik1 uc' nin görüntülenmesi
            ogrenciKitapAra1.Visible = false; // ogrenciKitapAra1 uc' nin gizlenmesi

            Grafik(); //Grafik fonksiyonunu çağırdık
        }
        private void cezaOdeme_Click(object sender, EventArgs e)
        {
            ogrenciKitapAlmaTeslim1.Visible = false; // ogrenciKitapAlmaTeslim1 uc' nin gizlenmesi
            ogrenciBilgilerim1.Visible = false; // ogrenciBilgilerim uc' nin gizlenmesi
            ogrenciCezaOdeme1.Visible = true; // ogrenciAlinanKitaplarıinListesi1 uc' nin görüntülenmesi
            ogrenciGrafik1.Visible = false; //ogrenciGrafik1 uc' nin gizlenmesi
            ogrenciKitapAra1.Visible = false; // ogrenciKitapAra1 uc' nin gizlenmesi
        }
        private void OgrBilgiListesi()  //Ogrencinin bilgilerinin tutulduğu fonksiyon
        {
            OgrenciVeri ogrenci = new OgrenciVeri()  // Ogrenci veriden nesne oluşturuldu
            {
                OgrenciId = int.Parse(labelOgrenciIdPanel.Text) //Id ogrenci ıd ' ye aktarıldı
            };

            // User Controllere Id Taşıma işleminin
            // gerçekleştirilmesi için label lara id atanır
            ogrenciCezaOdeme1.labelOgrenciIdCezaOdeme.Text = labelOgrenciIdPanel.Text;
            ogrenciKitapAlmaTeslim1.labelTeslimId.Text = labelOgrenciIdPanel.Text;

            //Ogrenci bilgileri labellara aktarıldı
            ogrenci = OgrenciBL.ogrenciIdBilgi(ogrenci);
            label2.Text = ogrenci.OgrenciAd + " " + ogrenci.OgrenciSoyad; // ad soyad label a eşitlenir
            ogrenciBilgilerim1.labelOgrenciAdi.Text = ogrenci.OgrenciAd; // ad label a eşitlenir
            ogrenciBilgilerim1.labelOgrenciSoyadi.Text = ogrenci.OgrenciSoyad; // soyad label a eşitlenir
            ogrenciBilgilerim1.labelOkulNumarasi.Text = ogrenci.OgrenciNo; // okul no label a eşitlenir
            ogrenciBilgilerim1.labelSifre.Text = ogrenci.OgrenciSifre; // şifre label a eşitlenir
            ogrenciBilgilerim1.labelCinsiyet.Text = ogrenci.OgrenciCinsiyet; // cinsiyet eşitlenir
            ogrenciBilgilerim1.labelCezaUcreti.Text = ogrenci.OgrenciCeza.ToString(); // ceza eşitlenir
        }
        private void Grafik()  // Grafik fonksiyon oluşturuldu
        {
            KitapIadeVeri kitap = new KitapIadeVeri()  //  KitapIadeVeri Entity katmanındaki Ogrenci ıd ye değer ataması yapıldı
            {
                OgrenciId = int.Parse(labelOgrenciIdPanel.Text)
            };

            GraphPane myPane = ogrenciGrafik1.grafikKitap.GraphPane; // GraphPane nesne oluşturuldu

            myPane.CurveList.Clear(); // grafiği temizlememimiz sağlar
            myPane.GraphObjList.Clear();// grafiği temizlememimiz sağlar

            myPane.Title.Text = "Öğrenci Kitap Grafiği"; // Grafik Başlığı yazıldı
            myPane.YAxis.Title.Text = "Kitap Sayısı"; // Y ekseninin ne olduğu yazıldı
            myPane.XAxis.Title.Text = "";
            double[] y1 = { KitapIadeBL.grafikAlinabilir(kitap) };// y1 sütununa alınabilecek
                                                                  // kitap sayısı aktarıldı
            double[] y2 = { KitapIadeBL.grafikVerilmis(kitap) };// y2 sütununa alınabilecek kitap
                                                                // sayısı aktarıldı
            double[] y3 = { KitapIadeBL.grafikHepsi() };// y3 sütununa alınabilecek kitap sayısı
                                                        // aktarıldı
            BarItem myBar = myPane.AddBar("Alınabilir Kitap Sayısı", null, y1, Color.Green);// y1 sütununun adı
                                                                                            // ve renk ataması yapıldı
            myBar.Bar.Fill = new Fill(Color.Green, Color.White, Color.Green);

            myBar = myPane.AddBar("İade Edilmemiş Kitap Sayısı", null, y2, Color.Red);// y2 sütununun adı ve renk ataması yapıldı
            myBar.Bar.Fill = new Fill(Color.Red, Color.White, Color.Red);

            myBar = myPane.AddBar("Tüm Kitap Sayısı", null, y3, Color.Orange);// y3 sütununun adı ve renk
                                                                              // ataması yapıldı
            myBar.Bar.Fill = new Fill(Color.Orange, Color.White, Color.Orange);

            myPane.XAxis.MajorTic.IsBetweenLabels = true;
            myPane.XAxis.Type = AxisType.Text;
            myPane.Chart.Fill = new Fill(Color.White,
                  Color.FromArgb(255, 255, 166), 90F);
            myPane.Fill = new Fill(Color.FromArgb(250, 250, 255));
            ogrenciGrafik1.grafikKitap.AxisChange();
        }
        private void OgrenciPanel_Load(object sender, EventArgs e)
        {
            Grafik(); //Grafik fonksiyonunu çağırdık
            OgrBilgiListesi(); // Ogrenci bilgilerinin tutulduğu fonksiyon çağrıldı

            // ---------------- Alınan Kitap Listesi ----------------
            AlinanKitapVeri alinanKitapVeri = new AlinanKitapVeri()  // nesne oluşturuldu
            {
                OgrenciId = int.Parse(labelOgrenciIdPanel.Text),  //id ataması yapıldı
            };
            ogrenciKitapAlmaTeslim1.dataGridView1.DataSource = KitapIadeBL.ogrenciIdListe(alinanKitapVeri); // Form açıldığında datagrid üzerine veritabanındaki listeyi aktardık

            // Bir sütunu gizledik ve diğer sütunların başlıklarını düzenledik
            ogrenciKitapAlmaTeslim1.dataGridView1.Columns[0].Visible = false;
            ogrenciKitapAlmaTeslim1.dataGridView1.Columns[1].HeaderText = "Kitap Adı"; // baslik kitap adi yapildi
            ogrenciKitapAlmaTeslim1.dataGridView1.Columns[2].HeaderText = "Alınma Tarihi";
            ogrenciKitapAlmaTeslim1.dataGridView1.Columns[3].HeaderText = "Teslim Tarihi";
            ogrenciKitapAlmaTeslim1.dataGridView1.Columns[4].HeaderText = "Teslim Edilmiş mi ?";
            // ---------------- Alınan Kitap Listesi ----------------

            ogrenciKitapAlmaTeslim1.dataGridView1.DataSource = KitapIadeBL.ogrenciIdListe(alinanKitapVeri); // Form açıldığında datagrid üzerine veritabanındaki listeyi aktardık

            // Bir sütunu gizledik ve diğer sütunların başlıklarını düzenledik
            ogrenciKitapAlmaTeslim1.dataGridView1.Columns[0].Visible = false;
            ogrenciKitapAlmaTeslim1.dataGridView1.Columns[1].HeaderText = "Kitap Adı";
            ogrenciKitapAlmaTeslim1.dataGridView1.Columns[2].HeaderText = "Alınma Tarihi";
            ogrenciKitapAlmaTeslim1.dataGridView1.Columns[3].HeaderText = "Teslim Tarihi";
            ogrenciKitapAlmaTeslim1.dataGridView1.Columns[4].HeaderText = "Teslim Edilmiş mi ?";

            KitapIadeVeri iade = new KitapIadeVeri()  // nesne oluşturuldu
            {
                OgrenciId = int.Parse(labelOgrenciIdPanel.Text)  // id ataması yapıldı
            };
            ogrenciKitapAlmaTeslim1.comboBox1.DataSource = KitapIadeBL.kitapAlinanLİste(iade); //Combobox a alinabilicek kitaplar aktarıldı
            ogrenciKitapAlmaTeslim1.comboBox2.DataSource = KitapIadeBL.kitapTeslimLİste(iade); // Combobox ateslim edilecek kitaplar aktarıldı
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close(); // paneli kapatır
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Brown;// mouse resim üstüne geldiğinde rengini değiştirmeyi sağlar
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(45, 134, 180);// mouse resim üstüne geldiğinde rengini değiştirmeyi sağlar
        }
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(45, 134, 180);// mouse panel üstüne geldiğinde rengini değiştirmeyi sağlar
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.Brown;// mouse panel üstüne geldiğinde rengini değiştirmeyi sağlar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // paneli kapatır 
        }
    }
}
