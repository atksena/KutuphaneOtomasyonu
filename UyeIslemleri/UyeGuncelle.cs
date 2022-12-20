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
    public partial class UyeGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public UyeGuncelle()
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

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            İslemler anasayfa = new İslemler();
            anasayfa.Show();
            this.Hide();
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UyeGuncelle_Load(object sender, EventArgs e)
        {
            UyeListele();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            adtxt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyadtxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tctxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mailtxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            notxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            sifretxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void UyeGuncelleBtn_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var uye = kdb.UyeBilgi.Where(x => x.ID == secilenId).FirstOrDefault();

            uye.AD = adtxt2.Text;
            uye.SOYAD = soyadtxt.Text;
            uye.TC = tctxt.Text;
            uye.MAİL = mailtxt.Text;
            uye.NUMARA = notxt.Text;
            uye.SİFRE = sifretxt.Text;

          
            kdb.SaveChanges();

            UyeListele();
        }

        private void TextEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            adtxt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyadtxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tctxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mailtxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            notxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            sifretxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}