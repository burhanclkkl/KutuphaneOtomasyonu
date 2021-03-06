using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;   // Entity katmanını kullanacağımız için ekledik.
using BusinessLayer;      // BusinessLayer katmanını kullanacağımız için ekledik.

namespace Kutuphane
{
    public partial class GirisGorevli : UserControl
    {
        public GirisGorevli()
        {
            InitializeComponent();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            GirisSifremiUnuttum girisSifremiUnuttum = new GirisSifremiUnuttum(); // Şifreyi unuttum linkine tıklanınca form açılacak onun için nesne türettim
            girisSifremiUnuttum.Show(); // formu göstermimizi sağlar
        }
        private void GirisGorevli_Load(object sender, EventArgs e)
        {
            textBox1.Text = "10000770044"; // kolayca giriş için metin tc ye eşitlendi
            textBox2.Text = "123456"; //  kolayca giriş için metin şifreye eşitlendi

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
                passw = 1;// şifre int i 1 e şitlenir
            }
            if (user == 1 && passw == 1) // passw ve user değerlerine bakılır
            {
                GorevliVeri gorevli = new GorevliVeri()  // Girilen veriler entity katmanındaki değişkenlere atandı
                {
                    //textbox ı görevTc ye eşitleriz 
                    gorevTc = textBox1.Text,
                    //textbox ı gorevSifre ye eşitleriz 
                    gorevSifre = textBox2.Text
                };

                if (GorevliBL.gorevliKontrol_BL(gorevli) == true) //Girilen değerler veri tabanındaki tabloda mevcut ise işlem gerçekleşti
                {
                    GorevliPanel gorevliPanel = new GorevliPanel(); // Gorevli geçiş formundan nesne üretildi
                    this.Hide(); // Bulunduğumuz fonksiyon kapatıldı
                    gorevliPanel.Show(); // Oluşturulan nesnenin formu açıldı
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
                    textBox2.PasswordChar = '\0'; // textBox doldurulunca içindeki metnin görünmesini sağlar
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
        private void GirisGorevli_Leave(object sender, EventArgs e)
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
