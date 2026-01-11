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
    public partial class frmYazarEkle : Form
    {

        YazarDAL _yazarDal = new YazarDAL();
        int _yazarId;
        Yazar _yazar;
        public frmYazarEkle( Yazar yazar)
        {
           _yazar= yazar;
            InitializeComponent();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnYazarKaydet_Click(object sender, EventArgs e)
        {

            if (_yazarId == 0)
            {
                Yazar yazar = new Yazar()
                {
                    Adi = txtYazarAdi.Text,
                    Soyadi = txtYazarSoyadi.Text
                };
                _yazarDal.Ekle(yazar);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Yazar yazar = new Yazar()
                {
                    Id = _yazarId,
                    Adi = txtYazarAdi.Text,
                    Soyadi = txtYazarSoyadi.Text
                };
                _yazarDal.Update(yazar);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void frmYazarEkle_Load(object sender, EventArgs e)
        {
            txtYazarAdi.Text = _yazar.Adi;
            txtYazarSoyadi.Text = _yazar.Soyadi;
            _yazarId = _yazar.Id;
        }
    }
}

