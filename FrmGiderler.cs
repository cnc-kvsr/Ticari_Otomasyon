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
    public partial class FrmGiderler : DevExpress.XtraEditors.XtraForm
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglanti = new SqlBaglantisi();
        void GiderListesi()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from TBL_GIDERLER Order By ID Asc",baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource=dataTable;
            gridView1.BestFitColumns();
        }
        void Temizle()
        {
            txtDogalgaz.Text = "";
            txtEkstra.Text = "";
            txtElektrik.Text = "";
            txtID.Text = "";
            txtInternet.Text = "";
            txtMaaslar.Text = "";
            txtNotlar.Text = "";
            txtSu.Text = "";
            cmbAy.Text = "";
            cmbYıl.Text = "";
        }
        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            GiderListesi();
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_GIDERLER (AY, YIL, ELEKTRIK,SU, DOGALGAZ, INTERNET,MAASLAR,EKSTRA,NOTLAR)" +
                "VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@P1", cmbAy.Text);
            komut.Parameters.AddWithValue("@P2", cmbYıl.Text);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(txtElektrik.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse(txtSu.Text));
            komut.Parameters.AddWithValue("@P5", decimal.Parse(txtDogalgaz.Text));
            komut.Parameters.AddWithValue("@P6", decimal.Parse(txtInternet.Text));
            komut.Parameters.AddWithValue("@P7", decimal.Parse(txtMaaslar.Text));
            komut.Parameters.AddWithValue("@P8", decimal.Parse(txtEkstra.Text));
            komut.Parameters.AddWithValue("@P9", txtNotlar.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Gider Tabloya Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GiderListesi();
            //Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dataRow!=null)
            {
                txtID.Text = dataRow["ID"].ToString();
                cmbAy.Text = dataRow["AY"].ToString();
                cmbYıl.Text = dataRow["YIL"].ToString();
                txtElektrik.Text = dataRow["ELEKTRIK"].ToString();
                txtSu.Text = dataRow["SU"].ToString();
                txtDogalgaz.Text = dataRow["DOGALGAZ"].ToString();
                txtInternet.Text = dataRow["INTERNET"].ToString();
                txtMaaslar.Text = dataRow["MAASLAR"].ToString();
                txtEkstra.Text = dataRow["EKSTRA"].ToString();
                txtNotlar.Text = dataRow["NOTLAR"].ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_GIDERLER where ID = @P1", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@P1", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Gider Listeden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            GiderListesi();
            Temizle();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_GIDERLER set AY=@P1, YIL=@P2, ELEKTRIK=@P3,SU=@P4, DOGALGAZ=@P5, INTERNET=@P6,MAASLAR=@P7,EKSTRA=@P8,NOTLAR=@P9 where ID=@P10",
                baglanti.Baglanti());
            komut.Parameters.AddWithValue("@P1", cmbAy.Text);
            komut.Parameters.AddWithValue("@P2", cmbYıl.Text);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(txtElektrik.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse(txtSu.Text));
            komut.Parameters.AddWithValue("@P5", decimal.Parse(txtDogalgaz.Text));
            komut.Parameters.AddWithValue("@P6", decimal.Parse(txtInternet.Text));
            komut.Parameters.AddWithValue("@P7", decimal.Parse(txtMaaslar.Text));
            komut.Parameters.AddWithValue("@P8", decimal.Parse(txtEkstra.Text));
            komut.Parameters.AddWithValue("@P9", txtNotlar.Text);
            komut.Parameters.AddWithValue("@P10", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            MessageBox.Show("Gider Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GiderListesi();
            Temizle();
        }
    }
}