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
    public partial class FrmFaturaUrunDuzenleme : DevExpress.XtraEditors.XtraForm
    {
        public FrmFaturaUrunDuzenleme()
        {
            InitializeComponent();
        }
        public string urunID;
        SqlBaglantisi baglanti = new SqlBaglantisi();

        private void FrmFaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            txtUrunID.Text = urunID;

            SqlCommand komut = new SqlCommand("Select * from TBL_FATURADETAY where FATURAURUNID = @p1", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", urunID);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                txtFiyat.Text = dataReader[4].ToString();
                txtAdet.Text = dataReader[3].ToString();
                txtTutar.Text = dataReader[5].ToString();
                txtUrunAd.Text = dataReader[2].ToString();

                baglanti.Baglanti().Close();
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_FATURADETAY set URUNAD = @p1, MIKTAR = @p2, FIYAT=@p3, TUTAR =@p4 where FATURAURUNID = @p5",
                baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            komut.Parameters.AddWithValue("@p2", txtAdet.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtFiyat.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
            komut.Parameters.AddWithValue("@p5", txtUrunID.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Değişiklikler Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_FATURADETAY where FATURAURUNID =@p1", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtUrunID.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Ürün Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}