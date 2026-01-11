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
    public partial class KitapEkle : Form
    {
        YazarDAL _yazarDal = new YazarDAL();
        TurDAL _turDal = new TurDAL();
        YayinEviDAL _yayinEviDal = new YayinEviDAL();
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {
            cbxYazar.DisplayMember = "YazarAdi";
            cbxYazar.ValueMember = "Id";
            cbxYazar.DataSource = _yazarDal.YazarListe();

            cbxTuru.DisplayMember = "adi";
            cbxTuru.ValueMember = "Id";
            cbxTuru.DataSource = _turDal.TurListele();

            cbxYayinEvi.DisplayMember = "ev_adi";
            cbxYayinEvi.ValueMember = "Id";
            cbxYayinEvi.DataSource = _yayinEviDal.Listele();
        }
    }
}
