using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace İmdi_kargo
{
    public partial class Kullanici : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;Database=imdikargo;Uid=root;pwd=YPpDy2np");
        Random rnd = new Random();
        int TakipNo=0;
        public Kullanici()
        {
            InitializeComponent();
        }

        private void Kullanici_Load(object sender, EventArgs e)
        {
            MessageBox.Show("merhaba!\nHoş geldiniz");
        }

        private void btnReturnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
            
        }

        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                
                Color secilenRenk = colorDialog.Color;
                this.BackColor = secilenRenk;
                
            }
        }

        private void btnKargoDurum_Click(object sender, EventArgs e)
        {
            dbKargomNerdeSorgu.Visible=true;
            btnKapat.Visible=true;
            int KargoNo = Convert.ToInt32(txtKargoTakipNo.Text);
            if (txtKargoTakipNo.Text == "")
            {
                MessageBox.Show("lütfen tekrar deneyiniz!");
            }
            con.Open();
            string query = "SELECT Takip_no, kargo_durum FROM kargo WHERE Takip_no= @kargoNo";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@kargoNo", KargoNo);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dbKargomNerdeSorgu.DataSource = dt;
            con.Close();
        }

        private void btnKargoYolla_Click(object sender, EventArgs e)
        {
            TakipNo=rnd.Next(1,100);
            string query = "INSERT INTO Kargo (Takip_no, Kargo_teslim_tipi, Kargo_gonderi_tarih, Kargo_odeme_tipi, Kargo_alici_adres) VALUES (@TakipNo, @teslimTipi, @gonderilenTarih, @odemeTipi, @aliciAdresi)";
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@TakipNo", TakipNo);
                cmd.Parameters.AddWithValue("@teslimTipi", cbTeslimTipi.Text);
                cmd.Parameters.AddWithValue("@gonderilenTarih", mtbGonderilenTarih.Text);
                cmd.Parameters.AddWithValue("@odemeTipi", cbOdemeTipi.Text);
                cmd.Parameters.AddWithValue("@aliciAdresi", txtAlicininAdresi.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kargo başarıyla gönderildi!"+"\nkargo takip numaranız: "+TakipNo+"\nLütfen unutmayınız!");
            }
        }

        private void btnKullaniciBilgiKaydet_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE musteri SET Musteri_AdSoyad=@adsoyad, Musteri_DogumYili=@dogumyili, Musteri_email=@email, Musteri_parola=@parola, Musteri_TC=@tc WHERE Musteri_No=@MusteriNo";
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@MusteriNo",Convert.ToInt32( txtKullanici_MusteriNo.Text));
                cmd.Parameters.AddWithValue("@adsoyad", txtKullaniciAdSoyad.Text);
                cmd.Parameters.AddWithValue("@dogumyili", txtKullaniciDY.Text);
                cmd.Parameters.AddWithValue("@email", txtulalniciMail.Text);
                cmd.Parameters.AddWithValue("@parola", txtKullaniciParola.Text);
                cmd.Parameters.AddWithValue("@tc", txtKullaniciTc.Text);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Bilgiler başarıyla güncellendi!");
                }
                else
                {
                    MessageBox.Show("Güncelleme yapılamadı lütfen tekrar deneyiniz!.");
                }
                con.Close();
            }

            if ((txtKullaniciAdSoyad.Text != "") || (txtAlicininAdresi.Text != "") || (txtKullaniciDY.Text != "") || (txtKullaniciParola.Text != "") || (txtKullaniciTc.Text != "") || (txtulalniciMail.Text != ""))
            {
                if (txtKullaniciTc.TextLength == 11)
                {
                    MessageBox.Show("Başarıyla kaydedildi");
                }
                else
                {
                    MessageBox.Show("Tc kimliğinizi prosedürlere uygun bir şekilde giriniz!");
                }
            }
            else
            {
                MessageBox.Show("lütfen tekrar deneyniz!");
            }
           
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            dbKargomNerdeSorgu.Visible = false;
            btnKapat.Visible = false;
        }

        private void txtKargoTakipNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKullaniciTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
