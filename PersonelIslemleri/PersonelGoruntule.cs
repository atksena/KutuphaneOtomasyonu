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
    public partial class PersonelGoruntule : DevExpress.XtraEditors.XtraForm
    {
        public PersonelGoruntule()
        {
            InitializeComponent();
        }
        public void PersonelListele()
        {
            KutuphaneOtoDBEntities1 kdb = new KutuphaneOtoDBEntities1();
            var personel = kdb.GorevliBilgi.ToList();
            dataGridView1.DataSource = personel.ToList();
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

        private void PersonelGoruntule_Load(object sender, EventArgs e)
        {
            PersonelListele();
        }

        private void sidePanel1_Click(object sender, EventArgs e)
        {

        }
    }
}