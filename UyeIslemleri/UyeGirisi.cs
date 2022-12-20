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
    public partial class UyeGirisi : DevExpress.XtraEditors.XtraForm
    {
        public UyeGirisi()
        {
            InitializeComponent();
        }
        KutuphaneOtoDBEntities1 kdb = new KutuphaneOtoDBEntities1();
        private void UyeGirisi_Load(object sender, EventArgs e)
        {

        }

        private void uyeGirisBtn_Click(object sender, EventArgs e)
        {
            string uyeAd = uyeAdGiris.Text;
            string uyeSifre = uyeSifreGiris.Text;

            var uye = kdb.UyeBilgi.Where(x => x.AD.Equals(uyeAd) && x.SİFRE.Equals(uyeSifre)).FirstOrDefault();

            if (uye == null)
            {
                MessageBox.Show(text: "Kullanıcı Adı veya Şifre Yanlış");
            }
            else
            {
                MessageBox.Show(text: "Başarılı");
                Uyeİslemler islem = new Uyeİslemler();
                islem.Show();
                this.Hide();
            }
        }

        private void uyeAdGiris_Enter(object sender, EventArgs e)
        {
            if (uyeAdGiris.Text == "Kullanıcı Adı")
            {
                uyeAdGiris.Text = "";
            }
        }

        private void uyeAdGiris_Leave(object sender, EventArgs e)
        {
            if (uyeAdGiris.Text == "")
            {
                uyeAdGiris.Text = "Kullanıcı Adı";
            }
        }

        private void uyeSifreGiris_Enter(object sender, EventArgs e)
        {
            if (uyeSifreGiris.Text == "Sifre")
            {
                uyeSifreGiris.Text = "";
            }
        }

        private void uyeSifreGiris_Leave(object sender, EventArgs e)
        {
            if (uyeSifreGiris.Text == "")
            {
                uyeSifreGiris.Text = "Sifre";
            }
        }

        private void gorGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (gorGoster.CheckState == CheckState.Checked)
            {
                uyeSifreGiris.UseSystemPasswordChar = true;
                gorGoster.Text = "Gizle";
            }
            else if (gorGoster.CheckState == CheckState.Unchecked)
            {
                uyeSifreGiris.UseSystemPasswordChar = false;
                gorGoster.Text = "Göster";
            }
        }
    }
}