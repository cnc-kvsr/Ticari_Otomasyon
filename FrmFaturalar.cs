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
    public partial class FrmFaturalar : DevExpress.XtraEditors.XtraForm
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglanti = new SqlBaglantisi();

        void Listele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from TBL_FATURABILGI", baglanti.Baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            grdFaturalar.DataSource = dataTable;
            gvFaturalar.BestFitColumns();
        }
        void Temizle()
        {
            txtID.Text = "";
            txtAlici.Text = "";
            txtSeri.Text = "";
            txtSıraNo.Text = "";
            txtTeslimAlan.Text = "";
            txtTeslimEden.Text = "";
            mskTarih.Text = "";
            mskSaat.Text = "";
            txtVergiDairesi.Text = "";

            txtTutar.Text = "";
            txtUrunAd.Text = "";
            txtAdet.Text = "";
            txtFiyat.Text = "";
            txtPersonel.Text = "";
        }
        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            if (txtFaturaID.Text == "" )
            {
                SqlCommand komut = new SqlCommand("Insert into TBL_FATURABILGI (SERI, SIRANO, TARIH, SAAT, VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN)" +
                    "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti.Baglanti());
                komut.Parameters.AddWithValue("@p1", txtSeri.Text);
                komut.Parameters.AddWithValue("@p2", txtSıraNo.Text);
                komut.Parameters.AddWithValue("@p3", mskTarih.Text);
                komut.Parameters.AddWithValue("@p4", mskSaat.Text);
                komut.Parameters.AddWithValue("@p5", txtVergiDairesi.Text);
                komut.Parameters.AddWithValue("@p6", txtAlici.Text);
                komut.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
                komut.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
                komut.ExecuteNonQuery();
                baglanti.Baglanti().Close();
                MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
             //Firma Carisi
            if (txtFaturaID.Text != "" && cmbCariTur.Text == "Firma")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(txtFiyat.Text);
                miktar = Convert.ToDouble(txtAdet.Text);
                tutar = miktar * fiyat;
                txtTutar.Text = tutar.ToString();

                SqlCommand komut2 = new SqlCommand("Insert into TBL_FATURADETAY (FATURAID,URUNAD, MIKTAR,FIYAT,TUTAR) " +
                    "values (@p1,@p2,@p3,@p4,@p5)", baglanti.Baglanti());
                komut2.Parameters.AddWithValue("@p1", txtFaturaID.Text);
                komut2.Parameters.AddWithValue("@p2", txtUrunAd.Text);
                komut2.Parameters.AddWithValue("@p3", txtAdet.Text);
                komut2.Parameters.AddWithValue("@p4", decimal.Parse(txtFiyat.Text));
                komut2.Parameters.AddWithValue("@p5", decimal.Parse(txtTutar.Text));
                komut2.ExecuteNonQuery();
                baglanti.Baglanti().Close();

                //Hareket tablosuna veri girişi 
                SqlCommand komut3 = new SqlCommand("Insert into TBL_FIRMAHAREKETLER (URUNID, ADET, PERSONEL, FIRMA, FIYAT, TOPLAM, FATURAID, TARIH)" +
                    "values (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", baglanti.Baglanti());
                komut3.Parameters.AddWithValue("@h1", txtUrunID.Text);
                komut3.Parameters.AddWithValue("@h2", txtAdet.Text);
                komut3.Parameters.AddWithValue("@h3", txtPersonel.Text);
                komut3.Parameters.AddWithValue("@h4", txtFirma.Text);
                komut3.Parameters.AddWithValue("@h5", decimal.Parse(txtFiyat.Text));
                komut3.Parameters.AddWithValue("@h6", decimal.Parse(txtTutar.Text));
                komut3.Parameters.AddWithValue("@h7", txtFaturaID.Text);
                komut3.Parameters.AddWithValue("@h8", mskTarih.Text);
                komut3.ExecuteNonQuery();
                baglanti.Baglanti().Close();

                //Stok sayısını azaltma
                SqlCommand komut4 = new SqlCommand("Update TBL_URUNLER set ADET = ADET - @s1 where ID = @s2", baglanti.Baglanti());
                komut4.Parameters.AddWithValue("@s1", txtAdet.Text);
                komut4.Parameters.AddWithValue("@s2", txtUrunID.Text);
                komut4.ExecuteNonQuery();
                baglanti.Baglanti().Close();

                MessageBox.Show("Faturaya Ait Ürün Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();

            }

            //Müşteri Carisi
            if (txtFaturaID.Text != "" && cmbCariTur.Text == "Müşteri")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(txtFiyat.Text);
                miktar = Convert.ToDouble(txtAdet.Text);
                tutar = miktar * fiyat;
                txtTutar.Text = tutar.ToString();

                SqlCommand komut2 = new SqlCommand("Insert into TBL_FATURADETAY (FATURAID,URUNAD, MIKTAR,FIYAT,TUTAR) " +
                    "values (@p1,@p2,@p3,@p4,@p5)", baglanti.Baglanti());
                komut2.Parameters.AddWithValue("@p1", txtFaturaID.Text);
                komut2.Parameters.AddWithValue("@p2", txtUrunAd.Text);
                komut2.Parameters.AddWithValue("@p3", txtAdet.Text);
                komut2.Parameters.AddWithValue("@p4", decimal.Parse(txtFiyat.Text));
                komut2.Parameters.AddWithValue("@p5", decimal.Parse(txtTutar.Text));
                komut2.ExecuteNonQuery();
                baglanti.Baglanti().Close();

                //Hareket tablosuna veri girişi 
                SqlCommand komut3 = new SqlCommand("Insert into TBL_MUSTERIHAREKETLER (URUNID, ADET, PERSONEL, MUSTERI, FIYAT, TOPLAM, FATURAID, TARIH)" +
                    "values (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", baglanti.Baglanti());
                komut3.Parameters.AddWithValue("@h1", txtUrunID.Text);
                komut3.Parameters.AddWithValue("@h2", txtAdet.Text);
                komut3.Parameters.AddWithValue("@h3", txtPersonel.Text);
                komut3.Parameters.AddWithValue("@h4", txtFirma.Text);
                komut3.Parameters.AddWithValue("@h5", decimal.Parse(txtFiyat.Text));
                komut3.Parameters.AddWithValue("@h6", decimal.Parse(txtTutar.Text));
                komut3.Parameters.AddWithValue("@h7", txtFaturaID.Text);
                komut3.Parameters.AddWithValue("@h8", mskTarih.Text);
                komut3.ExecuteNonQuery();
                baglanti.Baglanti().Close();

                //Stok sayısını azaltma
                SqlCommand komut4 = new SqlCommand("Update TBL_URUNLER set ADET = ADET - @s1 where ID = @s2", baglanti.Baglanti());
                komut4.Parameters.AddWithValue("@s1", txtAdet.Text);
                komut4.Parameters.AddWithValue("@s2", txtUrunID.Text);
                komut4.ExecuteNonQuery();
                baglanti.Baglanti().Close();

                MessageBox.Show("Müşteriye Ait Ürün Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gvFaturalar.GetDataRow(gvFaturalar.FocusedRowHandle);

            if (dataRow !=null)
            {
                txtID.Text = dataRow["FATURABILGIID"].ToString();
                txtSeri.Text = dataRow["SERI"].ToString();
                txtSıraNo.Text = dataRow["SIRANO"].ToString();
                mskTarih.Text = dataRow["TARIH"].ToString();
                mskSaat.Text = dataRow["SAAT"].ToString();
                txtVergiDairesi.Text = dataRow["VERGIDAIRE"].ToString();
                txtAlici.Text = dataRow["ALICI"].ToString();
                txtTeslimEden.Text = dataRow["TESLIMEDEN"].ToString();
                txtTeslimAlan.Text = dataRow["TESLIMALAN"].ToString();
                txtFaturaID.Text = dataRow["FATURABILGIID"].ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_FATURABILGI where FATURABILGIID = @p1", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            Listele();
            MessageBox.Show("Fatura Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_FATURABILGI set SERI=@p1, SIRANO=@p2, TARIH=@p3, SAAT=@p4,VERGIDAIRE=@p5," +
                "ALICI=@p6,TESLIMEDEN=@p7,TESLIMALAN=@p8 where FATURABILGIID = @p9", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtSeri.Text);
            komut.Parameters.AddWithValue("@p2", txtSıraNo.Text);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.Parameters.AddWithValue("@p5", txtVergiDairesi.Text);
            komut.Parameters.AddWithValue("@p6", txtAlici.Text);
            komut.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
            komut.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
            komut.Parameters.AddWithValue("@p9", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Fatura Bilgisi Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDetay frmFaturaUrun = new FrmFaturaUrunDetay();
            DataRow dataRow = gvFaturalar.GetDataRow(gvFaturalar.FocusedRowHandle);

            if (dataRow != null)
            {
                frmFaturaUrun.ID = dataRow["FATURABILGIID"].ToString();
            }
            frmFaturaUrun.Show();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT URUNAD,SATISFIYAT FROM TBL_URUNLER WHERE ID = @p1", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtUrunID.Text);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                txtUrunAd.Text = dataReader[0].ToString();
                txtFiyat.Text = dataReader[1].ToString();
            }
            baglanti.Baglanti().Close();
        }

    }
}