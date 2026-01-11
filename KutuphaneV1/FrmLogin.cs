using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneV1.DataAccess;

namespace KutuphaneV1
{
    public partial class FrmLogin : Form
    {
        KullaniciDAL _kullaniciDAL = new KullaniciDAL();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            var kullanici = _kullaniciDAL.KullaniciGetir(txtKullaniciAdi.Text, txtSifre.Text);

            if (kullanici==null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                return;
            }
            if (txtKullaniciAdi.Text.ToLower()==kullanici.adi.ToLower() && txtSifre.Text==kullanici.sifre)
            {
                Form1 frmAnaSayfa= new Form1();
                frmAnaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
        }

    }
}
