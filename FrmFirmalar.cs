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
    public partial class FrmFirmalar : DevExpress.XtraEditors.XtraForm
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglanti = new SqlBaglantisi();
        void FirmaListesi()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from TBL_FIRMALAR", baglanti.Baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
            gridView1.BestFitColumns();
        }
        void SehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_ILLER", baglanti.Baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                cmbIl.Properties.Items.Add(dataReader[1]);
            }
            baglanti.Baglanti().Close();
        }
        void CariKodAciklamalar()
        {
            SqlCommand komut = new SqlCommand("Select FIRMAKOD1 from TBL_KODLAR", baglanti.Baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                rchKod1.Text = dataReader[0].ToString();
            }
            baglanti.Baglanti().Close();
        }
        void Temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSektor.Text = "";
            txtYetkili.Text = "";
            txtYetkiliGörev.Text = "";
            txtKod1.Text = "";
            txtKod2.Text = "";
            txtKod3.Text = "";
            txtAdres.Text = "";
            txtMail.Text = "";
            txtVergiDairesi.Text = "";
            mskFax.Text = "";
            mskTelefon1.Text = "";
            mskTelefon2.Text = "";
            mskTelefon3.Text = "";
            mskTC.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtAd.Focus();
        }
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            FirmaListesi();
            SehirListesi();
            Temizle();
            CariKodAciklamalar();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null)
            {
                txtID.Text = dataRow["ID"].ToString();
                txtAd.Text = dataRow["AD"].ToString();
                txtSektor.Text = dataRow["SEKTOR"].ToString();
                txtYetkili.Text = dataRow["YETKILIADSOYAD"].ToString();
                txtYetkiliGörev.Text = dataRow["YETKILISTATU"].ToString();
                mskTC.Text = dataRow["YETKILITC"].ToString();
                mskTelefon1.Text = dataRow["TELEFON1"].ToString();
                mskTelefon2.Text = dataRow["TELEFON2"].ToString();
                mskTelefon3.Text = dataRow["TELEFON3"].ToString();
                mskFax.Text = dataRow["FAX"].ToString();
                txtMail.Text = dataRow["MAIL"].ToString();
                txtVergiDairesi.Text = dataRow["VERGIDAIRE"].ToString();
                txtAdres.Text = dataRow["ADRES"].ToString();
                txtKod1.Text = dataRow["OZELKOD1"].ToString();
                txtKod2.Text = dataRow["OZELKOD2"].ToString();
                txtKod3.Text = dataRow["OZELKOD3"].ToString();
                cmbIl.Text = dataRow["IL"].ToString();
                cmbIlce.Text = dataRow["ILCE"].ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_FIRMALAR (AD, YETKILISTATU, YETKILIADSOYAD, YETKILITC, SEKTOR, " +
                "TELEFON1, TELEFON2, TELEFON3, MAIL, FAX, IL, ILCE, VERGIDAIRE, ADRES, OZELKOD1, OZELKOD2, OZELKOD3) " +
                "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYetkiliGörev.Text);
            komut.Parameters.AddWithValue("@p3", txtYetkili.Text);
            komut.Parameters.AddWithValue("@p4", mskTC.Text);
            komut.Parameters.AddWithValue("@p5", txtSektor.Text);
            komut.Parameters.AddWithValue("@p6", mskTelefon1.Text);
            komut.Parameters.AddWithValue("@p7", mskTelefon2.Text);
            komut.Parameters.AddWithValue("@p8", mskTelefon3.Text);
            komut.Parameters.AddWithValue("@p9", txtMail.Text);
            komut.Parameters.AddWithValue("@p10", mskFax.Text);
            komut.Parameters.AddWithValue("@p11", cmbIl.Text);
            komut.Parameters.AddWithValue("@p12", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p13", txtVergiDairesi.Text);
            komut.Parameters.AddWithValue("@p14", txtAdres.Text);
            komut.Parameters.AddWithValue("@p15", txtKod1.Text);
            komut.Parameters.AddWithValue("@p16", txtKod2.Text);
            komut.Parameters.AddWithValue("@p17", txtKod3.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Firma Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FirmaListesi();
            Temizle();
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE from TBL_ILCELER where SEHIR = @p1", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", cmbIl.SelectedIndex + 1);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                cmbIlce.Properties.Items.Add(dataReader[0]);
            }
            baglanti.Baglanti().Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_FIRMALAR where ID = @p1", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            FirmaListesi();
            MessageBox.Show("Firma Listeden Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            Temizle();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_FIRMALAR set AD=@p1, YETKILISTATU=@p2, YETKILIADSOYAD=@p3, YETKILITC=@p4, SEKTOR=@p5, " +
                "TELEFON1=@p6, TELEFON2=@p7, TELEFON3=@p8, MAIL=@p9, FAX=@p10, IL=@p11, ILCE=@p12, VERGIDAIRE=@p13, ADRES=@p14, OZELKOD1=@p15, OZELKOD2=@p16, OZELKOD3=@p17" +
                " where ID = @p18", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYetkiliGörev.Text);
            komut.Parameters.AddWithValue("@p3", txtYetkili.Text);
            komut.Parameters.AddWithValue("@p4", mskTC.Text);
            komut.Parameters.AddWithValue("@p5", txtSektor.Text);
            komut.Parameters.AddWithValue("@p6", mskTelefon1.Text);
            komut.Parameters.AddWithValue("@p7", mskTelefon2.Text);
            komut.Parameters.AddWithValue("@p8", mskTelefon3.Text);
            komut.Parameters.AddWithValue("@p9", txtMail.Text);
            komut.Parameters.AddWithValue("@p10", mskFax.Text);
            komut.Parameters.AddWithValue("@p11", cmbIl.Text);
            komut.Parameters.AddWithValue("@p12", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p13", txtVergiDairesi.Text);
            komut.Parameters.AddWithValue("@p14", txtAdres.Text);
            komut.Parameters.AddWithValue("@p15", txtKod1.Text);
            komut.Parameters.AddWithValue("@p16", txtKod2.Text);
            komut.Parameters.AddWithValue("@p17", txtKod3.Text);
            komut.Parameters.AddWithValue("@p18", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Firma Bilgiler Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            FirmaListesi();
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}