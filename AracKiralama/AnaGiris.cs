using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class AnaGiris : Form
    {
        public AnaGiris()
        {
            InitializeComponent();
        }

        private void mitmMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriIslemleri frm = new MusteriIslemleri();
            frm.Show();
        }

        private void mitmMusteriSorgulama_Click(object sender, EventArgs e)
        {
            MusteriSorgulama frm = new MusteriSorgulama();
            frm.Show();
        }

        private void mitmMarkaIslemleri_Click(object sender, EventArgs e)
        {
            MarkaEkle frm = new MarkaEkle();
            frm.Show();
        }

        private void mitmAracEklemeIslemleri_Click(object sender, EventArgs e)
        {
            AracEkle frm = new AracEkle();
            frm.Show();
        }

        private void mitmAracArama_Click(object sender, EventArgs e)
        {
            AracArama frm = new AracArama();
            frm.Show();
        }

        private void mitmAracKiralama_Click(object sender, EventArgs e)
        {
            SatisIslemleri frm = new SatisIslemleri();
            frm.Show();
        }

        private void mitmAracTeslimAlma_Click(object sender, EventArgs e)
        {
            AracTeslimAlma frm = new AracTeslimAlma();
            frm.Show();
        }

        private void mitmYapilanKiralamalar_Click(object sender, EventArgs e)
        {
            AracKiralamaSorgulama frm = new AracKiralamaSorgulama();
            frm.Show();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MusteriIslemleri frm = new MusteriIslemleri();
            frm.Show();
        }


        private void pictureBox3_MouseClick_1(object sender, MouseEventArgs e)
        {
            AracKiralamaSorgulama frm = new AracKiralamaSorgulama();
            frm.Show();
        }

        private void pictureBox2_MouseClick_1(object sender, MouseEventArgs e)
        {
            AracArama frm = new AracArama();
            frm.Show();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            AracKiralamaSorgulama frm = new AracKiralamaSorgulama();
            frm.Show();
        }
    }
}
