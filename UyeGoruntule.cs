using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KutuphaneOto
{
    public partial class UyeGoruntule : DevExpress.XtraEditors.XtraForm
    {
        public UyeGoruntule()
        {
            InitializeComponent();
        }

        public void UyeListele()
        {
            KutuphaneOtoDBEntities1 kdb = new KutuphaneOtoDBEntities1();
            var uyeler = kdb.UyeBilgi.ToList();
            dataGridView1.DataSource = uyeler.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            İslemler anasayfa = new İslemler();
            anasayfa.Show();
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UyeGoruntule_Load(object sender, EventArgs e)
        {
            UyeListele();
        }

        private void sidePanel1_Click(object sender, EventArgs e)
        {

        }
    }
}