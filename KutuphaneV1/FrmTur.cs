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
    public partial class FrmTur : Form
    {
        TurDAL _turDal = new TurDAL();
        public FrmTur()
        {
            InitializeComponent();
        }

        private void FrmTur_Load(object sender, EventArgs e)
        {

        }

        private void btnTurEkle_Click(object sender, EventArgs e)
        {
            Tur tur = new Tur
            {
                adi = txtTurAdi.Text
            };

            _turDal.Ekle(tur);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
