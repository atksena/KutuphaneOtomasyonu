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
    public partial class KitapEkle : DevExpress.XtraEditors.XtraForm
    {
        public KitapEkle()
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

        private void KitapEkle_Load(object sender, EventArgs e)
        {
            KitapListele();
        }

        private void ktpEkleBtn_Click(object sender, EventArgs e)
        {
            Kitaplar kitap = new Kitaplar();
            kitap.ISBN = ktpISBN.Text;
            kitap.AD = ktpAd.Text;
            kitap.YAZAR = ktpYazar.Text;
            kitap.YAYINEVİ = ktpYayınevi.Text;
            kitap.BASIM_TARİHİ = ktpBasim.Value;
            kitap.SAYFA_SAYISI = Convert.ToInt16( ktpSayfa.Value);

            kdb.Kitaplar.Add(kitap);
            kdb.SaveChanges();

            KitapListele();

        }
    }
}