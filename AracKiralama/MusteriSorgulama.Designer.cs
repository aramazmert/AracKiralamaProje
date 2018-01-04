namespace AracKiralama
{
    partial class MusteriSorgulama
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
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.txtAdreseGore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefonaGore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyadaGore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTCyeGore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.AllowUserToAddRows = false;
            this.dgvMusteriler.AllowUserToDeleteRows = false;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Location = new System.Drawing.Point(169, 12);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.ReadOnly = true;
            this.dgvMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriler.Size = new System.Drawing.Size(713, 281);
            this.dgvMusteriler.TabIndex = 4;
            // 
            // txtAdreseGore
            // 
            this.txtAdreseGore.Location = new System.Drawing.Point(25, 194);
            this.txtAdreseGore.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAdreseGore.Name = "txtAdreseGore";
            this.txtAdreseGore.Size = new System.Drawing.Size(123, 23);
            this.txtAdreseGore.TabIndex = 4;
            this.txtAdreseGore.TextChanged += new System.EventHandler(this.txtAdreseGore_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 54;
            this.label4.Text = "ADRES";
            // 
            // txtTelefonaGore
            // 
            this.txtTelefonaGore.Location = new System.Drawing.Point(25, 146);
            this.txtTelefonaGore.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTelefonaGore.Name = "txtTelefonaGore";
            this.txtTelefonaGore.Size = new System.Drawing.Size(123, 23);
            this.txtTelefonaGore.TabIndex = 3;
            this.txtTelefonaGore.TextChanged += new System.EventHandler(this.txtTelefonaGore_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "TELEFON";
            // 
            // txtSoyadaGore
            // 
            this.txtSoyadaGore.Location = new System.Drawing.Point(25, 89);
            this.txtSoyadaGore.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSoyadaGore.Name = "txtSoyadaGore";
            this.txtSoyadaGore.Size = new System.Drawing.Size(123, 23);
            this.txtSoyadaGore.TabIndex = 2;
            this.txtSoyadaGore.TextChanged += new System.EventHandler(this.txtSoyadaGore_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "SOYAD";
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.Location = new System.Drawing.Point(25, 38);
            this.txtAdaGore.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(123, 23);
            this.txtAdaGore.TabIndex = 1;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.txtAdaGore_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "AD";
            // 
            // txtTCyeGore
            // 
            this.txtTCyeGore.Location = new System.Drawing.Point(25, 249);
            this.txtTCyeGore.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTCyeGore.Name = "txtTCyeGore";
            this.txtTCyeGore.Size = new System.Drawing.Size(123, 23);
            this.txtTCyeGore.TabIndex = 5;
            this.txtTCyeGore.TextChanged += new System.EventHandler(this.txtTCyeGore_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 56;
            this.label5.Text = "TC KİMLİK NO";
            // 
            // MusteriSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 330);
            this.Controls.Add(this.txtTCyeGore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdreseGore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefonaGore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoyadaGore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdaGore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMusteriler);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MusteriSorgulama";
            this.Text = "MÜŞTERİ ARAMA";
            this.Load += new System.EventHandler(this.MusteriSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.TextBox txtAdreseGore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefonaGore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyadaGore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTCyeGore;
        private System.Windows.Forms.Label label5;
    }
}