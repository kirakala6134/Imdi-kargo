using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace İmdi_kargo
{
    public partial class Admin : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;Database=imdikargo;Uid=root;pwd=YPpDy2np");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            MessageBox.Show("admin sayfası yükleniyor");
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void btnKargoDurumGuncelle_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cbKargoNo.SelectedItem == "" || cbKargoDurum.SelectedItem == null||mbtKargoTeslimTarih.Text =="")
            {
                MessageBox.Show("Lütfen tekrar deneyin");
                return;
            }
            string takipNo = cbKargoNo.Text;
            string yeniDurum = cbKargoDurum.SelectedItem.ToString();
            string TeslimTarih=mbtKargoTeslimTarih.Text;
            using (MySqlConnection con = new MySqlConnection("server=localhost;Database=imdikargo;Uid=root;pwd=YPpDy2np"))
            {
                con.Open();
                string query = "UPDATE kargo SET kargo_teslim_tarih = @Tarih, Kargo_durum = @Durum WHERE Takip_no = @TakipNo";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Durum", yeniDurum);
                    cmd.Parameters.AddWithValue("@Tarih", TeslimTarih);
                    cmd.Parameters.AddWithValue("@TakipNo", takipNo);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("kargo durumunuz güncellendi!");
                        dataGridView1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Güncellenecek kargo bulunamadı!");
                    }
                }
            }
        }

        private void cbKargoNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnKargoListe_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;Database=imdikargo;Uid=root;pwd=YPpDy2np"))
            {
                con.Open();
                string query = "SELECT * FROM kargo"; 

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btnMüsteriListe_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost;Database=imdikargo;Uid=root;pwd=YPpDy2np"))
            {
                con.Open();
                string query = "SELECT * FROM musteri";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
