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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        DbUrunEntities db = new DbUrunEntities();

        void UrunListesi()
        {
            var urunler = from x in db.TblUrunlers
                          select new
                          {
                              x.UrunId,
                              x.UrunAd,
                              x.Stok,
                              x.AlisFiyat,
                              x.SatisFiyat,
                              x.TblKategori.Ad,

                          };
            dataGridView1.DataSource = urunler.ToList();
        }
        void temizle()
        {
            Txt_AlisFiyat.Text = "";
            Txt_ID.Text = "";
            Txt_SatisFiyat.Text = "";
            Txt_Stok.Text = "";
            TxtAd.Text = "";
        }
        private void BtnListele_Click(object sender, EventArgs e)
        {

            //dataGridView1.DataSource = db.TblUrunlers.ToList();
            UrunListesi();
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            UrunListesi();
            comboBox1.DataSource = db.TblKategoris.ToList();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Ad";

        }

        private void BtkKaydet_Click(object sender, EventArgs e)
        {
            TblUrunler t = new TblUrunler();
            
            t.UrunAd = TxtAd.Text;
            t.Stok =  short.Parse(Txt_Stok.Text);
            t.AlisFiyat = decimal.Parse(Txt_AlisFiyat.Text);
            t.SatisFiyat = decimal.Parse(Txt_SatisFiyat.Text);
            t.Kategori = int.Parse(comboBox1.SelectedValue.ToString());
            db.TblUrunlers.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün başarılı bir şekilde sisteme kaydedildi.");
            UrunListesi();
            temizle();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Txt_Stok.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Txt_AlisFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Txt_SatisFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            //comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Txt_ID.Text != "")
            {
                int id = int.Parse(Txt_ID.Text);
                var x = db.TblUrunlers.Find(id);
                db.TblUrunlers.Remove(x);
                db.SaveChanges();
                MessageBox.Show("Ürün başarılı bir şekilde silindi", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                MessageBox.Show("Lütfen verileri listeledikten sonra bir satıra tıklayıp silmek istediğiniz kaydı seçiniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UrunListesi();
            temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Txt_ID.Text);
            var x = db.TblUrunlers.Find(id);
            x.UrunAd = TxtUrun.Text;
            x.Stok = short.Parse(Txt_Stok.Text);
            x.AlisFiyat = decimal.Parse(Txt_AlisFiyat.Text);
            x.SatisFiyat = decimal.Parse(Txt_SatisFiyat.Text);
            x.Kategori = int.Parse(comboBox1.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Verileriniz başarılı bir şekilde güncellendi", "Güncellem Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunListesi();

        }
    }
}
