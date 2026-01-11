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
    public partial class YayinEviEkle : Form
    {
        YayinEviDAL _yayinEviDAL = new YayinEviDAL();
        public YayinEviEkle()
        {
            InitializeComponent();
        }

        private void btnYayinEviEkle_Click(object sender, EventArgs e)
        {
            Yayin_Evi yayinEvi = new Yayin_Evi
            {
                ev_adi = txtYayinEviAdi.Text,
            };

            _yayinEviDAL.Ekle(yayinEvi);

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
