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
    public partial class MusteriSorgulama : Form
    {
        public MusteriSorgulama()
        {
            InitializeComponent();
        }
        ProjectDB db = new ProjectDB();
        string mad, msoyad, mtel, madres, mtc;
        private void MusteriSorgulama_Load(object sender, EventArgs e)
        {
            MusterileriGetir();
            txtAdaGore.Focus();         
        }
        void MusterileriGetir()
        {
            var sonuc = db.Musteriler.Select(x => new
            {
                x.MusteriId,
                x.MusteriAd,
                x.MusteriSoyad,
                x.MusteriAdres,
                x.MusteriTelefon,
                x.MusteriTC,
                x.MusteriDogumTarihi,
                x.EhliyetTarihi
            }).ToList();
            dgvMusteriler.DataSource = sonuc;
        }
        void MusteriAra(string mad, string msoyad, string mtel, string madres, string mtc)
        {
            var sonuc = db.Musteriler.Where(x => x.MusteriAd.Contains(mad) && x.MusteriSoyad.Contains(msoyad) && x.MusteriTelefon.Contains(mtel) && x.MusteriAdres.Contains(madres) && x.MusteriTC.Contains(mtc)).ToList();
            dgvMusteriler.DataSource = sonuc;
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            mad = txtAdaGore.Text;
            msoyad = txtSoyadaGore.Text;
            mtel = txtTelefonaGore.Text;
            madres = txtAdreseGore.Text;
            mtc = txtTCyeGore.Text;
            MusteriAra(mad, msoyad, mtel, madres, mtc);
            if (txtAdaGore.Text == null && txtSoyadaGore.Text == null && txtTelefonaGore.Text == null && txtAdreseGore.Text == null && txtTCyeGore.Text == null)
            {
                MusterileriGetir();
            }
        }

        private void txtSoyadaGore_TextChanged(object sender, EventArgs e)
        {
            mad = txtAdaGore.Text;
            msoyad = txtSoyadaGore.Text;
            mtel = txtTelefonaGore.Text;
            madres = txtAdreseGore.Text;
            mtc = txtTCyeGore.Text;
            MusteriAra(mad, msoyad, mtel, madres, mtc);
            if (txtAdaGore.Text == null && txtSoyadaGore.Text == null && txtTelefonaGore.Text == null && txtAdreseGore.Text == null && txtTCyeGore.Text == null)
            {
                MusterileriGetir();
            }
        }

        private void txtTelefonaGore_TextChanged(object sender, EventArgs e)
        {
            mad = txtAdaGore.Text;
            msoyad = txtSoyadaGore.Text;
            mtel = txtTelefonaGore.Text;
            madres = txtAdreseGore.Text;
            mtc = txtTCyeGore.Text;
            MusteriAra(mad, msoyad, mtel, madres, mtc);
            if (txtAdaGore.Text == null && txtSoyadaGore.Text == null && txtTelefonaGore.Text == null && txtAdreseGore.Text == null && txtTCyeGore.Text == null)
            {
                MusterileriGetir();
            }
        }

        private void txtAdreseGore_TextChanged(object sender, EventArgs e)
        {
            mad = txtAdaGore.Text;
            msoyad = txtSoyadaGore.Text;
            mtel = txtTelefonaGore.Text;
            madres = txtAdreseGore.Text;
            mtc = txtTCyeGore.Text;
            MusteriAra(mad, msoyad, mtel, madres, mtc);
            if (txtAdaGore.Text == null && txtSoyadaGore.Text == null && txtTelefonaGore.Text == null && txtAdreseGore.Text == null && txtTCyeGore.Text == null)
            {
                MusterileriGetir();
            }
        }

        private void txtTCyeGore_TextChanged(object sender, EventArgs e)
        {
            mad = txtAdaGore.Text;
            msoyad = txtSoyadaGore.Text;
            mtel = txtTelefonaGore.Text;
            madres = txtAdreseGore.Text;
            mtc = txtTCyeGore.Text;
            MusteriAra(mad, msoyad, mtel, madres, mtc);
            if (txtAdaGore.Text == null && txtSoyadaGore.Text == null && txtTelefonaGore.Text == null && txtAdreseGore.Text == null && txtTCyeGore.Text == null)
            {
                MusterileriGetir();
            }
        }
    }
}
