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
using System.Xml;

namespace Ticari_Otomasyon
{
    public partial class FrmAnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglanti = new SqlBaglantisi();

        void Stoklar()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT URUNAD,SUM(ADET) AS 'ADET' FROM TBL_URUNLER GROUP BY URUNAD HAVING SUM(ADET) <= 20 ORDER BY SUM(ADET)",
                baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            grdAzalanStoklar.DataSource = dataTable;
            gvAzalanStoklar.BestFitColumns();
        }
        void Ajanda()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT TOP 10 TARIH, SAAT, BASLIK FROM TBL_NOTLAR ORDER BY ID DESC",baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            grdAjanda.DataSource = dataTable;
            gvAjanda.BestFitColumns();
        }
        void FirmaHareketler()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Exec FIRMAHAREKET2", baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            grdSon10Hareket.DataSource = dataTable;
            gvSon10Hareket.BestFitColumns();
        }
        void Fihrist()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT AD, TELEFON1 FROM TBL_FIRMALAR", baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            grdFihrist.DataSource = dataTable;
            gvFihrist.BestFitColumns();
        }
        void Haberler()
        {
            XmlTextReader xmlText = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
            while (xmlText.Read())
            {
                if (xmlText.Name == "title")
                {
                    listBoxHaberler.Items.Add(xmlText.ReadString());
                }
            }
        }
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            Stoklar();
            Ajanda();
            FirmaHareketler();
            Fihrist();
            webBrowserDoviz.Navigate("https://www.tcmb.gov.tr/kurlar/kurlar_tr.html");
            Haberler();
        }

    }
}