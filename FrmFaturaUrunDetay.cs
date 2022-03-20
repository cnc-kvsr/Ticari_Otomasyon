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
    public partial class FrmFaturaUrunDetay : DevExpress.XtraEditors.XtraForm
    {
        public FrmFaturaUrunDetay()
        {
            InitializeComponent();
        }

        public string ID;
        SqlBaglantisi baglanti = new SqlBaglantisi();

        void Listele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from TBL_FATURADETAY where FATURAID = '"+ID+"'", baglanti.Baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
            gridView1.BestFitColumns();
        }
        private void FrmFaturaUrunDetay_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDuzenleme frmFaturaUrunDuzenleme = new FrmFaturaUrunDuzenleme();
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dataRow != null)
            {
                frmFaturaUrunDuzenleme.urunID = dataRow["FATURAURUNID"].ToString();
            }
            frmFaturaUrunDuzenleme.Show();
            //this.Hide();
        }
    }
}