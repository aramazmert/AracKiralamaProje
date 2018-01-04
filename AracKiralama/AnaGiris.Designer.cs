namespace AracKiralama
{
    partial class AnaGiris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaGiris));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mitmAracIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmMarkaIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmAracEklemeIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmAracArama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmMusteriIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmMusteriEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmMusteriSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmSatisIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmAracKiralama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmAracTeslimAlma = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmYapilanKiralamalar = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmAracIslemleri,
            this.mitmMusteriIslemleri,
            this.mitmSatisIslemleri});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1354, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mitmAracIslemleri
            // 
            this.mitmAracIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmMarkaIslemleri,
            this.mitmAracEklemeIslemleri,
            this.mitmAracArama});
            this.mitmAracIslemleri.Name = "mitmAracIslemleri";
            this.mitmAracIslemleri.Size = new System.Drawing.Size(119, 22);
            this.mitmAracIslemleri.Text = "ARAÇ İŞLEMLERİ";
            // 
            // mitmMarkaIslemleri
            // 
            this.mitmMarkaIslemleri.Name = "mitmMarkaIslemleri";
            this.mitmMarkaIslemleri.Size = new System.Drawing.Size(173, 22);
            this.mitmMarkaIslemleri.Text = "Marka İşlemleri";
            this.mitmMarkaIslemleri.Click += new System.EventHandler(this.mitmMarkaIslemleri_Click);
            // 
            // mitmAracEklemeIslemleri
            // 
            this.mitmAracEklemeIslemleri.Name = "mitmAracEklemeIslemleri";
            this.mitmAracEklemeIslemleri.Size = new System.Drawing.Size(173, 22);
            this.mitmAracEklemeIslemleri.Text = "Araç İşlemleri";
            this.mitmAracEklemeIslemleri.Click += new System.EventHandler(this.mitmAracEklemeIslemleri_Click);
            // 
            // mitmAracArama
            // 
            this.mitmAracArama.Name = "mitmAracArama";
            this.mitmAracArama.Size = new System.Drawing.Size(173, 22);
            this.mitmAracArama.Text = "Araç Arama";
            this.mitmAracArama.Click += new System.EventHandler(this.mitmAracArama_Click);
            // 
            // mitmMusteriIslemleri
            // 
            this.mitmMusteriIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmMusteriEkle,
            this.mitmMusteriSorgulama});
            this.mitmMusteriIslemleri.Name = "mitmMusteriIslemleri";
            this.mitmMusteriIslemleri.Size = new System.Drawing.Size(141, 22);
            this.mitmMusteriIslemleri.Text = "MÜŞTERİ İŞLEMLERİ";
            // 
            // mitmMusteriEkle
            // 
            this.mitmMusteriEkle.Name = "mitmMusteriEkle";
            this.mitmMusteriEkle.Size = new System.Drawing.Size(193, 22);
            this.mitmMusteriEkle.Text = "Müşteri Ekle";
            this.mitmMusteriEkle.Click += new System.EventHandler(this.mitmMusteriEkle_Click);
            // 
            // mitmMusteriSorgulama
            // 
            this.mitmMusteriSorgulama.Name = "mitmMusteriSorgulama";
            this.mitmMusteriSorgulama.Size = new System.Drawing.Size(193, 22);
            this.mitmMusteriSorgulama.Text = "Müşteri Sorgulama";
            this.mitmMusteriSorgulama.Click += new System.EventHandler(this.mitmMusteriSorgulama_Click);
            // 
            // mitmSatisIslemleri
            // 
            this.mitmSatisIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmAracKiralama,
            this.mitmAracTeslimAlma,
            this.mitmYapilanKiralamalar});
            this.mitmSatisIslemleri.Name = "mitmSatisIslemleri";
            this.mitmSatisIslemleri.Size = new System.Drawing.Size(118, 22);
            this.mitmSatisIslemleri.Text = "SATIŞ İŞLEMLERİ";
            // 
            // mitmAracKiralama
            // 
            this.mitmAracKiralama.Name = "mitmAracKiralama";
            this.mitmAracKiralama.Size = new System.Drawing.Size(194, 22);
            this.mitmAracKiralama.Text = "Araç Kiralama";
            this.mitmAracKiralama.Click += new System.EventHandler(this.mitmAracKiralama_Click);
            // 
            // mitmAracTeslimAlma
            // 
            this.mitmAracTeslimAlma.Name = "mitmAracTeslimAlma";
            this.mitmAracTeslimAlma.Size = new System.Drawing.Size(194, 22);
            this.mitmAracTeslimAlma.Text = "Teslim Alma";
            this.mitmAracTeslimAlma.Click += new System.EventHandler(this.mitmAracTeslimAlma_Click);
            // 
            // mitmYapilanKiralamalar
            // 
            this.mitmYapilanKiralamalar.Name = "mitmYapilanKiralamalar";
            this.mitmYapilanKiralamalar.Size = new System.Drawing.Size(194, 22);
            this.mitmYapilanKiralamalar.Text = "Yapılan Kiralamalar";
            this.mitmYapilanKiralamalar.Click += new System.EventHandler(this.mitmYapilanKiralamalar_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "buton-4.png");
            this.ımageList1.Images.SetKeyName(1, "buton-3.png");
            this.ımageList1.Images.SetKeyName(2, "buton-2.png");
            this.ımageList1.Images.SetKeyName(3, "buton-1.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(518, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 236);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(803, 73);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(249, 236);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseClick_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1074, 73);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(249, 236);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseClick);
            // 
            // AnaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaGiris";
            this.Text = "Araç Kiralama v1.0.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mitmAracIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mitmMusteriIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mitmSatisIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mitmMusteriEkle;
        private System.Windows.Forms.ToolStripMenuItem mitmMusteriSorgulama;
        private System.Windows.Forms.ToolStripMenuItem mitmMarkaIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mitmAracEklemeIslemleri;
        private System.Windows.Forms.ToolStripMenuItem mitmAracArama;
        private System.Windows.Forms.ToolStripMenuItem mitmAracKiralama;
        private System.Windows.Forms.ToolStripMenuItem mitmAracTeslimAlma;
        private System.Windows.Forms.ToolStripMenuItem mitmYapilanKiralamalar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

