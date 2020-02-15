namespace WFAHastaneKayıtSistemi
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.cbIller = new System.Windows.Forms.ComboBox();
            this.cbHastaneler = new System.Windows.Forms.ComboBox();
            this.cbHekimler = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lstHasta = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSaatler = new System.Windows.Forms.ComboBox();
            this.dtpGun = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFAHastaneKayıtSistemi.Properties.Resources.saglik_bakanligi_ndan_agiz_sagligina_iliskin_aciklama_h17396_7e037;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "İl:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hastane:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hekim:";
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRandevuAl.Location = new System.Drawing.Point(13, 531);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(215, 65);
            this.btnRandevuAl.TabIndex = 2;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // cbIller
            // 
            this.cbIller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIller.FormattingEnabled = true;
            this.cbIller.Location = new System.Drawing.Point(104, 251);
            this.cbIller.Name = "cbIller";
            this.cbIller.Size = new System.Drawing.Size(307, 28);
            this.cbIller.TabIndex = 3;
            this.cbIller.SelectedIndexChanged += new System.EventHandler(this.cbIller_SelectedIndexChanged);
            // 
            // cbHastaneler
            // 
            this.cbHastaneler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHastaneler.FormattingEnabled = true;
            this.cbHastaneler.Location = new System.Drawing.Point(104, 290);
            this.cbHastaneler.Name = "cbHastaneler";
            this.cbHastaneler.Size = new System.Drawing.Size(307, 28);
            this.cbHastaneler.TabIndex = 3;
            // 
            // cbHekimler
            // 
            this.cbHekimler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHekimler.FormattingEnabled = true;
            this.cbHekimler.Location = new System.Drawing.Point(104, 336);
            this.cbHekimler.Name = "cbHekimler";
            this.cbHekimler.Size = new System.Drawing.Size(307, 28);
            this.cbHekimler.TabIndex = 3;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTemizle.Location = new System.Drawing.Point(12, 625);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(215, 65);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "TC Kimlik Numarası:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hasta Adı - Soyadı :";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(185, 176);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(226, 26);
            this.txtTc.TabIndex = 4;
            this.txtTc.UseWaitCursor = true;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(185, 207);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(226, 26);
            this.txtAdSoyad.TabIndex = 4;
            this.txtAdSoyad.UseWaitCursor = true;
            // 
            // lstHasta
            // 
            this.lstHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHasta.FormattingEnabled = true;
            this.lstHasta.HorizontalScrollbar = true;
            this.lstHasta.ItemHeight = 20;
            this.lstHasta.Location = new System.Drawing.Point(417, 12);
            this.lstHasta.Name = "lstHasta";
            this.lstHasta.ScrollAlwaysVisible = true;
            this.lstHasta.Size = new System.Drawing.Size(1164, 704);
            this.lstHasta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Randevu Saatleri:";
            // 
            // cbSaatler
            // 
            this.cbSaatler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSaatler.FormattingEnabled = true;
            this.cbSaatler.Location = new System.Drawing.Point(166, 374);
            this.cbSaatler.Name = "cbSaatler";
            this.cbSaatler.Size = new System.Drawing.Size(245, 28);
            this.cbSaatler.TabIndex = 3;
            // 
            // dtpGun
            // 
            this.dtpGun.Location = new System.Drawing.Point(114, 426);
            this.dtpGun.Name = "dtpGun";
            this.dtpGun.Size = new System.Drawing.Size(297, 26);
            this.dtpGun.TabIndex = 6;
            this.dtpGun.Value = new System.DateTime(2019, 2, 3, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Gün Seç:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 731);
            this.Controls.Add(this.dtpGun);
            this.Controls.Add(this.lstHasta);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.cbSaatler);
            this.Controls.Add(this.cbHekimler);
            this.Controls.Add(this.cbHastaneler);
            this.Controls.Add(this.cbIller);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnRandevuAl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.ComboBox cbIller;
        private System.Windows.Forms.ComboBox cbHastaneler;
        private System.Windows.Forms.ComboBox cbHekimler;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.ListBox lstHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSaatler;
        private System.Windows.Forms.DateTimePicker dtpGun;
        private System.Windows.Forms.Label label7;
    }
}

