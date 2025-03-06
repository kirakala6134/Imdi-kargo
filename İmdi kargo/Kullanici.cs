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
    public partial class Kullanici : Form
    {
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
        }

        private void btnKargoYolla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kargonuz yollandı");
        }

        private void btnKullaniciBilgiKaydet_Click(object sender, EventArgs e)
        {
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
    }
}
