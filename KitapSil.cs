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
    public partial class KitapSil : DevExpress.XtraEditors.XtraForm
    {
        public KitapSil()
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

        private void KitapSil_Load(object sender, EventArgs e)
        {
            KitapListele();
        }

        private void ktpSil_Click(object sender, EventArgs e)
        {

            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kitap = kdb.Kitaplar.Where(x => x.ID == secilenId).FirstOrDefault();
            kdb.Kitaplar.Remove(kitap);
            kdb.SaveChanges();
            KitapListele();
        }
    }
}