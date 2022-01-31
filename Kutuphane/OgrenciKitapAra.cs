using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;        // BL katmanını kullanacağımız için ekledik.
using Entity;   // Entity katmanını kullanacağımız için ekledik.

namespace Kutuphane
{
    public partial class OgrenciKitapAra : UserControl
    {
        public OgrenciKitapAra()
        {
            InitializeComponent();
        }
        private void OgrenciKitapAra_Load(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Gray;  // textBox doldurulunca içindeki metnin beyaz renge dönmesini sağlar
            label4.Visible = false; // Öğrenci Id Gir label' ını gizlemek için Visible kullanılır

            dataGridView1.DataSource = KitapBL.kitapListe(); // Form açıldığında datagrid üzerine veritabanındaki listeyi aktardık
            //Bazı sütunların tabloda görünümünü kapattık
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = ""; // textBox1' e tıklanınca içinde yazılan değerler silinir
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.White;  // textBox doldurulunca içindeki metnin beyaz renge dönmesini sağlar
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == " " || textBox1.Text == "Kitap Id Gir") // textBox1.Text' in içine değer girilmediğinde Öğrenci Id Gir yazılır
            {
                textBox1.Text = "Kitap Id Gir"; // textBox' a Öğrenci Adı Gir yazmamızı sağlar
                label4.Visible = true; // Öğrenci Id Gir label' ını göstermek için Visible kullanılır
                textBox1.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            }
            else
            {
                label4.Visible = false; // Öğrenci Id Gir label' ını gizlemek için Visible kullanılır
                try
                {
                    KitapVeri kitap = new KitapVeri()  //Kitap veriden nesne oluşturuldu
                    {
                        KitapId = int.Parse(textBox1.Text)  // Id aktarıldı
                    };

                    kitap = KitapBL.kitapIdBilgi(kitap);  // Id bilgisi nesneye aktarıldı
                    labelKitapAdi.Text = kitap.KitapAd;
                    labelKitapTuru.Text = kitap.KitapTuru;
                    labelSayfaSayisi.Text = kitap.KitapSayfa;
                    labelYazar.Text = kitap.KitapYazar;

                    KitapOgrenciVeri kitapogrenci = new KitapOgrenciVeri()  // Kitap öğrenci veriden nesne oluşturuldu
                    {
                        KitapId = int.Parse(textBox1.Text)  // Kitap ıd 'si aktarıldı
                    };

                    if (KitapBL.kitapSorgu_BL(kitap) != false)  // Kitabın mevcut olup olmadığı kontrol edildi
                    {
                        dataGridView2.DataSource = KitapIadeBL.kitapOgrenciListe(kitapogrenci);  // Lİste datagride aktarıldı
                                                                                                 //Sütun başlıkları düzenlendi
                        dataGridView2.Columns[1].HeaderText = "Ad";
                        dataGridView2.Columns[2].HeaderText = "Soyad";
                        dataGridView2.Columns[6].HeaderText = "Teslim Edilmiş mi?";
                    }
                    else
                    {
                        KitapMevcutDegil kitapMevcutDegil = new KitapMevcutDegil();// kitap mevcut değil formu eklenir ve
                                                                                   // kitap mevcut olmadığında kullanıcıya uyarı verir
                        kitapMevcutDegil.Show();
                    };
                }
                catch (Exception)
                {
                    KitapMevcutDegil kitapMevcutDegil = new KitapMevcutDegil(); // kitap mevcut değil formu eklenir ve
                                                                                // kitap mevcut olmadığında kullanıcıya uyarı verir
                    kitapMevcutDegil.Show();
                }       
            }
        }
        private void OgrenciKitapAra_Leave(object sender, EventArgs e)
        {
            label4.Visible = false; // Kullanıcı Adı Gir label' ını gizlemek için Visible kullanılır
            textBox1.Text = "Öğrenci Id Gir"; // textBox' a Kullanıcı Adı Gir yazmamızı sağlar
            textBox1.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
        }
    }
}
