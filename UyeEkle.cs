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
    public partial class UyeEkle : DevExpress.XtraEditors.XtraForm
    {
        public UyeEkle()
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void sidePanel1_Click(object sender, EventArgs e)
        {

        }

        private void UyeEkle_Load(object sender, EventArgs e)
        {
            UyeListele();
        }

        private void uyeEkleBtn_Click(object sender, EventArgs e)
        {
            UyeBilgi uyeBilgi = new UyeBilgi();
            uyeBilgi.AD = uyeAdi.Text;
            uyeBilgi.SOYAD = uyeSoyad.Text;
            uyeBilgi.MAİL = uyeMail.Text;
            uyeBilgi.NUMARA = uyeNo.Text;
            uyeBilgi.TC = uyeTc.Text;
            uyeBilgi.SİFRE = uyeSifre.Text;

            kdb.UyeBilgi.Add(uyeBilgi);
            kdb.SaveChanges();
            UyeListele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}