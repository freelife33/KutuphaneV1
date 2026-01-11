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
    public partial class Form1 : Form
    {
        YazarDAL _yazarDal = new YazarDAL();
        TurDAL _turDal = new TurDAL();
        KullaniciDAL _kullaniciDal = new KullaniciDAL();
        YayinEviDAL _yayinEviDal = new YayinEviDAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkleForm = new KitapEkle();
            kitapEkleForm.ShowDialog();

        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            frmYazarEkle frmYzrEkle = new frmYazarEkle(new Yazar());
            //frmYzrEkle.ShowDialog();
            if (frmYzrEkle.ShowDialog() == DialogResult.OK)
            {
                dtgYazarlar.DataSource = _yazarDal.YazarListele();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgYazarlar.DataSource = _yazarDal.YazarListele();
            dtgKategori.DataSource = _turDal.TurListele();
            dtgKullanicilar.DataSource = _kullaniciDal.KullaniciListele();
            dtgYayinEvleri.DataSource = _yayinEviDal.Listele();
        }

        private void btnYazarGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgYazarlar.CurrentRow.Cells["Id"].Value);
            String adi = dtgYazarlar.CurrentRow.Cells["Adi"].Value.ToString();
            String soyadi = dtgYazarlar.CurrentRow.Cells["Soyadi"].Value.ToString();

            //MessageBox.Show(id.ToString()+ adi +soyadi);

            frmYazarEkle frmYzrEkle = new frmYazarEkle(new Yazar { Id = id, Adi = adi, Soyadi = soyadi });
            //frmYzrEkle.ShowDialog();

            if (frmYzrEkle.ShowDialog() == DialogResult.OK)
            {
                dtgYazarlar.DataSource = _yazarDal.YazarListele();
            }
        }

        private void btnYazarSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgYazarlar.CurrentRow.Cells["Id"].Value);
            String adi = dtgYazarlar.CurrentRow.Cells["Adi"].Value.ToString();
            String soyadi = dtgYazarlar.CurrentRow.Cells["Soyadi"].Value.ToString();

            if (MessageBox.Show(adi + " " + soyadi + " Silinecek. Onaylıyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _yazarDal.Delete(id);
                dtgYazarlar.DataSource = _yazarDal.YazarListele();
            }
        }

        private void btnTurEkle_Click(object sender, EventArgs e)
        {
            FrmTur frmTur = new FrmTur();
            frmTur.ShowDialog();
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            FrmKullanici frmKullanici = new FrmKullanici(new Kullanici());
            if (frmKullanici.ShowDialog() == DialogResult.OK)
            {
                dtgKullanicilar.DataSource = _kullaniciDal.KullaniciListele();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgKullanicilar.CurrentRow.Cells["Id"].Value);
            String adi = dtgKullanicilar.CurrentRow.Cells["adi"].Value.ToString();
            String soyadi = dtgKullanicilar.CurrentRow.Cells["soyadi"].Value.ToString();
            string sifre = dtgKullanicilar.CurrentRow.Cells["sifre"].Value.ToString();
            string rol = dtgKullanicilar.CurrentRow.Cells["rol"].Value.ToString();
            FrmKullanici frmKullanici = new FrmKullanici(new Kullanici { Id = id, adi = adi, soyadi = soyadi, sifre = sifre, rol = rol });
            if (frmKullanici.ShowDialog() == DialogResult.OK)
            {
                dtgKullanicilar.DataSource = _kullaniciDal.KullaniciListele();
            }
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtgKullanicilar.CurrentRow.Cells["Id"].Value);
            string adi = dtgKullanicilar.CurrentRow.Cells["adi"].Value.ToString();
            string soyadi = dtgKullanicilar.CurrentRow.Cells["soyadi"].Value.ToString();

            if (MessageBox.Show(adi + " " + soyadi + " Silinecek. Onaylıyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _kullaniciDal.Sil(id);
                dtgKullanicilar.DataSource = _kullaniciDal.KullaniciListele();
            }
            
        }

        private void btnYayinEviEkle_Click(object sender, EventArgs e)
        {
            YayinEviEkle frmYayinEviEkle = new YayinEviEkle();

            if (frmYayinEviEkle.ShowDialog() == DialogResult.OK)
            {
                dtgYayinEvleri.DataSource = _yayinEviDal.Listele();
            }
        }
    }
}
