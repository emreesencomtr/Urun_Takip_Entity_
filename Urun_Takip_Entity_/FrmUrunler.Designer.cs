
namespace Urun_Takip_Entity_
{
    partial class FrmUrunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtkKaydet = new System.Windows.Forms.Button();
            this.Txt_SatisFiyat = new System.Windows.Forms.TextBox();
            this.TxtSatisFiyat = new System.Windows.Forms.Label();
            this.Txt_AlisFiyat = new System.Windows.Forms.TextBox();
            this.TxtAlisFiyat = new System.Windows.Forms.Label();
            this.Txt_Stok = new System.Windows.Forms.TextBox();
            this.TxtStok = new System.Windows.Forms.Label();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.BtnListele = new System.Windows.Forms.Button();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtUrun = new System.Windows.Forms.Label();
            this.TxtKategori = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(779, 322);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(119, 24);
            this.BtnGuncelle.TabIndex = 29;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(779, 291);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(119, 25);
            this.BtnSil.TabIndex = 28;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtkKaydet
            // 
            this.BtkKaydet.Location = new System.Drawing.Point(779, 258);
            this.BtkKaydet.Name = "BtkKaydet";
            this.BtkKaydet.Size = new System.Drawing.Size(119, 27);
            this.BtkKaydet.TabIndex = 27;
            this.BtkKaydet.Text = "Kaydet";
            this.BtkKaydet.UseVisualStyleBackColor = true;
            this.BtkKaydet.Click += new System.EventHandler(this.BtkKaydet_Click);
            // 
            // Txt_SatisFiyat
            // 
            this.Txt_SatisFiyat.Location = new System.Drawing.Point(779, 142);
            this.Txt_SatisFiyat.Name = "Txt_SatisFiyat";
            this.Txt_SatisFiyat.Size = new System.Drawing.Size(138, 26);
            this.Txt_SatisFiyat.TabIndex = 5;
            // 
            // TxtSatisFiyat
            // 
            this.TxtSatisFiyat.AutoSize = true;
            this.TxtSatisFiyat.Location = new System.Drawing.Point(690, 145);
            this.TxtSatisFiyat.Name = "TxtSatisFiyat";
            this.TxtSatisFiyat.Size = new System.Drawing.Size(87, 20);
            this.TxtSatisFiyat.TabIndex = 25;
            this.TxtSatisFiyat.Text = "Satış Fiyat:";
            // 
            // Txt_AlisFiyat
            // 
            this.Txt_AlisFiyat.Location = new System.Drawing.Point(779, 113);
            this.Txt_AlisFiyat.Name = "Txt_AlisFiyat";
            this.Txt_AlisFiyat.Size = new System.Drawing.Size(138, 26);
            this.Txt_AlisFiyat.TabIndex = 4;
            // 
            // TxtAlisFiyat
            // 
            this.TxtAlisFiyat.AutoSize = true;
            this.TxtAlisFiyat.Location = new System.Drawing.Point(701, 113);
            this.TxtAlisFiyat.Name = "TxtAlisFiyat";
            this.TxtAlisFiyat.Size = new System.Drawing.Size(76, 20);
            this.TxtAlisFiyat.TabIndex = 23;
            this.TxtAlisFiyat.Text = "Alış Fiyat:";
            // 
            // Txt_Stok
            // 
            this.Txt_Stok.Location = new System.Drawing.Point(779, 78);
            this.Txt_Stok.Name = "Txt_Stok";
            this.Txt_Stok.Size = new System.Drawing.Size(138, 26);
            this.Txt_Stok.TabIndex = 3;
            // 
            // TxtStok
            // 
            this.TxtStok.AutoSize = true;
            this.TxtStok.Location = new System.Drawing.Point(735, 81);
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(42, 20);
            this.TxtStok.TabIndex = 21;
            this.TxtStok.Text = "Stok";
            // 
            // Txt_ID
            // 
            this.Txt_ID.Enabled = false;
            this.Txt_ID.Location = new System.Drawing.Point(779, 17);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(138, 26);
            this.Txt_ID.TabIndex = 1;
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(779, 228);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(119, 24);
            this.BtnListele.TabIndex = 18;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(779, 49);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(138, 26);
            this.TxtAd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(743, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 343);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TxtUrun
            // 
            this.TxtUrun.AutoSize = true;
            this.TxtUrun.Location = new System.Drawing.Point(729, 49);
            this.TxtUrun.Name = "TxtUrun";
            this.TxtUrun.Size = new System.Drawing.Size(48, 20);
            this.TxtUrun.TabIndex = 19;
            this.TxtUrun.Text = "Ürün:";
            // 
            // TxtKategori
            // 
            this.TxtKategori.AutoSize = true;
            this.TxtKategori.Location = new System.Drawing.Point(705, 177);
            this.TxtKategori.Name = "TxtKategori";
            this.TxtKategori.Size = new System.Drawing.Size(72, 20);
            this.TxtKategori.TabIndex = 30;
            this.TxtKategori.Text = "Kategori:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(779, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 28);
            this.comboBox1.TabIndex = 31;
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 358);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TxtKategori);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtkKaydet);
            this.Controls.Add(this.Txt_SatisFiyat);
            this.Controls.Add(this.TxtSatisFiyat);
            this.Controls.Add(this.Txt_AlisFiyat);
            this.Controls.Add(this.TxtAlisFiyat);
            this.Controls.Add(this.Txt_Stok);
            this.Controls.Add(this.TxtStok);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.TxtUrun);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUrunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler Formu";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtkKaydet;
        private System.Windows.Forms.TextBox Txt_SatisFiyat;
        private System.Windows.Forms.Label TxtSatisFiyat;
        private System.Windows.Forms.TextBox Txt_AlisFiyat;
        private System.Windows.Forms.Label TxtAlisFiyat;
        private System.Windows.Forms.TextBox Txt_Stok;
        private System.Windows.Forms.Label TxtStok;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label TxtUrun;
        private System.Windows.Forms.Label TxtKategori;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}