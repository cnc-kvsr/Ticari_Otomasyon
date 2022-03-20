
namespace Ticari_Otomasyon
{
    partial class FrmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            this.grdUrunler = new DevExpress.XtraGrid.GridControl();
            this.gvUrunler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtDetay = new System.Windows.Forms.RichTextBox();
            this.lblDetay = new DevExpress.XtraEditors.LabelControl();
            this.txtSatısFiyat = new DevExpress.XtraEditors.TextEdit();
            this.lblSatısFiyat = new DevExpress.XtraEditors.LabelControl();
            this.txtAlısFiyat = new DevExpress.XtraEditors.TextEdit();
            this.lblAlısFiyat = new DevExpress.XtraEditors.LabelControl();
            this.lblAdet = new DevExpress.XtraEditors.LabelControl();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.mskYil = new System.Windows.Forms.MaskedTextBox();
            this.lblYıl = new DevExpress.XtraEditors.LabelControl();
            this.txtModel = new DevExpress.XtraEditors.TextEdit();
            this.lblModel = new DevExpress.XtraEditors.LabelControl();
            this.txtMarka = new DevExpress.XtraEditors.TextEdit();
            this.lblMarka = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatısFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlısFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUrunler
            // 
            this.grdUrunler.Dock = System.Windows.Forms.DockStyle.Left;
            this.grdUrunler.Location = new System.Drawing.Point(0, 0);
            this.grdUrunler.MainView = this.gvUrunler;
            this.grdUrunler.Name = "grdUrunler";
            this.grdUrunler.Size = new System.Drawing.Size(1436, 692);
            this.grdUrunler.TabIndex = 0;
            this.grdUrunler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUrunler});
            // 
            // gvUrunler
            // 
            this.gvUrunler.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvUrunler.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvUrunler.Appearance.Row.Options.UseBackColor = true;
            this.gvUrunler.GridControl = this.grdUrunler;
            this.gvUrunler.Name = "gvUrunler";
            this.gvUrunler.OptionsView.ShowGroupPanel = false;
            this.gvUrunler.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.btnGüncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.txtDetay);
            this.groupControl1.Controls.Add(this.lblDetay);
            this.groupControl1.Controls.Add(this.txtSatısFiyat);
            this.groupControl1.Controls.Add(this.lblSatısFiyat);
            this.groupControl1.Controls.Add(this.txtAlısFiyat);
            this.groupControl1.Controls.Add(this.lblAlısFiyat);
            this.groupControl1.Controls.Add(this.lblAdet);
            this.groupControl1.Controls.Add(this.nudAdet);
            this.groupControl1.Controls.Add(this.mskYil);
            this.groupControl1.Controls.Add(this.lblYıl);
            this.groupControl1.Controls.Add(this.txtModel);
            this.groupControl1.Controls.Add(this.lblModel);
            this.groupControl1.Controls.Add(this.txtMarka);
            this.groupControl1.Controls.Add(this.lblMarka);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.lblAd);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.lblID);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(1562, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(378, 692);
            this.groupControl1.TabIndex = 1;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(111, 600);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(234, 37);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Appearance.Options.UseFont = true;
            this.btnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ImageOptions.Image")));
            this.btnGüncelle.Location = new System.Drawing.Point(111, 557);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(234, 37);
            this.btnGüncelle.TabIndex = 11;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(111, 519);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(234, 37);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(111, 481);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(234, 37);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtDetay
            // 
            this.txtDetay.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDetay.Location = new System.Drawing.Point(111, 359);
            this.txtDetay.Name = "txtDetay";
            this.txtDetay.Size = new System.Drawing.Size(234, 116);
            this.txtDetay.TabIndex = 8;
            this.txtDetay.Text = "";
            // 
            // lblDetay
            // 
            this.lblDetay.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDetay.Appearance.Options.UseFont = true;
            this.lblDetay.Location = new System.Drawing.Point(54, 363);
            this.lblDetay.Name = "lblDetay";
            this.lblDetay.Size = new System.Drawing.Size(51, 22);
            this.lblDetay.TabIndex = 20;
            this.lblDetay.Text = "Detay:";
            // 
            // txtSatısFiyat
            // 
            this.txtSatısFiyat.Location = new System.Drawing.Point(111, 319);
            this.txtSatısFiyat.Name = "txtSatısFiyat";
            this.txtSatısFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatısFiyat.Properties.Appearance.Options.UseFont = true;
            this.txtSatısFiyat.Size = new System.Drawing.Size(234, 28);
            this.txtSatısFiyat.TabIndex = 7;
            // 
            // lblSatısFiyat
            // 
            this.lblSatısFiyat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatısFiyat.Appearance.Options.UseFont = true;
            this.lblSatısFiyat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSatısFiyat.Location = new System.Drawing.Point(19, 323);
            this.lblSatısFiyat.Name = "lblSatısFiyat";
            this.lblSatısFiyat.Size = new System.Drawing.Size(86, 22);
            this.lblSatısFiyat.TabIndex = 18;
            this.lblSatısFiyat.Text = "Satış Fiyat:";
            // 
            // txtAlısFiyat
            // 
            this.txtAlısFiyat.Location = new System.Drawing.Point(111, 279);
            this.txtAlısFiyat.Name = "txtAlısFiyat";
            this.txtAlısFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlısFiyat.Properties.Appearance.Options.UseFont = true;
            this.txtAlısFiyat.Size = new System.Drawing.Size(234, 28);
            this.txtAlısFiyat.TabIndex = 6;
            // 
            // lblAlısFiyat
            // 
            this.lblAlısFiyat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlısFiyat.Appearance.Options.UseFont = true;
            this.lblAlısFiyat.Location = new System.Drawing.Point(29, 283);
            this.lblAlısFiyat.Name = "lblAlısFiyat";
            this.lblAlısFiyat.Size = new System.Drawing.Size(76, 22);
            this.lblAlısFiyat.TabIndex = 16;
            this.lblAlısFiyat.Text = "Alış Fiyat:";
            // 
            // lblAdet
            // 
            this.lblAdet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.Appearance.Options.UseFont = true;
            this.lblAdet.Location = new System.Drawing.Point(63, 243);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(42, 22);
            this.lblAdet.TabIndex = 15;
            this.lblAdet.Text = "Adet:";
            // 
            // nudAdet
            // 
            this.nudAdet.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAdet.Location = new System.Drawing.Point(111, 238);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(234, 29);
            this.nudAdet.TabIndex = 5;
            // 
            // mskYil
            // 
            this.mskYil.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskYil.Location = new System.Drawing.Point(111, 197);
            this.mskYil.Mask = "0000";
            this.mskYil.Name = "mskYil";
            this.mskYil.Size = new System.Drawing.Size(234, 29);
            this.mskYil.TabIndex = 4;
            this.mskYil.ValidatingType = typeof(int);
            // 
            // lblYıl
            // 
            this.lblYıl.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYıl.Appearance.Options.UseFont = true;
            this.lblYıl.Location = new System.Drawing.Point(81, 203);
            this.lblYıl.Name = "lblYıl";
            this.lblYıl.Size = new System.Drawing.Size(24, 22);
            this.lblYıl.TabIndex = 12;
            this.lblYıl.Text = "Yıl:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(111, 157);
            this.txtModel.Name = "txtModel";
            this.txtModel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModel.Properties.Appearance.Options.UseFont = true;
            this.txtModel.Size = new System.Drawing.Size(234, 28);
            this.txtModel.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.Appearance.Options.UseFont = true;
            this.lblModel.Location = new System.Drawing.Point(52, 163);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(53, 22);
            this.lblModel.TabIndex = 8;
            this.lblModel.Text = "Model:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(111, 117);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarka.Properties.Appearance.Options.UseFont = true;
            this.txtMarka.Size = new System.Drawing.Size(234, 28);
            this.txtMarka.TabIndex = 2;
            // 
            // lblMarka
            // 
            this.lblMarka.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Appearance.Options.UseFont = true;
            this.lblMarka.Location = new System.Drawing.Point(52, 123);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(53, 22);
            this.lblMarka.TabIndex = 6;
            this.lblMarka.Text = "Marka:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(111, 77);
            this.txtAd.Name = "txtAd";
            this.txtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Properties.Appearance.Options.UseFont = true;
            this.txtAd.Size = new System.Drawing.Size(234, 28);
            this.txtAd.TabIndex = 1;
            // 
            // lblAd
            // 
            this.lblAd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Appearance.Options.UseFont = true;
            this.lblAd.Location = new System.Drawing.Point(78, 83);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(27, 22);
            this.lblAd.TabIndex = 4;
            this.lblAd.Text = "Ad:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(111, 37);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(234, 28);
            this.txtID.TabIndex = 15;
            // 
            // lblID
            // 
            this.lblID.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Appearance.Options.UseFont = true;
            this.lblID.Location = new System.Drawing.Point(80, 43);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 22);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 692);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grdUrunler);
            this.Name = "FrmUrunler";
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatısFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlısFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdUrunler;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUrunler;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox txtDetay;
        private DevExpress.XtraEditors.LabelControl lblDetay;
        private DevExpress.XtraEditors.TextEdit txtSatısFiyat;
        private DevExpress.XtraEditors.LabelControl lblSatısFiyat;
        private DevExpress.XtraEditors.TextEdit txtAlısFiyat;
        private DevExpress.XtraEditors.LabelControl lblAlısFiyat;
        private DevExpress.XtraEditors.LabelControl lblAdet;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.MaskedTextBox mskYil;
        private DevExpress.XtraEditors.LabelControl lblYıl;
        private DevExpress.XtraEditors.TextEdit txtModel;
        private DevExpress.XtraEditors.LabelControl lblModel;
        private DevExpress.XtraEditors.TextEdit txtMarka;
        private DevExpress.XtraEditors.LabelControl lblMarka;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl lblAd;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
    }
}