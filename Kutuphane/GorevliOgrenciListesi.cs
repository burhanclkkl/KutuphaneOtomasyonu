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
    public partial class GorevliOgrenciListesi : UserControl
    {
        public GorevliOgrenciListesi()
        {
            InitializeComponent();
        }
        private void GorevliOgrenciListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OgrenciBL.liste(); // Form açıldığında datagrid üzerine veritabanındaki listeyi aktardık
            // Tablodaki görünümü iyileştirmek için genişliğini ayarladık ve isimlerini düzenledik.
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Okul No";
            dataGridView1.Columns[4].HeaderText = "Şifre";
            dataGridView1.Columns[5].HeaderText = "Cinsiyet";
            dataGridView1.Columns[6].HeaderText = "Ceza";
        }
    }
}
