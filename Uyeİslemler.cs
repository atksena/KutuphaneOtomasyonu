using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KutuphaneOto
{
    public partial class Uyeİslemler : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Uyeİslemler()
        {
            InitializeComponent();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            Uyeİslemler anasayfa = new Uyeİslemler();
            anasayfa.Show();
            this.Hide();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            UyeKitapListele uyeKtpList = new UyeKitapListele();
            uyeKtpList.Show();
            this.Hide();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            Hakkimizda2 bilgi = new Hakkimizda2();
            bilgi.Show();
            this.Hide();
        }
    }
}
