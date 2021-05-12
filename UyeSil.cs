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
    public partial class UyeSil : DevExpress.XtraEditors.XtraForm
    {
        public UyeSil()
        {
            InitializeComponent();
        }
        KutuphaneOtoDBEntities1 kdb = new KutuphaneOtoDBEntities1();
        public void UyeListele()
        {
            //KutuphaneOtoDBEntities1 kdb = new KutuphaneOtoDBEntities1();
            var uyeler = kdb.UyeBilgi.ToList();
            dataGridView1.DataSource = uyeler.ToList();
        }

        private void UyeSil_Load(object sender, EventArgs e)
        {
            UyeListele();
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

        private void uyeSilBtn_Click(object sender, EventArgs e)
        {

        }

        private void uyeSilBtn_Click_1(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var uye = kdb.UyeBilgi.Where(x => x.ID == secilenId).FirstOrDefault();
            kdb.UyeBilgi.Remove(uye);
            kdb.SaveChanges();
            UyeListele();
        }
    }
}