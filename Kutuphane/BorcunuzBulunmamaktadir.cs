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
    public partial class BorcunuzBulunmamaktadir : Form
    {
        public BorcunuzBulunmamaktadir()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); //formu kapatma işlemi

        }

        private void BorcunuzBulunmamaktadir_Load(object sender, EventArgs e)
            //borç bulunmadaığında açılan form
        {
            SystemSounds.Exclamation.Play(); // bildirim sesi eklenir
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
