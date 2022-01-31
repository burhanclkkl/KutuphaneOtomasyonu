using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Şifremi Unuttum için eklenen form
namespace Kutuphane
{
    public partial class GirisSifremiUnuttum : Form
    {
        public GirisSifremiUnuttum()
        {
            InitializeComponent();
        }
        private void cikisPng_Click(object sender, EventArgs e)
        {
            this.Close(); //formu kapatma işlemi
        }
    }
}
