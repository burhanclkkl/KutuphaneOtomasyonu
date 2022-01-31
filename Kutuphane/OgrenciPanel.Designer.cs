
namespace Kutuphane
{
    partial class OgrenciPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciPanel));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cezaOdeme = new System.Windows.Forms.Button();
            this.ogrenciBilgilerim = new System.Windows.Forms.Button();
            this.grafik = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.kitapAlmaIslemi = new System.Windows.Forms.Button();
            this.kitapAra = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelOgrenciIdPanel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ogrenciKitapAlmaTeslim1 = new Kutuphane.OgrenciKitapAlmaTeslim();
            this.ogrenciKitapAra1 = new Kutuphane.OgrenciKitapAra();
            this.ogrenciGrafik1 = new Kutuphane.OgrenciGrafik();
            this.ogrenciCezaOdeme1 = new Kutuphane.OgrenciCezaOdeme();
            this.ogrenciBilgilerim1 = new Kutuphane.OgrenciBilgilerim();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ogrenciKitapAlmaTeslim1);
            this.panel3.Controls.Add(this.ogrenciKitapAra1);
            this.panel3.Controls.Add(this.ogrenciGrafik1);
            this.panel3.Controls.Add(this.ogrenciCezaOdeme1);
            this.panel3.Controls.Add(this.ogrenciBilgilerim1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 600);
            this.panel3.TabIndex = 36;
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
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cezaOdeme);
            this.panel2.Controls.Add(this.ogrenciBilgilerim);
            this.panel2.Controls.Add(this.grafik);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.kitapAlmaIslemi);
            this.panel2.Controls.Add(this.kitapAra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 600);
            this.panel2.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Merhaba ; ";
            // 
            // cezaOdeme
            // 
            this.cezaOdeme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cezaOdeme.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.cezaOdeme.FlatAppearance.BorderSize = 2;
            this.cezaOdeme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.cezaOdeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cezaOdeme.ForeColor = System.Drawing.Color.White;
            this.cezaOdeme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cezaOdeme.ImageIndex = 3;
            this.cezaOdeme.Location = new System.Drawing.Point(0, 438);
            this.cezaOdeme.Name = "cezaOdeme";
            this.cezaOdeme.Size = new System.Drawing.Size(300, 61);
            this.cezaOdeme.TabIndex = 30;
            this.cezaOdeme.Text = "Ceza Ödeme";
            this.cezaOdeme.UseVisualStyleBackColor = true;
            this.cezaOdeme.Click += new System.EventHandler(this.cezaOdeme_Click);
            // 
            // ogrenciBilgilerim
            // 
            this.ogrenciBilgilerim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ogrenciBilgilerim.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.ogrenciBilgilerim.FlatAppearance.BorderSize = 2;
            this.ogrenciBilgilerim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.ogrenciBilgilerim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogrenciBilgilerim.ForeColor = System.Drawing.Color.White;
            this.ogrenciBilgilerim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ogrenciBilgilerim.ImageIndex = 0;
            this.ogrenciBilgilerim.Location = new System.Drawing.Point(0, 170);
            this.ogrenciBilgilerim.Name = "ogrenciBilgilerim";
            this.ogrenciBilgilerim.Size = new System.Drawing.Size(300, 61);
            this.ogrenciBilgilerim.TabIndex = 23;
            this.ogrenciBilgilerim.Text = "Bilgilerim";
            this.ogrenciBilgilerim.UseVisualStyleBackColor = true;
            this.ogrenciBilgilerim.Click += new System.EventHandler(this.ogrenciBilgilerim_Click);
            // 
            // grafik
            // 
            this.grafik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grafik.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.grafik.FlatAppearance.BorderSize = 2;
            this.grafik.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.grafik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grafik.ForeColor = System.Drawing.Color.White;
            this.grafik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grafik.ImageIndex = 4;
            this.grafik.Location = new System.Drawing.Point(0, 371);
            this.grafik.Name = "grafik";
            this.grafik.Size = new System.Drawing.Size(300, 61);
            this.grafik.TabIndex = 28;
            this.grafik.Text = "Grafik";
            this.grafik.UseVisualStyleBackColor = true;
            this.grafik.Click += new System.EventHandler(this.grafik_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kitap İşlemleri";
            // 
            // kitapAlmaIslemi
            // 
            this.kitapAlmaIslemi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapAlmaIslemi.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.kitapAlmaIslemi.FlatAppearance.BorderSize = 2;
            this.kitapAlmaIslemi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.kitapAlmaIslemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapAlmaIslemi.ForeColor = System.Drawing.Color.White;
            this.kitapAlmaIslemi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitapAlmaIslemi.ImageIndex = 2;
            this.kitapAlmaIslemi.Location = new System.Drawing.Point(0, 304);
            this.kitapAlmaIslemi.Name = "kitapAlmaIslemi";
            this.kitapAlmaIslemi.Size = new System.Drawing.Size(300, 61);
            this.kitapAlmaIslemi.TabIndex = 19;
            this.kitapAlmaIslemi.Text = "Kitap Alma Ve Teslim İşlemi";
            this.kitapAlmaIslemi.UseVisualStyleBackColor = true;
            this.kitapAlmaIslemi.Click += new System.EventHandler(this.kitapAlmaIslemi_Click);
            // 
            // kitapAra
            // 
            this.kitapAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapAra.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.kitapAra.FlatAppearance.BorderSize = 2;
            this.kitapAra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.kitapAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitapAra.ForeColor = System.Drawing.Color.White;
            this.kitapAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitapAra.ImageIndex = 1;
            this.kitapAra.Location = new System.Drawing.Point(0, 237);
            this.kitapAra.Name = "kitapAra";
            this.kitapAra.Size = new System.Drawing.Size(300, 61);
            this.kitapAra.TabIndex = 18;
            this.kitapAra.Text = "Kitap Ara";
            this.kitapAra.UseVisualStyleBackColor = true;
            this.kitapAra.Click += new System.EventHandler(this.kitapAra_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(134)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.labelOgrenciIdPanel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 30);
            this.panel1.TabIndex = 34;
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // labelOgrenciIdPanel
            // 
            this.labelOgrenciIdPanel.AutoSize = true;
            this.labelOgrenciIdPanel.Location = new System.Drawing.Point(796, 9);
            this.labelOgrenciIdPanel.Name = "labelOgrenciIdPanel";
            this.labelOgrenciIdPanel.Size = new System.Drawing.Size(35, 13);
            this.labelOgrenciIdPanel.TabIndex = 7;
            this.labelOgrenciIdPanel.Text = "label3";
            this.labelOgrenciIdPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 5;
            this.button1.Location = new System.Drawing.Point(207, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 33;
            this.button1.Text = "Çıkış Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ogrenciKitapAlmaTeslim1
            // 
            this.ogrenciKitapAlmaTeslim1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ogrenciKitapAlmaTeslim1.Location = new System.Drawing.Point(0, 0);
            this.ogrenciKitapAlmaTeslim1.Name = "ogrenciKitapAlmaTeslim1";
            this.ogrenciKitapAlmaTeslim1.Size = new System.Drawing.Size(900, 600);
            this.ogrenciKitapAlmaTeslim1.TabIndex = 4;
            // 
            // ogrenciKitapAra1
            // 
            this.ogrenciKitapAra1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ogrenciKitapAra1.Location = new System.Drawing.Point(0, 0);
            this.ogrenciKitapAra1.Name = "ogrenciKitapAra1";
            this.ogrenciKitapAra1.Size = new System.Drawing.Size(900, 600);
            this.ogrenciKitapAra1.TabIndex = 3;
            // 
            // ogrenciGrafik1
            // 
            this.ogrenciGrafik1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ogrenciGrafik1.Location = new System.Drawing.Point(0, 0);
            this.ogrenciGrafik1.Name = "ogrenciGrafik1";
            this.ogrenciGrafik1.Size = new System.Drawing.Size(900, 600);
            this.ogrenciGrafik1.TabIndex = 2;
            // 
            // ogrenciCezaOdeme1
            // 
            this.ogrenciCezaOdeme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ogrenciCezaOdeme1.Location = new System.Drawing.Point(0, 0);
            this.ogrenciCezaOdeme1.Name = "ogrenciCezaOdeme1";
            this.ogrenciCezaOdeme1.Size = new System.Drawing.Size(900, 600);
            this.ogrenciCezaOdeme1.TabIndex = 1;
            // 
            // ogrenciBilgilerim1
            // 
            this.ogrenciBilgilerim1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ogrenciBilgilerim1.Location = new System.Drawing.Point(0, 0);
            this.ogrenciBilgilerim1.Name = "ogrenciBilgilerim1";
            this.ogrenciBilgilerim1.Size = new System.Drawing.Size(900, 600);
            this.ogrenciBilgilerim1.TabIndex = 0;
            // 
            // OgrenciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1200, 630);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgrenciPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciPanel";
            this.Load += new System.EventHandler(this.OgrenciPanel_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ogrenciBilgilerim;
        private System.Windows.Forms.Button grafik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button kitapAlmaIslemi;
        private System.Windows.Forms.Button kitapAra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cezaOdeme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelOgrenciIdPanel;
        private OgrenciKitapAra ogrenciKitapAra1;
        private OgrenciGrafik ogrenciGrafik1;
        private OgrenciCezaOdeme ogrenciCezaOdeme1;
        private OgrenciBilgilerim ogrenciBilgilerim1;
        private OgrenciKitapAlmaTeslim ogrenciKitapAlmaTeslim1;
        private System.Windows.Forms.Button button1;
    }
}