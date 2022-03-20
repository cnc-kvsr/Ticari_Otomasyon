
namespace Ticari_Otomasyon
{
    partial class FrmGiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderler));
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaaslar = new DevExpress.XtraEditors.TextEdit();
            this.txtInternet = new DevExpress.XtraEditors.TextEdit();
            this.txtSu = new DevExpress.XtraEditors.TextEdit();
            this.cmbYıl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbAy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtElektrik = new DevExpress.XtraEditors.TextEdit();
            this.txtEkstra = new DevExpress.XtraEditors.TextEdit();
            this.lblEkstra = new DevExpress.XtraEditors.LabelControl();
            this.lblMaaslar = new DevExpress.XtraEditors.LabelControl();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtNotlar = new System.Windows.Forms.RichTextBox();
            this.lblNotlar = new DevExpress.XtraEditors.LabelControl();
            this.lblInternet = new DevExpress.XtraEditors.LabelControl();
            this.txtDogalgaz = new DevExpress.XtraEditors.TextEdit();
            this.lblDogalgaz = new DevExpress.XtraEditors.LabelControl();
            this.lblSu = new DevExpress.XtraEditors.LabelControl();
            this.lblElektrik = new DevExpress.XtraEditors.LabelControl();
            this.lblYıl = new DevExpress.XtraEditors.LabelControl();
            this.lblAy = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaaslar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInternet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYıl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtElektrik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEkstra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDogalgaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(116, 633);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(234, 37);
            this.btnTemizle.TabIndex = 26;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMaaslar);
            this.groupControl1.Controls.Add(this.txtInternet);
            this.groupControl1.Controls.Add(this.txtSu);
            this.groupControl1.Controls.Add(this.cmbYıl);
            this.groupControl1.Controls.Add(this.cmbAy);
            this.groupControl1.Controls.Add(this.txtElektrik);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.txtEkstra);
            this.groupControl1.Controls.Add(this.lblEkstra);
            this.groupControl1.Controls.Add(this.lblMaaslar);
            this.groupControl1.Controls.Add(this.btnGüncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.txtNotlar);
            this.groupControl1.Controls.Add(this.lblNotlar);
            this.groupControl1.Controls.Add(this.lblInternet);
            this.groupControl1.Controls.Add(this.txtDogalgaz);
            this.groupControl1.Controls.Add(this.lblDogalgaz);
            this.groupControl1.Controls.Add(this.lblSu);
            this.groupControl1.Controls.Add(this.lblElektrik);
            this.groupControl1.Controls.Add(this.lblYıl);
            this.groupControl1.Controls.Add(this.lblAy);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.lblID);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(1562, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(378, 692);
            this.groupControl1.TabIndex = 4;
            // 
            // txtMaaslar
            // 
            this.txtMaaslar.Location = new System.Drawing.Point(117, 296);
            this.txtMaaslar.Name = "txtMaaslar";
            this.txtMaaslar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaaslar.Properties.Appearance.Options.UseFont = true;
            this.txtMaaslar.Size = new System.Drawing.Size(234, 28);
            this.txtMaaslar.TabIndex = 7;
            // 
            // txtInternet
            // 
            this.txtInternet.Location = new System.Drawing.Point(116, 259);
            this.txtInternet.Name = "txtInternet";
            this.txtInternet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInternet.Properties.Appearance.Options.UseFont = true;
            this.txtInternet.Size = new System.Drawing.Size(234, 28);
            this.txtInternet.TabIndex = 6;
            // 
            // txtSu
            // 
            this.txtSu.Location = new System.Drawing.Point(116, 185);
            this.txtSu.Name = "txtSu";
            this.txtSu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSu.Properties.Appearance.Options.UseFont = true;
            this.txtSu.Size = new System.Drawing.Size(234, 28);
            this.txtSu.TabIndex = 4;
            // 
            // cmbYıl
            // 
            this.cmbYıl.Location = new System.Drawing.Point(117, 111);
            this.cmbYıl.Name = "cmbYıl";
            this.cmbYıl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYıl.Properties.Appearance.Options.UseFont = true;
            this.cmbYıl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbYıl.Properties.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022"});
            this.cmbYıl.Size = new System.Drawing.Size(234, 28);
            this.cmbYıl.TabIndex = 2;
            // 
            // cmbAy
            // 
            this.cmbAy.Location = new System.Drawing.Point(117, 74);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAy.Properties.Appearance.Options.UseFont = true;
            this.cmbAy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAy.Properties.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim ",
            "Kasım",
            "Aralık"});
            this.cmbAy.Size = new System.Drawing.Size(234, 28);
            this.cmbAy.TabIndex = 1;
            // 
            // txtElektrik
            // 
            this.txtElektrik.Location = new System.Drawing.Point(117, 148);
            this.txtElektrik.Name = "txtElektrik";
            this.txtElektrik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtElektrik.Properties.Appearance.Options.UseFont = true;
            this.txtElektrik.Size = new System.Drawing.Size(234, 28);
            this.txtElektrik.TabIndex = 3;
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(116, 333);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkstra.Properties.Appearance.Options.UseFont = true;
            this.txtEkstra.Size = new System.Drawing.Size(234, 28);
            this.txtEkstra.TabIndex = 8;
            // 
            // lblEkstra
            // 
            this.lblEkstra.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkstra.Appearance.Options.UseFont = true;
            this.lblEkstra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEkstra.Location = new System.Drawing.Point(57, 334);
            this.lblEkstra.Name = "lblEkstra";
            this.lblEkstra.Size = new System.Drawing.Size(54, 22);
            this.lblEkstra.TabIndex = 28;
            this.lblEkstra.Text = "Ekstra:";
            // 
            // lblMaaslar
            // 
            this.lblMaaslar.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaaslar.Appearance.Options.UseFont = true;
            this.lblMaaslar.Location = new System.Drawing.Point(46, 297);
            this.lblMaaslar.Name = "lblMaaslar";
            this.lblMaaslar.Size = new System.Drawing.Size(65, 22);
            this.lblMaaslar.TabIndex = 26;
            this.lblMaaslar.Text = "Maaşlar:";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Appearance.Options.UseFont = true;
            this.btnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ImageOptions.Image")));
            this.btnGüncelle.Location = new System.Drawing.Point(116, 587);
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
            this.btnSil.Location = new System.Drawing.Point(116, 541);
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
            this.btnKaydet.Location = new System.Drawing.Point(116, 495);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(234, 37);
            this.btnKaydet.TabIndex = 23;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtNotlar
            // 
            this.txtNotlar.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotlar.Location = new System.Drawing.Point(116, 370);
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(234, 116);
            this.txtNotlar.TabIndex = 9;
            this.txtNotlar.Text = "";
            // 
            // lblNotlar
            // 
            this.lblNotlar.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNotlar.Appearance.Options.UseFont = true;
            this.lblNotlar.Location = new System.Drawing.Point(58, 371);
            this.lblNotlar.Name = "lblNotlar";
            this.lblNotlar.Size = new System.Drawing.Size(53, 22);
            this.lblNotlar.TabIndex = 20;
            this.lblNotlar.Text = "Notlar:";
            // 
            // lblInternet
            // 
            this.lblInternet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInternet.Appearance.Options.UseFont = true;
            this.lblInternet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInternet.Location = new System.Drawing.Point(42, 260);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new System.Drawing.Size(69, 22);
            this.lblInternet.TabIndex = 18;
            this.lblInternet.Text = "İnternet:";
            // 
            // txtDogalgaz
            // 
            this.txtDogalgaz.Location = new System.Drawing.Point(116, 222);
            this.txtDogalgaz.Name = "txtDogalgaz";
            this.txtDogalgaz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDogalgaz.Properties.Appearance.Options.UseFont = true;
            this.txtDogalgaz.Size = new System.Drawing.Size(234, 28);
            this.txtDogalgaz.TabIndex = 5;
            // 
            // lblDogalgaz
            // 
            this.lblDogalgaz.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogalgaz.Appearance.Options.UseFont = true;
            this.lblDogalgaz.Location = new System.Drawing.Point(33, 223);
            this.lblDogalgaz.Name = "lblDogalgaz";
            this.lblDogalgaz.Size = new System.Drawing.Size(78, 22);
            this.lblDogalgaz.TabIndex = 16;
            this.lblDogalgaz.Text = "Doğalgaz:";
            // 
            // lblSu
            // 
            this.lblSu.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSu.Appearance.Options.UseFont = true;
            this.lblSu.Location = new System.Drawing.Point(85, 186);
            this.lblSu.Name = "lblSu";
            this.lblSu.Size = new System.Drawing.Size(26, 22);
            this.lblSu.TabIndex = 15;
            this.lblSu.Text = "Su:";
            // 
            // lblElektrik
            // 
            this.lblElektrik.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblElektrik.Appearance.Options.UseFont = true;
            this.lblElektrik.Location = new System.Drawing.Point(48, 149);
            this.lblElektrik.Name = "lblElektrik";
            this.lblElektrik.Size = new System.Drawing.Size(63, 22);
            this.lblElektrik.TabIndex = 8;
            this.lblElektrik.Text = "Elektrik:";
            // 
            // lblYıl
            // 
            this.lblYıl.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYıl.Appearance.Options.UseFont = true;
            this.lblYıl.Location = new System.Drawing.Point(87, 112);
            this.lblYıl.Name = "lblYıl";
            this.lblYıl.Size = new System.Drawing.Size(24, 22);
            this.lblYıl.TabIndex = 6;
            this.lblYıl.Text = "Yıl:";
            // 
            // lblAy
            // 
            this.lblAy.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAy.Appearance.Options.UseFont = true;
            this.lblAy.Location = new System.Drawing.Point(85, 75);
            this.lblAy.Name = "lblAy";
            this.lblAy.Size = new System.Drawing.Size(26, 22);
            this.lblAy.TabIndex = 4;
            this.lblAy.Text = "Ay:";
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
            this.lblID.Location = new System.Drawing.Point(86, 38);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 22);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1413, 692);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // FrmGiderler
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTemizle;
            this.ClientSize = new System.Drawing.Size(1940, 692);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmGiderler";
            this.Text = "GİDERLER";
            this.Load += new System.EventHandler(this.FrmGiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaaslar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInternet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYıl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtElektrik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEkstra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDogalgaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtMaaslar;
        private DevExpress.XtraEditors.TextEdit txtInternet;
        private DevExpress.XtraEditors.TextEdit txtSu;
        private DevExpress.XtraEditors.ComboBoxEdit cmbYıl;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAy;
        private DevExpress.XtraEditors.TextEdit txtElektrik;
        private DevExpress.XtraEditors.TextEdit txtEkstra;
        private DevExpress.XtraEditors.LabelControl lblEkstra;
        private DevExpress.XtraEditors.LabelControl lblMaaslar;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.RichTextBox txtNotlar;
        private DevExpress.XtraEditors.LabelControl lblNotlar;
        private DevExpress.XtraEditors.LabelControl lblInternet;
        private DevExpress.XtraEditors.TextEdit txtDogalgaz;
        private DevExpress.XtraEditors.LabelControl lblDogalgaz;
        private DevExpress.XtraEditors.LabelControl lblSu;
        private DevExpress.XtraEditors.LabelControl lblElektrik;
        private DevExpress.XtraEditors.LabelControl lblYıl;
        private DevExpress.XtraEditors.LabelControl lblAy;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}