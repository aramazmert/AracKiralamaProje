namespace AracKiralama
{
    partial class AracEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracEkle));
            this.dgvAraclar = new System.Windows.Forms.DataGridView();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMarkalar = new System.Windows.Forms.ComboBox();
            this.cbYakitTuru = new System.Windows.Forms.ComboBox();
            this.cbSanzimanTuru = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelAdi = new System.Windows.Forms.TextBox();
            this.txtModelYili = new System.Windows.Forms.TextBox();
            this.txtGunlukFiyat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAraclar
            // 
            this.dgvAraclar.AllowUserToAddRows = false;
            this.dgvAraclar.AllowUserToDeleteRows = false;
            this.dgvAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAraclar.Location = new System.Drawing.Point(12, 176);
            this.dgvAraclar.Name = "dgvAraclar";
            this.dgvAraclar.ReadOnly = true;
            this.dgvAraclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAraclar.Size = new System.Drawing.Size(749, 318);
            this.dgvAraclar.TabIndex = 9;
            this.dgvAraclar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAraclar_CellMouseClick);
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDegistir.ForeColor = System.Drawing.Color.Black;
            this.btnDegistir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDegistir.ImageKey = "icon.png";
            this.btnDegistir.ImageList = this.ımageList1;
            this.btnDegistir.Location = new System.Drawing.Point(614, 95);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(138, 75);
            this.btnDegistir.TabIndex = 14;
            this.btnDegistir.Text = "DEĞİŞTİR";
            this.btnDegistir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icon.png");
            this.ımageList1.Images.SetKeyName(1, "save.png");
            this.ımageList1.Images.SetKeyName(2, "car.png");
            this.ımageList1.Images.SetKeyName(3, "musica-searcher (1).png");
            this.ımageList1.Images.SetKeyName(4, "54657-200.png");
            this.ımageList1.Images.SetKeyName(5, "rubbish-bin.png");
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.ImageKey = "rubbish-bin.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(415, 95);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(139, 75);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.ImageKey = "save.png";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(213, 95);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(138, 75);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeni.ForeColor = System.Drawing.Color.Black;
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYeni.ImageKey = "54657-200.png";
            this.btnYeni.ImageList = this.ımageList1;
            this.btnYeni.Location = new System.Drawing.Point(15, 96);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(138, 74);
            this.btnYeni.TabIndex = 11;
            this.btnYeni.Text = "YENİ";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Araç Markası:";
            // 
            // cbMarkalar
            // 
            this.cbMarkalar.FormattingEnabled = true;
            this.cbMarkalar.Location = new System.Drawing.Point(102, 8);
            this.cbMarkalar.Name = "cbMarkalar";
            this.cbMarkalar.Size = new System.Drawing.Size(121, 23);
            this.cbMarkalar.TabIndex = 6;
            this.cbMarkalar.SelectedIndexChanged += new System.EventHandler(this.cbMarkalar_SelectedIndexChanged);
            // 
            // cbYakitTuru
            // 
            this.cbYakitTuru.FormattingEnabled = true;
            this.cbYakitTuru.Location = new System.Drawing.Point(102, 58);
            this.cbYakitTuru.Name = "cbYakitTuru";
            this.cbYakitTuru.Size = new System.Drawing.Size(121, 23);
            this.cbYakitTuru.TabIndex = 6;
            this.cbYakitTuru.SelectedIndexChanged += new System.EventHandler(this.cbYakitTuru_SelectedIndexChanged);
            // 
            // cbSanzimanTuru
            // 
            this.cbSanzimanTuru.FormattingEnabled = true;
            this.cbSanzimanTuru.Location = new System.Drawing.Point(359, 58);
            this.cbSanzimanTuru.Name = "cbSanzimanTuru";
            this.cbSanzimanTuru.Size = new System.Drawing.Size(121, 23);
            this.cbSanzimanTuru.TabIndex = 6;
            this.cbSanzimanTuru.SelectedIndexChanged += new System.EventHandler(this.cbSanzimanTuru_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Araç Modeli:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Araç Yılı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yakıt Türü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Şanzıman Türü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Günlük Fiyat:";
            // 
            // txtModelAdi
            // 
            this.txtModelAdi.Location = new System.Drawing.Point(359, 8);
            this.txtModelAdi.Name = "txtModelAdi";
            this.txtModelAdi.Size = new System.Drawing.Size(121, 23);
            this.txtModelAdi.TabIndex = 8;
            // 
            // txtModelYili
            // 
            this.txtModelYili.Location = new System.Drawing.Point(631, 13);
            this.txtModelYili.Name = "txtModelYili";
            this.txtModelYili.Size = new System.Drawing.Size(121, 23);
            this.txtModelYili.TabIndex = 8;
            // 
            // txtGunlukFiyat
            // 
            this.txtGunlukFiyat.Location = new System.Drawing.Point(631, 58);
            this.txtGunlukFiyat.Name = "txtGunlukFiyat";
            this.txtGunlukFiyat.Size = new System.Drawing.Size(121, 23);
            this.txtGunlukFiyat.TabIndex = 8;
            this.txtGunlukFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGunlukFiyat_KeyPress);
            // 
            // AracEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 511);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.dgvAraclar);
            this.Controls.Add(this.txtGunlukFiyat);
            this.Controls.Add(this.txtModelYili);
            this.Controls.Add(this.txtModelAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSanzimanTuru);
            this.Controls.Add(this.cbYakitTuru);
            this.Controls.Add(this.cbMarkalar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AracEkle";
            this.Text = "ARAÇ İŞLEMLERİ";
            this.Load += new System.EventHandler(this.AracEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAraclar;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMarkalar;
        private System.Windows.Forms.ComboBox cbYakitTuru;
        private System.Windows.Forms.ComboBox cbSanzimanTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModelAdi;
        private System.Windows.Forms.TextBox txtModelYili;
        private System.Windows.Forms.TextBox txtGunlukFiyat;
        private System.Windows.Forms.ImageList ımageList1;
    }
}