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
    public partial class FrmHareketler : DevExpress.XtraEditors.XtraForm
    {
        public FrmHareketler()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglanti = new SqlBaglantisi();

        void FirmaHareketleri()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Exec FIRMAHAREKETLER", baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            grdFirma.DataSource = dataTable;
            gvFirma.BestFitColumns();
        }
        void MusteriHareketleri()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Exec MUSTERIHAREKETLER", baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            grdMusteri.DataSource = dataTable;
            gvMusteri.BestFitColumns();
        }
        private void FrmHareketler_Load(object sender, EventArgs e)
        {
            FirmaHareketleri();
            MusteriHareketleri();
        }
    }
}