
namespace Kutuphane
{
    partial class GorevliPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GorevliPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kitapListesiButton = new System.Windows.Forms.Button();
            this.ogrenciSilButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ogrenciGuncelleButton = new System.Windows.Forms.Button();
            this.ogrenciEkleButton = new System.Windows.Forms.Button();
            this.OgrenciListesiButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.kitapSilButton = new System.Windows.Forms.Button();
            this.kitapGuncelleButton = new System.Windows.Forms.Button();
            this.kitapEkleButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gorevliOgrenciSil1 = new Kutuphane.GorevliOgrenciSil();
            this.gorevliOgrenciListesi1 = new Kutuphane.GorevliOgrenciListesi();
            this.gorevliOgrenciGuncelle1 = new Kutuphane.GorevliOgrenciGuncelle();
            this.gorevliOgrenciEkle1 = new Kutuphane.GorevliOgrenciEkle();
            this.gorevliKitapSil1 = new Kutuphane.GorevliKitapSil();
            this.gorevliKitapListesi1 = new Kutuphane.GorevliKitapListesi();
            this.gorevliKitapGuncelle1 = new Kutuphane.GorevliKitapGuncelle();
            this.gorevliKitapEkle1 = new Kutuphane.GorevliKitapEkle();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 30);
            this.panel1.TabIndex = 1;
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1170, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.kitapListesiButton);
            this.panel2.Controls.Add(this.ogrenciSilButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ogrenciGuncelleButton);
            this.panel2.Controls.Add(this.ogrenciEkleButton);
            this.panel2.Controls.Add(this.OgrenciListesiButton);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.kitapSilButton);
            this.panel2.Controls.Add(this.kitapGuncelleButton);
            this.panel2.Controls.Add(this.kitapEkleButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 600);
            this.panel2.TabIndex = 32;
            // 
            // kitapListesiButton
            // 
            this.kitapListesiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapListesiButton.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.kitapListesiButton.FlatAppearance.BorderSize = 2;
            this.kitapListesiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.kitapListesiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapListesiButton.ForeColor = System.Drawing.Color.White;
            this.kitapListesiButton.Location = new System.Drawing.Point(0, 48);
            this.kitapListesiButton.Name = "kitapListesiButton";
            this.kitapListesiButton.Size = new System.Drawing.Size(300, 54);
            this.kitapListesiButton.TabIndex = 23;
            this.kitapListesiButton.Text = "Kitap Listesi";
            this.kitapListesiButton.UseVisualStyleBackColor = true;
            this.kitapListesiButton.Click += new System.EventHandler(this.kitapListesiButton_Click);
            // 
            // ogrenciSilButton
            // 
            this.ogrenciSilButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ogrenciSilButton.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.ogrenciSilButton.FlatAppearance.BorderSize = 2;
            this.ogrenciSilButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.ogrenciSilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogrenciSilButton.ForeColor = System.Drawing.Color.White;
            this.ogrenciSilButton.Location = new System.Drawing.Point(0, 523);
            this.ogrenciSilButton.Name = "ogrenciSilButton";
            this.ogrenciSilButton.Size = new System.Drawing.Size(300, 54);
            this.ogrenciSilButton.TabIndex = 28;
            this.ogrenciSilButton.Text = "Öğrenci Sil";
            this.ogrenciSilButton.UseVisualStyleBackColor = true;
            this.ogrenciSilButton.Click += new System.EventHandler(this.ogrenciSilButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Öğrenci İşlemleri";
            // 
            // ogrenciGuncelleButton
            // 
            this.ogrenciGuncelleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ogrenciGuncelleButton.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.ogrenciGuncelleButton.FlatAppearance.BorderSize = 2;
            this.ogrenciGuncelleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.ogrenciGuncelleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogrenciGuncelleButton.ForeColor = System.Drawing.Color.White;
            this.ogrenciGuncelleButton.Location = new System.Drawing.Point(0, 459);
            this.ogrenciGuncelleButton.Name = "ogrenciGuncelleButton";
            this.ogrenciGuncelleButton.Size = new System.Drawing.Size(300, 54);
            this.ogrenciGuncelleButton.TabIndex = 26;
            this.ogrenciGuncelleButton.Text = "Öğrenci Güncelle";
            this.ogrenciGuncelleButton.UseVisualStyleBackColor = true;
            this.ogrenciGuncelleButton.Click += new System.EventHandler(this.ogrenciGuncelleButton_Click);
            // 
            // ogrenciEkleButton
            // 
            this.ogrenciEkleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ogrenciEkleButton.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.ogrenciEkleButton.FlatAppearance.BorderSize = 2;
            this.ogrenciEkleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.ogrenciEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogrenciEkleButton.ForeColor = System.Drawing.Color.White;
            this.ogrenciEkleButton.Location = new System.Drawing.Point(0, 395);
            this.ogrenciEkleButton.Name = "ogrenciEkleButton";
            this.ogrenciEkleButton.Size = new System.Drawing.Size(300, 54);
            this.ogrenciEkleButton.TabIndex = 25;
            this.ogrenciEkleButton.Text = "Öğrenci Ekle";
            this.ogrenciEkleButton.UseVisualStyleBackColor = true;
            this.ogrenciEkleButton.Click += new System.EventHandler(this.ogrenciEkleButton_Click);
            // 
            // OgrenciListesiButton
            // 
            this.OgrenciListesiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OgrenciListesiButton.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.OgrenciListesiButton.FlatAppearance.BorderSize = 2;
            this.OgrenciListesiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.OgrenciListesiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OgrenciListesiButton.ForeColor = System.Drawing.Color.White;
            this.OgrenciListesiButton.Location = new System.Drawing.Point(0, 331);
            this.OgrenciListesiButton.Name = "OgrenciListesiButton";
            this.OgrenciListesiButton.Size = new System.Drawing.Size(300, 54);
            this.OgrenciListesiButton.TabIndex = 24;
            this.OgrenciListesiButton.Text = "Öğrenci Listesi";
            this.OgrenciListesiButton.UseVisualStyleBackColor = true;
            this.OgrenciListesiButton.Click += new System.EventHandler(this.OgrenciListesiButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kitap İşlemleri";
            // 
            // kitapSilButton
            // 
            this.kitapSilButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapSilButton.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.kitapSilButton.FlatAppearance.BorderSize = 2;
            this.kitapSilButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.kitapSilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapSilButton.ForeColor = System.Drawing.Color.White;
            this.kitapSilButton.Location = new System.Drawing.Point(0, 240);
            this.kitapSilButton.Name = "kitapSilButton";
            this.kitapSilButton.Size = new System.Drawing.Size(300, 54);
            this.kitapSilButton.TabIndex = 21;
            this.kitapSilButton.Text = "Kitap Sil";
            this.kitapSilButton.UseVisualStyleBackColor = true;
            this.kitapSilButton.Click += new System.EventHandler(this.kitapSilButton_Click);
            // 
            // kitapGuncelleButton
            // 
            this.kitapGuncelleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapGuncelleButton.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.kitapGuncelleButton.FlatAppearance.BorderSize = 2;
            this.kitapGuncelleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.kitapGuncelleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapGuncelleButton.ForeColor = System.Drawing.Color.White;
            this.kitapGuncelleButton.Location = new System.Drawing.Point(0, 176);
            this.kitapGuncelleButton.Name = "kitapGuncelleButton";
            this.kitapGuncelleButton.Size = new System.Drawing.Size(300, 54);
            this.kitapGuncelleButton.TabIndex = 19;
            this.kitapGuncelleButton.Text = "Kitap Güncelle";
            this.kitapGuncelleButton.UseVisualStyleBackColor = true;
            this.kitapGuncelleButton.Click += new System.EventHandler(this.kitapGuncelleButton_Click);
            // 
            // kitapEkleButton
            // 
            this.kitapEkleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapEkleButton.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.kitapEkleButton.FlatAppearance.BorderSize = 2;
            this.kitapEkleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.kitapEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapEkleButton.ForeColor = System.Drawing.Color.White;
            this.kitapEkleButton.Location = new System.Drawing.Point(0, 112);
            this.kitapEkleButton.Name = "kitapEkleButton";
            this.kitapEkleButton.Size = new System.Drawing.Size(300, 54);
            this.kitapEkleButton.TabIndex = 18;
            this.kitapEkleButton.Text = "Kitap Ekle";
            this.kitapEkleButton.UseVisualStyleBackColor = true;
            this.kitapEkleButton.Click += new System.EventHandler(this.kitapEkleButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gorevliOgrenciSil1);
            this.panel3.Controls.Add(this.gorevliOgrenciListesi1);
            this.panel3.Controls.Add(this.gorevliOgrenciGuncelle1);
            this.panel3.Controls.Add(this.gorevliOgrenciEkle1);
            this.panel3.Controls.Add(this.gorevliKitapSil1);
            this.panel3.Controls.Add(this.gorevliKitapListesi1);
            this.panel3.Controls.Add(this.gorevliKitapGuncelle1);
            this.panel3.Controls.Add(this.gorevliKitapEkle1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 600);
            this.panel3.TabIndex = 33;
            // 
            // gorevliOgrenciSil1
            // 
            this.gorevliOgrenciSil1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gorevliOgrenciSil1.Location = new System.Drawing.Point(0, 0);
            this.gorevliOgrenciSil1.Name = "gorevliOgrenciSil1";
            this.gorevliOgrenciSil1.Size = new System.Drawing.Size(900, 600);
            this.gorevliOgrenciSil1.TabIndex = 7;
            this.gorevliOgrenciSil1.Load += new System.EventHandler(this.gorevliOgrenciSil1_Load);
            // 
            // gorevliOgrenciListesi1
            // 
            this.gorevliOgrenciListesi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gorevliOgrenciListesi1.Location = new System.Drawing.Point(0, 0);
            this.gorevliOgrenciListesi1.Name = "gorevliOgrenciListesi1";
            this.gorevliOgrenciListesi1.Size = new System.Drawing.Size(900, 600);
            this.gorevliOgrenciListesi1.TabIndex = 6;
            // 
            // gorevliOgrenciGuncelle1
            // 
            this.gorevliOgrenciGuncelle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gorevliOgrenciGuncelle1.Location = new System.Drawing.Point(0, 0);
            this.gorevliOgrenciGuncelle1.Name = "gorevliOgrenciGuncelle1";
            this.gorevliOgrenciGuncelle1.Size = new System.Drawing.Size(900, 600);
            this.gorevliOgrenciGuncelle1.TabIndex = 5;
            // 
            // gorevliOgrenciEkle1
            // 
            this.gorevliOgrenciEkle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gorevliOgrenciEkle1.Location = new System.Drawing.Point(0, 0);
            this.gorevliOgrenciEkle1.Name = "gorevliOgrenciEkle1";
            this.gorevliOgrenciEkle1.Size = new System.Drawing.Size(900, 600);
            this.gorevliOgrenciEkle1.TabIndex = 4;
            // 
            // gorevliKitapSil1
            // 
            this.gorevliKitapSil1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gorevliKitapSil1.Location = new System.Drawing.Point(0, 0);
            this.gorevliKitapSil1.Name = "gorevliKitapSil1";
            this.gorevliKitapSil1.Size = new System.Drawing.Size(900, 600);
            this.gorevliKitapSil1.TabIndex = 3;
            // 
            // gorevliKitapListesi1
            // 
            this.gorevliKitapListesi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gorevliKitapListesi1.Location = new System.Drawing.Point(0, 0);
            this.gorevliKitapListesi1.Name = "gorevliKitapListesi1";
            this.gorevliKitapListesi1.Size = new System.Drawing.Size(900, 600);
            this.gorevliKitapListesi1.TabIndex = 2;
            // 
            // gorevliKitapGuncelle1
            // 
            this.gorevliKitapGuncelle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gorevliKitapGuncelle1.Location = new System.Drawing.Point(0, 0);
            this.gorevliKitapGuncelle1.Name = "gorevliKitapGuncelle1";
            this.gorevliKitapGuncelle1.Size = new System.Drawing.Size(900, 600);
            this.gorevliKitapGuncelle1.TabIndex = 1;
            // 
            // gorevliKitapEkle1
            // 
            this.gorevliKitapEkle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gorevliKitapEkle1.Location = new System.Drawing.Point(0, 0);
            this.gorevliKitapEkle1.Name = "gorevliKitapEkle1";
            this.gorevliKitapEkle1.Size = new System.Drawing.Size(900, 600);
            this.gorevliKitapEkle1.TabIndex = 0;
            // 
            // GorevliPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1200, 630);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GorevliPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GorevliSecimEkrani";
            this.Load += new System.EventHandler(this.GorevliPanel_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button kitapSilButton;
        private System.Windows.Forms.Button kitapGuncelleButton;
        private System.Windows.Forms.Button kitapEkleButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button kitapListesiButton;
        private System.Windows.Forms.Button ogrenciSilButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ogrenciGuncelleButton;
        private System.Windows.Forms.Button ogrenciEkleButton;
        private System.Windows.Forms.Button OgrenciListesiButton;
        private GorevliOgrenciSil gorevliOgrenciSil1;
        private GorevliOgrenciListesi gorevliOgrenciListesi1;
        private GorevliOgrenciGuncelle gorevliOgrenciGuncelle1;
        private GorevliOgrenciEkle gorevliOgrenciEkle1;
        private GorevliKitapSil gorevliKitapSil1;
        private GorevliKitapListesi gorevliKitapListesi1;
        private GorevliKitapGuncelle gorevliKitapGuncelle1;
        private GorevliKitapEkle gorevliKitapEkle1;
    }
}