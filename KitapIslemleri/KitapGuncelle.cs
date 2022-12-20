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
    public partial class KitapGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public KitapGuncelle()
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

        private void KitapGuncelle_Load(object sender, EventArgs e)
        {
            KitapListele();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ktpISBN.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ktpAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ktpYazar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ktpYayınevi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ktpBasim.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            ktpSayfa.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void KtpGunBtn_Click(object sender, EventArgs e)
        {
            int gunKtp = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var gunKitap = kdb.Kitaplar.Where(x => x.ID == gunKtp).FirstOrDefault();

            gunKitap.ISBN = ktpISBN.Text;
            gunKitap.AD = ktpAd.Text;
            gunKitap.YAZAR = ktpYazar.Text;
            gunKitap.YAYINEVİ = ktpYayınevi.Text;
            gunKitap.BASIM_TARİHİ = ktpBasim.Value;
            gunKitap.SAYFA_SAYISI = Convert.ToInt16(ktpSayfa.Value);

            kdb.SaveChanges();

            KitapListele();
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ktpISBN.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ktpAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ktpYazar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ktpYayınevi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ktpBasim.Value =Convert.ToDateTime( dataGridView1.CurrentRow.Cells[5].Value);
            ktpSayfa.Value = Convert.ToDecimal( dataGridView1.CurrentRow.Cells[6].Value);

        }
    }
}