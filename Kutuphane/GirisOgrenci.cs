using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;  // Entity katmanını kullanacağımız için ekledik.
using BusinessLayer;      // BusinessLayer katmanını kullanacağımız için ekledik.

namespace Kutuphane
{
    public partial class GirisOgrenci : UserControl
    {
        public GirisOgrenci()
        {
            InitializeComponent();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            GirisSifremiUnuttum girisSifremiUnuttum = new GirisSifremiUnuttum(); // Şifreyi unuttum linkine tıklanınca form açılacak onun için nesne türettim
            girisSifremiUnuttum.Show(); // formu göstermimizi sağlar
        }
        private void GirisOgrenci_Load(object sender, EventArgs e)
        {

            textBox1.Text = "192222384"; // kolayca giriş için metin kullanıcı adına eşitlendi
            textBox2.Text = "11"; //  kolayca giriş için metin şifreye eşitlendi

            label3.Visible = false; // şifre Gir label' ını gizlemek için Visible kullanılır
            label4.Visible = false; // Kullanıcı Adı Gir label' ını gizlemek için Visible kullanılır
            textBox2.PasswordChar = '\0'; // textBox doldurulunca içindeki metnin görünmesini sağlar
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int user = 0; // şifre için atanan değer = 0
            int passw = 0; // şifre için atanan değer = 0

            if (textBox1.Text == "" || textBox1.Text == " " || textBox1.Text == "Kullanıcı Adı Gir") // textBox1.Text' in içine değer girilmediğinde Kullanıcı Adı Gir yazılır
            {
                textBox1.Text = "Kullanıcı Adı Gir"; // textBox' a Kullanıcı Adı Gir yazmamızı sağlar
                label4.Visible = true; // Kullanıcı Adı Gir label' ını göstermek için Visible kullanılır
            }
            else
            {
                label4.Visible = false; // Kullanıcı Adı Gir label' ını gizlemek için Visible kullanılır
                user = 1;
            }
            if (textBox2.Text == "" || textBox2.Text == " " || textBox2.Text == "Şifre Gir") // textBox1.Text' in içine değer girilmediğinde Şifre Gir yazılır
            {
                textBox2.Text = "Şifre Gir"; // textBox' a Şifre Gir yazmamızı sağlar
                label3.Visible = true; // şifre Gir label' ını göstermek için Visible kullanılır
                textBox2.PasswordChar = '\0'; // textBox doldurulunca içindeki metnin görünmesini sağlar
            }
            else
            {
                label3.Visible = false; // şifre Gir label' ını gizlemek için Visible kullanılır
                passw = 1;
            }
            if (user == 1 && passw == 1) // passw ve user değerlerine bakılır
            {
                OgrenciVeri ogrenci = new OgrenciVeri()       //Entity katmanındaki verilere girilen değerler aktarıldı
                {
                    OgrenciNo = textBox1.Text,
                    OgrenciSifre = textBox2.Text
                };
                if (OgrenciBL.ogrenciKontrol_BL(ogrenci) == true) // Veritabanındaki tabloda girilen değerlere ait öğrenci var mı kontrol edildi
                {
                    labelOgrenciIdGiris.Text = OgrenciBL.ogrenciIdSorgu(ogrenci).ToString(); //id ataması yapıldı
                    OgrenciPanel ogrenciPanel = new OgrenciPanel();
                    ogrenciPanel.labelOgrenciIdPanel.Text = labelOgrenciIdGiris.Text;
                    this.Hide();                         // Şuan bulunduğumuz form kapatıldı
                    ogrenciPanel.Show();                 // Oluşturulan nesne ile geçiş yapılacak form ekranı açıldı
                }
                else
                {
                    GirisSifremiUnuttum hataliSifre = new GirisSifremiUnuttum();
                    hataliSifre.Show(); // Oluşturulan nesnenin formu açıldı
                    label3.Visible = false; // şifre Gir label' ını gizlemek için Visible kullanılır
                    label4.Visible = false; // Kullanıcı Adı Gir label' ını gizlemek için Visible kullanılır
                    textBox1.Text = "Kullanıcı Adı Gir"; // textBox' a Kullanıcı Adı Gir yazmamızı sağlar
                    textBox1.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
                    textBox2.Text = "Şifre Gir"; // textBox' a Şifre Gir yazmamızı sağlar
                    textBox2.ForeColor = Color.Gray;  // textBox doldurulunca içindeki metnin beyaz renge dönmesini sağlar
                    textBox2.PasswordChar = '\0'; // textBox doldurulunca içindeki metnin görünmesini sağlars
                }
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = ""; // textBox1' e tıklanınca içinde yazılan değerler silinir
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = ""; // textBox2' ye tıklanınca içinde yazılan değerler silinir
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.White; // textBox doldurulunca içindeki metnin beyaz renge dönmesini sağlar
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.White;  // textBox doldurulunca içindeki metnin beyaz renge dönmesini sağlar
            textBox2.PasswordChar = '*'; // textBox doldurulunca içindeki metnin *** olmasını sağlar
        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0'; // textBox doldurulunca içindeki metnin görünmesini sağlar
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*'; // textBox doldurulunca içindeki metnin *** olarak görünmesini sağlar
        }
        private void GirisOgrenci_Leave(object sender, EventArgs e)
        {
            label3.Visible = false; // şifre Gir label' ını gizlemek için Visible kullanılır
            label4.Visible = false; // Kullanıcı Adı Gir label' ını gizlemek için Visible kullanılır
            textBox1.Text = "Kullanıcı Adı Gir"; // textBox' a Kullanıcı Adı Gir yazmamızı sağlar
            textBox1.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            textBox2.Text = "Şifre Gir"; // textBox' a Şifre Gir yazmamızı sağlar
            textBox2.ForeColor = Color.Gray;  // textBox doldurulunca içindeki metnin beyaz renge dönmesini sağlar
            textBox2.PasswordChar = '\0'; // textBox doldurulunca içindeki metnin görünmesini sağlar
        }
    }
}
