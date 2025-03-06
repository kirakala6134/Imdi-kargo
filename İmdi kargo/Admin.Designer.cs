namespace İmdi_kargo
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.btnMüsteriListe = new System.Windows.Forms.Button();
            this.btnKargoListe = new System.Windows.Forms.Button();
            this.btnKargoDurumGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cbKargoNo = new System.Windows.Forms.ComboBox();
            this.cbKargoDurum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAyarlar = new System.Windows.Forms.GroupBox();
            this.btnRenkSec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbAyarlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAnaSayfa);
            this.panel1.Controls.Add(this.btnMüsteriListe);
            this.panel1.Controls.Add(this.btnKargoListe);
            this.panel1.Controls.Add(this.btnKargoDurumGuncelle);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 114);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::İmdi_kargo.Properties.Resources.İmdi1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Location = new System.Drawing.Point(1043, 0);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(184, 114);
            this.btnAnaSayfa.TabIndex = 4;
            this.btnAnaSayfa.Text = "Anasayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // btnMüsteriListe
            // 
            this.btnMüsteriListe.Location = new System.Drawing.Point(738, 0);
            this.btnMüsteriListe.Name = "btnMüsteriListe";
            this.btnMüsteriListe.Size = new System.Drawing.Size(308, 114);
            this.btnMüsteriListe.TabIndex = 3;
            this.btnMüsteriListe.Text = "Müsteri Listesi";
            this.btnMüsteriListe.UseVisualStyleBackColor = true;
            // 
            // btnKargoListe
            // 
            this.btnKargoListe.Location = new System.Drawing.Point(434, 0);
            this.btnKargoListe.Name = "btnKargoListe";
            this.btnKargoListe.Size = new System.Drawing.Size(308, 114);
            this.btnKargoListe.TabIndex = 2;
            this.btnKargoListe.Text = "Kargo Listesi";
            this.btnKargoListe.UseVisualStyleBackColor = true;
            // 
            // btnKargoDurumGuncelle
            // 
            this.btnKargoDurumGuncelle.Location = new System.Drawing.Point(117, 0);
            this.btnKargoDurumGuncelle.Name = "btnKargoDurumGuncelle";
            this.btnKargoDurumGuncelle.Size = new System.Drawing.Size(319, 114);
            this.btnKargoDurumGuncelle.TabIndex = 1;
            this.btnKargoDurumGuncelle.Text = "Kargo Durumu Güncelle";
            this.btnKargoDurumGuncelle.UseVisualStyleBackColor = true;
            this.btnKargoDurumGuncelle.Click += new System.EventHandler(this.btnKargoDurumGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1214, 236);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.cbKargoNo);
            this.groupBox1.Controls.Add(this.cbKargoDurum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 435);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 240);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kargo Durumu Güncelle";
            this.groupBox1.Visible = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(12, 158);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(311, 59);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cbKargoNo
            // 
            this.cbKargoNo.FormattingEnabled = true;
            this.cbKargoNo.Location = new System.Drawing.Point(169, 39);
            this.cbKargoNo.Name = "cbKargoNo";
            this.cbKargoNo.Size = new System.Drawing.Size(154, 24);
            this.cbKargoNo.TabIndex = 4;
            // 
            // cbKargoDurum
            // 
            this.cbKargoDurum.FormattingEnabled = true;
            this.cbKargoDurum.Items.AddRange(new object[] {
            "Kargo Bayide",
            "Kargo Ulaştı",
            "Kargo Taşınıyor"});
            this.cbKargoDurum.Location = new System.Drawing.Point(169, 101);
            this.cbKargoDurum.Name = "cbKargoDurum";
            this.cbKargoDurum.Size = new System.Drawing.Size(154, 24);
            this.cbKargoDurum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kargo Durumu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kargo Takip No:";
            // 
            // gbAyarlar
            // 
            this.gbAyarlar.Controls.Add(this.btnRenkSec);
            this.gbAyarlar.Controls.Add(this.label3);
            this.gbAyarlar.Location = new System.Drawing.Point(752, 501);
            this.gbAyarlar.Name = "gbAyarlar";
            this.gbAyarlar.Size = new System.Drawing.Size(459, 174);
            this.gbAyarlar.TabIndex = 6;
            this.gbAyarlar.TabStop = false;
            this.gbAyarlar.Text = "Ayarlar";
            // 
            // btnRenkSec
            // 
            this.btnRenkSec.Location = new System.Drawing.Point(6, 106);
            this.btnRenkSec.Name = "btnRenkSec";
            this.btnRenkSec.Size = new System.Drawing.Size(434, 62);
            this.btnRenkSec.TabIndex = 1;
            this.btnRenkSec.Text = "Renk seç";
            this.btnRenkSec.UseVisualStyleBackColor = true;
            this.btnRenkSec.Click += new System.EventHandler(this.btnRenkSec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Arka plan rengi:";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 687);
            this.Controls.Add(this.gbAyarlar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAyarlar.ResumeLayout(false);
            this.gbAyarlar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Button btnMüsteriListe;
        private System.Windows.Forms.Button btnKargoListe;
        private System.Windows.Forms.Button btnKargoDurumGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cbKargoNo;
        private System.Windows.Forms.ComboBox cbKargoDurum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbAyarlar;
        private System.Windows.Forms.Button btnRenkSec;
        private System.Windows.Forms.Label label3;
    }
}