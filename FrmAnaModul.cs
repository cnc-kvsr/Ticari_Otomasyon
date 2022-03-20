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
    public partial class FrmAnaModul : Form
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }

        public string kullanici;
        private void FrmAnaModul_Load(object sender, EventArgs e)
        {
            FrmAnaSayfa frmAnaSayfa = (FrmAnaSayfa)Application.OpenForms["frmAnaSayfa"];
            if (frmAnaSayfa == null)
            {
                frmAnaSayfa = new FrmAnaSayfa();
                frmAnaSayfa.MdiParent = this;
                frmAnaSayfa.Show();
            }
            frmAnaSayfa.Activate();
        }
        FrmUrunler frmUrunler;
        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FrmUrunler frmUrunler = (FrmUrunler)Application.OpenForms["frmUrunler"];
            
            if (frmUrunler == null || frmUrunler.IsDisposed)
            {
                frmUrunler = new FrmUrunler();
                frmUrunler.MdiParent = this;
                frmUrunler.Show();
            }
            frmUrunler.Activate();

        }
        
        private void btnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMusteriler frmMusteriler = (FrmMusteriler)Application.OpenForms["frmMusteriler"];

            if (frmMusteriler == null)
            {
                frmMusteriler = new FrmMusteriler();
                frmMusteriler.MdiParent = this;
                frmMusteriler.Show();
            }
            frmMusteriler.Activate();
        }

        private void btnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFirmalar frmFirmalar = (FrmFirmalar)Application.OpenForms["frmFirmalar"];

            if (frmFirmalar == null)
            {
                frmFirmalar = new FrmFirmalar();
                frmFirmalar.MdiParent = this;
                frmFirmalar.Show();
            }
            frmFirmalar.Activate();
        }

        FrmPersoneller frmPersonel;
        private void btnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FrmPersoneller frmPersonel = (FrmPersoneller)Application.OpenForms["frmPersonel"];

            if (frmPersonel==null || frmPersonel.IsDisposed)
            {
                frmPersonel = new FrmPersoneller();
                frmPersonel.MdiParent = this;
                frmPersonel.Show();
            }
            frmPersonel.Activate();
        }

        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRehber frmRehber = (FrmRehber)Application.OpenForms["frmRehber"];

            if(frmRehber == null)
            {
                frmRehber = new FrmRehber();
                frmRehber.MdiParent = this;
                frmRehber.Show();
            }
            frmRehber.Activate();
        }

        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGiderler frmGiderler = (FrmGiderler)Application.OpenForms["frmGiderler"];

            if (frmGiderler == null)
            {
                frmGiderler = new FrmGiderler();
                frmGiderler.MdiParent = this;
                frmGiderler.Show();
            }
            frmGiderler.Activate();
        }

        private void btnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBankalar frmBankalar = (FrmBankalar)Application.OpenForms["frmBankalar"];

            if (frmBankalar == null)
            {
                frmBankalar = new FrmBankalar();
                frmBankalar.MdiParent = this;
                frmBankalar.Show();
            }
            frmBankalar.Activate();
        }

        private void btnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFaturalar frmFaturalar = (FrmFaturalar)Application.OpenForms["frmFaturalar"];

            if (frmFaturalar == null)
            {
                frmFaturalar = new FrmFaturalar();
                frmFaturalar.MdiParent = this;
                frmFaturalar.Show();
            }
            frmFaturalar.Activate();
        }

        private void btnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNotlar frmNotlar = (FrmNotlar)Application.OpenForms["frmNotlar"];
            if (frmNotlar == null)
            {
                frmNotlar = new FrmNotlar();
                frmNotlar.MdiParent = this;
                frmNotlar.Show();
            }
            frmNotlar.Activate();
        }

        private void btnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmHareketler frmHareketler = (FrmHareketler)Application.OpenForms["frmHareketler"];
            if (frmHareketler == null)
            {
                frmHareketler = new FrmHareketler();
                frmHareketler.MdiParent = this;
                frmHareketler.Show();
            }
            frmHareketler.Activate();
        }

        private void btnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRaporlar frmRaporlar = (FrmRaporlar)Application.OpenForms["frmRaporlar"];
            if (frmRaporlar==null)
            {
                frmRaporlar = new FrmRaporlar();
                frmRaporlar.MdiParent = this;
                frmRaporlar.Show();
            }
            frmRaporlar.Activate();
        }

        private void btnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStoklar frmStoklar = (FrmStoklar)Application.OpenForms["frmStoklar"];
            if (frmStoklar == null)
            {
                frmStoklar = new FrmStoklar();
                frmStoklar.MdiParent = this;
                frmStoklar.Show();
            }
            frmStoklar.Activate();
        }

        private void btnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAyarlar frmAyarlar = (FrmAyarlar)Application.OpenForms["frmAyarlar"];
            if (frmAyarlar == null)
            {
                frmAyarlar = new FrmAyarlar();
                frmAyarlar.ShowDialog();
            }
            frmAyarlar.Activate();
        }

        private void btnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasa frmKasa = (FrmKasa)Application.OpenForms["frmKasa"];
            if (frmKasa == null)
            {
                frmKasa = new FrmKasa();
                frmKasa.ad = kullanici;
                frmKasa.MdiParent = this;
                frmKasa.Show();
            }
            frmKasa.Activate();
        }

        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAnaSayfa frmAnaSayfa = (FrmAnaSayfa)Application.OpenForms["frmAnaSayfa"];
            if (frmAnaSayfa == null)
            {
                frmAnaSayfa = new FrmAnaSayfa();
                frmAnaSayfa.MdiParent = this;
                frmAnaSayfa.Show();
            }
            frmAnaSayfa.Activate();
        }
    }
}
