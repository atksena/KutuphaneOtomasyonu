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
using System.Data.OleDb;

namespace KutuphaneOto
{
    public partial class KitapAra : DevExpress.XtraEditors.XtraForm
    {
        public KitapAra()
        {
            InitializeComponent();
        }
        KutuphaneOtoDBEntities1 kdb = new KutuphaneOtoDBEntities1();

        public void KitapListele()
        {
            //KutuphaneOtoDBEntities1 kdb = new KutuphaneOtoDBEntities1();
            var kitaplar = kdb.Kitaplar.ToList();
            dataGridView1.DataSource = kitaplar.ToList();
        }
        private void KitapAra_Load(object sender, EventArgs e)
        {
            KitapListele();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            İslemler anasayfa = new İslemler();
            anasayfa.Show();
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void ktpAraBtn_Click(object sender, EventArgs e)
        {

        }

        private void ısbnAra_EditValueChanged(object sender, EventArgs e)
        {
            string gelenIsbn = ısbnAra.Text;
            var bulunan = kdb.Kitaplar.Where(x => x.ISBN.Contains(gelenIsbn)).ToList();
            dataGridView1.DataSource = bulunan;
        }
    }
}