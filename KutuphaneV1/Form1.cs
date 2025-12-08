using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneV1
{
    public partial class Form1 : Form
    {
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
            frmYazarEkle  frmYzrEkle= new frmYazarEkle();
            frmYzrEkle.ShowDialog();
        }
    }
}
