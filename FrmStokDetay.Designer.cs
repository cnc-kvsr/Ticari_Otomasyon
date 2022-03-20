
namespace Ticari_Otomasyon
{
    partial class FrmStokDetay
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
            this.gvStokDetay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdStokDetay = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gvStokDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStokDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // gvStokDetay
            // 
            this.gvStokDetay.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvStokDetay.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvStokDetay.Appearance.Row.Options.UseBackColor = true;
            this.gvStokDetay.GridControl = this.grdStokDetay;
            this.gvStokDetay.Name = "gvStokDetay";
            // 
            // grdStokDetay
            // 
            this.grdStokDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdStokDetay.Location = new System.Drawing.Point(0, 0);
            this.grdStokDetay.MainView = this.gvStokDetay;
            this.grdStokDetay.Name = "grdStokDetay";
            this.grdStokDetay.Size = new System.Drawing.Size(1504, 408);
            this.grdStokDetay.TabIndex = 1;
            this.grdStokDetay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStokDetay});
            // 
            // FrmStokDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1504, 408);
            this.Controls.Add(this.grdStokDetay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStokDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOK DETAY";
            this.Load += new System.EventHandler(this.FrmStokDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStokDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStokDetay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvStokDetay;
        private DevExpress.XtraGrid.GridControl grdStokDetay;
    }
}