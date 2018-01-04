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
    public partial class MarkaEkle : Form
    {
        public MarkaEkle()
        {
            InitializeComponent();
        }
        ProjectDB db = new ProjectDB();
        int aracId;
        string aciklama;
        private void MarkaEkle_Load(object sender, EventArgs e)
        {
            MarkaGetir();
            btnEkle.Visible = false;
            btnSil.Visible = false;
            btnDegistir.Visible = false;
            txtAracMarka.ReadOnly = true;
            txtMarkaAciklama.ReadOnly = true;
        }
        private void MarkaGetir()
        {
            var sonuc = db.Marka.Select(x => new
            {
                Id = x.MarkaNo,
                x.AracMarka,
                x.Aciklama
            }).ToList();
            dgvMarkalar.DataSource = sonuc;
            dgvMarkalar.Columns[0].Width = 30;
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
            txtAracMarka.ReadOnly = false;
            txtAracMarka.Clear();
            txtMarkaAciklama.ReadOnly = false;
            txtMarkaAciklama.Clear();
            txtAracMarka.Focus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            btnYeni.Visible = false;
            if(string.IsNullOrEmpty(txtAracMarka.Text) || string.IsNullOrEmpty(txtMarkaAciklama.Text))
            {
                MessageBox.Show("Lütfen Bütün Alanları Giriniz!", "Eksik Bilgi!");
            }
            else
            {
                bool varmi = MarkaVarMi(txtAracMarka.Text);
                if(varmi)
                {
                    MessageBox.Show("Bu Marka Zaten Var!", "Daha Önce Kayıtlı!");
                }
                else
                {
                    Marka marka = new Marka();
                    marka.AracMarka = txtAracMarka.Text;
                    marka.Aciklama = txtMarkaAciklama.Text;
                    db.Marka.Add(marka);
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Araç Markası Kaydedildi!", "Kayıt Başarılı!");
                        btnDegistir.Visible = false;
                        btnSil.Visible = false;
                        btnEkle.Visible = false;
                        btnYeni.Visible = true;
                        TemizleIslemSonrasi();
                        MarkaGetir();
                    }
                    catch (Exception ex)
                    {
                        string hata = ex.Message;
                    }
                }
            }
        }
        private bool MarkaVarMi(string aracmarkasi)
        {
            bool marka = db.Marka.Any(x => x.AracMarka == aracmarkasi);
            if (marka)
                return true;
            else
                return false;
        }
        private void TemizleIslemSonrasi()
        {
            txtAracMarka.ReadOnly = true;
            txtAracMarka.Clear();
            txtMarkaAciklama.ReadOnly = true;
            txtMarkaAciklama.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Kayıt Silinsin Mi?","Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Marka marka = (Marka)db.Marka.Where(x => x.MarkaNo == aracId).FirstOrDefault();
                try
                {
                    db.Marka.Remove(marka);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt Silme İşlemi Başarılı!", "Kayıt Silindi!");
                    btnDegistir.Visible = false;
                    btnSil.Visible = false;
                    btnEkle.Visible = false;
                    btnYeni.Visible = true;
                    TemizleIslemSonrasi();
                    MarkaGetir();
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                }
            }
        }

        private void dgvMarkalar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            aracId = Convert.ToInt32(dgvMarkalar.SelectedRows[0].Cells[0].Value);
            txtAracMarka.Text = dgvMarkalar.SelectedRows[0].Cells[1].Value.ToString();
            txtMarkaAciklama.Text = dgvMarkalar.SelectedRows[0].Cells[2].Value.ToString();
            aciklama = dgvMarkalar.SelectedRows[0].Cells[2].Value.ToString();
            btnEkle.Visible = false;
            btnYeni.Visible = false;
            btnSil.Visible = true;
            btnDegistir.Visible = true;
            txtMarkaAciklama.ReadOnly = false;
            txtMarkaAciklama.Focus();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            btnYeni.Visible = false;
            txtAracMarka.ReadOnly = true;
            txtMarkaAciklama.ReadOnly = false;
            txtMarkaAciklama.Focus();
            if(string.IsNullOrEmpty(txtMarkaAciklama.Text))
            {
                MessageBox.Show("Lütfen Marka Açıklaması Giriniz!", "Eksik Bilgi!");
            }
            else
            {
                bool aciklamavarmi = MarkaAciklamaKontrolByUpdate(txtMarkaAciklama.Text);
                if(aciklamavarmi)
                {
                    MessageBox.Show("Bu Marka Açıklaması Zaten Var!", "Daha Önce Kayıtlı!");
                }
                else
                {
                    Marka marka = db.Marka.Where(x => x.Aciklama == aciklama).SingleOrDefault();
                    marka.Aciklama = txtMarkaAciklama.Text;
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Marka Açıklaması Güncellendi!", "Güncelleme Başarılı!");
                        btnDegistir.Visible = false;
                        btnSil.Visible = false;
                        btnEkle.Visible = false;
                        btnYeni.Visible = true;
                        TemizleIslemSonrasi();
                        MarkaGetir();
                    }
                    catch (Exception ex)
                    {
                        string hata = ex.Message;
                    }
                }
            }
        }
        private bool MarkaAciklamaKontrolByUpdate(string aciklama)
        {
            Marka aciklamavarmi = db.Marka.Where(x => x.Aciklama == aciklama).SingleOrDefault();
            return Convert.ToBoolean(aciklamavarmi);
        }
    }
}
