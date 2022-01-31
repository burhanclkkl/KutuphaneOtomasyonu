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
    public partial class GorevliKitapListesi : UserControl
    {
        int id;  //Global Id tanımlandı
        public GorevliKitapListesi()
        {
            InitializeComponent();
        }
        private void GorevliKitapListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Indigo; // başlık rengi değiştirildi
            dataGridView1.DataSource = KitapBL.kitapListe(); // Form açıldığında datagrid üzerine veritabanındaki listeyi aktardık
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Indigo; // başlık rengi değiştirildi
            // button1 e a tıklanınca... 
            dataGridView1.DataSource = KitapBL.kitapListe();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()); // id ataması yapıldı
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green; // başlık rengi değiştirildi
            KitapOgrenciVeri kitap = new KitapOgrenciVeri()
            {
                KitapId = id
            };
            dataGridView1.DataSource = KitapIadeBL.kitapOgrenciListe(kitap);
        }
    }
}
