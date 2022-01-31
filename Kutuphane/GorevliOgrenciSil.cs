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
    public partial class GorevliOgrenciSil : UserControl
    {
        public GorevliOgrenciSil()
        {
            InitializeComponent();
        }
        private void GorevliOgrenciSil_Load(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Gray;  // textBox doldurulunca içindeki metnin beyaz renge dönmesini sağlar
            label4.Visible = false; // Öğrenci Id Gir label' ını gizlemek için Visible kullanılır
            dataGridView1.DataSource = OgrenciBL.liste(); // Lİstenin güncel halini datagrid e yansıttık
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
            if (textBox1.Text == "" || textBox1.Text == " " || textBox1.Text == "Öğrenci Id Gir") // textBox1.Text' in içine değer girilmediğinde Öğrenci Id Gir yazılır
            {
                textBox1.Text = "Öğrenci Id Gir"; // textBox' a Öğrenci Adı Gir yazmamızı sağlar
                label4.Visible = true; // Öğrenci Id Gir label' ını göstermek için Visible kullanılır
                textBox1.ForeColor = Color.Gray; // textBox doldurulunca içindeki metnin gri renge dönmesini sağlar
            }
            else
            {
                label4.Visible = false; // Öğrenci Id Gir label' ını gizlemek için Visible kullanılır
                //Entity katmanındaki OgrenciId değişkenine textboxtaki veriyi aktardık
                OgrenciVeri ogrenci = new OgrenciVeri()
                {
                    OgrenciId = int.Parse(textBox1.Text)
                };
                if (OgrenciBL.ogrenciSorgu_BL(ogrenci) == true)
                {
                    OgrenciBL.ogrenciSil(ogrenci); // Business katmanındaki ogrenciSİL Fonksiyonuna silme işlemi için verileri gönderdik
                    OgrenciSilindi ogrenciSilindi = new OgrenciSilindi(); // Form nesnesi türetilir
                    ogrenciSilindi.Show();
                    dataGridView1.DataSource = OgrenciBL.liste(); // Lİstenin güncel halini datagrid e yansıttık
                }
            }
            dataGridView1.DataSource = OgrenciBL.liste(); // Lİstenin güncel halini datagrid e yansıttık
        }
        private void GorevliOgrenciSil_Leave(object sender, EventArgs e)
        {
            label4.Visible = false; // Kullanıcı Adı Gir label' ını gizlemek için Visible kullanılır
            textBox1.Text = "Öğrenci Id Gir"; // textBox' a Kullanıcı Adı Gir yazmamızı sağlar
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
