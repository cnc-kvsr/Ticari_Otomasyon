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
    public partial class FrmStoklar : DevExpress.XtraEditors.XtraForm
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglanti = new SqlBaglantisi();
        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            UrunListele();
            StokListesi();
            FirmaSehirListesi();
        }
        void UrunListele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT URUNAD,SUM(ADET) AS 'MIKTAR' FROM TBL_URUNLER GROUP BY URUNAD", baglanti.Baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            grdStoklar.DataSource = dataTable;
            gvStoklar.BestFitColumns();
        }
        void StokListesi()
        {
            SqlCommand komut = new SqlCommand("SELECT URUNAD,SUM(ADET) AS 'MIKTAR' FROM TBL_URUNLER GROUP BY URUNAD", baglanti.Baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                chartStoklar.Series["Series Urun"].Points.AddPoint(Convert.ToString(dataReader[0]), Convert.ToInt32(dataReader[1]));
            }
            baglanti.Baglanti().Close();
        }
        
        void FirmaSehirListesi()
        {
            SqlCommand komut = new SqlCommand("SELECT IL,COUNT(*) FROM TBL_FIRMALAR GROUP BY IL", baglanti.Baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                chartControlFirma.Series["Series Firma"].Points.AddPoint(Convert.ToString(dataReader[0]), int.Parse(dataReader[1].ToString()));
            }
            baglanti.Baglanti().Close();
        }

        private void gvStoklar_DoubleClick(object sender, EventArgs e)
        {
            FrmStokDetay frmStokDetay = new FrmStokDetay();
            DataRow dataRow = gvStoklar.GetDataRow(gvStoklar.FocusedRowHandle);

            if (dataRow !=null)
            {
                frmStokDetay.ad = dataRow["URUNAD"].ToString();
            }
            frmStokDetay.Show();
        }
    }
}