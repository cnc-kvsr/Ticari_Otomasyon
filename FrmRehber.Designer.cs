
namespace Ticari_Otomasyon
{
    partial class FrmRehber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRehber));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.grdMusteriler = new DevExpress.XtraGrid.GridControl();
            this.gvMusteriler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.grdFirmalar = new DevExpress.XtraGrid.GridControl();
            this.gvFirmalar = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMusteriler)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFirmalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFirmalar)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1940, 692);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.grdMusteriler);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1938, 662);
            this.xtraTabPage1.Text = "Müşteriler";
            // 
            // grdMusteriler
            // 
            this.grdMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMusteriler.Location = new System.Drawing.Point(0, 0);
            this.grdMusteriler.MainView = this.gvMusteriler;
            this.grdMusteriler.Name = "grdMusteriler";
            this.grdMusteriler.Size = new System.Drawing.Size(1938, 662);
            this.grdMusteriler.TabIndex = 0;
            this.grdMusteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMusteriler});
            // 
            // gvMusteriler
            // 
            this.gvMusteriler.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvMusteriler.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvMusteriler.Appearance.Row.Options.UseBackColor = true;
            this.gvMusteriler.GridControl = this.grdMusteriler;
            this.gvMusteriler.Name = "gvMusteriler";
            this.gvMusteriler.OptionsView.ShowGroupPanel = false;
            this.gvMusteriler.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.grdFirmalar);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1938, 662);
            this.xtraTabPage2.Text = "Firmalar";
            // 
            // grdFirmalar
            // 
            this.grdFirmalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFirmalar.Location = new System.Drawing.Point(0, 0);
            this.grdFirmalar.MainView = this.gvFirmalar;
            this.grdFirmalar.Name = "grdFirmalar";
            this.grdFirmalar.Size = new System.Drawing.Size(1938, 662);
            this.grdFirmalar.TabIndex = 1;
            this.grdFirmalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFirmalar});
            // 
            // gvFirmalar
            // 
            this.gvFirmalar.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvFirmalar.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvFirmalar.Appearance.Row.Options.UseBackColor = true;
            this.gvFirmalar.GridControl = this.grdFirmalar;
            this.gvFirmalar.Name = "gvFirmalar";
            this.gvFirmalar.OptionsView.ShowGroupPanel = false;
            this.gvFirmalar.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
            // 
            // FrmRehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 692);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FrmRehber";
            this.Text = "REHBER";
            this.Load += new System.EventHandler(this.FrmRehber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMusteriler)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFirmalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFirmalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl grdMusteriler;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMusteriler;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl grdFirmalar;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFirmalar;
    }
}