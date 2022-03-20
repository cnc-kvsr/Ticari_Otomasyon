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
    public partial class FrmPersoneller : DevExpress.XtraEditors.XtraForm
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglanti = new SqlBaglantisi();
        void Listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from TBL_PERSONELLER", baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            grdPersoneller.DataSource = dataTable;
            gvPersoneller.BestFitColumns();
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
        void Temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTelefon.Text = "";
            mskTC.Text = "";
            txtMail.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtGorev.Text = "";
            txtAdres.Text = "";
        }
        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            Listele();
            SehirListesi();
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_PERSONELLER (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) " +
                "VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", mskTC.Text);
            komut.Parameters.AddWithValue("@p5", txtMail.Text);
            komut.Parameters.AddWithValue("@p6", cmbIl.Text);
            komut.Parameters.AddWithValue("@p7", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p8", txtAdres.Text);
            komut.Parameters.AddWithValue("@p9", txtGorev.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Personel Bilgileri Kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();
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
            SqlCommand komut = new SqlCommand("Delete from TBL_PERSONELLER where ID = @p1", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Personel Listeden Silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            Listele();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gvPersoneller.GetDataRow(gvPersoneller.FocusedRowHandle);

            if(dataRow != null)
            {
                txtID.Text = dataRow["ID"].ToString();
                txtAd.Text = dataRow["AD"].ToString();
                txtSoyad.Text = dataRow["SOYAD"].ToString();
                mskTelefon.Text = dataRow["TELEFON"].ToString();
                mskTC.Text = dataRow["TC"].ToString();
                txtMail.Text = dataRow["MAIL"].ToString();
                cmbIl.Text = dataRow["IL"].ToString();
                cmbIlce.Text = dataRow["ILCE"].ToString();
                txtAdres.Text = dataRow["ADRES"].ToString();
                txtGorev.Text = dataRow["GOREV"].ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_PERSONELLER set AD=@p1,SOYAD=@p2,TELEFON=@p3,TC=@p4,MAIL=@p5,IL=@p6,ILCE=@p7,ADRES=@p8,GOREV=@p9 " +
                "where ID = @p10", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", mskTC.Text);
            komut.Parameters.AddWithValue("@p5", txtMail.Text);
            komut.Parameters.AddWithValue("@p6", cmbIl.Text);
            komut.Parameters.AddWithValue("@p7", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p8", txtAdres.Text);
            komut.Parameters.AddWithValue("@p9", txtGorev.Text);
            komut.Parameters.AddWithValue("@p10", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Personel Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
            Temizle();
        }
    }
}