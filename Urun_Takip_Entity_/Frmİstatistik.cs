using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urun_Takip_Entity_
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        DbUrunEntities db = new DbUrunEntities();

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            DateTime bugün = DateTime.Today;
            LblMüsteriSayisi.Text = db.TblMusterilers.Count().ToString();
            LblKategoriSayisi.Text = db.TblKategoris.Count().ToString();
            LblUrunSayisi.Text = db.TblUrunlers.Count().ToString();
            LblBeyazEsya.Text = db.TblUrunlers.Count(x=> x.Kategori==1).ToString();
            LblToplamStok.Text = db.TblUrunlers.Max(x => x.Stok).ToString();
            LblBugunSatisAdedi.Text = db.TblSatislars.Count(x => x.Tarih == bugün).ToString();
            LblKasaT.Text = db.TblSatislars.Sum(x => x.Toplam).ToString() + " ₺";
            LblBugunkuKasa.Text = db.TblSatislars.Where(x => x.Tarih == bugün).Sum(y => y.Toplam).ToString() + " ₺";
            LblEnYuksekFiyatliUrun.Text = (from x in db.TblUrunlers orderby x.SatisFiyat descending select x.UrunAd).FirstOrDefault();
            LblEnDusukFiyatliUrun.Text = (from x in db.TblUrunlers orderby x.SatisFiyat ascending select x.UrunAd).FirstOrDefault();
            LblEnFazlaStokluUrun.Text = (from x in db.TblUrunlers orderby x.Stok descending select x.UrunAd).FirstOrDefault();
            LblEnAzStokluUrun.Text = (from x in db.TblUrunlers orderby x.Stok ascending select x.UrunAd).FirstOrDefault();

        }

        private void LblEnAzStokluUrun_Click(object sender, EventArgs e)
        {

        }
    }
}
