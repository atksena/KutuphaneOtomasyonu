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
    public partial class İslemler : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public İslemler()
        {
            InitializeComponent();
        }

       

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            UyeGoruntule listele = new UyeGoruntule();
            listele.Show();
            this.Hide();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            UyeSil uyeSilme = new UyeSil();
            uyeSilme.Show();
            this.Hide();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            UyeEkle UyeEkleme = new UyeEkle();
            UyeEkleme.Show();
            this.Hide();
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            UyeGuncelle guncelle = new UyeGuncelle();
            guncelle.Show();
            this.Hide();
        }

        private void accordionControlElement16_Click(object sender, EventArgs e)
        {
            PersonelGoruntule perGoruntule = new PersonelGoruntule();
            perGoruntule.Show();
            this.Hide();
        }

        private void accordionControlElement17_Click(object sender, EventArgs e)
        {
            PersonelEkle perEkleme = new PersonelEkle();
            perEkleme.Show();
            this.Hide();
        }

        private void accordionControlElement18_Click(object sender, EventArgs e)
        {
            PersonelSil perSilme = new PersonelSil();
            perSilme.Show();
            this.Hide();
        }

        private void accordionControlElement19_Click(object sender, EventArgs e)
        {
            PersonelGuncelle perGuncelleme = new PersonelGuncelle();
            perGuncelleme.Show();
            this.Hide();
        }

        private void accordionControlElement18_Click_1(object sender, EventArgs e)
        {
            PersonelSil perSilme = new PersonelSil();
            perSilme.Show();
            this.Hide();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            KitapGoruntule ktpGoruntule = new KitapGoruntule();
            ktpGoruntule.Show();
            this.Hide();
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            KitapEkle ktpEkleme = new KitapEkle();
            ktpEkleme.Show();
            this.Hide();
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            KitapSil ktpSilme = new KitapSil();
            ktpSilme.Show();
            this.Hide();
        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            KitapGuncelle ktpGuncelle = new KitapGuncelle();
            ktpGuncelle.Show();
            this.Hide();
        }

        private void accordionControlElement21_Click(object sender, EventArgs e)
        {
            KitapAra ktpArama = new KitapAra();
            ktpArama.Show();
            this.Hide();
        }

        private void accordionControlElement20_Click(object sender, EventArgs e)
        {
            Hakkimizda bilgi = new Hakkimizda();
            bilgi.Show();
            this.Hide();
            
        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            İslemler anasyf = new İslemler();
            anasyf.Show();
            this.Hide();
        }
    }
}
