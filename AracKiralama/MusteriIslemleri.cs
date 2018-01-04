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
    public partial class MusteriIslemleri : Form
    {
        public MusteriIslemleri()
        {
            InitializeComponent();
        }
        ProjectDB db = new ProjectDB();
        int musteriId;
        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {
            btnEkle.Visible = false;
            btnSil.Visible = false;
            btnDegistir.Visible = false;
            txtMusteriAdi.ReadOnly = true;
            txtMusteriSoyadi.ReadOnly = true;
            txtMusteriAdresi.ReadOnly = true;
            txtMusteriTelefonu.ReadOnly = true;
            txtMusteriTc.ReadOnly = true;
            dtpDogumTarihi.Enabled = false;
            dtpEhliyetTarihi.Enabled = false;
            MusterileriGetir();
        }
        private void MusterileriGetir()
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

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
            btnDegistir.Visible = false;
            btnEkle.Visible = true;
            btnSil.Visible = true;
            btnYeni.Visible = false;
        }
        private void Temizle()
        {
            txtMusteriAdi.ReadOnly = false;
            txtMusteriAdi.Clear();
            txtMusteriSoyadi.ReadOnly = false;
            txtMusteriSoyadi.Clear();
            txtMusteriAdresi.ReadOnly = false;
            txtMusteriAdresi.Clear();
            txtMusteriTelefonu.ReadOnly = false;
            txtMusteriTelefonu.Clear();
            txtMusteriTc.ReadOnly = false;
            txtMusteriTc.Clear();
            dtpDogumTarihi.Enabled = true;
            dtpEhliyetTarihi.Enabled = true;
            txtMusteriAdi.Focus();
        }
        private void TemizleIslemSonrasi()
        {
            txtMusteriAdi.ReadOnly = true;
            txtMusteriAdi.Clear();
            txtMusteriSoyadi.ReadOnly = true;
            txtMusteriSoyadi.Clear();
            txtMusteriAdresi.ReadOnly = true;
            txtMusteriAdresi.Clear();
            txtMusteriTelefonu.ReadOnly = true;
            txtMusteriTelefonu.Clear();
            txtMusteriTc.ReadOnly = true;
            txtMusteriTc.Clear();
            dtpDogumTarihi.Value = DateTime.Today;            
            dtpDogumTarihi.Enabled = false;
            dtpEhliyetTarihi.Value = DateTime.Today;
            dtpEhliyetTarihi.Enabled = false;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            btnYeni.Visible = false;
            if(string.IsNullOrEmpty(txtMusteriAdi.Text) || string.IsNullOrEmpty(txtMusteriSoyadi.Text) || string.IsNullOrEmpty(txtMusteriAdresi.Text) ||string.IsNullOrEmpty(txtMusteriTelefonu.Text) || string.IsNullOrEmpty(txtMusteriTc.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Eksik Bilgi!");
            }
            else
            {
                bool varmi = MusteriVarMi(txtMusteriTc.Text);
                if(varmi)
                {
                    MessageBox.Show("Bu Müşteri Daha Önceden Kayıtlıdır!", "Yeniden Kayıt Yapılamaz!");
                }
                else
                {
                    Musteriler musteri = new Musteriler();
                    musteri.MusteriAd = txtMusteriAdi.Text;
                    musteri.MusteriSoyad = txtMusteriSoyadi.Text;
                    musteri.MusteriAdres = txtMusteriAdresi.Text;
                    musteri.MusteriTelefon = txtMusteriTelefonu.Text;
                    musteri.MusteriTC = txtMusteriTc.Text;
                    musteri.MusteriDogumTarihi = dtpDogumTarihi.Value;
                    musteri.EhliyetTarihi = dtpEhliyetTarihi.Value;
                    db.Musteriler.Add(musteri);
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Müşteri Kaydı Oluşturuldu!", "Yeni Kayıt Oluşturuldu!");
                        btnDegistir.Visible = false;
                        btnSil.Visible = false;
                        btnEkle.Visible = false;
                        btnYeni.Visible = true;
                        TemizleIslemSonrasi();
                        MusterileriGetir();

                    }
                    catch (Exception ex)
                    {

                        string hata = ex.Message;
                    }
                }
            }
        }
        private bool MusteriVarMi(string musteriTc)
        {
            bool musteri = db.Musteriler.Any(x => x.MusteriTC == musteriTc);
            if (musteri)
                return true;
            else
                return false;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            btnYeni.Visible = false;
            if(string.IsNullOrEmpty(txtMusteriAdi.Text) || string.IsNullOrEmpty(txtMusteriSoyadi.Text) || string.IsNullOrEmpty(txtMusteriAdresi.Text) || string.IsNullOrEmpty(txtMusteriTelefonu.Text) || string.IsNullOrEmpty(txtMusteriTc.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Eksik Bilgi!");
            }
            else
            {
                bool telvarmi = TelefonKontrolUpdate(txtMusteriTelefonu.Text);
                if (telvarmi)
                {
                    MessageBox.Show("Bu Telefon Numarası Zaten Var!", "Hatalı Giriş!");
                }
                else
                {
                    Musteriler musteri = db.Musteriler.Where(x => x.MusteriId == musteriId).SingleOrDefault();
                    musteri.MusteriTelefon = txtMusteriTelefonu.Text;
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Telefon Numarası Güncellendi!", "Güncelleme Başarılı!");
                        btnDegistir.Visible = false;
                        btnSil.Visible = false;
                        btnEkle.Visible = false;
                        btnYeni.Visible = true;
                        TemizleIslemSonrasi();
                        MusterileriGetir();
                    }
                    catch (Exception ex)
                    {

                        string hata = ex.Message;
                    }
                }
            }
        }
        private bool TelefonKontrolUpdate(string telno)
        {
            Musteriler telvarmi = db.Musteriler.Where(x => x.MusteriTelefon == telno).SingleOrDefault();
            return Convert.ToBoolean(telvarmi);
        }
        private void dgvMusteriler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            musteriId = Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells[0].Value);
            txtMusteriAdi.Text = dgvMusteriler.SelectedRows[0].Cells[1].Value.ToString();
            txtMusteriSoyadi.Text = dgvMusteriler.SelectedRows[0].Cells[2].Value.ToString();
            txtMusteriTelefonu.Text = dgvMusteriler.SelectedRows[0].Cells[4].Value.ToString();
            txtMusteriAdresi.Text = dgvMusteriler.SelectedRows[0].Cells[3].Value.ToString();
            txtMusteriTc.Text = dgvMusteriler.SelectedRows[0].Cells[5].Value.ToString();
            dtpDogumTarihi.Value = Convert.ToDateTime(dgvMusteriler.SelectedRows[0].Cells[6].Value);
            dtpEhliyetTarihi.Value = Convert.ToDateTime(dgvMusteriler.SelectedRows[0].Cells[7].Value);
            btnEkle.Visible = false;
            btnYeni.Visible = false;
            btnSil.Visible = true;
            btnDegistir.Visible = true;
            txtMusteriTelefonu.ReadOnly = false;
            txtMusteriTelefonu.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kayıt Silinsin Mi?","Silinsin Mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Musteriler musteri = (Musteriler)db.Musteriler.Where(x => x.MusteriId == musteriId).FirstOrDefault();
                try
                {
                    db.Musteriler.Remove(musteri);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt Silme İşlemi Başarılı!", "Kayıt Silindi!");
                    btnDegistir.Visible = false;
                    btnSil.Visible = false;
                    btnEkle.Visible = false;
                    btnYeni.Visible = true;
                    TemizleIslemSonrasi();
                    MusterileriGetir();
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                }
            }
        }
    }
}
