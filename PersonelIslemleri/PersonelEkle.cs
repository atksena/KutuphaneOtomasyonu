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
    public partial class PersonelEkle : DevExpress.XtraEditors.XtraForm
    {
        public PersonelEkle()
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

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            PersonelListele();
        }

        private void perEkle_Click(object sender, EventArgs e)
        {
            GorevliBilgi gorevliBilgi = new GorevliBilgi();
            gorevliBilgi.AD = perAd.Text;
            gorevliBilgi.SOYAD = perSoyad.Text;
            gorevliBilgi.MAİL = perMail.Text;
            gorevliBilgi.NUMARA = perNo.Text;
            gorevliBilgi.TC = perTc.Text;
            gorevliBilgi.gorevliSifre = perSifre.Text;

            kdb.GorevliBilgi.Add(gorevliBilgi);
            kdb.SaveChanges();
            PersonelListele();
        }
    }
}