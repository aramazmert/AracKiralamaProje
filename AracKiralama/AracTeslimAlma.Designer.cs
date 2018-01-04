namespace AracKiralama
{
    partial class AracTeslimAlma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracTeslimAlma));
            this.dgvAraclar = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTeslimAl = new System.Windows.Forms.Button();
            this.txtAracYakit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAracSanziman = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAracModel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAracMarka = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAracGetir = new System.Windows.Forms.Button();
            this.dtpTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAraclar
            // 
            this.dgvAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAraclar.Location = new System.Drawing.Point(14, 12);
            this.dgvAraclar.Name = "dgvAraclar";
            this.dgvAraclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAraclar.Size = new System.Drawing.Size(568, 162);
            this.dgvAraclar.TabIndex = 13;
            this.dgvAraclar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAraclar_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTeslimAl);
            this.groupBox2.Controls.Add(this.txtAracYakit);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtAracSanziman);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtAracModel);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtAracMarka);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(254, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 217);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.ImageKey = "key-silhouette-security-tool-interface-symbol-of-password.png";
            this.btnTeslimAl.ImageList = this.ımageList1;
            this.btnTeslimAl.Location = new System.Drawing.Point(152, 133);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(156, 84);
            this.btnTeslimAl.TabIndex = 7;
            this.btnTeslimAl.Text = "TESLİM AL";
            this.btnTeslimAl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeslimAl.UseVisualStyleBackColor = true;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // txtAracYakit
            // 
            this.txtAracYakit.Location = new System.Drawing.Point(152, 74);
            this.txtAracYakit.Name = "txtAracYakit";
            this.txtAracYakit.ReadOnly = true;
            this.txtAracYakit.Size = new System.Drawing.Size(156, 22);
            this.txtAracYakit.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 14);
            this.label10.TabIndex = 28;
            this.label10.Text = "Araç Yakıt Türü:";
            // 
            // txtAracSanziman
            // 
            this.txtAracSanziman.Location = new System.Drawing.Point(152, 105);
            this.txtAracSanziman.Name = "txtAracSanziman";
            this.txtAracSanziman.ReadOnly = true;
            this.txtAracSanziman.Size = new System.Drawing.Size(156, 22);
            this.txtAracSanziman.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 14);
            this.label13.TabIndex = 26;
            this.label13.Text = "Araç Şanzıman Türü:";
            // 
            // txtAracModel
            // 
            this.txtAracModel.Location = new System.Drawing.Point(152, 46);
            this.txtAracModel.Name = "txtAracModel";
            this.txtAracModel.ReadOnly = true;
            this.txtAracModel.Size = new System.Drawing.Size(156, 22);
            this.txtAracModel.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 14);
            this.label14.TabIndex = 25;
            this.label14.Text = "Araç Model:";
            // 
            // txtAracMarka
            // 
            this.txtAracMarka.Location = new System.Drawing.Point(152, 18);
            this.txtAracMarka.Name = "txtAracMarka";
            this.txtAracMarka.ReadOnly = true;
            this.txtAracMarka.Size = new System.Drawing.Size(156, 22);
            this.txtAracMarka.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 14);
            this.label15.TabIndex = 22;
            this.label15.Text = "Araç Marka:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAracGetir);
            this.groupBox1.Controls.Add(this.dtpTeslimTarihi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 217);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih Seçimi";
            // 
            // btnAracGetir
            // 
            this.btnAracGetir.ImageKey = "car.png";
            this.btnAracGetir.ImageList = this.ımageList1;
            this.btnAracGetir.Location = new System.Drawing.Point(74, 133);
            this.btnAracGetir.Name = "btnAracGetir";
            this.btnAracGetir.Size = new System.Drawing.Size(156, 84);
            this.btnAracGetir.TabIndex = 2;
            this.btnAracGetir.Text = "ARAÇLARI GETİR";
            this.btnAracGetir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracGetir.UseVisualStyleBackColor = true;
            this.btnAracGetir.Click += new System.EventHandler(this.btnAracGetir_Click);
            // 
            // dtpTeslimTarihi
            // 
            this.dtpTeslimTarihi.Location = new System.Drawing.Point(9, 41);
            this.dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            this.dtpTeslimTarihi.Size = new System.Drawing.Size(221, 22);
            this.dtpTeslimTarihi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 32;
            this.label1.Text = "Teslim Tarihi:";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "car.png");
            this.ımageList1.Images.SetKeyName(1, "key.png");
            this.ımageList1.Images.SetKeyName(2, "key-silhouette-security-tool-interface-symbol-of-password.png");
            // 
            // AracTeslimAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvAraclar);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AracTeslimAlma";
            this.Text = "TESLİM ALMA EKRANI";
            this.Load += new System.EventHandler(this.AracTeslimAlma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAraclar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTeslimAl;
        private System.Windows.Forms.TextBox txtAracYakit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAracSanziman;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAracModel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAracMarka;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAracGetir;
        private System.Windows.Forms.DateTimePicker dtpTeslimTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}