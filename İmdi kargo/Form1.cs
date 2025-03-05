using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İmdi_kargo
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<string>> sehirler = new Dictionary<string, List<string>>()
        {
            { "İstanbul", new List<string> { "Beyoğlu", "Beşiktaş", "Ümraniye" } },
            { "Ankara", new List<string> { "Çankaya", "Keçiören", "Mamak" } },
            { "Trabzon", new List<string> { "Sürmene", "Of", "Araklı"} },
            { "İzmir", new List<string> { "Konak", "Bornova", "Karşıyaka" } }
        };
        string AdminName = "Admin";
        string AdminParola = "1234";
        string UyeMail = "";
        string UyeParola = "";
        public Form1()
        {
            InitializeComponent();
            cbGonderiIL.Items.AddRange(new object[] { "İstanbul", "Ankara", "Trabzon", "İzmir" });
            cbAlınacakIl.Items.AddRange(new object[] { "İstanbul", "Ankara", "Trabzon", "İzmir" });
            cbGonderiIL.SelectedIndexChanged += cbGonderiIL_SelectedIndexChanged;
            cbAlınacakIl.SelectedIndexChanged += cbAlınacakIl_SelectedIndexChanged;
            cbGonderiIlce.SelectedIndexChanged += cbAlınacakIl_SelectedIndexChanged;
            cbAlınacakIlce.SelectedIndexChanged += cbAlınacakIl_SelectedIndexChanged;
        }


        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            if ((txtUyeEmail.Text == UyeMail) && (txtUyeParola.Text == UyeParola))
            {
                MessageBox.Show("girişiniz başarılı!");
                kullanici.Show();
            }
            else
            {
                MessageBox.Show("lütfen tekrar deneyiniz!");
            }
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            btnGiris.Enabled = false;
            if (btnKaydol.Enabled)
            {
                groupBox5.Visible = true;
                groupBox6.Visible = false;
            }
          
        }
        private void btnSure_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            groupBox5.Visible = false;
        }

        private void cbGonderiIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGonderiIlce.Items.Clear();
            string secilenSehir = cbGonderiIL.SelectedItem.ToString();

            if (sehirler.ContainsKey(secilenSehir))
            {
                foreach (string ilce in sehirler[secilenSehir])
                {
                    cbGonderiIlce.Items.Add(ilce);
                }
            }
        }

        private void cbAlınacakIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAlınacakIlce.Items.Clear();
            string secilenSehir = cbAlınacakIl.SelectedItem.ToString();

            if (sehirler.ContainsKey(secilenSehir))
            {
                foreach (string ilce in sehirler[secilenSehir])
                {
                    cbAlınacakIlce.Items.Add(ilce);
                }
            }
        }

        private void btnUyeKaydol_Click(object sender, EventArgs e)
        {
            
            if (txtKayıtEmail.Text != "" && txtAdSoyad.Text != "" && txtTcNo.Text != "" && txtDogumYili.Text != "" && txtKayıtParola.Text != "" && txtKayıtParolaTekrar.Text != "")
            {
                if (txtKayıtParola.Text == txtKayıtParolaTekrar.Text && (txtTcNo.TextLength == 11))
                {
                    MessageBox.Show("üyeliğiniz tamamlandı!");
                    groupBox5.Visible = false;
                    UyeMail=txtKayıtEmail.Text;
                    UyeParola=txtKayıtParola.Text;
                    btnGiris.Enabled = true;
                }
                else
                {
                    MessageBox.Show("lütfen tekrar deneyiniz!");

                }
            }
            else
            {
                MessageBox.Show("kayıt olamadınız!");
            }
           

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if ((cbGonderiIL.SelectedIndex == 0 && cbAlınacakIl.SelectedIndex == 0))
            {
                MessageBox.Show("maliyetiniz:20tl\nKargonuzu alma süreniz tahmini 2 Gün");
            }
            else if((cbGonderiIL.SelectedIndex == 0 && cbAlınacakIl.SelectedIndex == 1) ||(cbGonderiIL.SelectedIndex == 1 && cbAlınacakIl.SelectedIndex == 0)) 
            {
                MessageBox.Show("maliyetiniz:100tl\nKargonuzu alma süreniz tahmini 7 Gün");
            }
            else if((cbGonderiIL.SelectedIndex == 0 && cbAlınacakIl.SelectedIndex == 2) || (cbGonderiIL.SelectedIndex == 2 && cbAlınacakIl.SelectedIndex == 0))
            {
                MessageBox.Show("maliyetiniz:150tl\nKargonuzu alma süreniz tahmini 10 Gün");
            }
            else if((cbGonderiIL.SelectedIndex == 0 && cbAlınacakIl.SelectedIndex == 3) || (cbGonderiIL.SelectedIndex == 3 && cbAlınacakIl.SelectedIndex == 0))
            {
                MessageBox.Show("maliyetiniz:80tl\nKargonuzu alma süreniz tahmini 5 Gün");
            }
            else if((cbGonderiIL.SelectedIndex == 1 && cbAlınacakIl.SelectedIndex == 1))
            {
                MessageBox.Show("maliyetiniz:10tl\nKargonuzu alma süreniz tahmini 2 Gün");
            }
            else if((cbGonderiIL.SelectedIndex == 1 && cbAlınacakIl.SelectedIndex == 2) || (cbGonderiIL.SelectedIndex == 2 && cbAlınacakIl.SelectedIndex == 1))
            {
                MessageBox.Show("maliyetiniz:100tl\nKargonuzu alma süreniz tahmini 7 Gün");
            }
            else if ((cbGonderiIL.SelectedIndex == 1 && cbAlınacakIl.SelectedIndex == 3) || (cbGonderiIL.SelectedIndex == 3 && cbAlınacakIl.SelectedIndex == 1))
            {
                MessageBox.Show("maliyetiniz:60tl\nKargonuzu alma süreniz tahmini 4 Gün");
            }
            else if((cbGonderiIL.SelectedIndex == 2 && cbAlınacakIl.SelectedIndex == 2))
            {
                MessageBox.Show("maliyetiniz:10tl\nKargonuzu alma süreniz tahmini 1 Gün");
            }
            else if((cbGonderiIL.SelectedIndex == 2 && cbAlınacakIl.SelectedIndex == 3) || (cbGonderiIL.SelectedIndex == 3 && cbAlınacakIl.SelectedIndex == 2))
            {
                MessageBox.Show("maliyetiniz:250tl\nKargonuzu alma süreniz tahmini 15 Gün");
            }
            else if ((cbGonderiIL.SelectedIndex == 3 && cbAlınacakIl.SelectedIndex == 3))
            {
                MessageBox.Show("maliyetiniz:15tl\nKargonuzu alma süreniz tahmini 2 Gün");
            }
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();    
            if (txtAdminName.Text == AdminName && txtAdminParola.Text == AdminParola)
            {
                  MessageBox.Show("Merhaba hoş geldiniz admin");
                  admin.Show();
                  this.Hide();  
            }
            else
            {
                 MessageBox.Show("lütfen tekrar deneyiniz");
                    
            }
        }
    }
}
