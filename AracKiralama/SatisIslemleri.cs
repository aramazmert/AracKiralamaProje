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
    public partial class SatisIslemleri : Form
    {
        public SatisIslemleri()
        {
            InitializeComponent();
        }
        ProjectDB db = new ProjectDB();
        string mtc;
        int kacGun = 0;
        int id, aracId;
        int alisTarihi, teslimTarihi;
        decimal tfiyat, gfiyat;
        private void SatisIslemleri_Load(object sender, EventArgs e)
        {
            MarkaGetir();
            YakitTuruGetir();
            SanzimanTuruGetir();
            btnKirala.Visible = false;
            alisTarihi = dtpAlisTarihi.Value.Day;
            btnKirala.Visible = false;
            btnAracKirala.Visible = false;
        }
        private void MarkaGetir()
        {
            var sonuc = db.Marka.Select(x => new
            {
                x.MarkaNo,
                x.AracMarka
            }).ToList();
            cbMarkalar.ValueMember = "MarkaNo";
            cbMarkalar.DisplayMember = "AracMarka";
            cbMarkalar.DataSource = sonuc;
        }
        private void YakitTuruGetir()
        {
            var sonuc = db.YakitTuru.Select(x => new
            {
                x.YakitTuruId,
                x.YakitAdi
            }).ToList();
            cbYakitTuru.ValueMember = "YakitTuruId";
            cbYakitTuru.DisplayMember = "YakitAdi";
            cbYakitTuru.DataSource = sonuc;
        }
        private void SanzimanTuruGetir()
        {
            var sonuc = db.SanzimanTuru.Select(x => new
            {
                x.SanzimanTuruId,
                x.SanzimanAdi
            }).ToList();
            cbSanzimanTuru.ValueMember = "SanzimanTuruId";
            cbSanzimanTuru.DisplayMember = "SanzimanAdi";
            cbSanzimanTuru.DataSource = sonuc;
        }

        private void btnAraclariGoster_Click(object sender, EventArgs e)
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
                    x.GunlukFiyat,
                    x.KiradaMi
                }).Where(x => (int)cbMarkalar.SelectedValue == x.secilenMarka && (int)cbYakitTuru.SelectedValue == x.secilenYakit && (int)cbSanzimanTuru.SelectedValue == x.secilenSanziman && x.KiradaMi == false).ToList();
                dgvAraclar.DataSource = sonuc;
                dgvAraclar.Columns[0].Visible = false;
                dgvAraclar.Columns[3].Visible = false;
                dgvAraclar.Columns[5].Visible = false;
                dgvAraclar.Columns[8].Visible = false;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
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

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            mtc = txtMusteriTc.Text;
            if (string.IsNullOrEmpty(txtMusteriTc.Text))
            {
                MessageBox.Show("Lütfen Müşteri TC Kimlik Numarası'nı Giriniz!", "Eksik Bilgi!");
            }
            else
            {
                id = db.Musteriler.FirstOrDefault(x => x.MusteriTC == mtc).MusteriId;
                txtMusteriAd.Text = MusteriAdiBul(id);
                txtMusteriSoyad.Text = MusteriSoyadiBul(id);
                txtDogumTarihi.Text = MusteriDogumTarihiBul(id);
                txtEhliyetTarihi.Text = MusteriehliyetTarihiBul(id);
                txtMusteriTelefon.Text = MusteriTelefonuBul(id);
                txtMusteriAdres.Text = MusteriAdresiBul(id);
            }
        }
        private string MusteriAdiBul(int mid)
        {
            var sonuc = db.Musteriler.Find(mid).MusteriAd;
            return Convert.ToString(sonuc);
        }
        private string MusteriSoyadiBul(int mid)
        {
            var sonuc = db.Musteriler.Find(mid).MusteriSoyad;
            return Convert.ToString(sonuc);
        }
        private string MusteriAdresiBul(int mid)
        {
            var sonuc = db.Musteriler.Find(mid).MusteriAdres;
            return Convert.ToString(sonuc);
        }
        private string MusteriTelefonuBul(int mid)
        {
            var sonuc = db.Musteriler.Find(mid).MusteriTelefon;
            return Convert.ToString(sonuc);
        }
        private string MusteriDogumTarihiBul(int mid)
        {
            var sonuc = db.Musteriler.Find(mid).MusteriDogumTarihi;
            return Convert.ToString(sonuc);
        }
        private string MusteriehliyetTarihiBul(int mid)
        {
            var sonuc = db.Musteriler.Find(mid).EhliyetTarihi;
            return Convert.ToString(sonuc);
        }

        private void dgvAraclar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtAracMarka.Text = dgvAraclar.SelectedRows[0].Cells[1].Value.ToString();
            txtAracModel.Text = dgvAraclar.SelectedRows[0].Cells[2].Value.ToString();
            txtAracSanziman.Text = dgvAraclar.SelectedRows[0].Cells[6].Value.ToString();
            txtAracYakit.Text = dgvAraclar.SelectedRows[0].Cells[4].Value.ToString();
            txtGunlukFiyat.Text = dgvAraclar.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void dtpTeslimTarihi_ValueChanged(object sender, EventArgs e)
        {
            teslimTarihi = dtpTeslimTarihi.Value.Day;
            if (teslimTarihi < alisTarihi)
            {
                MessageBox.Show("Teslim Tarihi Alış Tarihinden Önce Olamaz!", "Hata!");
            }
            else
            {
                kacGun = dtpTeslimTarihi.Value.Day - dtpAlisTarihi.Value.Day;
                gfiyat = Convert.ToDecimal(txtGunlukFiyat.Text);
                gfiyat = kacGun * gfiyat;
                txtGunlukFiyat.Text = gfiyat.ToString();
            }
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            btnAracKirala.Visible = true;
            int secilenAracId = Convert.ToInt32(dgvAraclar.SelectedRows[0].Cells[0].Value);
            id = db.Musteriler.FirstOrDefault(x => x.MusteriTC == mtc).MusteriId;
            int markaid, yakitid, sanzimanid;
            markaid = 0;
            yakitid = 0;
            sanzimanid = 0;
            DoldurMarka(markaid);
            DoldurYakit(yakitid);
            DoldurSanziman(sanzimanid);
            Satis s = new Satis();
            s.MusteriId = id;
            s.AracId = Convert.ToInt32(cbMarkalar.SelectedValue);
            s.AlisTarihi = dtpAlisTarihi.Value;
            s.TeslimTarihi = dtpTeslimTarihi.Value;
            s.KiralikGunTutari = gfiyat;
            s.ToplamTutar = tfiyat;
            db.Satis.Add(s);
            try
            {
                db.SaveChanges();
                DoldurMarka((int)cbMarkalar.SelectedValue);
                DoldurSanziman((int)cbSanzimanTuru.SelectedValue);
                DoldurYakit((int)cbYakitTuru.SelectedValue);
                MessageBox.Show("Kayıt Eklendi!", "Kayıt Başarılı!");
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            btnKirala.Visible = true;
            gfiyat = Convert.ToDecimal(txtGunlukFiyat.Text);
            if (dtpAlisTarihi.Value > dtpTeslimTarihi.Value)
            {
                MessageBox.Show("Alış Tarihi Teslim Tarihinden Büyük Olamaz!", "Hata!");
            }
            else if (dtpAlisTarihi.Value == dtpTeslimTarihi.Value)
            {
                MessageBox.Show("Araçlar En Az 1 Günlük Kiralanabilir !", "Hata!");
            }
            else
            {

            }
        }

        private void dtpAlisTarihi_ValueChanged(object sender, EventArgs e)
        {
            alisTarihi = dtpAlisTarihi.Value.Day;
        }
        private void DoldurSanziman(int sanzimanid)
        {
            if (cbSanzimanTuru.SelectedValue != null)
            {
                sanzimanid = (int)cbSanzimanTuru.SelectedValue;
            }
        }

        private void cbMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DoldurMarka((int)cbMarkalar.SelectedValue);
            }
            catch (Exception)
            {

            }
        }

        private void cbSanzimanTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DoldurSanziman((int)cbSanzimanTuru.SelectedValue);
            }
            catch (Exception)
            {

            }
        }

        private void cbYakitTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DoldurYakit((int)cbYakitTuru.SelectedValue);
            }
            catch (Exception)
            {

            }
        }

        private void btnAracKirala_Click(object sender, EventArgs e)
        {
            int secilenAracId = Convert.ToInt32(dgvAraclar.SelectedRows[0].Cells[0].Value);
            Araclar a = new Araclar();
            aracId = db.Satis.FirstOrDefault(x => x.AracId == secilenAracId).AracId;
            a = db.Araclar.Where(x => x.AracId == aracId).SingleOrDefault();
            a.KiradaMi = true;
            try
            {
                db.SaveChanges();
                MessageBox.Show("Araç Kiralandı!", "Araç Kullanımda!");
                Temizle();
                btnKirala.Visible = false;
                btnAracKirala.Visible = false;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }

        }

        private void DoldurYakit(int yakitid)
        {
            if (cbYakitTuru.SelectedValue != null)
            {
                yakitid = (int)cbYakitTuru.SelectedValue;
            }
        }
        private void DoldurMarka(int markaid)
        {
            if (cbMarkalar.SelectedValue != null)
            {
                markaid = (int)cbMarkalar.SelectedValue;
            }
        }
        private void Temizle()
        {
            txtAracMarka.Clear();
            txtAracModel.Clear();
            txtAracSanziman.Clear();
            txtAracYakit.Clear();
            txtDogumTarihi.Clear();
            txtEhliyetTarihi.Clear();
            txtGunlukFiyat.Clear();
            txtMusteriAd.Clear();
            txtMusteriAdres.Clear();
            txtMusteriSoyad.Clear();
            txtMusteriTc.Clear();
            txtMusteriTelefon.Clear();
            dtpAlisTarihi.Value = DateTime.Now;
            dtpTeslimTarihi.Value = DateTime.Now;
            dgvAraclar.DataSource = null;
        }
    }
}
