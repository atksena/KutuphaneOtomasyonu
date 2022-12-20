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
    public partial class UyeKitapListele : DevExpress.XtraEditors.XtraForm
    {
        public UyeKitapListele()
        {
            InitializeComponent();
        }
        public void KitapListele()
        {
           KutuphaneOtoDBEntities1 kdb = new KutuphaneOtoDBEntities1();
            var kitaplar = kdb.Kitaplar.ToList();
            dataGridView1.DataSource = kitaplar.ToList();
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Uyeİslemler anasayfa = new Uyeİslemler();
            anasayfa.Show();
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UyeKitapListele_Load(object sender, EventArgs e)
        {
            KitapListele();
        }
    }
}