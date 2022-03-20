
namespace Ticari_Otomasyon
{
    partial class FrmStoklar
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.grdStoklar = new DevExpress.XtraGrid.GridControl();
            this.gvStoklar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageUrun = new DevExpress.XtraTab.XtraTabPage();
            this.chartStoklar = new DevExpress.XtraCharts.ChartControl();
            this.xtraTabPageFırma = new DevExpress.XtraTab.XtraTabPage();
            this.chartControlFirma = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageUrun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.xtraTabPageFırma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStoklar
            // 
            this.grdStoklar.Dock = System.Windows.Forms.DockStyle.Left;
            this.grdStoklar.Location = new System.Drawing.Point(0, 0);
            this.grdStoklar.MainView = this.gvStoklar;
            this.grdStoklar.Name = "grdStoklar";
            this.grdStoklar.Size = new System.Drawing.Size(538, 692);
            this.grdStoklar.TabIndex = 3;
            this.grdStoklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStoklar});
            // 
            // gvStoklar
            // 
            this.gvStoklar.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvStoklar.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvStoklar.Appearance.Row.Options.UseBackColor = true;
            this.gvStoklar.GridControl = this.grdStoklar;
            this.gvStoklar.Name = "gvStoklar";
            this.gvStoklar.OptionsView.ShowGroupPanel = false;
            this.gvStoklar.DoubleClick += new System.EventHandler(this.gvStoklar_DoubleClick);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.xtraTabControl1.Location = new System.Drawing.Point(695, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageUrun;
            this.xtraTabControl1.Size = new System.Drawing.Size(1245, 692);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageUrun,
            this.xtraTabPageFırma});
            // 
            // xtraTabPageUrun
            // 
            this.xtraTabPageUrun.Controls.Add(this.chartStoklar);
            this.xtraTabPageUrun.Name = "xtraTabPageUrun";
            this.xtraTabPageUrun.Size = new System.Drawing.Size(1243, 662);
            this.xtraTabPageUrun.Text = "ÜRÜN - MİKTAR";
            // 
            // chartStoklar
            // 
            this.chartStoklar.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chartStoklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartStoklar.Legend.Name = "Default Legend";
            this.chartStoklar.Location = new System.Drawing.Point(0, 0);
            this.chartStoklar.Name = "chartStoklar";
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series Urun";
            series1.View = pieSeriesView1;
            this.chartStoklar.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartStoklar.Size = new System.Drawing.Size(1243, 662);
            this.chartStoklar.TabIndex = 2;
            // 
            // xtraTabPageFırma
            // 
            this.xtraTabPageFırma.Controls.Add(this.chartControlFirma);
            this.xtraTabPageFırma.Name = "xtraTabPageFırma";
            this.xtraTabPageFırma.Size = new System.Drawing.Size(1243, 662);
            this.xtraTabPageFırma.Text = "FİRMA - ŞEHİR";
            // 
            // chartControlFirma
            // 
            this.chartControlFirma.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            simpleDiagram3D1.RotationMatrixSerializable = "0.999906049796322;0;-0.0137073549861255;0;-0.011870917636676;0.5;-0.8659440405213" +
    "63;0;0.00685367749306274;0.866025403784439;0.499953024898161;0;0;0;0;1";
            this.chartControlFirma.Diagram = simpleDiagram3D1;
            this.chartControlFirma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlFirma.Legend.Name = "Default Legend";
            this.chartControlFirma.Location = new System.Drawing.Point(0, 0);
            this.chartControlFirma.Name = "chartControlFirma";
            series2.LegendTextPattern = "{A}";
            series2.Name = "Series Firma";
            series2.View = pie3DSeriesView1;
            this.chartControlFirma.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControlFirma.SeriesTemplate.LegendTextPattern = "{S}{A}";
            this.chartControlFirma.Size = new System.Drawing.Size(1243, 662);
            this.chartControlFirma.TabIndex = 2;
            // 
            // FrmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 692);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.grdStoklar);
            this.Name = "FrmStoklar";
            this.Text = "STOKLAR";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageUrun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStoklar)).EndInit();
            this.xtraTabPageFırma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlFirma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl grdStoklar;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStoklar;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageUrun;
        private DevExpress.XtraCharts.ChartControl chartStoklar;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageFırma;
        private DevExpress.XtraCharts.ChartControl chartControlFirma;
    }
}