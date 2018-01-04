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
    public partial class AracEkle : Form
    {
        public AracEkle()
        {
            InitializeComponent();
        }
        ProjectDB db = new ProjectDB();
        Araclar a = new Araclar();
        Marka m = new Marka();
        YakitTuru yt = new YakitTuru();
        SanzimanTuru st = new SanzimanTuru();
        int aracid;
        decimal gunlukfiyat;
        private void AracEkle_Load(object sender, EventArgs e)
        {
            MarkaGetir();
            YakitTuruGetir();
            SanzimanTuruGetir();
            AraclariGetir();
            btnEkle.Visible = false;
            btnSil.Visible = false;
            btnDegistir.Visible = false;
            cbMarkalar.Enabled = false;
            txtModelAdi.ReadOnly = true;
            txtModelYili.ReadOnly = true;
            txtGunlukFiyat.ReadOnly = true;
            cbSanzimanTuru.Enabled = false;
            cbYakitTuru.Enabled = false;
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
        private void Temizle()
        {
            txtModelAdi.ReadOnly = false;
            txtModelAdi.Clear();
            txtGunlukFiyat.ReadOnly = false;
            txtGunlukFiyat.Clear();
            txtModelYili.ReadOnly = false;
            txtModelYili.Clear();
            cbMarkalar.Enabled = true;
            cbSanzimanTuru.Enabled = true;
            cbYakitTuru.Enabled = true;
            txtModelAdi.Focus();

        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
            btnDegistir.Visible = false;
            btnEkle.Visible = true;
            btnSil.Visible = true;
            btnYeni.Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int markaid, yakitid, sanzimanid;
            markaid = 0;
            yakitid = 0;
            sanzimanid = 0;
            DoldurMarka(markaid);
            DoldurYakit(yakitid);
            DoldurSanziman(sanzimanid);
            btnYeni.Visible = false;
            if (string.IsNullOrEmpty(txtModelAdi.Text) || string.IsNullOrEmpty(txtModelYili.Text) || string.IsNullOrEmpty(txtGunlukFiyat.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Eksik Bilgi!");
            }
            else
            {
                bool varmi = ModelVarMi(aracid);
                if(varmi)
                {
                    MessageBox.Show("Bu Model Zaten Var!", "Daha Önce Kayıtlı!");
                }
                else
                {
                    Araclar arac = new Araclar();
                    arac.MarkaNo = Convert.ToInt32(cbMarkalar.SelectedValue);
                    arac.Model = txtModelAdi.Text;
                    arac.ModelYili = Convert.ToInt32(txtModelYili.Text);
                    arac.YakitTuruId = Convert.ToInt32(cbYakitTuru.SelectedValue);
                    arac.SanzimanTuruId = Convert.ToInt32(cbSanzimanTuru.SelectedValue);
                    arac.GunlukFiyat = Convert.ToDecimal(txtGunlukFiyat.Text);
                    db.Araclar.Add(arac);
                    try
                    {
                        db.SaveChanges();
                        DoldurMarka((int)cbMarkalar.SelectedValue);
                        DoldurSanziman((int)cbSanzimanTuru.SelectedValue);
                        DoldurYakit((int)cbYakitTuru.SelectedValue);
                        MessageBox.Show("Yeni Araç Kaydedildi!", "Kayıt Başarılı!");
                        TemizleIslemSonrasi();
                        AraclariGetir();
                        btnDegistir.Visible = false;
                        btnSil.Visible = false;
                        btnEkle.Visible = false;
                        btnYeni.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        string hata = ex.Message;
                    }
                }
            }
        }
        private bool ModelVarMi(int aracid)
        {
            bool model = db.Araclar.Any(x => x.AracId == aracid);
            if (model)
                return true;
            else
                return false;
        }
        private void TemizleIslemSonrasi()
        {
            cbMarkalar.Enabled = false;
            cbMarkalar.Text = "";
            txtModelAdi.ReadOnly = true;
            txtModelAdi.Clear();
            txtModelYili.ReadOnly = true;
            txtModelYili.Clear();
            txtGunlukFiyat.ReadOnly = true;
            txtGunlukFiyat.Clear();
            cbSanzimanTuru.Text = "";
            cbSanzimanTuru.Enabled = false;
            cbYakitTuru.Text = "";
            cbYakitTuru.Enabled = false;
        }
        private void DoldurMarka(int markaid)
        {
            if (cbMarkalar.SelectedValue != null)
            {
                markaid = (int)cbMarkalar.SelectedValue;
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
        private void DoldurYakit(int yakitid)
        {
            if (cbYakitTuru.SelectedValue != null)
            {
                yakitid = (int)cbYakitTuru.SelectedValue;
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
        private void DoldurSanziman(int sanzimanid)
        {
            if (cbSanzimanTuru.SelectedValue != null)
            {
                sanzimanid = (int)cbSanzimanTuru.SelectedValue;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Araç Silinsin Mi?","Kayıt Silinecek!",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Araclar arac = (Araclar)db.Araclar.Where(x => x.AracId == aracid).FirstOrDefault();
                try
                {
                    db.Araclar.Remove(arac);
                    db.SaveChanges();
                    MessageBox.Show("Araç Silindi!", "Silme İşlemi Başarılı!");
                    btnDegistir.Visible = false;
                    btnSil.Visible = false;
                    btnEkle.Visible = false;
                    btnYeni.Visible = true;
                    TemizleIslemSonrasi();
                    AraclariGetir();
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                }
            }
        }

        private void dgvAraclar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            aracid = (int)dgvAraclar.SelectedRows[0].Cells[0].Value;
            m = db.Marka.Find(aracid);
            cbMarkalar.SelectedValue = m.MarkaNo;
            txtModelAdi.Text = dgvAraclar.SelectedRows[0].Cells[2].Value.ToString();
            txtModelYili.Text = dgvAraclar.SelectedRows[0].Cells[3].Value.ToString();
            yt = db.YakitTuru.Find(YakitTuruIdYakala());
            cbYakitTuru.SelectedValue = yt.YakitTuruId;
            st = db.SanzimanTuru.Find(SanzimanTuruIdYakala());
            cbSanzimanTuru.SelectedValue = st.SanzimanTuruId;
            txtGunlukFiyat.Text = dgvAraclar.SelectedRows[0].Cells[6].Value.ToString();
            gunlukfiyat = Convert.ToDecimal(dgvAraclar.SelectedRows[0].Cells[6].Value);
            btnEkle.Visible = false;
            btnYeni.Visible = false;
            btnSil.Visible = true;
            btnDegistir.Visible = true;
            txtGunlukFiyat.ReadOnly = false;
            txtModelAdi.Focus();
        }

        private void txtGunlukFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber((char)e.KeyChar) || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber((char)e.KeyChar) || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            btnYeni.Visible = false;
            txtGunlukFiyat.ReadOnly = false;
            if (string.IsNullOrEmpty(txtGunlukFiyat.Text))
            {
                MessageBox.Show("Lütfen Günlük Fiyat Alanını Doldurunuz!", "Eksik Bilgi!");
            }
            else
            {
                Araclar a = db.Araclar.Where(x => x.GunlukFiyat == gunlukfiyat).SingleOrDefault();
                a.GunlukFiyat = Convert.ToDecimal(txtGunlukFiyat.Text);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Araç Günlük Fiyatı Güncellendi!", "Güncelleme Başarılı!");
                    btnDegistir.Visible = false;
                    btnSil.Visible = false;
                    btnEkle.Visible = false;
                    btnYeni.Visible = true;
                    TemizleIslemSonrasi();
                    AraclariGetir();
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                }
            }
        }

        private int YakitTuruIdYakala()
        {
            int ytid;
            if (dgvAraclar.SelectedRows[0].Cells[4].Value.ToString() == "Dizel")
            {
                ytid = 1;
            }
            else
            {
                ytid = 2;
            }
            return ytid;
        }

        private int SanzimanTuruIdYakala()
        {
            int stid;
            if (dgvAraclar.SelectedRows[0].Cells[5].Value.ToString() == "Otomatik")
            {
                stid = 1;
            }
            else
            {
                stid = 2;
            }
            return stid;
        }
    }
}

