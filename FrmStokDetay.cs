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
    public partial class FrmStokDetay : DevExpress.XtraEditors.XtraForm
    {
        public FrmStokDetay()
        {
            InitializeComponent();
        }
        public string ad;
        SqlBaglantisi baglanti = new SqlBaglantisi();

        private void FrmStokDetay_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM TBL_URUNLER WHERE URUNAD ='" + ad + "' ", baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            grdStokDetay.DataSource = dataTable;
            gvStokDetay.BestFitColumns();
        }
    }
}