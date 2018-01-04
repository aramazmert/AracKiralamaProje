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
    public partial class AracTeslimAlma : Form
    {
        public AracTeslimAlma()
        {
            InitializeComponent();
        }
        ProjectDB db = new ProjectDB();
        DateTime tarih;
        int secilenAracId, aracId;
        private void AracTeslimAlma_Load(object sender, EventArgs e)
        {
            btnTeslimAl.Visible = false;
            tarih = dtpTeslimTarihi.Value.Date;
        }
        private void araclariGetir()
        {
            var sonuc = db.Araclar.Where(x => x.KiradaMi == true).Select(x => new
            {
                x.AracId,
                x.Marka.AracMarka,
                x.Model,
                x.YakitTuru.YakitAdi,
                x.SanzimanTuru.SanzimanAdi              
            }).ToList();
            dgvAraclar.DataSource = sonuc;
            dgvAraclar.Columns[0].Visible = false;
        }

        private void dgvAraclar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenAracId = Convert.ToInt32(dgvAraclar.SelectedRows[0].Cells[0].Value);
            txtAracMarka.Text = dgvAraclar.SelectedRows[0].Cells[1].Value.ToString();
            txtAracModel.Text = dgvAraclar.SelectedRows[0].Cells[2].Value.ToString();
            txtAracYakit.Text = dgvAraclar.SelectedRows[0].Cells[3].Value.ToString();
            txtAracSanziman.Text = dgvAraclar.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            secilenAracId = Convert.ToInt32(dgvAraclar.SelectedRows[0].Cells[0].Value);
            Araclar a = new Araclar();
            aracId = db.Satis.FirstOrDefault(x => x.AracId == secilenAracId).AracId;
            a = db.Araclar.Where(x => x.AracId == aracId).SingleOrDefault();
            a.KiradaMi = false;
            try
            {
                db.SaveChanges();
                MessageBox.Show("Araç Teslim Alındı!", "Araç Boşta!");
                Temizle();
                btnTeslimAl.Visible = false;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
        }

        private void btnAracGetir_Click(object sender, EventArgs e)
        {
            araclariGetir();
            btnTeslimAl.Visible = true;
        }
        private void Temizle()
        {
            txtAracMarka.Clear();
            txtAracModel.Clear();
            txtAracSanziman.Clear();
            txtAracYakit.Clear();
            dgvAraclar.DataSource = "";
        }
    }
}
