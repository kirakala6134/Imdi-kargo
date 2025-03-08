namespace İmdi_kargo
{
    partial class Kullanici
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
            this.gbGonderiSor = new System.Windows.Forms.GroupBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKargoDurum = new System.Windows.Forms.Button();
            this.txtKargoTakipNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbKargoYolla = new System.Windows.Forms.GroupBox();
            this.txtAlicininAdresi = new System.Windows.Forms.RichTextBox();
            this.mtbGonderilenTarih = new System.Windows.Forms.MaskedTextBox();
            this.cbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.cbTeslimTipi = new System.Windows.Forms.ComboBox();
            this.btnKargoYolla = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbBilgiler = new System.Windows.Forms.GroupBox();
            this.btnKullaniciBilgiKaydet = new System.Windows.Forms.Button();
            this.txtKullaniciParola = new System.Windows.Forms.TextBox();
            this.txtulalniciMail = new System.Windows.Forms.TextBox();
            this.txtKullaniciDY = new System.Windows.Forms.TextBox();
            this.txtKullaniciTc = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdSoyad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbAyarlar = new System.Windows.Forms.GroupBox();
            this.btnReturnAnaSayfa = new System.Windows.Forms.Button();
            this.btnRenkSec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dbKargomNerdeSorgu = new System.Windows.Forms.DataGridView();
            this.gbGonderiSor.SuspendLayout();
            this.gbKargoYolla.SuspendLayout();
            this.gbBilgiler.SuspendLayout();
            this.gbAyarlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbKargomNerdeSorgu)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGonderiSor
            // 
            this.gbGonderiSor.Controls.Add(this.dbKargomNerdeSorgu);
            this.gbGonderiSor.Controls.Add(this.btnKapat);
            this.gbGonderiSor.Controls.Add(this.btnKargoDurum);
            this.gbGonderiSor.Controls.Add(this.txtKargoTakipNo);
            this.gbGonderiSor.Controls.Add(this.label2);
            this.gbGonderiSor.Location = new System.Drawing.Point(13, 13);
            this.gbGonderiSor.Name = "gbGonderiSor";
            this.gbGonderiSor.Size = new System.Drawing.Size(366, 583);
            this.gbGonderiSor.TabIndex = 0;
            this.gbGonderiSor.TabStop = false;
            this.gbGonderiSor.Text = "GonderiSorgula";
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(194, 85);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(135, 46);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Visible = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKargoDurum
            // 
            this.btnKargoDurum.Location = new System.Drawing.Point(11, 85);
            this.btnKargoDurum.Name = "btnKargoDurum";
            this.btnKargoDurum.Size = new System.Drawing.Size(135, 46);
            this.btnKargoDurum.TabIndex = 5;
            this.btnKargoDurum.Text = "Durum";
            this.btnKargoDurum.UseVisualStyleBackColor = true;
            this.btnKargoDurum.Click += new System.EventHandler(this.btnKargoDurum_Click);
            // 
            // txtKargoTakipNo
            // 
            this.txtKargoTakipNo.Location = new System.Drawing.Point(168, 40);
            this.txtKargoTakipNo.Name = "txtKargoTakipNo";
            this.txtKargoTakipNo.Size = new System.Drawing.Size(192, 22);
            this.txtKargoTakipNo.TabIndex = 4;
            this.txtKargoTakipNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKargoTakipNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kargo Takip No:";
            // 
            // gbKargoYolla
            // 
            this.gbKargoYolla.Controls.Add(this.txtAlicininAdresi);
            this.gbKargoYolla.Controls.Add(this.mtbGonderilenTarih);
            this.gbKargoYolla.Controls.Add(this.cbOdemeTipi);
            this.gbKargoYolla.Controls.Add(this.cbTeslimTipi);
            this.gbKargoYolla.Controls.Add(this.btnKargoYolla);
            this.gbKargoYolla.Controls.Add(this.label6);
            this.gbKargoYolla.Controls.Add(this.label5);
            this.gbKargoYolla.Controls.Add(this.label4);
            this.gbKargoYolla.Controls.Add(this.label3);
            this.gbKargoYolla.Location = new System.Drawing.Point(385, 13);
            this.gbKargoYolla.Name = "gbKargoYolla";
            this.gbKargoYolla.Size = new System.Drawing.Size(476, 583);
            this.gbKargoYolla.TabIndex = 1;
            this.gbKargoYolla.TabStop = false;
            this.gbKargoYolla.Text = "Kargo Yolla";
            // 
            // txtAlicininAdresi
            // 
            this.txtAlicininAdresi.Location = new System.Drawing.Point(153, 247);
            this.txtAlicininAdresi.Name = "txtAlicininAdresi";
            this.txtAlicininAdresi.Size = new System.Drawing.Size(292, 228);
            this.txtAlicininAdresi.TabIndex = 14;
            this.txtAlicininAdresi.Text = "";
            // 
            // mtbGonderilenTarih
            // 
            this.mtbGonderilenTarih.Location = new System.Drawing.Point(166, 106);
            this.mtbGonderilenTarih.Mask = "00/00/0000";
            this.mtbGonderilenTarih.Name = "mtbGonderilenTarih";
            this.mtbGonderilenTarih.Size = new System.Drawing.Size(125, 22);
            this.mtbGonderilenTarih.TabIndex = 13;
            this.mtbGonderilenTarih.ValidatingType = typeof(System.DateTime);
            // 
            // cbOdemeTipi
            // 
            this.cbOdemeTipi.FormattingEnabled = true;
            this.cbOdemeTipi.Location = new System.Drawing.Point(154, 182);
            this.cbOdemeTipi.Name = "cbOdemeTipi";
            this.cbOdemeTipi.Size = new System.Drawing.Size(137, 24);
            this.cbOdemeTipi.TabIndex = 12;
            // 
            // cbTeslimTipi
            // 
            this.cbTeslimTipi.FormattingEnabled = true;
            this.cbTeslimTipi.Location = new System.Drawing.Point(125, 39);
            this.cbTeslimTipi.Name = "cbTeslimTipi";
            this.cbTeslimTipi.Size = new System.Drawing.Size(137, 24);
            this.cbTeslimTipi.TabIndex = 11;
            // 
            // btnKargoYolla
            // 
            this.btnKargoYolla.Location = new System.Drawing.Point(257, 507);
            this.btnKargoYolla.Name = "btnKargoYolla";
            this.btnKargoYolla.Size = new System.Drawing.Size(213, 70);
            this.btnKargoYolla.TabIndex = 10;
            this.btnKargoYolla.Text = "Yolla";
            this.btnKargoYolla.UseVisualStyleBackColor = true;
            this.btnKargoYolla.Click += new System.EventHandler(this.btnKargoYolla_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Alıcının Adresi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ödeme Tipi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teslim Tipi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(0, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gönderilen Tarih";
            // 
            // gbBilgiler
            // 
            this.gbBilgiler.Controls.Add(this.btnKullaniciBilgiKaydet);
            this.gbBilgiler.Controls.Add(this.txtKullaniciParola);
            this.gbBilgiler.Controls.Add(this.txtulalniciMail);
            this.gbBilgiler.Controls.Add(this.txtKullaniciDY);
            this.gbBilgiler.Controls.Add(this.txtKullaniciTc);
            this.gbBilgiler.Controls.Add(this.txtKullaniciAdSoyad);
            this.gbBilgiler.Controls.Add(this.label11);
            this.gbBilgiler.Controls.Add(this.label10);
            this.gbBilgiler.Controls.Add(this.label9);
            this.gbBilgiler.Controls.Add(this.label8);
            this.gbBilgiler.Controls.Add(this.label7);
            this.gbBilgiler.Location = new System.Drawing.Point(867, 13);
            this.gbBilgiler.Name = "gbBilgiler";
            this.gbBilgiler.Size = new System.Drawing.Size(459, 403);
            this.gbBilgiler.TabIndex = 2;
            this.gbBilgiler.TabStop = false;
            this.gbBilgiler.Text = "Bilgileriniz";
            // 
            // btnKullaniciBilgiKaydet
            // 
            this.btnKullaniciBilgiKaydet.Location = new System.Drawing.Point(12, 360);
            this.btnKullaniciBilgiKaydet.Name = "btnKullaniciBilgiKaydet";
            this.btnKullaniciBilgiKaydet.Size = new System.Drawing.Size(387, 37);
            this.btnKullaniciBilgiKaydet.TabIndex = 15;
            this.btnKullaniciBilgiKaydet.Text = "Kaydet ve Değiştir";
            this.btnKullaniciBilgiKaydet.UseVisualStyleBackColor = true;
            this.btnKullaniciBilgiKaydet.Click += new System.EventHandler(this.btnKullaniciBilgiKaydet_Click);
            // 
            // txtKullaniciParola
            // 
            this.txtKullaniciParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciParola.Location = new System.Drawing.Point(113, 321);
            this.txtKullaniciParola.Name = "txtKullaniciParola";
            this.txtKullaniciParola.Size = new System.Drawing.Size(195, 30);
            this.txtKullaniciParola.TabIndex = 24;
            // 
            // txtulalniciMail
            // 
            this.txtulalniciMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtulalniciMail.Location = new System.Drawing.Point(113, 238);
            this.txtulalniciMail.Name = "txtulalniciMail";
            this.txtulalniciMail.Size = new System.Drawing.Size(195, 30);
            this.txtulalniciMail.TabIndex = 23;
            // 
            // txtKullaniciDY
            // 
            this.txtKullaniciDY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciDY.Location = new System.Drawing.Point(113, 159);
            this.txtKullaniciDY.Name = "txtKullaniciDY";
            this.txtKullaniciDY.Size = new System.Drawing.Size(195, 30);
            this.txtKullaniciDY.TabIndex = 22;
            // 
            // txtKullaniciTc
            // 
            this.txtKullaniciTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciTc.Location = new System.Drawing.Point(113, 93);
            this.txtKullaniciTc.Name = "txtKullaniciTc";
            this.txtKullaniciTc.Size = new System.Drawing.Size(195, 30);
            this.txtKullaniciTc.TabIndex = 21;
            this.txtKullaniciTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciTc_KeyPress);
            // 
            // txtKullaniciAdSoyad
            // 
            this.txtKullaniciAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdSoyad.Location = new System.Drawing.Point(113, 32);
            this.txtKullaniciAdSoyad.Name = "txtKullaniciAdSoyad";
            this.txtKullaniciAdSoyad.Size = new System.Drawing.Size(195, 30);
            this.txtKullaniciAdSoyad.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(7, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Parola:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(7, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Doğum Yılı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "TC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "AdSoyad:";
            // 
            // gbAyarlar
            // 
            this.gbAyarlar.Controls.Add(this.btnReturnAnaSayfa);
            this.gbAyarlar.Controls.Add(this.btnRenkSec);
            this.gbAyarlar.Controls.Add(this.label1);
            this.gbAyarlar.Location = new System.Drawing.Point(867, 422);
            this.gbAyarlar.Name = "gbAyarlar";
            this.gbAyarlar.Size = new System.Drawing.Size(459, 174);
            this.gbAyarlar.TabIndex = 3;
            this.gbAyarlar.TabStop = false;
            this.gbAyarlar.Text = "Ayarlar";
            // 
            // btnReturnAnaSayfa
            // 
            this.btnReturnAnaSayfa.Location = new System.Drawing.Point(12, 87);
            this.btnReturnAnaSayfa.Name = "btnReturnAnaSayfa";
            this.btnReturnAnaSayfa.Size = new System.Drawing.Size(387, 81);
            this.btnReturnAnaSayfa.TabIndex = 2;
            this.btnReturnAnaSayfa.Text = "Anasayfa";
            this.btnReturnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnReturnAnaSayfa.Click += new System.EventHandler(this.btnReturnAnaSayfa_Click);
            // 
            // btnRenkSec
            // 
            this.btnRenkSec.Location = new System.Drawing.Point(153, 35);
            this.btnRenkSec.Name = "btnRenkSec";
            this.btnRenkSec.Size = new System.Drawing.Size(130, 31);
            this.btnRenkSec.TabIndex = 1;
            this.btnRenkSec.Text = "Renk seç";
            this.btnRenkSec.UseVisualStyleBackColor = true;
            this.btnRenkSec.Click += new System.EventHandler(this.btnRenkSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arka plan rengi:";
            // 
            // dbKargomNerdeSorgu
            // 
            this.dbKargomNerdeSorgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbKargomNerdeSorgu.Location = new System.Drawing.Point(11, 182);
            this.dbKargomNerdeSorgu.Name = "dbKargomNerdeSorgu";
            this.dbKargomNerdeSorgu.RowHeadersWidth = 51;
            this.dbKargomNerdeSorgu.RowTemplate.Height = 24;
            this.dbKargomNerdeSorgu.Size = new System.Drawing.Size(349, 302);
            this.dbKargomNerdeSorgu.TabIndex = 15;
            this.dbKargomNerdeSorgu.Visible = false;
            // 
            // Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 608);
            this.Controls.Add(this.gbAyarlar);
            this.Controls.Add(this.gbBilgiler);
            this.Controls.Add(this.gbKargoYolla);
            this.Controls.Add(this.gbGonderiSor);
            this.Name = "Kullanici";
            this.Text = "Kullanici";
            this.Load += new System.EventHandler(this.Kullanici_Load);
            this.gbGonderiSor.ResumeLayout(false);
            this.gbGonderiSor.PerformLayout();
            this.gbKargoYolla.ResumeLayout(false);
            this.gbKargoYolla.PerformLayout();
            this.gbBilgiler.ResumeLayout(false);
            this.gbBilgiler.PerformLayout();
            this.gbAyarlar.ResumeLayout(false);
            this.gbAyarlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbKargomNerdeSorgu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGonderiSor;
        private System.Windows.Forms.GroupBox gbKargoYolla;
        private System.Windows.Forms.GroupBox gbBilgiler;
        private System.Windows.Forms.GroupBox gbAyarlar;
        private System.Windows.Forms.Button btnReturnAnaSayfa;
        private System.Windows.Forms.Button btnRenkSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKargoDurum;
        private System.Windows.Forms.TextBox txtKargoTakipNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtAlicininAdresi;
        private System.Windows.Forms.MaskedTextBox mtbGonderilenTarih;
        private System.Windows.Forms.ComboBox cbOdemeTipi;
        private System.Windows.Forms.ComboBox cbTeslimTipi;
        private System.Windows.Forms.Button btnKargoYolla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKullaniciParola;
        private System.Windows.Forms.TextBox txtulalniciMail;
        private System.Windows.Forms.TextBox txtKullaniciDY;
        private System.Windows.Forms.TextBox txtKullaniciTc;
        private System.Windows.Forms.TextBox txtKullaniciAdSoyad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKullaniciBilgiKaydet;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView dbKargomNerdeSorgu;
    }
}