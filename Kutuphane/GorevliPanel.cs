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
    public partial class GorevliPanel : Form
    {
        public GorevliPanel()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close(); //formu kapatma işlemi
        }
        private void GorevliPanel_Load(object sender, EventArgs e)
        {
            gorevliKitapEkle1.Visible = false; // gorevliKitapEkle1 UserContol' ün gizlenmesini sağlar
            gorevliKitapGuncelle1.Visible = false; // gorevliKitapGuncelle1 UserContol' ün gizlenmesini sağlar
            gorevliKitapListesi1.Visible = false; // gorevliKitapListesi1 UserContol' ün görünmesini sağlar
            gorevliKitapSil1.Visible = false; //gorevliKitapSil1 UserContol' ün görünmesini sağlar

            gorevliOgrenciEkle1.Visible = false; // gorevliOgrenciEkle1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciGuncelle1.Visible = false; // gorevliOgrenciGuncelle1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciListesi1.Visible = false; // gorevliOgrenciListesi1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciSil1.Visible = false; // gorevliOgrenciSil1 UserContol' ün gizlenmesini sağlar
        }

        private void kitapListesiButton_Click(object sender, EventArgs e)
        {
            gorevliKitapEkle1.Visible = false; // gorevliKitapEkle1 UserContol' ün gizlenmesini sağlar
            gorevliKitapGuncelle1.Visible = false; // gorevliKitapGuncelle1 UserContol' ün gizlenmesini sağlar
            gorevliKitapListesi1.Visible = true; // gorevliKitapListesi1 UserContol' ün görünmesini sağlar
            gorevliKitapSil1.Visible = false; //gorevliKitapSil1 UserContol' ün görünmesini sağlar

            gorevliOgrenciEkle1.Visible = false; // gorevliOgrenciEkle1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciGuncelle1.Visible = false; // gorevliOgrenciGuncelle1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciListesi1.Visible = false; // gorevliOgrenciListesi1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciSil1.Visible = false; // gorevliOgrenciSil1 UserContol' ün gizlenmesini sağlar
            gorevliKitapListesi1.dataGridView1.DataSource = KitapBL.kitapListe();// Ekleme işleminden sonra listenin güncel halini ekrana yansıttık
        }

        private void kitapEkleButton_Click(object sender, EventArgs e)
        {
            gorevliKitapEkle1.Visible = true; // gorevliKitapEkle1 UserContol' ün görünmesi sağlar
            gorevliKitapGuncelle1.Visible = false; // gorevliKitapGuncelle1 UserContol' ün gizlenmesini sağlar
            gorevliKitapListesi1.Visible = false; // gorevliKitapListesi1 UserContol' ün gizlenmesini sağlar
            gorevliKitapSil1.Visible = false; //gorevliKitapSil1 UserContol' ün görünmesini sağlar

            gorevliOgrenciEkle1.Visible = false; // gorevliOgrenciEkle1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciGuncelle1.Visible = false; // gorevliOgrenciGuncelle1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciListesi1.Visible = false; // gorevliOgrenciListesi1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciSil1.Visible = false; // gorevliOgrenciSil1 UserContol' ün gizlenmesini sağlar
            gorevliKitapEkle1.dataGridView1.DataSource = KitapBL.kitapListe();// Ekleme işleminden sonra listenin güncel halini ekrana yansıttık

        }

        private void kitapGuncelleButton_Click(object sender, EventArgs e)
        {
            gorevliKitapEkle1.Visible = false; // gorevliKitapEkle1 UserContol' ün gizlenmesini sağlar
            gorevliKitapGuncelle1.Visible = true; // gorevliKitapGuncelle1 UserContol' ün görünmesi sağlar
            gorevliKitapListesi1.Visible = false; // gorevliKitapListesi1 UserContol' ün gizlenmesini sağlar
            gorevliKitapSil1.Visible = false; //gorevliKitapSil1 UserContol' ün görünmesini sağlar

            gorevliOgrenciEkle1.Visible = false; // gorevliOgrenciEkle1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciGuncelle1.Visible = false; // gorevliOgrenciGuncelle1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciListesi1.Visible = false; // gorevliOgrenciListesi1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciSil1.Visible = false; // gorevliOgrenciSil1 UserContol' ün gizlenmesini sağlar
            gorevliKitapGuncelle1.dataGridView1.DataSource = KitapBL.kitapListe();// Ekleme işleminden sonra listenin güncel halini ekrana yansıttık

        }

        private void kitapSilButton_Click(object sender, EventArgs e)
        {
            gorevliKitapEkle1.Visible = false; // gorevliKitapEkle1 UserContol' ün gizlenmesini sağlar
            gorevliKitapGuncelle1.Visible = false; // gorevliKitapGuncelle1 UserContol' ün gizlenmesini sağlar
            gorevliKitapListesi1.Visible = false; // gorevliKitapListesi1 UserContol' ün gizlenmesini sağlar
            gorevliKitapSil1.Visible = true; //gorevliKitapSil1 UserContol' ün görünmesi sağlar

            gorevliOgrenciEkle1.Visible = false; // gorevliOgrenciEkle1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciGuncelle1.Visible = false; // gorevliOgrenciGuncelle1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciListesi1.Visible = false; // gorevliOgrenciListesi1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciSil1.Visible = false; // gorevliOgrenciSil1 UserContol' ün gizlenmesini sağlar
            gorevliKitapSil1.dataGridView1.DataSource = KitapBL.kitapListe();// Ekleme işleminden sonra listenin güncel halini ekrana yansıttık

        }

        private void OgrenciListesiButton_Click(object sender, EventArgs e)
        {
            gorevliKitapEkle1.Visible = false; // gorevliKitapEkle1 UserContol' ün gizlenmesini sağlar
            gorevliKitapGuncelle1.Visible = false; // gorevliKitapGuncelle1 UserContol' ün gizlenmesini sağlar
            gorevliKitapListesi1.Visible = false; // gorevliKitapListesi1 UserContol' ün gizlenmesini sağlar
            gorevliKitapSil1.Visible = false; //gorevliKitapSil1 UserContol' ün görünmesi sağlar

            gorevliOgrenciEkle1.Visible = false; // gorevliOgrenciEkle1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciGuncelle1.Visible = false; // gorevliOgrenciGuncelle1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciListesi1.Visible = true; // gorevliOgrenciListesi1 UserContol' ün görünmesini sağlar
            gorevliOgrenciSil1.Visible = false; // gorevliOgrenciSil1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciListesi1.dataGridView1.DataSource = OgrenciBL.liste(); // Lİstenin güncel halini datagrid e yansıttık

        }

        private void ogrenciEkleButton_Click(object sender, EventArgs e)
        {
            gorevliKitapEkle1.Visible = false; // gorevliKitapEkle1 UserContol' ün gizlenmesini sağlar
            gorevliKitapGuncelle1.Visible = false; // gorevliKitapGuncelle1 UserContol' ün gizlenmesini sağlar
            gorevliKitapListesi1.Visible = false; // gorevliKitapListesi1 UserContol' ün gizlenmesini sağlar
            gorevliKitapSil1.Visible = false; //gorevliKitapSil1 UserContol' ün görünmesi sağlar

            gorevliOgrenciEkle1.Visible = true; // gorevliOgrenciEkle1 UserContol' ün görünmesini sağlar
            gorevliOgrenciGuncelle1.Visible = false; // gorevliOgrenciGuncelle1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciListesi1.Visible = false; // gorevliOgrenciListesi1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciSil1.Visible = false; // gorevliOgrenciSil1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciEkle1.dataGridView1.DataSource = OgrenciBL.liste(); // Lİstenin güncel halini datagrid e yansıttık

        }

        private void ogrenciGuncelleButton_Click(object sender, EventArgs e)
        {
            gorevliKitapEkle1.Visible = false; // gorevliKitapEkle1 UserContol' ün gizlenmesini sağlar
            gorevliKitapGuncelle1.Visible = false; // gorevliKitapGuncelle1 UserContol' ün gizlenmesini sağlar
            gorevliKitapListesi1.Visible = false; // gorevliKitapListesi1 UserContol' ün gizlenmesini sağlar
            gorevliKitapSil1.Visible = false; //gorevliKitapSil1 UserContol' ün görünmesi sağlar

            gorevliOgrenciEkle1.Visible = false; // gorevliOgrenciEkle1 UserContol' ün görünmesini sağlar
            gorevliOgrenciGuncelle1.Visible = true; // gorevliOgrenciGuncelle1 UserContol' ün görünmesini sağlar
            gorevliOgrenciListesi1.Visible = false; // gorevliOgrenciListesi1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciSil1.Visible = false; // gorevliOgrenciSil1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciGuncelle1.dataGridView1.DataSource = OgrenciBL.liste(); // Lİstenin güncel halini datagrid e yansıttık

        }

        private void ogrenciSilButton_Click(object sender, EventArgs e)
        {
            gorevliKitapEkle1.Visible = false; // gorevliKitapEkle1 UserContol' ün gizlenmesini sağlar
            gorevliKitapGuncelle1.Visible = false; // gorevliKitapGuncelle1 UserContol' ün gizlenmesini sağlar
            gorevliKitapListesi1.Visible = false; // gorevliKitapListesi1 UserContol' ün gizlenmesini sağlar
            gorevliKitapSil1.Visible = false; //gorevliKitapSil1 UserContol' ün görünmesini sağlar

            gorevliOgrenciEkle1.Visible = false; // gorevliOgrenciEkle1 UserContol' ün görünmesini sağlar
            gorevliOgrenciGuncelle1.Visible = false; // gorevliOgrenciGuncelle1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciListesi1.Visible = false; // gorevliOgrenciListesi1 UserContol' ün gizlenmesini sağlar
            gorevliOgrenciSil1.Visible = true; // gorevliOgrenciSil1 UserContol' ün görünmesi sağlar
            gorevliOgrenciSil1.dataGridView1.DataSource = OgrenciBL.liste(); // Lİstenin güncel halini datagrid e yansıttık

        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Brown;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(45, 134, 180);
        }
        private void gorevliOgrenciSil1_Load(object sender, EventArgs e)
        {

        }
        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Brown; // mouse panel üstüne geldiğinde rengini değiştirmeyi sağlar
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(45, 134, 180);// mouse panel üstüne geldiğinde rengini değiştirmeyi sağlar
        }
    }
}
