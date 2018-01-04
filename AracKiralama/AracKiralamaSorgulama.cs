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
    public partial class AracKiralamaSorgulama : Form
    {
        public AracKiralamaSorgulama()
        {
            InitializeComponent();
        }
        ProjectDB db = new ProjectDB();
        private void AracKiralamaSorgulama_Load(object sender, EventArgs e)
        {
            FaturaGetir();
        }
        private void FaturaGetir()
        {
            var sonuc = db.Satis.Select(x => new
            {
                x.FaturaId,
                MusteriAdiSoyadi = x.Musteriler.MusteriAd + x.Musteriler.MusteriSoyad,
                AracMarka = x.Araclar.Marka.AracMarka,
                AracModeli = x.Araclar.Model,
                x.AlisTarihi,
                x.TeslimTarihi,
                x.Araclar.GunlukFiyat,
                x.KiralikGunTutari,
                x.ToplamTutar
            }).ToList();
            dgvFatura.DataSource = sonuc;
        }
    }
}
