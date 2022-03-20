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
using DevExpress.Charts;


namespace Ticari_Otomasyon
{
    public partial class FrmKasa : DevExpress.XtraEditors.XtraForm
    {
        public FrmKasa()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglanti = new SqlBaglantisi();
        void GiderListesi()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from TBL_GIDERLER", baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            grdKasaCikis.DataSource = dataTable;
            gvKasaCikis.BestFitColumns();
        }
        void MusteriHareket()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Execute MUSTERIHAREKETLER", baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            grdMusteriHareket.DataSource = dataTable;
            //this.gvMusteriHareket.OptionsView.ColumnAutoWidth = false;
            gvMusteriHareket.BestFitColumns();
        }

        void FirmaHareket()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Execute FIRMAHAREKETLER", baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            grdFirmaHareket.DataSource = dataTable;
            gvFirmaHareket.BestFitColumns();
        }
        /// <summary>
        /// Gider toplamını verir
        /// </summary>
        void HesaplaToplamTutar()
        {
            SqlCommand komut = new SqlCommand("Select Sum(TUTAR) From TBL_FATURADETAY", baglanti.Baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                lblKasaToplamTutar.Text = dataReader[0].ToString() + " ₺";
            }
            baglanti.Baglanti().Close();
        }
        /// <summary>
        /// Son ayın fatura odemelerinin toplamını verir
        /// </summary>
        void FaturaOdemeleri()
        {
            SqlCommand komut = new SqlCommand("SELECT (ELEKTRIK+SU+DOGALGAZ+INTERNET+EKSTRA) FROM TBL_GIDERLER ORDER BY ID ASC", baglanti.Baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                lblOdemeler.Text = dataReader[0].ToString() + " ₺";
            }
            baglanti.Baglanti().Close();
        }
        /// <summary>
        /// Son Ayın personel maas toplamını verir.
        /// </summary>
        void PersonelMaaslar()  
        {
            SqlCommand komut = new SqlCommand("SELECT MAASLAR FROM TBL_GIDERLER ORDER BY ID ASC", baglanti.Baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                lblPersonelMaaslari.Text = dataReader[0].ToString() + " ₺";
            }
            baglanti.Baglanti().Close();
        }

        void ToplamMusteriSayisi()
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM TBL_MUSTERILER", baglanti.Baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                lblMusteriSayisi.Text = dataReader[0].ToString();
            }
            baglanti.Baglanti().Close();
        }
        void ToplamFirmaSayisi()
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM TBL_FIRMALAR", baglanti.Baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                lblFirmaSayisi.Text = dataReader[0].ToString();
            }
            baglanti.Baglanti().Close();
        }

        void ToplamFirmaSehirSayisi()
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(DISTINCT (IL)) FROM TBL_FIRMALAR", baglanti.Baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                lblFirmaSehirSayisi.Text = dataReader[0].ToString();
            }
            baglanti.Baglanti().Close();
        }

        void ToplamMusteriSehirSayisi()
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(DISTINCT (IL)) FROM TBL_MUSTERILER", baglanti.Baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                lblMusteriSehirSayisi.Text = dataReader[0].ToString();
            }
            baglanti.Baglanti().Close();
        }
        void ToplamPersonelSayisi()
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM TBL_PERSONELLER", baglanti.Baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                lblPersonelSayisi.Text = dataReader[0].ToString();
            }
            baglanti.Baglanti().Close();
        }

        void ToplamStokSayisi()
        {
            SqlCommand komut = new SqlCommand("SELECT SUM(ADET) FROM TBL_URUNLER", baglanti.Baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                lblStokSayisi.Text = dataReader[0].ToString();
            }
            baglanti.Baglanti().Close();
        }
        public string ad;
        private void FrmKasa_Load(object sender, EventArgs e)
        {
            MusteriHareket();
            FirmaHareket();
            HesaplaToplamTutar();
            FaturaOdemeleri();
            PersonelMaaslar();
            ToplamMusteriSayisi();
            ToplamFirmaSayisi();
            ToplamFirmaSehirSayisi();
            ToplamMusteriSehirSayisi();
            ToplamPersonelSayisi();
            ToplamStokSayisi();
            //FaturaSon4Su();
            GiderListesi();

            lblAktifKullanici.Text = ad;
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            //Elektrik
            if (sayac>=0 && sayac<=5)
            {
                grp1.Text = "Elektrik";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("SELECT TOP 4 AY,ELEKTRIK FROM TBL_GIDERLER ORDER BY ID DESC", baglanti.Baglanti());
                SqlDataReader dataReader = komut.ExecuteReader();
                while (dataReader.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dataReader[0], dataReader[1]));
                }
                baglanti.Baglanti().Close();
            }

            //Su
            if (sayac>5 && sayac<=10)
            {
                grp1.Text = "Su";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("SELECT TOP 4 AY,SU FROM TBL_GIDERLER ORDER BY ID DESC", baglanti.Baglanti());
                SqlDataReader dataReader = komut.ExecuteReader();
                while (dataReader.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dataReader[0], dataReader[1]));
                }
                baglanti.Baglanti().Close();
            }

            //Doğalgaz
            if (sayac>10 && sayac<=15)
            {
                grp1.Text = "Doğalgaz";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("SELECT TOP 4 AY,DOGALGAZ FROM TBL_GIDERLER ORDER BY ID DESC", baglanti.Baglanti());
                SqlDataReader dataReader = komut.ExecuteReader();
                while (dataReader.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dataReader[0], dataReader[1]));
                }
                baglanti.Baglanti().Close();
            }

            //Internet
            if (sayac > 15 && sayac <= 20)
            {
                grp1.Text = "İnternet";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("SELECT TOP 4 AY,INTERNET FROM TBL_GIDERLER ORDER BY ID DESC", baglanti.Baglanti());
                SqlDataReader dataReader = komut.ExecuteReader();
                while (dataReader.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dataReader[0], dataReader[1]));
                }
                baglanti.Baglanti().Close();
            }
            //Ekstra
            if (sayac > 20 && sayac <= 25)
            {
                grp1.Text = "Ekstra";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("SELECT TOP 4 AY,EKSTRA FROM TBL_GIDERLER ORDER BY ID DESC", baglanti.Baglanti());
                SqlDataReader dataReader = komut.ExecuteReader();
                while (dataReader.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dataReader[0], dataReader[1]));
                }
                baglanti.Baglanti().Close();
            }
            if (sayac == 26)
            {
                sayac = 0;
            }
        }

        int sayac2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            //Elektrik
            if (sayac2 >= 0 && sayac2 <= 5)
            {
                grp2.Text = "Elektrik";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("SELECT TOP 4 AY,ELEKTRIK FROM TBL_GIDERLER ORDER BY ID DESC", baglanti.Baglanti());
                SqlDataReader dataReader = komut.ExecuteReader();
                while (dataReader.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dataReader[0], dataReader[1]));
                }
                baglanti.Baglanti().Close();
            }

            //Su
            if (sayac2 > 5 && sayac2 <= 10)
            {
                grp2.Text = "Su";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("SELECT TOP 4 AY,SU FROM TBL_GIDERLER ORDER BY ID DESC", baglanti.Baglanti());
                SqlDataReader dataReader = komut.ExecuteReader();
                while (dataReader.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dataReader[0], dataReader[1]));
                }
                baglanti.Baglanti().Close();
            }

            //Doğalgaz
            if (sayac2 > 10 && sayac2 <= 15)
            {
                grp2.Text = "Doğalgaz";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("SELECT TOP 4 AY,DOGALGAZ FROM TBL_GIDERLER ORDER BY ID DESC", baglanti.Baglanti());
                SqlDataReader dataReader = komut.ExecuteReader();
                while (dataReader.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dataReader[0], dataReader[1]));
                }
                baglanti.Baglanti().Close();
            }

            //Internet
            if (sayac2 > 15 && sayac2 <= 20)
            {
                grp2.Text = "İnternet";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("SELECT TOP 4 AY,INTERNET FROM TBL_GIDERLER ORDER BY ID DESC", baglanti.Baglanti());
                SqlDataReader dataReader = komut.ExecuteReader();
                while (dataReader.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dataReader[0], dataReader[1]));
                }
                baglanti.Baglanti().Close();
            }
            //Ekstra
            if (sayac2 > 20 && sayac2 <= 25)
            {
                grp2.Text = "Ekstra";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut = new SqlCommand("SELECT TOP 4 AY,EKSTRA FROM TBL_GIDERLER ORDER BY ID DESC", baglanti.Baglanti());
                SqlDataReader dataReader = komut.ExecuteReader();
                while (dataReader.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dataReader[0], dataReader[1]));
                }
                baglanti.Baglanti().Close();
            }
            if (sayac2 == 26)
            {
                sayac2 = 0;
            }
        }

    }
}