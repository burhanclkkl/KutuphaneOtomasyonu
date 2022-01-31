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
using System.Diagnostics; // linkin açılmasını sağlar

namespace Kutuphane
{
    public partial class GirisHakkimizda : Form
    {
        public GirisHakkimizda()
        {
            InitializeComponent();
        }
        private void cikisPng_Click(object sender, EventArgs e)
        {
            this.Close(); // form' un kapanmasını sağlar
        }
        private void GirisHakkimizda_Load(object sender, EventArgs e)
        {
            // Hakkımızda Label' ına tıklanınca açılacak olan UserControl
            SystemSounds.Exclamation.Play(); // bildirim sesi eklenir
        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("chrome.exe", "https://github.com/burhanclkkl");
            }
            catch (Exception)
            {

            }
        }
    }
}
