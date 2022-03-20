using DevExpress.XtraEditors;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmRaporlar : DevExpress.XtraEditors.XtraForm
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'TicariOtomasyonDataSet3.TBL_PERSONELLER' table. You can move, or remove it, as needed.
            this.TBL_PERSONELLERTableAdapter.Fill(this.TicariOtomasyonDataSet3.TBL_PERSONELLER);
            // TODO: This line of code loads data into the 'TicariOtomasyonDataSet2.TBL_GIDERLER' table. You can move, or remove it, as needed.
            this.TBL_GIDERLERTableAdapter.Fill(this.TicariOtomasyonDataSet2.TBL_GIDERLER);
            // TODO: This line of code loads data into the 'TicariOtomasyonDataSet1.TBL_MUSTERILER' table. You can move, or remove it, as needed.
            this.TBL_MUSTERILERTableAdapter.Fill(this.TicariOtomasyonDataSet1.TBL_MUSTERILER);
            // TODO: This line of code loads data into the 'TicariOtomasyonDataSet.TBL_FIRMALAR' table. You can move, or remove it, as needed.
            this.TBL_FIRMALARTableAdapter.Fill(this.TicariOtomasyonDataSet.TBL_FIRMALAR);
            this.reportViewerFirma.RefreshReport();
            this.reportViewerGider.RefreshReport();
            this.reportViewerPersonel.RefreshReport();
            this.reportViewerMusteri.RefreshReport();
        }

    }
}