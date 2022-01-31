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
    public partial class OgrenciKitapAlmaTeslim : UserControl
    {
        public OgrenciKitapAlmaTeslim()
        {
            InitializeComponent();
        }
        public void listeRenklendirme() //Tabloda teslim sürelerinin gecikme veya teslim edilme durumlarına göre renklendirme yapıldı
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++) // Tablo satırı kadar döndürüldü
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle(); //Nesne oluşturuldu

                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[4].Value) == true) // testlim edilme durumu kontrol edildi
                {
                    //Satır renklendirildi
                    renk.BackColor = Color.Green;
                    renk.ForeColor = Color.White;
                }
                else
                {
                    //Teslim edilmeyen kitapların teslim tarihine ne kadar kaldığı öğrenildi
                    TimeSpan sonuc = DateTime.Now - Convert.ToDateTime(dataGridView1.Rows[i].Cells[2].Value);

                    // 15 gün ve üzeri ise satır kırmızı renk yapıldı
                    if (sonuc.TotalDays > 15)
                    {
                        renk.BackColor = Color.Red;
                    }
                    // teslim süresine 2 gün kalmış ise satır sarı yapıldı
                    if (sonuc.TotalDays >= 13 && sonuc.TotalDays <= 15)
                    {
                        renk.BackColor = Color.Yellow;
                    }
                }
                dataGridView1.Rows[i].DefaultCellStyle = renk; // Satırlara renklendirme işlemi gerçekleştirildi
            }
        }
        private void OgrenciKitapAlmaIslemi_Load(object sender, EventArgs e)
        {
            label4.Visible = false;//label' ı gizlemek için Visible kullanılır
            label5.Visible = false;//label' ı gizlemek için Visible

            label1.Visible = false;//label' ı gizlemek için Visible kullanılır
            label7.Visible = false;//label' ı gizlemek için Visible kullanılır

            listeRenklendirme();  // Tablodaki satırları renklendirme fonksiyounu çağrıldı
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox1.Text == " ") // comboBox1.Text' in içine değer girilmediğinde Geçersiz Cinsiyet
            {
                label4.Visible = true; //Cinsiyet label' ını göstermek için Visible kullanılır
            }
            else
            {
                label4.Visible = false; // Yazar Adı Gir label' ını gizlemek için Visible kullanılır
                TimeSpan gecenSure = DateTime.Now - dateTimePicker1.Value.Date; //zaman farkı alındı
                if (gecenSure.TotalDays >= 0)  // Şuanki günden ileri olup olmadığı kontrol edildi
                {
                    KitapOgrenciVeri kitapId = new KitapOgrenciVeri() //nesne oluşturuldu
                    {
                        KitapAd = comboBox1.Text //Kitap adı aktarıldı
                    };

                    KitapIadeVeri kitap = new KitapIadeVeri() // nesne oluşturuldu
                    {
                        KitapId = KitapIadeBL.kitapId(kitapId), // kitap id aktarıldı
                        OgrenciId = int.Parse(labelTeslimId.Text),  // ogrenci id aktarıldı
                        KitapAlinma = dateTimePicker1.Value.Date  // alinma tarihi aktarıldı
                    };

                    KitapIadeBL.kitapAlimIslemi(kitap); // Veri tabanında alma işlemi gerçekleştirildi

                    //Güncel liste oluşturuldu
                    AlinanKitapVeri alinanKitapVeri = new AlinanKitapVeri()
                    {
                        OgrenciId = int.Parse(labelTeslimId.Text)
                    };
                    dataGridView1.DataSource = KitapIadeBL.ogrenciIdListe(alinanKitapVeri);
                    listeRenklendirme();

                    //güncel kitaplar oluşturuldu
                    KitapIadeVeri iade = new KitapIadeVeri()
                    {
                        OgrenciId = int.Parse(labelTeslimId.Text)
                    };
                    comboBox1.DataSource = KitapIadeBL.kitapAlinanLİste(iade);
                    comboBox2.DataSource = KitapIadeBL.kitapTeslimLİste(iade);

                    MessageBox.Show("Kitap alındı"); // kitap alındığında bilidirm amaçlı eklenen MessageBox
                }

            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "" || comboBox2.Text == " ") // comboBox1.Text' in içine değer girilmediğinde Geçersiz Cinsiyet
            {
                label1.Visible = true; //Cinsiyet label' ını göstermek için Visible kullanılır
            }
            else
            {
                label1.Visible = false; // Yazar Adı Gir label' ını gizlemek için Visible kullanılır

                KitapOgrenciVeri kitapId = new KitapOgrenciVeri() // nesne oluşturuldu
                {
                    KitapAd = comboBox2.Text //kitap adı aktarıldı
                };

                KitapIadeVeri kitap = new KitapIadeVeri() // nesne oluşturuldu ve bilgiler aktarıldı
                {
                    KitapId = KitapIadeBL.kitapId(kitapId),
                    OgrenciId = int.Parse(labelTeslimId.Text),
                    KitapTeslim = dateTimePicker2.Value.Date,
                    KitapKontrol = true
                };
                KitapIadeBL.kitapTarih(kitap); //alinma tarihi çekildi
                TimeSpan sonuc = kitap.KitapTeslim - kitap.KitapAlinma; // zaman farkı alındı
                if (sonuc.TotalDays >= 0) //zaman farkını eksi olamaması kontrol edildi
                {
                    KitapIadeBL.kitapTeslimIslemi(kitap); //teslim işlemi gerçekleştirildi

                    //Güncel liste
                    AlinanKitapVeri alinanKitapVeri = new AlinanKitapVeri()
                    {
                        OgrenciId = int.Parse(labelTeslimId.Text)
                    };
                    dataGridView1.DataSource = KitapIadeBL.ogrenciIdListe(alinanKitapVeri);
                    listeRenklendirme();  // tablo satırları renklendirildi

                    //Güncel  Kitap
                    KitapIadeVeri iade = new KitapIadeVeri()
                    {
                        OgrenciId = int.Parse(labelTeslimId.Text)
                    };
                    comboBox1.DataSource = KitapIadeBL.kitapAlinanLİste(iade);
                    comboBox2.DataSource = KitapIadeBL.kitapTeslimLİste(iade);

                    if (sonuc.TotalDays > 15)  // teslim süresi 15 günü geçmiş ise ceza işlemi uygulandı
                    {
                        float ceza = float.Parse(sonuc.TotalDays.ToString()) - 15;  //15 gün teslim süresini aşanlara hergün için 1 tl kesildi
                        KitapIadeBL.ogrenciCeza(iade); //Ceza bilgisi çekildi
                        iade.OgrenciCeza += ceza; //üzerine ekleme yapıldı
                        KitapIadeBL.ogrenciCezaIslemi(iade); // Veri tabanında ceza işlemi gerçekleşti
                    }
                    MessageBox.Show("Teslim edildi");
                }

            }
        }
    }
}
