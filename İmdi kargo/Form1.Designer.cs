﻿namespace İmdi_kargo
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtUyeParola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUyeEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdminParola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnNoArat = new System.Windows.Forms.Button();
            this.txtSorgu = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSure = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtDogumYili1 = new System.Windows.Forms.MaskedTextBox();
            this.btnUyeKaydol = new System.Windows.Forms.Button();
            this.txtKayıtParolaTekrar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKayıtParola = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKayıtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.cbAlınacakIlce = new System.Windows.Forms.ComboBox();
            this.cbAlınacakIl = new System.Windows.Forms.ComboBox();
            this.cbGonderiIce = new System.Windows.Forms.ComboBox();
            this.cbGonderiIL = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dbGonderiSorgu = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGonderiSorgu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnKaydol);
            this.groupBox1.Controls.Add(this.btnGiris);
            this.groupBox1.Controls.Add(this.txtUyeParola);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUyeEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 209);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Giris";
            // 
            // btnKaydol
            // 
            this.btnKaydol.Location = new System.Drawing.Point(145, 120);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(135, 78);
            this.btnKaydol.TabIndex = 11;
            this.btnKaydol.Text = "Kaydol";
            this.btnKaydol.UseVisualStyleBackColor = true;
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(4, 120);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(135, 78);
            this.btnGiris.TabIndex = 10;
            this.btnGiris.Text = "Giris";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtUyeParola
            // 
            this.txtUyeParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUyeParola.Location = new System.Drawing.Point(79, 75);
            this.txtUyeParola.Name = "txtUyeParola";
            this.txtUyeParola.Size = new System.Drawing.Size(199, 34);
            this.txtUyeParola.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(-1, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parola";
            // 
            // txtUyeEmail
            // 
            this.txtUyeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUyeEmail.Location = new System.Drawing.Point(79, 31);
            this.txtUyeEmail.Name = "txtUyeEmail";
            this.txtUyeEmail.Size = new System.Drawing.Size(199, 34);
            this.txtUyeEmail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-1, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtAdminName);
            this.groupBox2.Controls.Add(this.btnAdminGiris);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAdminParola);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(946, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 224);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Admin giris";
            // 
            // txtAdminName
            // 
            this.txtAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminName.Location = new System.Drawing.Point(146, 20);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(199, 34);
            this.txtAdminName.TabIndex = 13;
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Location = new System.Drawing.Point(37, 140);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(274, 78);
            this.btnAdminGiris.TabIndex = 16;
            this.btnAdminGiris.Text = "Giris";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(-5, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // txtAdminParola
            // 
            this.txtAdminParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminParola.Location = new System.Drawing.Point(121, 72);
            this.txtAdminParola.Name = "txtAdminParola";
            this.txtAdminParola.Size = new System.Drawing.Size(199, 34);
            this.txtAdminParola.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Parola";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnKapat);
            this.groupBox3.Controls.Add(this.btnNoArat);
            this.groupBox3.Controls.Add(this.txtSorgu);
            this.groupBox3.Location = new System.Drawing.Point(377, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 127);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "gönderi sorgulama";
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(431, 71);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(120, 50);
            this.btnKapat.TabIndex = 13;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Visible = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnNoArat
            // 
            this.btnNoArat.Location = new System.Drawing.Point(431, 18);
            this.btnNoArat.Name = "btnNoArat";
            this.btnNoArat.Size = new System.Drawing.Size(120, 50);
            this.btnNoArat.TabIndex = 12;
            this.btnNoArat.Text = "Arat";
            this.btnNoArat.UseVisualStyleBackColor = true;
            this.btnNoArat.Click += new System.EventHandler(this.btnNoArat_Click);
            // 
            // txtSorgu
            // 
            this.txtSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSorgu.Location = new System.Drawing.Point(6, 26);
            this.txtSorgu.Name = "txtSorgu";
            this.txtSorgu.Size = new System.Drawing.Size(419, 30);
            this.txtSorgu.TabIndex = 0;
            this.txtSorgu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSorgu_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnSure);
            this.groupBox4.Location = new System.Drawing.Point(376, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(564, 131);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hizmet türü";
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(118, 24);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(308, 78);
            this.btnSure.TabIndex = 12;
            this.btnSure.Text = "süre ve maliyet";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.txtDogumYili1);
            this.groupBox5.Controls.Add(this.btnUyeKaydol);
            this.groupBox5.Controls.Add(this.txtKayıtParolaTekrar);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtKayıtParola);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtTcNo);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtAdSoyad);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtKayıtEmail);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(16, 237);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(366, 434);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kaydol";
            this.groupBox5.Visible = false;
            // 
            // txtDogumYili1
            // 
            this.txtDogumYili1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDogumYili1.Location = new System.Drawing.Point(125, 191);
            this.txtDogumYili1.Mask = "00/00/0000";
            this.txtDogumYili1.Name = "txtDogumYili1";
            this.txtDogumYili1.Size = new System.Drawing.Size(229, 34);
            this.txtDogumYili1.TabIndex = 13;
            this.txtDogumYili1.ValidatingType = typeof(System.DateTime);
            // 
            // btnUyeKaydol
            // 
            this.btnUyeKaydol.Location = new System.Drawing.Point(21, 346);
            this.btnUyeKaydol.Name = "btnUyeKaydol";
            this.btnUyeKaydol.Size = new System.Drawing.Size(325, 77);
            this.btnUyeKaydol.TabIndex = 12;
            this.btnUyeKaydol.Text = "üyeliği tamamla";
            this.btnUyeKaydol.UseVisualStyleBackColor = true;
            this.btnUyeKaydol.Click += new System.EventHandler(this.btnUyeKaydol_Click);
            // 
            // txtKayıtParolaTekrar
            // 
            this.txtKayıtParolaTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayıtParolaTekrar.Location = new System.Drawing.Point(161, 297);
            this.txtKayıtParolaTekrar.Name = "txtKayıtParolaTekrar";
            this.txtKayıtParolaTekrar.PasswordChar = '*';
            this.txtKayıtParolaTekrar.Size = new System.Drawing.Size(199, 34);
            this.txtKayıtParolaTekrar.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(1, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 29);
            this.label11.TabIndex = 22;
            this.label11.Text = "Parola Tekrar";
            // 
            // txtKayıtParola
            // 
            this.txtKayıtParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayıtParola.Location = new System.Drawing.Point(112, 244);
            this.txtKayıtParola.Name = "txtKayıtParola";
            this.txtKayıtParola.PasswordChar = '*';
            this.txtKayıtParola.Size = new System.Drawing.Size(199, 34);
            this.txtKayıtParola.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(6, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 29);
            this.label10.TabIndex = 12;
            this.label10.Text = "Parola";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "Doğum yılı";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcNo.Location = new System.Drawing.Point(74, 137);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(280, 34);
            this.txtTcNo.TabIndex = 19;
            this.txtTcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTcNo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(1, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "TC";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(147, 82);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(191, 34);
            this.txtAdSoyad.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "AD SOYAD";
            // 
            // txtKayıtEmail
            // 
            this.txtKayıtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayıtEmail.Location = new System.Drawing.Point(87, 30);
            this.txtKayıtEmail.Name = "txtKayıtEmail";
            this.txtKayıtEmail.Size = new System.Drawing.Size(199, 34);
            this.txtKayıtEmail.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.btnHesapla);
            this.groupBox6.Controls.Add(this.cbAlınacakIlce);
            this.groupBox6.Controls.Add(this.cbAlınacakIl);
            this.groupBox6.Controls.Add(this.cbGonderiIce);
            this.groupBox6.Controls.Add(this.cbGonderiIL);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(411, 374);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(746, 312);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hizmet";
            this.groupBox6.Visible = false;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(220, 241);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(305, 66);
            this.btnHesapla.TabIndex = 14;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // cbAlınacakIlce
            // 
            this.cbAlınacakIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAlınacakIlce.FormattingEnabled = true;
            this.cbAlınacakIlce.Location = new System.Drawing.Point(600, 202);
            this.cbAlınacakIlce.Name = "cbAlınacakIlce";
            this.cbAlınacakIlce.Size = new System.Drawing.Size(135, 33);
            this.cbAlınacakIlce.TabIndex = 31;
            // 
            // cbAlınacakIl
            // 
            this.cbAlınacakIl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAlınacakIl.FormattingEnabled = true;
            this.cbAlınacakIl.Location = new System.Drawing.Point(600, 103);
            this.cbAlınacakIl.Name = "cbAlınacakIl";
            this.cbAlınacakIl.Size = new System.Drawing.Size(135, 33);
            this.cbAlınacakIl.TabIndex = 30;
            this.cbAlınacakIl.SelectedIndexChanged += new System.EventHandler(this.cbAlınacakIl_SelectedIndexChanged);
            // 
            // cbGonderiIce
            // 
            this.cbGonderiIce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGonderiIce.FormattingEnabled = true;
            this.cbGonderiIce.Location = new System.Drawing.Point(224, 202);
            this.cbGonderiIce.Name = "cbGonderiIce";
            this.cbGonderiIce.Size = new System.Drawing.Size(135, 33);
            this.cbGonderiIce.TabIndex = 29;
            // 
            // cbGonderiIL
            // 
            this.cbGonderiIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGonderiIL.FormattingEnabled = true;
            this.cbGonderiIL.Location = new System.Drawing.Point(188, 103);
            this.cbGonderiIL.Name = "cbGonderiIL";
            this.cbGonderiIL.Size = new System.Drawing.Size(135, 33);
            this.cbGonderiIL.TabIndex = 28;
            this.cbGonderiIL.SelectedIndexChanged += new System.EventHandler(this.cbGonderiIL_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(447, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 29);
            this.label15.TabIndex = 27;
            this.label15.Text = "Alınacak İlçe";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(473, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 29);
            this.label14.TabIndex = 26;
            this.label14.Text = "Alınacak İl";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(16, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 29);
            this.label13.TabIndex = 25;
            this.label13.Text = "Gönderilecek ilçe";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(6, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 29);
            this.label12.TabIndex = 24;
            this.label12.Text = "Gönderilecek il";
            // 
            // dbGonderiSorgu
            // 
            this.dbGonderiSorgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGonderiSorgu.Location = new System.Drawing.Point(162, 262);
            this.dbGonderiSorgu.Name = "dbGonderiSorgu";
            this.dbGonderiSorgu.RowHeadersWidth = 51;
            this.dbGonderiSorgu.RowTemplate.Height = 24;
            this.dbGonderiSorgu.Size = new System.Drawing.Size(1100, 220);
            this.dbGonderiSorgu.TabIndex = 13;
            this.dbGonderiSorgu.Visible = false;
            this.dbGonderiSorgu.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGonderiSorgu_CellEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 689);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(425, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Not: Admin giriş kullanıcı adı:Admin parola:1234";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(15, 723);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(787, 25);
            this.label16.TabIndex = 25;
            this.label16.Text = "Tarih girerken yılın sadece son iki rakamını giriniz mesela 25.08.2008 değilde 25" +
    ".08.08 gibi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::İmdi_kargo.Properties.Resources.İmdi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1324, 757);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dbGonderiSorgu);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGonderiSorgu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnGiris_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydol;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtUyeParola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUyeEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdminParola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNoArat;
        private System.Windows.Forms.TextBox txtSorgu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtKayıtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUyeKaydol;
        private System.Windows.Forms.TextBox txtKayıtParolaTekrar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKayıtParola;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ComboBox cbAlınacakIlce;
        private System.Windows.Forms.ComboBox cbAlınacakIl;
        private System.Windows.Forms.ComboBox cbGonderiIce;
        private System.Windows.Forms.ComboBox cbGonderiIL;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtDogumYili1;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView dbGonderiSorgu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
    }
}

