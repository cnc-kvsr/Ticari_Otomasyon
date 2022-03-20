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
    public partial class FrmRehber : DevExpress.XtraEditors.XtraForm
    {
        public FrmRehber()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglanti = new SqlBaglantisi();
        void MusteriBilgileri()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select AD, SOYAD, TELEFON, TELEFON2,MAIL from TBL_MUSTERILER", baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            grdMusteriler.DataSource = dataTable;
            gvMusteriler.BestFitColumns();
        }
        void FirmaBilgileri()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select AD, YETKILIADSOYAD, TELEFON1, TELEFON2,TELEFON2,MAIL,FAX from TBL_FIRMALAR", baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            grdFirmalar.DataSource = dataTable;
            gvFirmalar.BestFitColumns();
        }
        private void FrmRehber_Load(object sender, EventArgs e)
        {
            MusteriBilgileri();
            FirmaBilgileri();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frmMail = new FrmMail();
            DataRow dataRow = gvMusteriler.GetDataRow(gvMusteriler.FocusedRowHandle);

            if (dataRow != null)
            {
                frmMail.mail = dataRow["MAIL"].ToString();
            }
            frmMail.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frmMail = new FrmMail();
            DataRow dataRow = gvFirmalar.GetDataRow(gvFirmalar.FocusedRowHandle);

            if (dataRow != null)
            {
                frmMail.mail = dataRow["MAIL"].ToString();
            }
            frmMail.Show();
        }
    }
}