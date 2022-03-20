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
    public partial class FrmBankalar : DevExpress.XtraEditors.XtraForm
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglanti = new SqlBaglantisi();

        void Listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Execute BANKABILGILERI", baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
            gridView1.BestFitColumns();
        }
        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            Listele();
            SehirListesi();
            FirmaListesi();
            Temizle();
        }
        void Temizle()
        {
            txtID.Text = "";
            txtBankaAdi.Text = "";
            txtHesapTuru.Text = "";
            txtSube.Text = "";
            txtYetkili.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            mskHesapNo.Text = "";
            mskIBAN.Text = "";
            mskTarih.Text = "";
            mskTelefon.Text = "";
            lookUpEditFirma.Text = "";
        }
        void SehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_ILLER", baglanti.Baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                cmbIl.Properties.Items.Add(dataReader[1]);
            }
            baglanti.Baglanti().Close();
        }

        void FirmaListesi()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select ID,AD from TBL_FIRMALAR", baglanti.Baglanti());
            dataAdapter.Fill(dataTable);
            lookUpEditFirma.Properties.ValueMember = "ID";
            lookUpEditFirma.Properties.DisplayMember = "AD";
            lookUpEditFirma.Properties.DataSource = dataTable;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_BANKALAR (BANKAADI, IL, ILCE, SUBE,IBAN,HESAPNO,YETKILI, TELEFON,TARIH,HESAPTURU,FIRMAID)" +
                "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtBankaAdi.Text);
            komut.Parameters.AddWithValue("@p2", cmbIl.Text);
            komut.Parameters.AddWithValue("@p3", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p4", txtSube.Text);
            komut.Parameters.AddWithValue("@p5", mskIBAN.Text);
            komut.Parameters.AddWithValue("@p6", mskHesapNo.Text);
            komut.Parameters.AddWithValue("@p7", txtYetkili.Text);
            komut.Parameters.AddWithValue("@p8", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p9", mskTarih.Text);
            komut.Parameters.AddWithValue("@p10", txtHesapTuru.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEditFirma.EditValue);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            Listele();
            MessageBox.Show("Banka Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE from TBL_ILCELER where SEHIR = @p1", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", cmbIl.SelectedIndex + 1);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                cmbIlce.Properties.Items.Add(dataReader[0]);
            }
            baglanti.Baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null)
            {
                txtID.Text = dataRow["ID"].ToString();
                txtBankaAdi.Text = dataRow["BANKAADI"].ToString();
                cmbIl.Text = dataRow["IL"].ToString();
                cmbIlce.Text = dataRow["ILCE"].ToString();
                txtSube.Text = dataRow["SUBE"].ToString();
                mskIBAN.Text = dataRow["IBAN"].ToString();
                mskHesapNo.Text = dataRow["HESAPNO"].ToString();
                txtYetkili.Text = dataRow["YETKILI"].ToString();
                mskTelefon.Text = dataRow["TELEFON"].ToString();
                mskTarih.Text = dataRow["TARIH"].ToString();
                txtHesapTuru.Text = dataRow["HESAPTURU"].ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_BANKALAR where ID = @p1", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            Temizle();
            MessageBox.Show("Banka Bilgisi Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_BANKALAR set BANKAADI=@p1, IL=@p2, ILCE=@p3, SUBE=@p4,IBAN=@p5,HESAPNO=@p6,YETKILI=@p7," +
                " TELEFON=@p8,TARIH=@p9,HESAPTURU=@p10,FIRMAID=@p11 where ID = @p12", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtBankaAdi.Text);
            komut.Parameters.AddWithValue("@p2", cmbIl.Text);
            komut.Parameters.AddWithValue("@p3", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p4", txtSube.Text);
            komut.Parameters.AddWithValue("@p5", mskIBAN.Text);
            komut.Parameters.AddWithValue("@p6", mskHesapNo.Text);
            komut.Parameters.AddWithValue("@p7", txtYetkili.Text);
            komut.Parameters.AddWithValue("@p8", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p9", mskTarih.Text);
            komut.Parameters.AddWithValue("@p10", txtHesapTuru.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEditFirma.EditValue);
            komut.Parameters.AddWithValue("@p12", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Baglanti().Close();
            Listele();
            MessageBox.Show("Banka Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}