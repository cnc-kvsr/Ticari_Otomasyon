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
    public partial class FrmAdmin : DevExpress.XtraEditors.XtraForm
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglanti = new SqlBaglantisi();
        private void btnGirisYap_MouseHover(object sender, EventArgs e)
        {
            btnGirisYap.BackColor = Color.Blue;
        }

        private void btnGirisYap_MouseLeave(object sender, EventArgs e)
        {
            btnGirisYap.BackColor = Color.DimGray;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_ADMIN where KULLANICIAD = @P1 AND SIFRE =@P2", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@P1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@P2", txtSifre.Text);
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                this.Hide();
                FrmAnaModul frmAnaModul = new FrmAnaModul();
                frmAnaModul.kullanici = txtKullaniciAdi.Text;
                frmAnaModul.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglanti.Baglanti().Close();
        }

        private void txtSifre_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lblSifre_Click(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lblKullaniciAdi_Click(object sender, EventArgs e)
        {

        }
    }
}