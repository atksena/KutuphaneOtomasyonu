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
    public partial class PersonelSil : DevExpress.XtraEditors.XtraForm
    {
        public PersonelSil()
        {
            InitializeComponent();
        }
        KutuphaneOtoDBEntities1 kdb = new KutuphaneOtoDBEntities1();

        public void PersonelListele()
        {
            //KutuphaneOtoDBEntities1 kdb = new KutuphaneOtoDBEntities1();
            var personeller = kdb.GorevliBilgi.ToList();
            dataGridView1.DataSource = personeller.ToList();
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

        private void PersonelSil_Load(object sender, EventArgs e)
        {
            PersonelListele();
        }

        private void perSilBtn_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var personel = kdb.GorevliBilgi.Where(x => x.ID == secilenId).FirstOrDefault();
            kdb.GorevliBilgi.Remove(personel);
            kdb.SaveChanges();
            PersonelListele();
        }

        private void sidePanel1_Click(object sender, EventArgs e)
        {

        }
    }
}