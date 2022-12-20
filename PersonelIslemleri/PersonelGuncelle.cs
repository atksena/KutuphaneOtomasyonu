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
    public partial class PersonelGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public PersonelGuncelle()
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

        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {
            PersonelListele();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            perAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            perSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            perTc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            perNo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            perMail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            perSifre.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void textEdit6_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void perGunBtn_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var personel = kdb.GorevliBilgi.Where(x => x.ID == secilenId).FirstOrDefault();

            personel.AD = perAd.Text;
            personel.SOYAD = perSoyad.Text;
            personel.TC = perTc.Text;
            personel.MAİL = perMail.Text;
            personel.NUMARA =perNo.Text;
            personel.gorevliSifre = perSifre.Text;


            kdb.SaveChanges();
            PersonelListele();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }
    }
}