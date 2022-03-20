
namespace Ticari_Otomasyon
{
    partial class FrmHareketler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHareketler));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.grdMusteri = new DevExpress.XtraGrid.GridControl();
            this.gvMusteri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.grdFirma = new DevExpress.XtraGrid.GridControl();
            this.gvFirma = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMusteri)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1940, 692);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.grdMusteri);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1938, 662);
            this.xtraTabPage1.Text = "Müşteri Hareketleri";
            // 
            // grdMusteri
            // 
            this.grdMusteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMusteri.Location = new System.Drawing.Point(0, 0);
            this.grdMusteri.MainView = this.gvMusteri;
            this.grdMusteri.Name = "grdMusteri";
            this.grdMusteri.Size = new System.Drawing.Size(1938, 662);
            this.grdMusteri.TabIndex = 0;
            this.grdMusteri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMusteri});
            // 
            // gvMusteri
            // 
            this.gvMusteri.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvMusteri.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvMusteri.Appearance.Row.Options.UseBackColor = true;
            this.gvMusteri.GridControl = this.grdMusteri;
            this.gvMusteri.Name = "gvMusteri";
            this.gvMusteri.OptionsView.ShowGroupPanel = false;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.grdFirma);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1938, 662);
            this.xtraTabPage2.Text = "Firma Hareketleri";
            // 
            // grdFirma
            // 
            this.grdFirma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFirma.Location = new System.Drawing.Point(0, 0);
            this.grdFirma.MainView = this.gvFirma;
            this.grdFirma.Name = "grdFirma";
            this.grdFirma.Size = new System.Drawing.Size(1938, 662);
            this.grdFirma.TabIndex = 1;
            this.grdFirma.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFirma});
            // 
            // gvFirma
            // 
            this.gvFirma.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvFirma.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvFirma.Appearance.Row.Options.UseBackColor = true;
            this.gvFirma.GridControl = this.grdFirma;
            this.gvFirma.Name = "gvFirma";
            this.gvFirma.OptionsView.ShowGroupPanel = false;
            // 
            // FrmHareketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 692);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FrmHareketler";
            this.Text = "HAREKETLER";
            this.Load += new System.EventHandler(this.FrmHareketler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMusteri)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFirma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl grdMusteri;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMusteri;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl grdFirma;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFirma;
    }
}