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
using KutuphaneV1.Entity;

namespace KutuphaneV1
{
    public partial class FrmKullanici : Form
    {
        KullaniciDAL _kullaniciDAL = new KullaniciDAL();
        Kullanici _kullanici= new Kullanici();
        public FrmKullanici(Kullanici kullanici)
        {
            _kullanici = kullanici;
            InitializeComponent();
        }

        private void FrmKullanici_Load(object sender, EventArgs e)
        {
            if (_kullanici.Id > 0)
            {
                txtKullaniciAdi.Text = _kullanici.adi;
                txtKullaniciSoyadi.Text = _kullanici.soyadi;
                txtSifre.Text = _kullanici.sifre;
                cmbYetki.SelectedItem = _kullanici.rol;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici
            {
                adi = txtKullaniciAdi.Text,
                soyadi = txtKullaniciSoyadi.Text,
                sifre = txtSifre.Text,
                rol = cmbYetki.Text
            };

            if (_kullanici.Id > 0)
            {
                kullanici.Id = _kullanici.Id;
                _kullaniciDAL.Guncelle(kullanici);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                _kullaniciDAL.Ekle(kullanici);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
