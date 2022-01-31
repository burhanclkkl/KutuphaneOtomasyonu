using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;        // BusinessLayer katmanını kullanacağımız için ekledik.
using Entity;   // Entity katmanını kullanacağımız için ekledik.

namespace Kutuphane
{
    public partial class GorevliOgrenciGuncelle : UserControl
    {
        public GorevliOgrenciGuncelle()
        {
            InitializeComponent();
        }
        int id;
        string ilkNo;
        private void GorevliOgrenciGuncelle_Load(object sender, EventArgs e)
        {
            label4.Visible = false;//label' ı gizlemek için Visible kullanılır
            label1.Visible = false;//label' ı gizlemek için Visible kullanılır
            label5.Visible = false;//label' ı gizlemek için Visible kullanılır
            label7.Visible = false;//label' ı gizlemek için Visible kullanılır
            label9.Visible = false;//label' ı gizlemek için Visible kullanılır

            dataGridView1.DataSource = OgrenciBL.liste(); // Form açıldığında datagrid üzerine veritabanındaki listeyi aktardık
                                                          // Form açıldığında guncelleme kısmındaki textboxların ve gunceleme için gerekli id nin boş kalmasını  sağladık.
                                                          // Tablodaki görünümü iyileştirmek için genişliğini ayarladık ve isimlerini düzenledik.
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Okul NO";
            dataGridView1.Columns[4].HeaderText = "Sifre";
            dataGridView1.Columns[5].HeaderText = "Cinsiyet";
            dataGridView1.Columns[6].HeaderText = "Ceza";
        }
        int t1 = 0, t2 = 0, t3 = 0, t4 = 0, t5 = 0; // textboxların boş olması durumu için
                                            // eklenen değer atamaları
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == " " || textBox1.Text == "Öğrenci Adı Gir") // textBox1.Text' in içine değer girilmediğinde Öğrenci Adı Gir yazılır
            {
                textBox1.Text = "Öğrenci Adı Gir"; // textBox' a Öğrenci Adı Gir yazmamızı sağlar
                label4.Visible = true; // Öğrenci Adı Gir label' ını göstermek için Visible kullanılır
                textBox1.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            }
            else
            {
                label4.Visible = false; // Öğrenci Adı Gir label' ını gizlemek için Visible kullanılır  
                t1 = 1;
            }
            if (textBox3.Text == "" || textBox3.Text == " " || textBox3.Text == "Öğrenci Soyadı Gir") // textBox3.Text' in içine değer girilmediğinde Öğrenci Soyadı Gir yazılır
            {
                textBox3.Text = "Öğrenci Soyadı Gir"; // textBox' a Sayfa Sayısı Gir yazmamızı sağlar
                label5.Visible = true; // Öğrenci Soyadı Gir label' ını göstermek için Visible kullanılır
                textBox3.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            }
            else
            {
                label5.Visible = false; // Öğrenci Soyadı Gir label' ını gizlemek için Visible kullanılır
                t2 = 1;
            }
            if (comboBox1.Text == "" || comboBox1.Text == " ") // comboBox1.Text' in içine değer girilmediğinde Geçersiz Cinsiyet
            {
                label1.Visible = true; //Cinsiyet label' ını göstermek için Visible kullanılır
            }
            else
            {
                label1.Visible = false; // Yazar Adı Gir label' ını gizlemek için Visible kullanılır
                t3 = 1;
            }
            if (textBox4.Text == "" || textBox4.Text == " " || textBox4.Text == "Okul Numarası Gir") // textBox4.Text' in içine değer girilmediğinde Okul Numarası Gir yazılır
            {
                textBox4.Text = "Okul Numarası Gir"; // textBox' a Kullanıcı Adı Gir yazmamızı sağlar
                label7.Visible = true; // Okul Numarası Gir label' ını göstermek için Visible kullanılır
                textBox4.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            }
            else
            {
                label7.Visible = false; // Yazar Adı Gir label' ını gizlemek için Visible kullanılır
                t4 = 1;
            }

            if (textBox5.Text == "" || textBox5.Text == " " || textBox5.Text == "Şifre Gir") // textBox4.Text' in içine değer girilmediğinde Okul Numarası Gir yazılır
            {
                textBox4.Text = "Şifre Gir"; // textBox' a Kullanıcı Adı Gir yazmamızı sağlar
                label9.Visible = true; // Okul Numarası Gir label' ını göstermek için Visible kullanılır
                textBox4.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            }
            else
            {
                label9.Visible = false; // Yazar Adı Gir label' ını gizlemek için Visible kullanılır
                t5 = 1;
            }
            // textboların boş olup olmaması
            //durumuna göre değer atması yapılır
            if (t1 == 1 && t2 == 1 && t3 == 1 && t4 == 1 && t5 == 1)
            {
                //Entity katmanındaki değişkenlere textboxtaki verileri aktardık
                OgrenciVeri ogrenci = new OgrenciVeri()
                {
                    OgrenciAd = textBox1.Text,
                    OgrenciSoyad = textBox3.Text,
                    OgrenciNo = textBox4.Text,
                    OgrenciSifre = textBox5.Text,
                    OgrenciCinsiyet = comboBox1.Text,
                    OgrenciId = id
                };
                // Girilen id ye ait ogrenci kontrol edildi
                if (OgrenciBL.ogrenciSorgu_BL(ogrenci) == true)
                {
                    if (OgrenciBL.ogrenciOkulNoKOntrol(ogrenci) == true || ilkNo == ogrenci.OgrenciNo.ToString())
                    {
                        OgrenciBL.ogrenciGuncelle(ogrenci);// Business katmanındaki ogrenciGuncelle Fonksiyonuna guncelleme işlemi için verileri gönderdik
                        
                        MessageBox.Show("Guncellendi");
                        dataGridView1.DataSource = OgrenciBL.liste();// Lİstenin güncel halini datagrid e yansıttık
                    }
                    else
                    {
                        OgrenciNumarasiMevcut ogrenciNumarasiMevcut = new OgrenciNumarasiMevcut(); // Öğrenci mevcut formu oluşturulur
                        ogrenciNumarasiMevcut.Show();
                    }
                }
            }
            dataGridView1.DataSource = OgrenciBL.liste(); // Lİstenin güncel halini datagrid e yansıttık
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.White;  // textBox doldurulunca içindeki metnin beyaz renge dönmesini sağlar
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.White;  // textBox doldurulunca içindeki metnin beyaz renge dönmesini sağlar
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.White;  // textBox doldurulunca içindeki metnin beyaz renge dönmesini sağlar
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ForeColor = Color.White;  // textBox doldurulunca içindeki metnin beyaz renge dönmesini sağlar
        }
        private void GorevliOgrenciGuncelle_Leave(object sender, EventArgs e)
        {
            label4.Visible = false;//label' ı gizlemek için Visible kullanılır
            label1.Visible = false;//label' ı gizlemek için Visible kullanılır
            label5.Visible = false;//label' ı gizlemek için Visible kullanılır
            label7.Visible = false;//label' ı gizlemek için Visible kullanılır
            label9.Visible = false;//label' ı gizlemek için Visible kullanılır

            textBox1.Text = "Öğrenci Adı Gir"; // textBox' a Kullanıcı Adı Gir yazmamızı sağlar
            textBox3.Text = "Öğrenci Soyadı Gir"; // textBox' a Sayfa Sayısı Gir yazmamızı sağlar
            textBox4.Text = "Okul Numarası Gir"; // textBox' a Kullanıcı Adı Gir yazmamızı sağlar

            textBox3.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            textBox1.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            textBox4.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            textBox5.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = ""; // textBox1' e tıklanınca içinde yazılan değerler silinir
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //Tablo üzerinde tıklanan satırın verilerini guncelleme alanındaki textboxlara yazdırdık
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            ilkNo = textBox4.Text;
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = ""; // textBox1' e tıklanınca içinde yazılan değerler silinir
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = ""; // textBox1' e tıklanınca içinde yazılan değerler silinir
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.Text = ""; // textBox1' e tıklanınca içinde yazılan değerler silinir
        }
    }
}
