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

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
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

        private void btnMaliyet_Click(object sender, EventArgs e)
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
            string secilenSehir1 = cbAlınacakIl.SelectedItem.ToString();

            if (sehirler.ContainsKey(secilenSehir1))
            {
                foreach (string ilce1 in sehirler[secilenSehir1])
                {
                    cbAlınacakIlce.Items.Add(ilce1);
                }
            }
        }

        private void btnUyeKaydol_Click(object sender, EventArgs e)
        {
            
            if (txtKayıtParola.Text == txtKayıtParolaTekrar.Text)
            {
                MessageBox.Show("üyeliğiniz tamamlandı!");
                groupBox5.Visible = false;
            }
            else
            {
                MessageBox.Show("şifrenizi kontrol edin");

            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if ((cbGonderiIL.SelectedIndex == 0 && cbAlınacakIl.SelectedIndex == 0))
            {
                MessageBox.Show("maliyetiniz:20tl\nKargonuzu alma süreniz tahmini 2 Gün");
            }
            else if ((cbGonderiIL.SelectedIndex == 0 && cbAlınacakIl.SelectedIndex == 1) ||(cbGonderiIL.SelectedIndex == 1 && cbAlınacakIl.SelectedIndex == 0)) 
            {
                MessageBox.Show("maliyetiniz:100tl\nKargonuzu alma süreniz tahmini 7 Gün");
            }
            else if ((cbGonderiIL.SelectedIndex == 0 && cbAlınacakIl.SelectedIndex == 2) || (cbGonderiIL.SelectedIndex == 2 && cbAlınacakIl.SelectedIndex == 0))
            {
                MessageBox.Show("maliyetiniz:150tl\nKargonuzu alma süreniz tahmini 10 Gün");
            }
            else if ((cbGonderiIL.SelectedIndex == 0 && cbAlınacakIl.SelectedIndex == 3) || (cbGonderiIL.SelectedIndex == 3 && cbAlınacakIl.SelectedIndex == 0))
            {
                MessageBox.Show("maliyetiniz:80tl\nKargonuzu alma süreniz tahmini 5 Gün");
            }
            else if ((cbGonderiIL.SelectedIndex == 1 && cbAlınacakIl.SelectedIndex == 1))
            {
                MessageBox.Show("maliyetiniz:10tl\nKargonuzu alma süreniz tahmini 2 Gün");
            }
            else if ((cbGonderiIL.SelectedIndex == 1 && cbAlınacakIl.SelectedIndex == 2) || (cbGonderiIL.SelectedIndex == 2 && cbAlınacakIl.SelectedIndex == 1))
            {
                MessageBox.Show("maliyetiniz:100tl\nKargonuzu alma süreniz tahmini 7 Gün");
            }
            else if ((cbGonderiIL.SelectedIndex == 1 && cbAlınacakIl.SelectedIndex == 3) || (cbGonderiIL.SelectedIndex == 3 && cbAlınacakIl.SelectedIndex == 1))
            {
                MessageBox.Show("maliyetiniz:60tl\nKargonuzu alma süreniz tahmini 4 Gün");
            }
            else if ((cbGonderiIL.SelectedIndex == 2 && cbAlınacakIl.SelectedIndex == 2))
            {
                MessageBox.Show("maliyetiniz:10tl\nKargonuzu alma süreniz tahmini 1 Gün");
            }
            else if ((cbGonderiIL.SelectedIndex == 2 && cbAlınacakIl.SelectedIndex == 3) || (cbGonderiIL.SelectedIndex == 3 && cbAlınacakIl.SelectedIndex == 2))
            {
                MessageBox.Show("maliyetiniz:250tl\nKargonuzu alma süreniz tahmini 15 Gün");
            }
            else if ((cbGonderiIL.SelectedIndex == 3 && cbAlınacakIl.SelectedIndex == 3))
            {
                MessageBox.Show("maliyetiniz:15tl\nKargonuzu alma süreniz tahmini 2 Gün");
            }


        }
    }
}
