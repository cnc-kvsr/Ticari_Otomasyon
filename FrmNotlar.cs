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
    public partial class FrmNotlar : DevExpress.XtraEditors.XtraForm
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglanti = new SqlBaglantisi();

        void Listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from TBL_NOTLAR", baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            grdNotlar.DataSource = dataTable;
            gvNotlar.BestFitColumns();
        }
        void Temizle()
        {
            txtBaslik.Text = "";
            txtDetay.Text = "";
            txtHitap.Text = "";
            txtOlusturan.Text = "";
            txtID.Text = "";
            mskTarih.Text = "";
            mskSaat.Text = "";
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_NOTLAR (TARIH, SAAT, BASLIK, DETAY, OLUSTURAN, HITAP) " +
                "values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", mskTarih.Text);
            komut.Parameters.AddWithValue("@p2", mskSaat.Text);
            komut.Parameters.AddWithValue("@p3", txtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", txtDetay.Text);
            komut.Parameters.AddWithValue("@p5", txtOlusturan.Text);
            komut.Parameters.AddWithValue("@p6", txtHitap.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            Listele();
            MessageBox.Show("Yeni Not Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gvNotlar.GetDataRow(gvNotlar.FocusedRowHandle);
            if (dataRow != null)
            {
                txtID.Text = dataRow["ID"].ToString();
                txtBaslik.Text = dataRow["BASLIK"].ToString();
                txtDetay.Text = dataRow["DETAY"].ToString();
                txtHitap.Text = dataRow["OLUSTURAN"].ToString();
                txtOlusturan.Text = dataRow["HITAP"].ToString();
                mskSaat.Text = dataRow["SAAT"].ToString();
                mskTarih.Text = dataRow["TARIH"].ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_NOTLAR where ID = @p1", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Not Sistemden Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_NOTLAR set TARIH =@p1, SAAT=@p2, BASLIK=@p3, DETAY=@p4, OLUSTURAN=@p5, HITAP=@p6 where ID = @p7",
                baglanti.Baglanti());
                komut.Parameters.AddWithValue("@p1", mskTarih.Text);
            komut.Parameters.AddWithValue("@p2", mskSaat.Text);
            komut.Parameters.AddWithValue("@p3", txtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", txtDetay.Text);
            komut.Parameters.AddWithValue("@p5", txtOlusturan.Text);
            komut.Parameters.AddWithValue("@p6", txtHitap.Text);
            komut.Parameters.AddWithValue("@p7", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            Listele();
            MessageBox.Show("Not Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay frmNotDetay = new FrmNotDetay();
            DataRow dataRow = gvNotlar.GetDataRow(gvNotlar.FocusedRowHandle);

            if(dataRow != null)
            {
                frmNotDetay.metin = dataRow["DETAY"].ToString();
            }
            frmNotDetay.Show();
        }
    }
}