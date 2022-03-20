using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    public partial class FrmUrunler : DevExpress.XtraEditors.XtraForm
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglanti = new SqlBaglantisi();
        void Listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from TBL_URUNLER", baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            grdUrunler.DataSource = dataTable;
            gvUrunler.BestFitColumns();
        }
        void Temizle()
        {
            txtAd.Text = "";
            txtAlısFiyat.Text = "";
            txtDetay.Text = "";
            txtID.Text = "";
            txtMarka.Text = "";
            txtModel.Text = "";
            txtSatısFiyat.Text = "";
            mskYil.Text = "";
            nudAdet.Value = 0;
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_URUNLER(URUNAD, MARKA, MODEL, YIL, ADET, ALISFIYAT, SATISFIYAT, DETAY) " +
                "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", mskYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((nudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtAlısFiyat.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtSatısFiyat.Text));
            komut.Parameters.AddWithValue("@p8", txtDetay.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("Delete from TBL_URUNLER where ID=@p1", baglanti.Baglanti());
            komutSil.Parameters.AddWithValue("@p1", txtID.Text);
            komutSil.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Listele();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gvUrunler.GetDataRow(gvUrunler.FocusedRowHandle);
            txtID.Text = dataRow["ID"].ToString();
            txtAd.Text = dataRow["URUNAD"].ToString();
            txtMarka.Text = dataRow["MARKA"].ToString();
            txtModel.Text = dataRow["MODEL"].ToString();
            mskYil.Text = dataRow["YIL"].ToString();
            nudAdet.Value = decimal.Parse(dataRow["ADET"].ToString());
            txtAlısFiyat.Text = dataRow["ALISFIYAT"].ToString();
            txtSatısFiyat.Text = dataRow["SATISFIYAT"].ToString();
            txtDetay.Text = dataRow["DETAY"].ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_URUNLER set URUNAD = @P1,MARKA = @P2,MODEL = @P3,YIL = @P4,ADET = @P5, ALISFIYAT = @P6," +
                "SATISFIYAT = @P7, DETAY = @P8 where ID = @P9", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", mskYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((nudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtAlısFiyat.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtSatısFiyat.Text));
            komut.Parameters.AddWithValue("@p8", txtDetay.Text);
            komut.Parameters.AddWithValue("@p9", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}