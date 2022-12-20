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
    public partial class KitapGoruntule : DevExpress.XtraEditors.XtraForm
    {
        public KitapGoruntule()
        {
            InitializeComponent();
        }
        public void KitapListele()
        {
            KutuphaneOtoDBEntities1 kdb = new KutuphaneOtoDBEntities1();
            var kitaplar = kdb.Kitaplar.ToList();
            dataGridView1.DataSource = kitaplar.ToList();
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

        private void KitapGoruntule_Load(object sender, EventArgs e)
        {
            KitapListele();
        }
    }
}