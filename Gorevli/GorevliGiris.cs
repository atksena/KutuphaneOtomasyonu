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
    public partial class GorevliGiris : DevExpress.XtraEditors.XtraForm
    {
        public GorevliGiris()
        {
            InitializeComponent();
        }
        KutuphaneOtoDBEntities1 kdb = new KutuphaneOtoDBEntities1();
        private void GorevliGiris_Load(object sender, EventArgs e)
        {

        }

        private void gorevliGirisBtn_Click(object sender, EventArgs e)
        {
            string gorevliAd = gorevliAdGiris.Text;
            string gorevliSifre = gorevliSifreGiris.Text;

            var gorevli = kdb.GorevliBilgi.Where(x => x.AD.Equals(gorevliAd) && x.gorevliSifre.Equals(gorevliSifre)).FirstOrDefault();

            if (gorevli == null)
            {
                MessageBox.Show(text: "Kullanıcı Adı veya Şifre Yanlış");
            }
            else
            {
                MessageBox.Show(text: "Başarılı");
                İslemler islem = new İslemler();
                islem.Show();
                this.Hide();
            }

        }
 
       

        private void gorevliAdGiris_Leave(object sender, EventArgs e)
        {
            if (gorevliAdGiris.Text == "")
            {
                gorevliAdGiris.Text = "Kullanıcı Adı";
            }
        }

        private void gorevliSifreGiris_Enter(object sender, EventArgs e)
        {
            if (gorevliSifreGiris.Text == "Sifre")
            {
                gorevliSifreGiris.Text = "";
            }

        }

        private void gorevliSifreGiris_Leave(object sender, EventArgs e)
        {

            if (gorevliSifreGiris.Text == "")
            {
                gorevliSifreGiris.Text = "Sifre";
            }
        }

        private void gorGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (gorGoster.CheckState == CheckState.Checked)
            {
                gorevliSifreGiris.UseSystemPasswordChar = true;
                gorGoster.Text = "Gizle";
            }
            else if (gorGoster.CheckState == CheckState.Unchecked)
            {
                gorevliSifreGiris.UseSystemPasswordChar = false;
                gorGoster.Text = "Göster";
            }
        }

        private void gorevliAdGiris_Enter(object sender, EventArgs e)
        {
            if (gorevliAdGiris.Text == "Kullanıcı Adı")
            {
                gorevliAdGiris.Text = "";
            }
        }
    }
}