
namespace Ticari_Otomasyon
{
    partial class FrmRaporlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaporlar));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TBL_FIRMALARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TicariOtomasyonDataSet = new Ticari_Otomasyon.TicariOtomasyonDataSet();
            this.TBL_MUSTERILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TicariOtomasyonDataSet1 = new Ticari_Otomasyon.TicariOtomasyonDataSet1();
            this.TBL_FIRMALARTableAdapter = new Ticari_Otomasyon.TicariOtomasyonDataSetTableAdapters.TBL_FIRMALARTableAdapter();
            this.xtraTabPagePersonel = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewerPersonel = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPageGider = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewerGider = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPageMusteri = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewerMusteri = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPageFirma = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewerFirma = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TBL_MUSTERILERTableAdapter = new Ticari_Otomasyon.TicariOtomasyonDataSet1TableAdapters.TBL_MUSTERILERTableAdapter();
            this.TicariOtomasyonDataSet2 = new Ticari_Otomasyon.TicariOtomasyonDataSet2();
            this.TBL_GIDERLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBL_GIDERLERTableAdapter = new Ticari_Otomasyon.TicariOtomasyonDataSet2TableAdapters.TBL_GIDERLERTableAdapter();
            this.TicariOtomasyonDataSet3 = new Ticari_Otomasyon.TicariOtomasyonDataSet3();
            this.TBL_PERSONELLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBL_PERSONELLERTableAdapter = new Ticari_Otomasyon.TicariOtomasyonDataSet3TableAdapters.TBL_PERSONELLERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_FIRMALARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_MUSTERILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet1)).BeginInit();
            this.xtraTabPagePersonel.SuspendLayout();
            this.xtraTabPageGider.SuspendLayout();
            this.xtraTabPageMusteri.SuspendLayout();
            this.xtraTabPageFirma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_GIDERLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_PERSONELLERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TBL_FIRMALARBindingSource
            // 
            this.TBL_FIRMALARBindingSource.DataMember = "TBL_FIRMALAR";
            this.TBL_FIRMALARBindingSource.DataSource = this.TicariOtomasyonDataSet;
            // 
            // TicariOtomasyonDataSet
            // 
            this.TicariOtomasyonDataSet.DataSetName = "TicariOtomasyonDataSet";
            this.TicariOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBL_MUSTERILERBindingSource
            // 
            this.TBL_MUSTERILERBindingSource.DataMember = "TBL_MUSTERILER";
            this.TBL_MUSTERILERBindingSource.DataSource = this.TicariOtomasyonDataSet1;
            // 
            // TicariOtomasyonDataSet1
            // 
            this.TicariOtomasyonDataSet1.DataSetName = "TicariOtomasyonDataSet1";
            this.TicariOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBL_FIRMALARTableAdapter
            // 
            this.TBL_FIRMALARTableAdapter.ClearBeforeFill = true;
            // 
            // xtraTabPagePersonel
            // 
            this.xtraTabPagePersonel.Controls.Add(this.reportViewerPersonel);
            this.xtraTabPagePersonel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPagePersonel.ImageOptions.Image")));
            this.xtraTabPagePersonel.Name = "xtraTabPagePersonel";
            this.xtraTabPagePersonel.Size = new System.Drawing.Size(1938, 662);
            this.xtraTabPagePersonel.Text = "Personel Raporları";
            // 
            // reportViewerPersonel
            // 
            this.reportViewerPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TBL_PERSONELLERBindingSource;
            this.reportViewerPersonel.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerPersonel.LocalReport.ReportEmbeddedResource = "Ticari_Otomasyon.Raporlar.Personeller.rdlc";
            this.reportViewerPersonel.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPersonel.Name = "reportViewerPersonel";
            this.reportViewerPersonel.ServerReport.BearerToken = null;
            this.reportViewerPersonel.Size = new System.Drawing.Size(1938, 662);
            this.reportViewerPersonel.TabIndex = 0;
            // 
            // xtraTabPageGider
            // 
            this.xtraTabPageGider.Controls.Add(this.reportViewerGider);
            this.xtraTabPageGider.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageGider.ImageOptions.Image")));
            this.xtraTabPageGider.Name = "xtraTabPageGider";
            this.xtraTabPageGider.Size = new System.Drawing.Size(1938, 662);
            this.xtraTabPageGider.Text = "Gider Raporları";
            // 
            // reportViewerGider
            // 
            this.reportViewerGider.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.TBL_GIDERLERBindingSource;
            this.reportViewerGider.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerGider.LocalReport.ReportEmbeddedResource = "Ticari_Otomasyon.Raporlar.Giderler.rdlc";
            this.reportViewerGider.Location = new System.Drawing.Point(0, 0);
            this.reportViewerGider.Name = "reportViewerGider";
            this.reportViewerGider.ServerReport.BearerToken = null;
            this.reportViewerGider.Size = new System.Drawing.Size(1938, 662);
            this.reportViewerGider.TabIndex = 0;
            // 
            // xtraTabPageMusteri
            // 
            this.xtraTabPageMusteri.Controls.Add(this.reportViewerMusteri);
            this.xtraTabPageMusteri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageMusteri.ImageOptions.Image")));
            this.xtraTabPageMusteri.Name = "xtraTabPageMusteri";
            this.xtraTabPageMusteri.Size = new System.Drawing.Size(1938, 662);
            this.xtraTabPageMusteri.Text = "Musteri Raporları";
            // 
            // reportViewerMusteri
            // 
            this.reportViewerMusteri.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.TBL_MUSTERILERBindingSource;
            this.reportViewerMusteri.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerMusteri.LocalReport.ReportEmbeddedResource = "Ticari_Otomasyon.Raporlar.Musteriler.rdlc";
            this.reportViewerMusteri.Location = new System.Drawing.Point(0, 0);
            this.reportViewerMusteri.Name = "reportViewerMusteri";
            this.reportViewerMusteri.ServerReport.BearerToken = null;
            this.reportViewerMusteri.Size = new System.Drawing.Size(1938, 662);
            this.reportViewerMusteri.TabIndex = 0;
            // 
            // xtraTabPageFirma
            // 
            this.xtraTabPageFirma.Controls.Add(this.reportViewerFirma);
            this.xtraTabPageFirma.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageFirma.ImageOptions.Image")));
            this.xtraTabPageFirma.Name = "xtraTabPageFirma";
            this.xtraTabPageFirma.Size = new System.Drawing.Size(1938, 662);
            this.xtraTabPageFirma.Text = "Firma Raporları";
            // 
            // reportViewerFirma
            // 
            this.reportViewerFirma.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSetFirmalar";
            reportDataSource4.Value = this.TBL_FIRMALARBindingSource;
            this.reportViewerFirma.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewerFirma.LocalReport.ReportEmbeddedResource = "Ticari_Otomasyon.Raporlar.Firmalar.rdlc";
            this.reportViewerFirma.Location = new System.Drawing.Point(0, 0);
            this.reportViewerFirma.Name = "reportViewerFirma";
            this.reportViewerFirma.ServerReport.BearerToken = null;
            this.reportViewerFirma.Size = new System.Drawing.Size(1938, 662);
            this.reportViewerFirma.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageFirma;
            this.xtraTabControl1.Size = new System.Drawing.Size(1940, 692);
            this.xtraTabControl1.TabIndex = 5;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageFirma,
            this.xtraTabPageMusteri,
            this.xtraTabPageGider,
            this.xtraTabPagePersonel});
            // 
            // TBL_MUSTERILERTableAdapter
            // 
            this.TBL_MUSTERILERTableAdapter.ClearBeforeFill = true;
            // 
            // TicariOtomasyonDataSet2
            // 
            this.TicariOtomasyonDataSet2.DataSetName = "TicariOtomasyonDataSet2";
            this.TicariOtomasyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBL_GIDERLERBindingSource
            // 
            this.TBL_GIDERLERBindingSource.DataMember = "TBL_GIDERLER";
            this.TBL_GIDERLERBindingSource.DataSource = this.TicariOtomasyonDataSet2;
            // 
            // TBL_GIDERLERTableAdapter
            // 
            this.TBL_GIDERLERTableAdapter.ClearBeforeFill = true;
            // 
            // TicariOtomasyonDataSet3
            // 
            this.TicariOtomasyonDataSet3.DataSetName = "TicariOtomasyonDataSet3";
            this.TicariOtomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBL_PERSONELLERBindingSource
            // 
            this.TBL_PERSONELLERBindingSource.DataMember = "TBL_PERSONELLER";
            this.TBL_PERSONELLERBindingSource.DataSource = this.TicariOtomasyonDataSet3;
            // 
            // TBL_PERSONELLERTableAdapter
            // 
            this.TBL_PERSONELLERTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 692);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FrmRaporlar";
            this.Text = "RAPORLAR";
            this.Load += new System.EventHandler(this.FrmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBL_FIRMALARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_MUSTERILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet1)).EndInit();
            this.xtraTabPagePersonel.ResumeLayout(false);
            this.xtraTabPageGider.ResumeLayout(false);
            this.xtraTabPageMusteri.ResumeLayout(false);
            this.xtraTabPageFirma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_GIDERLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_PERSONELLERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource TBL_FIRMALARBindingSource;
        private TicariOtomasyonDataSet TicariOtomasyonDataSet;
        private TicariOtomasyonDataSetTableAdapters.TBL_FIRMALARTableAdapter TBL_FIRMALARTableAdapter;
        private DevExpress.XtraTab.XtraTabPage xtraTabPagePersonel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPersonel;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageGider;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerGider;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMusteri;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageFirma;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerFirma;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMusteri;
        private System.Windows.Forms.BindingSource TBL_MUSTERILERBindingSource;
        private TicariOtomasyonDataSet1 TicariOtomasyonDataSet1;
        private TicariOtomasyonDataSet1TableAdapters.TBL_MUSTERILERTableAdapter TBL_MUSTERILERTableAdapter;
        private System.Windows.Forms.BindingSource TBL_GIDERLERBindingSource;
        private TicariOtomasyonDataSet2 TicariOtomasyonDataSet2;
        private TicariOtomasyonDataSet2TableAdapters.TBL_GIDERLERTableAdapter TBL_GIDERLERTableAdapter;
        private System.Windows.Forms.BindingSource TBL_PERSONELLERBindingSource;
        private TicariOtomasyonDataSet3 TicariOtomasyonDataSet3;
        private TicariOtomasyonDataSet3TableAdapters.TBL_PERSONELLERTableAdapter TBL_PERSONELLERTableAdapter;
    }
}