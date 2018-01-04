namespace AracKiralama
{
    partial class AracArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracArama));
            this.dgvAraclar = new System.Windows.Forms.DataGridView();
            this.txtFiyataGore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYilaGore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModeleGore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMarkayaGore = new System.Windows.Forms.ComboBox();
            this.cbSanzimanTuruneGore = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbYakitTuruneGore = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAraclar
            // 
            this.dgvAraclar.AllowUserToAddRows = false;
            this.dgvAraclar.AllowUserToDeleteRows = false;
            this.dgvAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAraclar.Location = new System.Drawing.Point(20, 137);
            this.dgvAraclar.Name = "dgvAraclar";
            this.dgvAraclar.ReadOnly = true;
            this.dgvAraclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAraclar.Size = new System.Drawing.Size(685, 281);
            this.dgvAraclar.TabIndex = 5;
            // 
            // txtFiyataGore
            // 
            this.txtFiyataGore.Location = new System.Drawing.Point(457, 102);
            this.txtFiyataGore.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFiyataGore.Name = "txtFiyataGore";
            this.txtFiyataGore.Size = new System.Drawing.Size(123, 23);
            this.txtFiyataGore.TabIndex = 55;
            this.txtFiyataGore.TextChanged += new System.EventHandler(this.txtFiyataGore_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "FİYAT";
            // 
            // txtYilaGore
            // 
            this.txtYilaGore.Location = new System.Drawing.Point(244, 40);
            this.txtYilaGore.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtYilaGore.Name = "txtYilaGore";
            this.txtYilaGore.Size = new System.Drawing.Size(123, 23);
            this.txtYilaGore.TabIndex = 54;
            this.txtYilaGore.TextChanged += new System.EventHandler(this.txtYilaGore_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "YIL";
            // 
            // txtModeleGore
            // 
            this.txtModeleGore.Location = new System.Drawing.Point(32, 40);
            this.txtModeleGore.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtModeleGore.Name = "txtModeleGore";
            this.txtModeleGore.Size = new System.Drawing.Size(123, 23);
            this.txtModeleGore.TabIndex = 53;
            this.txtModeleGore.TextChanged += new System.EventHandler(this.txtModeleGore_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "MODEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 58;
            this.label4.Text = "MARKA";
            // 
            // cbMarkayaGore
            // 
            this.cbMarkayaGore.FormattingEnabled = true;
            this.cbMarkayaGore.Location = new System.Drawing.Point(458, 40);
            this.cbMarkayaGore.Name = "cbMarkayaGore";
            this.cbMarkayaGore.Size = new System.Drawing.Size(121, 23);
            this.cbMarkayaGore.TabIndex = 59;
            this.cbMarkayaGore.SelectedIndexChanged += new System.EventHandler(this.cbMarkayaGore_SelectedIndexChanged);
            // 
            // cbSanzimanTuruneGore
            // 
            this.cbSanzimanTuruneGore.FormattingEnabled = true;
            this.cbSanzimanTuruneGore.Location = new System.Drawing.Point(245, 102);
            this.cbSanzimanTuruneGore.Name = "cbSanzimanTuruneGore";
            this.cbSanzimanTuruneGore.Size = new System.Drawing.Size(121, 23);
            this.cbSanzimanTuruneGore.TabIndex = 61;
            this.cbSanzimanTuruneGore.SelectedIndexChanged += new System.EventHandler(this.cbSanzimanTuruneGore_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 60;
            this.label5.Text = "ŞANZIMAN";
            // 
            // cbYakitTuruneGore
            // 
            this.cbYakitTuruneGore.FormattingEnabled = true;
            this.cbYakitTuruneGore.Location = new System.Drawing.Point(33, 102);
            this.cbYakitTuruneGore.Name = "cbYakitTuruneGore";
            this.cbYakitTuruneGore.Size = new System.Drawing.Size(121, 23);
            this.cbYakitTuruneGore.TabIndex = 63;
            this.cbYakitTuruneGore.SelectedIndexChanged += new System.EventHandler(this.cbYakitTuruneGore_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 62;
            this.label6.Text = "YAKIT TÜRÜ";
            // 
            // btnAra
            // 
            this.btnAra.AutoSize = true;
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAra.ImageKey = "musica-searcher (1).png";
            this.btnAra.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(637, 40);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(68, 77);
            this.btnAra.TabIndex = 64;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "musica-searcher (1).png");
            // 
            // AracArama
            // 
            this.AcceptButton = this.btnAra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 517);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cbYakitTuruneGore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSanzimanTuruneGore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMarkayaGore);
            this.Controls.Add(this.txtFiyataGore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYilaGore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModeleGore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAraclar);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AracArama";
            this.Text = "DETAYLI ARAÇ SORGULAMA";
            this.Load += new System.EventHandler(this.AracArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAraclar;
        private System.Windows.Forms.TextBox txtFiyataGore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYilaGore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModeleGore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMarkayaGore;
        private System.Windows.Forms.ComboBox cbSanzimanTuruneGore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbYakitTuruneGore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ImageList ımageList1;
    }
}