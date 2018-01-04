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
    public partial class AracArama : Form
    {
        public AracArama()
        {
            InitializeComponent();
        }
        ProjectDB db = new ProjectDB();
        string aracmarka, aracmodel, sanzimanturu, yakitturu, aracyil, fiyat;
        private void AracArama_Load(object sender, EventArgs e)
        {
            AraclariGetir();
            YakitTuruGetir();
            SanzimanTuruGetir();
            MarkaGetir();
        }
        private void MarkaGetir()
        {
            var sonuc = db.Marka.Select(x => new
            {
                x.MarkaNo,
                x.AracMarka
            }).ToList();
            cbMarkayaGore.ValueMember = "MarkaNo";
            cbMarkayaGore.DisplayMember = "AracMarka";
            cbMarkayaGore.DataSource = sonuc;
        }

        private void txtModeleGore_TextChanged(object sender, EventArgs e)
        {
            aracmodel = txtModeleGore.Text;
            aracyil = txtYilaGore.Text;
            fiyat = txtYilaGore.Text;
            aracBul(aracmodel, aracyil, fiyat);
            if (string.IsNullOrEmpty(txtModeleGore.Text) && string.IsNullOrEmpty(txtYilaGore.Text) && string.IsNullOrEmpty(txtFiyataGore.Text))
            {
                AraclariGetir();
            }
        }

        private void txtYilaGore_TextChanged(object sender, EventArgs e)
        {
            aracmodel = txtModeleGore.Text;
            aracyil = txtYilaGore.Text;
            fiyat = txtYilaGore.Text;
            aracBul(aracmodel, aracyil, fiyat);
            if (string.IsNullOrEmpty(txtModeleGore.Text) && string.IsNullOrEmpty(txtYilaGore.Text) && string.IsNullOrEmpty(txtFiyataGore.Text))
            {
                AraclariGetir();
            }
        }

        private void txtFiyataGore_TextChanged(object sender, EventArgs e)
        {
            aracmodel = txtModeleGore.Text;
            aracyil = txtYilaGore.Text;
            fiyat = txtYilaGore.Text;
            aracBul(aracmodel, aracyil, fiyat);
            if (string.IsNullOrEmpty(txtModeleGore.Text) && string.IsNullOrEmpty(txtYilaGore.Text) && string.IsNullOrEmpty(txtFiyataGore.Text))
            {
                AraclariGetir();
            }
        }

        private void cbMarkayaGore_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aracmarka = Convert.ToString(cbMarkayaGore.SelectedValue);
            //aracmodel = txtModeleGore.Text;
            //aracyil = txtYilaGore.Text;
            //sanzimanturu = Convert.ToString(cbSanzimanTuruneGore.SelectedValue);
            //yakitturu = Convert.ToString(cbYakitTuruneGore.SelectedValue);
            //fiyat = txtYilaGore.Text;
            //aracBul(aracmarka, aracmodel, aracyil, sanzimanturu, yakitturu, fiyat);
            //if (string.IsNullOrEmpty(txtModeleGore.Text) && string.IsNullOrEmpty(txtYilaGore.Text) && string.IsNullOrEmpty(txtFiyataGore.Text))
            //{
            //    AraclariGetir();
            //}
        }

        private void cbSanzimanTuruneGore_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aracmarka = Convert.ToString(cbMarkayaGore.SelectedValue);
            //aracmodel = txtModeleGore.Text;
            //aracyil = txtYilaGore.Text;
            //sanzimanturu = Convert.ToString(cbSanzimanTuruneGore.SelectedValue);
            //yakitturu = Convert.ToString(cbYakitTuruneGore.SelectedValue);
            //fiyat = txtYilaGore.Text;
            //aracBul(aracmarka, aracmodel, aracyil, sanzimanturu, yakitturu, fiyat);
            //if (string.IsNullOrEmpty(txtModeleGore.Text) && string.IsNullOrEmpty(txtYilaGore.Text) && string.IsNullOrEmpty(txtFiyataGore.Text))
            //{
            //    AraclariGetir();
            //}
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Araclar a = new Araclar();
            YakitTuru yt = new YakitTuru();
            SanzimanTuru st = new SanzimanTuru();
            int secilenMarka = a.MarkaNo;
            int secilenYakit = yt.YakitTuruId;
            int secilenSanziman = st.SanzimanTuruId;
            try
            {
                var sonuc = db.Araclar.Select(x => new
                {
                    secilenMarka = x.Marka.MarkaNo,
                    x.Marka.AracMarka,
                    x.Model,
                    secilenYakit = x.YakitTuru.YakitTuruId,
                    x.YakitTuru.YakitAdi,
                    secilenSanziman = x.SanzimanTuru.SanzimanTuruId,
                    x.SanzimanTuru.SanzimanAdi,
                    fiyat = x.GunlukFiyat,
                    x.KiradaMi,
                    yil = x.ModelYili
                }).Where(x => (int)cbMarkayaGore.SelectedValue == x.secilenMarka && (int)cbYakitTuruneGore.SelectedValue == x.secilenYakit && (int)cbSanzimanTuruneGore.SelectedValue == x.secilenSanziman && x.KiradaMi == false).ToList();
                dgvAraclar.DataSource = sonuc;
                dgvAraclar.Columns[0].Visible = false;
                dgvAraclar.Columns[3].Visible = false;
                dgvAraclar.Columns[5].Visible = false;
                dgvAraclar.Columns[8].Visible = false;
            }
            catch
            {
            }
        }

        private void cbYakitTuruneGore_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aracmarka = Convert.ToString(cbMarkayaGore.SelectedValue);
            //aracmodel = txtModeleGore.Text;
            //aracyil = txtYilaGore.Text;
            //sanzimanturu = Convert.ToString(cbSanzimanTuruneGore.SelectedValue);
            //yakitturu = Convert.ToString(cbYakitTuruneGore.SelectedValue);
            //fiyat = txtYilaGore.Text;
            //aracBul(aracmarka, aracmodel, aracyil, sanzimanturu, yakitturu, fiyat);
            //if (string.IsNullOrEmpty(txtModeleGore.Text) && string.IsNullOrEmpty(txtYilaGore.Text) && string.IsNullOrEmpty(txtFiyataGore.Text))
            //{
            //    AraclariGetir();
            //}
        }

        private void YakitTuruGetir()
        {
            var sonuc = db.YakitTuru.Select(x => new
            {
                x.YakitTuruId,
                x.YakitAdi
            }).ToList();
            cbYakitTuruneGore.ValueMember = "YakitTuruId";
            cbYakitTuruneGore.DisplayMember = "YakitAdi";
            cbYakitTuruneGore.DataSource = sonuc;
        }
        private void SanzimanTuruGetir()
        {
            var sonuc = db.SanzimanTuru.Select(x => new
            {
                x.SanzimanTuruId,
                x.SanzimanAdi
            }).ToList();
            cbSanzimanTuruneGore.ValueMember = "SanzimanTuruId";
            cbSanzimanTuruneGore.DisplayMember = "SanzimanAdi";
            cbSanzimanTuruneGore.DataSource = sonuc;
        }
        private void AraclariGetir()
        {
            var sonuc = db.Araclar.Select(x => new
            {
                Id = x.AracId,
                x.Marka.AracMarka,
                x.Model,
                x.ModelYili,
                x.YakitTuru.YakitAdi,
                x.SanzimanTuru.SanzimanAdi,
                x.GunlukFiyat,
            }).ToList();
            dgvAraclar.DataSource = sonuc;
            dgvAraclar.Columns[0].Width = 30;
        }
        private void aracBul(string model, string yil, string fiyat)
        {
            yil = "1";
            fiyat = "1";
            int aracyili = Convert.ToInt32(yil);
            int aracfiyati = Convert.ToInt32(fiyat);
            var sonuc = db.Araclar.Where(x => x.Model.Contains(model)).ToList();
            dgvAraclar.DataSource = sonuc;
        }
    }
}
