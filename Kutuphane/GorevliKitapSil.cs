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
    public partial class GorevliKitapSil : UserControl
    {
        public GorevliKitapSil()
        {
            InitializeComponent();
        }
        private void GorevliKitapSil_Load(object sender, EventArgs e)
        {
            label4.Visible = false; //label' ı gizlemek için Visible kullanılır

            dataGridView1.DataSource = KitapBL.kitapListe(); // Listenin güncel halini datagrid e yansıttık
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
            if (textBox1.Text == "" || textBox1.Text == " " || textBox1.Text == "Kitap Id Gir") // textBox1.Text' in içine değer girilmediğinde Kullanıcı Adı Gir yazılır
            {
                textBox1.Text = "Kitap Id Gir"; // textBox' a Kullanıcı Id Gir yazmamızı sağlar
                label4.Visible = true; // Kitap Id Gir label' ını göstermek için Visible kullanılır
                textBox1.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            }
            else
            {
                label4.Visible = false; // Kitap Id Gir label' ını gizlemek için Visible kullanılır
                //Entity katmanındaki KitapId değişkenine textboxtaki veriyi aktardık
                KitapVeri kitap = new KitapVeri()
                {
                    KitapId = int.Parse(textBox1.Text)
                };
                //Girilen id ye ait kitap kontrol edildi
                if (KitapBL.kitapSorgu_BL(kitap) == true)
                {
                    KitapSilindi kitapSilindi = new KitapSilindi();
                    KitapBL.kitapSil(kitap); // Business katmanındaki kitapSİL Fonksiyonuna silme işlemi için verileri gönderdik
                    kitapSilindi.Show();
                    dataGridView1.DataSource = KitapBL.kitapListe(); // Listenin güncel halini datagrid e yansıttık
                }
            }
            label4.Visible = false; // Kullanıcı Adı Gir label' ını gizlemek için Visible kullanılır
            textBox1.Text = "Kitap Id Gir"; // textBox' a Kullanıcı Adı Gir yazmamızı sağlar
            textBox1.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            dataGridView1.DataSource = KitapBL.kitapListe();// Ekleme işleminden sonra listenin güncel halini ekrana yansıttık
        }
        private void GorevliKitapSil_Leave(object sender, EventArgs e)
        {
            label4.Visible = false; // Kullanıcı Adı Gir label' ını gizlemek için Visible kullanılır
            textBox1.Text = "Kitap Id Gir"; // textBox' a Kullanıcı Adı Gir yazmamızı sağlar
            textBox1.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
