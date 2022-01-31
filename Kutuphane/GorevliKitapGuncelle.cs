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
    public partial class GorevliKitapGuncelle : UserControl
    {
        public GorevliKitapGuncelle()
        {
            InitializeComponent();
        }
        private void GorevliKitapGuncelle_Load(object sender, EventArgs e)
        {
            label4.Visible = false;//label' ı gizlemek için Visible kullanılır
            label1.Visible = false;//label' ı gizlemek için Visible kullanılır
            label5.Visible = false;//label' ı gizlemek için Visible kullanılır
            label7.Visible = false;//label' ı gizlemek için Visible kullanılır

            dataGridView1.DataSource = KitapBL.kitapListe(); // Form açıldığında datagrid üzerine veritabanındaki listeyi aktardık      
        }
        int id;// Form açıldığında guncelleme kısmındaki textboxların ve gunceleme için gerekli id nin boş kalmasını  sağladık.
        int t1 = 0, t2 = 0, t3 = 0, t4 = 0; // şifre için int değerleri atanır
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == " " || textBox1.Text == "Kitap Adı Gir") // textBox1.Text' in içine değer girilmediğinde Kullanıcı Adı Gir yazılır
            {
                textBox1.Text = "Kitap Adı Gir"; // textBox' a Kullanıcı Adı Gir yazmamızı sağlar
                label4.Visible = true; // Kitap Adı Gir label' ını göstermek için Visible kullanılır
                textBox1.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            }
            else
            {
                label4.Visible = false; // Kitap Adı Gir label' ını gizlemek için Visible kullanılır
                t1 = 1;
            }
            if (textBox3.Text == "" || textBox3.Text == " " || textBox3.Text == "Sayfa Sayısı Gir") // textBox3.Text' in içine değer girilmediğinde Kullanıcı Sayfa Sayısı Gir yazılır
            {
                textBox3.Text = "Sayfa Sayısı Gir"; // textBox' a Sayfa Sayısı Gir yazmamızı sağlar
                label5.Visible = true; // Sayfa Sayısı Gir label' ını göstermek için Visible kullanılır
                textBox3.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            }
            else
            {
                label5.Visible = false; // Sayfa Sayısı Gir label' ını gizlemek için Visible kullanılır
                t2= 1;
            }
            if (textBox4.Text == "" || textBox4.Text == " " || textBox4.Text == "Yazar Adı Gir") // textBox4.Text' in içine değer girilmediğinde Yazar Adı Gir yazılır
            {
                textBox4.Text = "Yazar Adı Gir"; // textBox' a Kullanıcı Adı Gir yazmamızı sağlar
                label7.Visible = true; // Yazar Adı Gir label' ını göstermek için Visible kullanılır
                textBox4.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            }
            else
            {
                label7.Visible = false; // Yazar Adı Gir label' ını gizlemek için Visible kullanılır
                t3 = 1;
            }
            if (comboBox1.Text == "" || comboBox1.Text == " ") // comboBox1.Text' in içine değer girilmediğinde Geçersiz Kitap Türü
            {
                label1.Visible = true; //Geçersiz Kitap Türü label' ını göstermek için Visible kullanılır
            }
            else
            {
                label1.Visible = false; // Yazar Adı Gir label' ını gizlemek için Visible kullanılır
                t4 = 1;
            }
            if (t1 == 1 && t2 == 1 && t3 == 1 && t4 == 1)
            {
                //Entity katmanındaki değişkenlere textboxtaki verileri aktardık
                KitapVeri kitap = new KitapVeri()
                {
                    KitapAd = textBox1.Text,
                    KitapTuru = comboBox1.Text,
                    KitapSayfa = textBox3.Text,
                    KitapYazar = textBox4.Text,
                    KitapId = id
                };
                // Girilen id ye ait kitap kontrol edildi
                if (KitapBL.kitapSorgu_BL(kitap) == true)
                {
                    KitapBL.kitapGuncelle(kitap);// Business katmanındaki kitapGuncelle Fonksiyonuna guncelleme işlemi için verileri gönderdik
                    MessageBox.Show("Guncellendi");
                    dataGridView1.DataSource = KitapBL.kitapListe();// Lİstenin güncel halini datagrid e yansıttık
                    //Güncelleme işlemi bitince textboxları temizledik
                    textBox1.Text = "";
                    comboBox1.Text = null;
                    textBox3.Text = "";
                    textBox4.Text = "";
                    id = 0;
                }
            }
            dataGridView1.DataSource = KitapBL.kitapListe();// Ekleme işleminden sonra listenin güncel halini ekrana yansıttık
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = ""; // textBox1' e tıklanınca içinde yazılan değerler silinir
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = ""; // textBox1' e tıklanınca içinde yazılan değerler silinir
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = ""; // textBox1' e tıklanınca içinde yazılan değerler silinir
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.White;  // textBox doldurulunca içindeki metnin beyaz renge dönmesini sağlar
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.White;  // textBox doldurulunca içindeki metnin beyaz renge dönmesini sağlar
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textboxuna harf girisini engelleme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.White;  // textBox doldurulunca içindeki metnin beyaz renge dönmesini sağlar
        }
        private void GorevliKitapGuncelle_Leave(object sender, EventArgs e)
        {
            label4.Visible = false; //label' ı gizlemek için Visible kullanılır
            label1.Visible = false; //label' ı gizlemek için Visible kullanılır
            label5.Visible = false; //label' ı gizlemek için Visible kullanılır
            label7.Visible = false; //label' ı gizlemek için Visible kullanılır

            textBox1.Text = "Kitap Adı Gir"; // textBox' a Kullanıcı Adı Gir yazmamızı sağlar
            textBox3.Text = "Sayfa Sayısı Gir"; // textBox' a Sayfa Sayısı Gir yazmamızı sağlar
            textBox4.Text = "Yazar Adı Gir"; // textBox' a Kullanıcı Adı Gir yazmamızı sağlar

            textBox3.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            textBox1.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            textBox4.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //Tablo üzerinde tıklanan satırın verilerini guncelleme alanındaki textboxlara yazdırdık
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
