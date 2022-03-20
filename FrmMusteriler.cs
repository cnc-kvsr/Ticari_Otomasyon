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
    public partial class FrmMusteriler : DevExpress.XtraEditors.XtraForm
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglanti = new SqlBaglantisi();

        void Listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from TBL_MUSTERILER", baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            grdMusteriler.DataSource = dataTable;
            gvMusteriler.BestFitColumns();
        }
        void Temizle()
        {
            txtAd.Text = "";
            txtAdres.Text = "";
            txtID.Text = "";
            txtMail.Text = "";
            txtSoyad.Text = "";
            txtVergiDairesi.Text = "";
            mskTC.Text = "";
            mskTelefon.Text = "";
            mskTelefon2.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";

        }
        void SehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_ILLER", baglanti.Baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while(dataReader.Read())
            {
                cmbIl.Properties.Items.Add(dataReader[1]);
            }
            baglanti.Baglanti().Close();
        }
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            Listele();
            SehirListesi();
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_MUSTERILER (AD, SOYAD, TELEFON, TELEFON2, TC, MAIL, IL, ILCE, ADRES, VERGIDAIRE)" +
                "values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", mskTelefon2.Text);
            komut.Parameters.AddWithValue("@p5", mskTC.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.Parameters.AddWithValue("@p7", cmbIl.Text);
            komut.Parameters.AddWithValue("@p8", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p9", txtAdres.Text);
            komut.Parameters.AddWithValue("@p10", txtVergiDairesi.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gvMusteriler.GetDataRow(gvMusteriler.FocusedRowHandle);
            if (dataRow != null)
            {
                txtID.Text = dataRow["ID"].ToString();
                txtAd.Text = dataRow["AD"].ToString();
                txtSoyad.Text = dataRow["SOYAD"].ToString();
                mskTelefon.Text = dataRow["TELEFON"].ToString();
                mskTelefon2.Text = dataRow["TELEFON2"].ToString();
                mskTC.Text = dataRow["TC"].ToString();
                txtMail.Text = dataRow["MAIL"].ToString();
                cmbIl.Text = dataRow["IL"].ToString();
                cmbIlce.Text = dataRow["ILCE"].ToString();
                txtVergiDairesi.Text = dataRow["VERGIDAIRE"].ToString();
                txtAdres.Text = dataRow["ADRES"].ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {           
            DialogResult message =MessageBox.Show("Müşteri kaydını silmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from TBL_MUSTERILER where ID=@p1", baglanti.Baglanti());
                komut.Parameters.AddWithValue("@p1", txtID.Text);
                komut.ExecuteNonQuery();
                baglanti.Baglanti().Close();
            }            
            Listele();
            Temizle();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_MUSTERILER set AD= @p1, SOYAD=@p2, TELEFON= @p3, TELEFON2 = @p4, TC = @p5, MAIL = @p6," +
                "IL = @p7, ILCE = @p8, VERGIDAIRE = @p9, ADRES = @p10 where ID = @p11", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", mskTelefon2.Text);
            komut.Parameters.AddWithValue("@p5", mskTC.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.Parameters.AddWithValue("@p7", cmbIl.Text);
            komut.Parameters.AddWithValue("@p8", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p9", txtVergiDairesi.Text);
            komut.Parameters.AddWithValue("@p10", txtAdres.Text);
            komut.Parameters.AddWithValue("@p11", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}