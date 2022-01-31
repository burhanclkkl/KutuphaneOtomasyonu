using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;  // BusinessLayer katmanını kullandık
using Entity; // Entity katmanını kullandık
namespace Kutuphane
{
    public partial class OgrenciCezaOdeme : UserControl
    {
        public OgrenciCezaOdeme()
        {
            InitializeComponent();
        }

        private void OgrenciCezaOdeme_Load(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Gray;  // textBox doldurulunca içindeki metnin beyaz renge dönmesini sağlar
            label4.Visible = false; // Öğrenci Id Gir label' ını gizlemek için Visible kullanılır
        }
        public int tutar = 0; // tutar string i oluşturulur
                              // ve 0 değeri atanır, bu değer label değeri dolu
                              // ise 1 e çevirilir
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == " " || textBox1.Text == "Tutar Gir") // textBox1.Text' in içine değer girilmediğinde Öğrenci Adı Gir yazılır
            {
                textBox1.Text = "Tutar Gir"; // textBox' a Kullanıcı Adı Gir yazmamızı sağlar
                label4.Visible = true; // Kitap Adı Gir label' ını göstermek için Visible kullanılır
                textBox1.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            }
            else
            {
                label4.Visible = false; // Kitap Adı Gir label' ını gizlemek için Visible kullanılır
                tutar = 1;
            }
            if (tutar == 1)
            {
                KitapIadeVeri ogrenciId = new KitapIadeVeri()  // nesne oluşturuldu
                {
                    OgrenciId = int.Parse(labelOgrenciIdCezaOdeme.Text) //id ataması yapıldı
                };
                KitapIadeBL.ogrenciCeza(ogrenciId); // Ceza bilgisi çekildi
                
                if (Convert.ToInt32(textBox1.Text) < 0)
                {
                    HataliCezaOdeme hataliCezaOdeme = new HataliCezaOdeme();
                    hataliCezaOdeme.Show();
                }
                else
                {
                    if (ogrenciId.OgrenciCeza != 0)  // ceza durumu 0 değil ise...
                    {
                        float ceza = ogrenciId.OgrenciCeza - float.Parse(textBox1.Text); //ceza farkı atandı
                        if (ceza >= 0)  // cezanın eksi olmaması kontrol edildi
                        {
                            CezaOdeme cezaOdeme = new CezaOdeme();
                            ogrenciId.OgrenciCeza = ceza; // Ogrenci cezasına aktarıldı
                            KitapIadeBL.ogrenciCezaIslemi(ogrenciId); //veri tabanı ile işlem gerçekleşti
                            cezaOdeme.Show();
                        }
                        else
                        {
                            HataliCezaOdeme hataliCezaOdeme = new HataliCezaOdeme();
                            hataliCezaOdeme.Show();
                        }
                    }
                    else
                    {
                        BorcunuzBulunmamaktadir borcunuzBulunmamaktadir = new BorcunuzBulunmamaktadir();
                        borcunuzBulunmamaktadir.Show();
                        label4.Visible = false; // Kullanıcı Adı Gir label' ını gizlemek için Visible kullanılır
                        textBox1.Text = "Tutar Gir"; // textBox' a Tutar Gir yazmamızı sağlar
                        textBox1.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
                    }
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.White;  // textBox doldurulunca içindeki metnin beyaz renge dönmesini sağlar
        }
        private void OgrenciCezaOdeme_Leave(object sender, EventArgs e)
        {
            label4.Visible = false; // Kullanıcı Adı Gir label' ını gizlemek için Visible kullanılır
            textBox1.Text = "Tutar Gir"; // textBox' a Tutar Gir yazmamızı sağlar
            textBox1.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = ""; // textBox1' e tıklanınca içinde yazılan değerler silinir
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
