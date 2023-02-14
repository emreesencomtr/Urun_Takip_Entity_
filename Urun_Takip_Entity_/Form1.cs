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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbUrunEntities db = new DbUrunEntities();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = db.TblMusterilers.ToList();
            var degerler = from x in db.TblMusterilers
                           select new
                           {
                               x.MusteriID,
                               x.Ad,
                               x.Soyad,
                               x.Sehir,
                               x.Bakiye,

                           };
            dataGridView1.DataSource = degerler.ToList();
        }

        private void BtkKaydet_Click(object sender, EventArgs e)
        {
            TblMusteriler t = new TblMusteriler();
            t.Ad = Txt_Ad.Text;
            t.Soyad = Txt_Soyad.Text;
            t.Sehir = Txt_Sehir.Text;
            t.Bakiye = decimal.Parse(Txt_Bakiye.Text);
            db.TblMusterilers.Add(t);
            db.SaveChanges();
            MessageBox.Show("Yeni bir müşteri kaydı yapıldı!");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var x = db.TblMusterilers.Find(id);
            db.TblMusterilers.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Müşteri sistemden silindi!");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var x = db.TblMusterilers.Find(id);
            x.Ad = Txt_Ad.Text;
            x.Soyad = Txt_Soyad.Text;
            x.Sehir = Txt_Sehir.Text;
            x.Bakiye = decimal.Parse(Txt_Bakiye.Text);
            db.SaveChanges();
            MessageBox.Show("Müşteri bilgisi güncellendi!");
        }
    }
}
