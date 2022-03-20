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
    public partial class FrmAyarlar : DevExpress.XtraEditors.XtraForm
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglanti = new SqlBaglantisi();

        void Listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from TBL_ADMIN", baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            grdAyarlar.DataSource = dataTable;
            gvAyarlar.BestFitColumns();
        }
        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            Listele();
            txtKullaniciAd.Text = "";
            txtSifre.Text = "";
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            if (btnIslem.Text == "KAYDET")
            {
                SqlCommand komut = new SqlCommand("Insert into TBL_ADMIN values (@p1,@p2)", baglanti.Baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                komut.ExecuteNonQuery();
                baglanti.Baglanti().Close();
                MessageBox.Show("Yeni Admin Sisteme Kaydedildi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            if (btnIslem.Text == "GÜNCELLE")
            {
                SqlCommand komut = new SqlCommand("Update TBL_ADMIN set SIFRE=@p2 where KULLANICIAD = @p1", baglanti.Baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                komut.ExecuteNonQuery();
                baglanti.Baglanti().Close();
                MessageBox.Show("Admin Bilgisi Güncellendi.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
            }
        }

        private void gvAyarlar_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gvAyarlar.GetDataRow(gvAyarlar.FocusedRowHandle);
            if (dataRow != null)
            {
                txtKullaniciAd.Text = dataRow["KULLANICIAD"].ToString();
                txtSifre.Text = dataRow["SIFRE"].ToString();
            }
        }

        private void txtKullaniciAd_EditValueChanged(object sender, EventArgs e)
        {
            if (txtKullaniciAd.Text != "")
            {
                btnIslem.Text = "GÜNCELLE";
                btnIslem.BackColor = Color.LightPink;
            }
            else
            {
                btnIslem.Text = "KAYDET";
                btnIslem.BackColor = Color.LightYellow;
            }

        }
    }
}