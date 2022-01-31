using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class GirisPanel : Form
    {
        public GirisPanel()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            girisOgrenci1.Visible = false; // girisOgrenci1 UserControl' ünün gizlenmesini sağlar
            girisDuyurular1.Visible = true; // girisDuyurular1 UserControl' ünün görünmesini sağlar3  
            girisGorevli1.Visible = false; // girisGorevli1 UserControl' ünün gizlenmesini sağlar
        }
        private void button1_Click(object sender, EventArgs e)
        {
            girisOgrenci1.Visible = false; // girisOgrenci1 UserControl' ünün gizlenmesini sağlar
            girisDuyurular1.Visible = false; // girisDuyurular1 UserControl' ünün gizlenmesini sağlar
            girisGorevli1.Visible = true; // girisGorevli1 UserControl' ünün görünmesini sağlar
        }
        private void button2_Click(object sender, EventArgs e)
        {
            girisOgrenci1.Visible = true; // girisOgrenci1 UserControl' ünün görünmesini sağlar
            girisDuyurular1.Visible = false; // girisDuyurular1 UserControl' ünün gizlenmesini sağlar
            girisGorevli1.Visible = false; // girisGorevli1 UserControl' ünün gizlenmesini sağlar
        }
        private void button3_Click(object sender, EventArgs e)
        {
            girisOgrenci1.Visible = false; // girisOgrenci1 UserControl' ünün gizlenmesini sağlar
            girisDuyurular1.Visible = true; // girisDuyurular1 UserControl' ünün görünmesini sağlar
            girisGorevli1.Visible = false; // girisGorevli1 UserControl' ünün gizlenmesini sağlar
        }
        private void label6_Click(object sender, EventArgs e)
        {
            GirisHakkimizda girisHakkimizda = new GirisHakkimizda(); // form nesnesi oluşturulur
            girisHakkimizda.Show(); // formu göstermimizi sağlar
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close(); //formu kapatma işlemi
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Brown; // mouse panel üstüne geldiğinde rengini değiştirmeyi sağlar
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(45, 134, 180);// mouse panel üstüne geldiğinde rengini değiştirmeyi sağlar
        }
        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Brown;// mouse panel üstüne geldiğinde rengini değiştirmeyi sağlar
        }
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(45, 134, 180);// mouse panel üstüne geldiğinde rengini değiştirmeyi sağlar
        }
    }
}
