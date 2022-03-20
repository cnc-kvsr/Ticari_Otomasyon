
namespace Ticari_Otomasyon
{
    partial class FrmPersoneller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersoneller));
            this.gvPersoneller = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdPersoneller = new DevExpress.XtraGrid.GridControl();
            this.cmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbIl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtGorev = new DevExpress.XtraEditors.TextEdit();
            this.lblGorev = new DevExpress.XtraEditors.LabelControl();
            this.lblIlce = new DevExpress.XtraEditors.LabelControl();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.lblAdres = new DevExpress.XtraEditors.LabelControl();
            this.lblIl = new DevExpress.XtraEditors.LabelControl();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.lblMail = new DevExpress.XtraEditors.LabelControl();
            this.lblTC = new DevExpress.XtraEditors.LabelControl();
            this.lblTelefon = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.lblSoyad = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.ımageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.ımageSlider2 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.ımageSlider3 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.ımageSlider4 = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersoneller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersoneller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider4)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPersoneller
            // 
            this.gvPersoneller.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvPersoneller.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvPersoneller.Appearance.Row.Options.UseBackColor = true;
            this.gvPersoneller.GridControl = this.grdPersoneller;
            this.gvPersoneller.Name = "gvPersoneller";
            this.gvPersoneller.OptionsView.ShowGroupPanel = false;
            this.gvPersoneller.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // grdPersoneller
            // 
            this.grdPersoneller.Location = new System.Drawing.Point(0, 0);
            this.grdPersoneller.MainView = this.gvPersoneller;
            this.grdPersoneller.Name = "grdPersoneller";
            this.grdPersoneller.Size = new System.Drawing.Size(1413, 458);
            this.grdPersoneller.TabIndex = 4;
            this.grdPersoneller.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPersoneller});
            // 
            // cmbIlce
            // 
            this.cmbIlce.Location = new System.Drawing.Point(116, 305);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIlce.Properties.Appearance.Options.UseFont = true;
            this.cmbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIlce.Size = new System.Drawing.Size(234, 28);
            this.cmbIlce.TabIndex = 7;
            // 
            // cmbIl
            // 
            this.cmbIl.Location = new System.Drawing.Point(116, 267);
            this.cmbIl.Name = "cmbIl";
            this.cmbIl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIl.Properties.Appearance.Options.UseFont = true;
            this.cmbIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIl.Size = new System.Drawing.Size(234, 28);
            this.cmbIl.TabIndex = 6;
            this.cmbIl.SelectedIndexChanged += new System.EventHandler(this.cmbIl_SelectedIndexChanged);
            // 
            // mskTC
            // 
            this.mskTC.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTC.Location = new System.Drawing.Point(116, 190);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(234, 29);
            this.mskTC.TabIndex = 4;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // mskTelefon
            // 
            this.mskTelefon.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.Location = new System.Drawing.Point(116, 151);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(234, 29);
            this.mskTelefon.TabIndex = 3;
            // 
            // txtGorev
            // 
            this.txtGorev.Location = new System.Drawing.Point(116, 343);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGorev.Properties.Appearance.Options.UseFont = true;
            this.txtGorev.Size = new System.Drawing.Size(234, 28);
            this.txtGorev.TabIndex = 8;
            // 
            // lblGorev
            // 
            this.lblGorev.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGorev.Appearance.Options.UseFont = true;
            this.lblGorev.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGorev.Location = new System.Drawing.Point(57, 349);
            this.lblGorev.Name = "lblGorev";
            this.lblGorev.Size = new System.Drawing.Size(52, 22);
            this.lblGorev.TabIndex = 28;
            this.lblGorev.Text = "Görev:";
            // 
            // lblIlce
            // 
            this.lblIlce.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlce.Appearance.Options.UseFont = true;
            this.lblIlce.Location = new System.Drawing.Point(75, 313);
            this.lblIlce.Name = "lblIlce";
            this.lblIlce.Size = new System.Drawing.Size(34, 22);
            this.lblIlce.TabIndex = 26;
            this.lblIlce.Text = "İlçe:";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Appearance.Options.UseFont = true;
            this.btnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ImageOptions.Image")));
            this.btnGüncelle.Location = new System.Drawing.Point(116, 597);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(234, 37);
            this.btnGüncelle.TabIndex = 25;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(116, 552);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(234, 37);
            this.btnSil.TabIndex = 24;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(116, 507);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(234, 37);
            this.btnKaydet.TabIndex = 23;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(116, 381);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(234, 116);
            this.txtAdres.TabIndex = 9;
            this.txtAdres.Text = "";
            // 
            // lblAdres
            // 
            this.lblAdres.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Appearance.Options.UseFont = true;
            this.lblAdres.Location = new System.Drawing.Point(59, 381);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(50, 22);
            this.lblAdres.TabIndex = 20;
            this.lblAdres.Text = "Adres:";
            // 
            // lblIl
            // 
            this.lblIl.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIl.Appearance.Options.UseFont = true;
            this.lblIl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblIl.Location = new System.Drawing.Point(92, 274);
            this.lblIl.Name = "lblIl";
            this.lblIl.Size = new System.Drawing.Size(17, 22);
            this.lblIl.TabIndex = 18;
            this.lblIl.Text = "İl:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(116, 229);
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Properties.Appearance.Options.UseFont = true;
            this.txtMail.Size = new System.Drawing.Size(234, 28);
            this.txtMail.TabIndex = 5;
            // 
            // lblMail
            // 
            this.lblMail.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Appearance.Options.UseFont = true;
            this.lblMail.Location = new System.Drawing.Point(72, 235);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(37, 22);
            this.lblMail.TabIndex = 16;
            this.lblMail.Text = "Mail:";
            // 
            // lblTC
            // 
            this.lblTC.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Appearance.Options.UseFont = true;
            this.lblTC.Location = new System.Drawing.Point(81, 196);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(28, 22);
            this.lblTC.TabIndex = 15;
            this.lblTC.Text = "TC:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Appearance.Options.UseFont = true;
            this.lblTelefon.Location = new System.Drawing.Point(44, 157);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(65, 22);
            this.lblTelefon.TabIndex = 8;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(116, 113);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtSoyad.Size = new System.Drawing.Size(234, 28);
            this.txtSoyad.TabIndex = 2;
            // 
            // lblSoyad
            // 
            this.lblSoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Appearance.Options.UseFont = true;
            this.lblSoyad.Location = new System.Drawing.Point(55, 119);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(54, 22);
            this.lblSoyad.TabIndex = 6;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(116, 75);
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
            this.lblAd.Location = new System.Drawing.Point(82, 81);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(27, 22);
            this.lblAd.TabIndex = 4;
            this.lblAd.Text = "Ad:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(116, 37);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(234, 28);
            this.txtID.TabIndex = 100;
            // 
            // lblID
            // 
            this.lblID.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Appearance.Options.UseFont = true;
            this.lblID.Location = new System.Drawing.Point(84, 43);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 22);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.cmbIlce);
            this.groupControl1.Controls.Add(this.cmbIl);
            this.groupControl1.Controls.Add(this.mskTC);
            this.groupControl1.Controls.Add(this.mskTelefon);
            this.groupControl1.Controls.Add(this.txtGorev);
            this.groupControl1.Controls.Add(this.lblGorev);
            this.groupControl1.Controls.Add(this.lblIlce);
            this.groupControl1.Controls.Add(this.btnGüncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.txtAdres);
            this.groupControl1.Controls.Add(this.lblAdres);
            this.groupControl1.Controls.Add(this.lblIl);
            this.groupControl1.Controls.Add(this.txtMail);
            this.groupControl1.Controls.Add(this.lblMail);
            this.groupControl1.Controls.Add(this.lblTC);
            this.groupControl1.Controls.Add(this.lblTelefon);
            this.groupControl1.Controls.Add(this.txtSoyad);
            this.groupControl1.Controls.Add(this.lblSoyad);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.lblAd);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.lblID);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(1562, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(378, 760);
            this.groupControl1.TabIndex = 5;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(116, 642);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(234, 37);
            this.btnTemizle.TabIndex = 26;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // ımageSlider1
            // 
            this.ımageSlider1.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.ımageSlider1.AutoSlideInterval = 5000;
            this.ımageSlider1.CurrentImageIndex = 0;
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images1"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images2"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images3"))));
            this.ımageSlider1.Location = new System.Drawing.Point(1068, 464);
            this.ımageSlider1.Name = "ımageSlider1";
            this.ımageSlider1.Size = new System.Drawing.Size(338, 283);
            this.ımageSlider1.TabIndex = 9;
            this.ımageSlider1.Text = "ımageSlider1";
            // 
            // ımageSlider2
            // 
            this.ımageSlider2.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.ımageSlider2.AutoSlideInterval = 5000;
            this.ımageSlider2.CurrentImageIndex = 0;
            this.ımageSlider2.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider2.Images"))));
            this.ımageSlider2.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider2.Images1"))));
            this.ımageSlider2.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider2.Images2"))));
            this.ımageSlider2.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider2.Images3"))));
            this.ımageSlider2.Location = new System.Drawing.Point(713, 464);
            this.ımageSlider2.Name = "ımageSlider2";
            this.ımageSlider2.Size = new System.Drawing.Size(338, 283);
            this.ımageSlider2.TabIndex = 10;
            this.ımageSlider2.Text = "ımageSlider2";
            // 
            // ımageSlider3
            // 
            this.ımageSlider3.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.ımageSlider3.AutoSlideInterval = 5000;
            this.ımageSlider3.CurrentImageIndex = 0;
            this.ımageSlider3.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider3.Images"))));
            this.ımageSlider3.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider3.Images1"))));
            this.ımageSlider3.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider3.Images2"))));
            this.ımageSlider3.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider3.Images3"))));
            this.ımageSlider3.Location = new System.Drawing.Point(358, 464);
            this.ımageSlider3.Name = "ımageSlider3";
            this.ımageSlider3.Size = new System.Drawing.Size(338, 283);
            this.ımageSlider3.TabIndex = 11;
            this.ımageSlider3.Text = "ımageSlider3";
            // 
            // ımageSlider4
            // 
            this.ımageSlider4.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.ımageSlider4.AutoSlideInterval = 5000;
            this.ımageSlider4.CurrentImageIndex = 0;
            this.ımageSlider4.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider4.Images"))));
            this.ımageSlider4.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider4.Images1"))));
            this.ımageSlider4.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider4.Images2"))));
            this.ımageSlider4.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider4.Images3"))));
            this.ımageSlider4.Location = new System.Drawing.Point(3, 464);
            this.ımageSlider4.Name = "ımageSlider4";
            this.ımageSlider4.Size = new System.Drawing.Size(338, 283);
            this.ımageSlider4.TabIndex = 12;
            this.ımageSlider4.Text = "ımageSlider4";
            // 
            // FrmPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 760);
            this.Controls.Add(this.ımageSlider4);
            this.Controls.Add(this.ımageSlider3);
            this.Controls.Add(this.ımageSlider2);
            this.Controls.Add(this.ımageSlider1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grdPersoneller);
            this.Name = "FrmPersoneller";
            this.Text = "PERSONELLER";
            this.Load += new System.EventHandler(this.FrmPersoneller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPersoneller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersoneller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvPersoneller;
        private DevExpress.XtraGrid.GridControl grdPersoneller;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIlce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIl;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private DevExpress.XtraEditors.TextEdit txtGorev;
        private DevExpress.XtraEditors.LabelControl lblGorev;
        private DevExpress.XtraEditors.LabelControl lblIlce;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.RichTextBox txtAdres;
        private DevExpress.XtraEditors.LabelControl lblAdres;
        private DevExpress.XtraEditors.LabelControl lblIl;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.LabelControl lblMail;
        private DevExpress.XtraEditors.LabelControl lblTC;
        private DevExpress.XtraEditors.LabelControl lblTelefon;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.LabelControl lblSoyad;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl lblAd;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.Controls.ImageSlider ımageSlider1;
        private DevExpress.XtraEditors.Controls.ImageSlider ımageSlider2;
        private DevExpress.XtraEditors.Controls.ImageSlider ımageSlider3;
        private DevExpress.XtraEditors.Controls.ImageSlider ımageSlider4;
    }
}