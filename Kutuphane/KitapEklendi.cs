using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // kütüphanesini ekliyoruz

namespace Kutuphane
{
    public partial class KitapEklendi : Form
    {
        public KitapEklendi()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); //formu kapatma işlemi
        }

        private void KitapEklendi_Load(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play(); // bildirim sesi eklenir
        }
    }
}
