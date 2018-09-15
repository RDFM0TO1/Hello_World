namespace HelloWorld
{
    partial class Form_Giderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Giderler));
            this.richT_Gid_Notlar = new System.Windows.Forms.RichTextBox();
            this.comboB_Gid_Ay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboB_Gid_Yıl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textE_Gid_Ekstra = new DevExpress.XtraEditors.TextEdit();
            this.simpleB_Gid_Guncel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleB_Gid_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleB_Gid_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textE_Gid_Doğalgaz = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textE_Gid_Maaşlar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textE_Gid_İnternet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridC_Giderler = new DevExpress.XtraGrid.GridControl();
            this.gridView_Giderler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridC_Gid_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Gid_Ay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Gid_Yıl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Gid_Elektrik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Gid_Su = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Gid_Doğalgaz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Gid_Internet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Gid_Maaşlar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Gid_Ekstra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Gid_Notlar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textE_Gid_Elektrik = new DevExpress.XtraEditors.TextEdit();
            this.textE_Gid_Su = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.comboB_Gid_Ay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboB_Gid_Yıl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Gid_Ekstra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Gid_Doğalgaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Gid_Maaşlar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Gid_İnternet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridC_Giderler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Giderler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Gid_Elektrik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Gid_Su.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // richT_Gid_Notlar
            // 
            this.richT_Gid_Notlar.Location = new System.Drawing.Point(108, 316);
            this.richT_Gid_Notlar.Name = "richT_Gid_Notlar";
            this.richT_Gid_Notlar.Size = new System.Drawing.Size(166, 96);
            this.richT_Gid_Notlar.TabIndex = 31;
            this.richT_Gid_Notlar.Text = "";
            // 
            // comboB_Gid_Ay
            // 
            this.comboB_Gid_Ay.Location = new System.Drawing.Point(110, 76);
            this.comboB_Gid_Ay.Name = "comboB_Gid_Ay";
            this.comboB_Gid_Ay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.comboB_Gid_Ay.Properties.Appearance.Options.UseFont = true;
            this.comboB_Gid_Ay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboB_Gid_Ay.Properties.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.comboB_Gid_Ay.Size = new System.Drawing.Size(166, 24);
            this.comboB_Gid_Ay.TabIndex = 30;
            // 
            // comboB_Gid_Yıl
            // 
            this.comboB_Gid_Yıl.Location = new System.Drawing.Point(110, 106);
            this.comboB_Gid_Yıl.Name = "comboB_Gid_Yıl";
            this.comboB_Gid_Yıl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.comboB_Gid_Yıl.Properties.Appearance.Options.UseFont = true;
            this.comboB_Gid_Yıl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboB_Gid_Yıl.Properties.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.comboB_Gid_Yıl.Size = new System.Drawing.Size(166, 24);
            this.comboB_Gid_Yıl.TabIndex = 29;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(50, 289);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(58, 18);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "EKSTRA:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textE_Gid_Su);
            this.groupControl1.Controls.Add(this.textE_Gid_Elektrik);
            this.groupControl1.Controls.Add(this.richT_Gid_Notlar);
            this.groupControl1.Controls.Add(this.comboB_Gid_Ay);
            this.groupControl1.Controls.Add(this.comboB_Gid_Yıl);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textE_Gid_Ekstra);
            this.groupControl1.Controls.Add(this.simpleB_Gid_Guncel);
            this.groupControl1.Controls.Add(this.simpleB_Gid_Sil);
            this.groupControl1.Controls.Add(this.simpleB_Gid_Kaydet);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.textE_Gid_Doğalgaz);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textE_Gid_Maaşlar);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textE_Gid_İnternet);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(1602, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(314, 661);
            this.groupControl1.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(47, 317);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 18);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "NOTLAR:";
            // 
            // textE_Gid_Ekstra
            // 
            this.textE_Gid_Ekstra.Location = new System.Drawing.Point(108, 286);
            this.textE_Gid_Ekstra.Name = "textE_Gid_Ekstra";
            this.textE_Gid_Ekstra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textE_Gid_Ekstra.Properties.Appearance.Options.UseFont = true;
            this.textE_Gid_Ekstra.Size = new System.Drawing.Size(166, 24);
            this.textE_Gid_Ekstra.TabIndex = 23;
            // 
            // simpleB_Gid_Guncel
            // 
            this.simpleB_Gid_Guncel.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleB_Gid_Guncel.Appearance.Options.UseFont = true;
            this.simpleB_Gid_Guncel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleB_Per_Guncel.ImageOptions.Image")));
            this.simpleB_Gid_Guncel.Location = new System.Drawing.Point(108, 553);
            this.simpleB_Gid_Guncel.Name = "simpleB_Gid_Guncel";
            this.simpleB_Gid_Guncel.Size = new System.Drawing.Size(166, 47);
            this.simpleB_Gid_Guncel.TabIndex = 21;
            this.simpleB_Gid_Guncel.Text = "GÜNCELLE";
            this.simpleB_Gid_Guncel.Click += new System.EventHandler(this.simpleB_Gid_Guncel_Click);
            // 
            // simpleB_Gid_Sil
            // 
            this.simpleB_Gid_Sil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleB_Gid_Sil.Appearance.Options.UseFont = true;
            this.simpleB_Gid_Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleB_Per_Sil.ImageOptions.Image")));
            this.simpleB_Gid_Sil.Location = new System.Drawing.Point(108, 500);
            this.simpleB_Gid_Sil.Name = "simpleB_Gid_Sil";
            this.simpleB_Gid_Sil.Size = new System.Drawing.Size(166, 47);
            this.simpleB_Gid_Sil.TabIndex = 20;
            this.simpleB_Gid_Sil.Text = "SİL";
            this.simpleB_Gid_Sil.Click += new System.EventHandler(this.simpleB_Gid_Sil_Click);
            // 
            // simpleB_Gid_Kaydet
            // 
            this.simpleB_Gid_Kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleB_Gid_Kaydet.Appearance.Options.UseFont = true;
            this.simpleB_Gid_Kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleB_Per_Kaydet.ImageOptions.Image")));
            this.simpleB_Gid_Kaydet.Location = new System.Drawing.Point(108, 447);
            this.simpleB_Gid_Kaydet.Name = "simpleB_Gid_Kaydet";
            this.simpleB_Gid_Kaydet.Size = new System.Drawing.Size(166, 47);
            this.simpleB_Gid_Kaydet.TabIndex = 19;
            this.simpleB_Gid_Kaydet.Text = "KAYDET";
            this.simpleB_Gid_Kaydet.Click += new System.EventHandler(this.simpleB_Gid_Kaydet_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(85, 173);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(23, 18);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "SU:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(40, 265);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(68, 18);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "MAAŞLAR:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(32, 235);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 18);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "INTERNET:";
            // 
            // textE_Gid_Doğalgaz
            // 
            this.textE_Gid_Doğalgaz.Location = new System.Drawing.Point(110, 196);
            this.textE_Gid_Doğalgaz.Name = "textE_Gid_Doğalgaz";
            this.textE_Gid_Doğalgaz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textE_Gid_Doğalgaz.Properties.Appearance.Options.UseFont = true;
            this.textE_Gid_Doğalgaz.Size = new System.Drawing.Size(166, 24);
            this.textE_Gid_Doğalgaz.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(29, 205);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(79, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "DOĞALGAZ:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(37, 139);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "ELEKTRİK:";
            // 
            // textE_Gid_Maaşlar
            // 
            this.textE_Gid_Maaşlar.Location = new System.Drawing.Point(110, 256);
            this.textE_Gid_Maaşlar.Name = "textE_Gid_Maaşlar";
            this.textE_Gid_Maaşlar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textE_Gid_Maaşlar.Properties.Appearance.Options.UseFont = true;
            this.textE_Gid_Maaşlar.Size = new System.Drawing.Size(166, 24);
            this.textE_Gid_Maaşlar.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(80, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "YIL:";
            // 
            // textE_Gid_İnternet
            // 
            this.textE_Gid_İnternet.Location = new System.Drawing.Point(108, 226);
            this.textE_Gid_İnternet.Name = "textE_Gid_İnternet";
            this.textE_Gid_İnternet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textE_Gid_İnternet.Properties.Appearance.Options.UseFont = true;
            this.textE_Gid_İnternet.Size = new System.Drawing.Size(166, 24);
            this.textE_Gid_İnternet.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(80, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "AY:";
            // 
            // gridC_Giderler
            // 
            this.gridC_Giderler.Location = new System.Drawing.Point(8, 2);
            this.gridC_Giderler.MainView = this.gridView_Giderler;
            this.gridC_Giderler.Name = "gridC_Giderler";
            this.gridC_Giderler.Size = new System.Drawing.Size(1571, 669);
            this.gridC_Giderler.TabIndex = 6;
            this.gridC_Giderler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Giderler});
            // 
            // gridView_Giderler
            // 
            this.gridView_Giderler.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView_Giderler.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView_Giderler.Appearance.Row.Options.UseBackColor = true;
            this.gridView_Giderler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridC_Gid_Id,
            this.gridC_Gid_Ay,
            this.gridC_Gid_Yıl,
            this.gridC_Gid_Elektrik,
            this.gridC_Gid_Su,
            this.gridC_Gid_Doğalgaz,
            this.gridC_Gid_Internet,
            this.gridC_Gid_Maaşlar,
            this.gridC_Gid_Ekstra,
            this.gridC_Gid_Notlar});
            this.gridView_Giderler.GridControl = this.gridC_Giderler;
            this.gridView_Giderler.Name = "gridView_Giderler";
            this.gridView_Giderler.OptionsSelection.MultiSelect = true;
            this.gridView_Giderler.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView_Giderler.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_Giderler_RowCellClick);
            // 
            // gridC_Gid_Id
            // 
            this.gridC_Gid_Id.Caption = "ID";
            this.gridC_Gid_Id.FieldName = "ID";
            this.gridC_Gid_Id.Name = "gridC_Gid_Id";
            // 
            // gridC_Gid_Ay
            // 
            this.gridC_Gid_Ay.Caption = "AY";
            this.gridC_Gid_Ay.FieldName = "AY";
            this.gridC_Gid_Ay.Name = "gridC_Gid_Ay";
            this.gridC_Gid_Ay.Visible = true;
            this.gridC_Gid_Ay.VisibleIndex = 1;
            // 
            // gridC_Gid_Yıl
            // 
            this.gridC_Gid_Yıl.Caption = "YIL";
            this.gridC_Gid_Yıl.FieldName = "YIL";
            this.gridC_Gid_Yıl.Name = "gridC_Gid_Yıl";
            this.gridC_Gid_Yıl.Visible = true;
            this.gridC_Gid_Yıl.VisibleIndex = 2;
            // 
            // gridC_Gid_Elektrik
            // 
            this.gridC_Gid_Elektrik.Caption = "ELEKTRIK";
            this.gridC_Gid_Elektrik.FieldName = "ELEKTRIK";
            this.gridC_Gid_Elektrik.Name = "gridC_Gid_Elektrik";
            this.gridC_Gid_Elektrik.Visible = true;
            this.gridC_Gid_Elektrik.VisibleIndex = 3;
            // 
            // gridC_Gid_Su
            // 
            this.gridC_Gid_Su.Caption = "SU";
            this.gridC_Gid_Su.FieldName = "SU";
            this.gridC_Gid_Su.Name = "gridC_Gid_Su";
            this.gridC_Gid_Su.Visible = true;
            this.gridC_Gid_Su.VisibleIndex = 4;
            // 
            // gridC_Gid_Doğalgaz
            // 
            this.gridC_Gid_Doğalgaz.Caption = "DOĞALGAZ";
            this.gridC_Gid_Doğalgaz.FieldName = "DOGALGAZ";
            this.gridC_Gid_Doğalgaz.Name = "gridC_Gid_Doğalgaz";
            this.gridC_Gid_Doğalgaz.Visible = true;
            this.gridC_Gid_Doğalgaz.VisibleIndex = 5;
            // 
            // gridC_Gid_Internet
            // 
            this.gridC_Gid_Internet.Caption = "İNTERNET";
            this.gridC_Gid_Internet.FieldName = "INTERNET";
            this.gridC_Gid_Internet.Name = "gridC_Gid_Internet";
            this.gridC_Gid_Internet.Visible = true;
            this.gridC_Gid_Internet.VisibleIndex = 6;
            // 
            // gridC_Gid_Maaşlar
            // 
            this.gridC_Gid_Maaşlar.Caption = "MAAŞLAR";
            this.gridC_Gid_Maaşlar.FieldName = "MAASLAR";
            this.gridC_Gid_Maaşlar.Name = "gridC_Gid_Maaşlar";
            this.gridC_Gid_Maaşlar.Visible = true;
            this.gridC_Gid_Maaşlar.VisibleIndex = 7;
            // 
            // gridC_Gid_Ekstra
            // 
            this.gridC_Gid_Ekstra.Caption = "EKSTRA";
            this.gridC_Gid_Ekstra.FieldName = "EKSTRA";
            this.gridC_Gid_Ekstra.Name = "gridC_Gid_Ekstra";
            this.gridC_Gid_Ekstra.Visible = true;
            this.gridC_Gid_Ekstra.VisibleIndex = 8;
            // 
            // gridC_Gid_Notlar
            // 
            this.gridC_Gid_Notlar.Caption = "NOTLAR";
            this.gridC_Gid_Notlar.FieldName = "NOTLAR";
            this.gridC_Gid_Notlar.Name = "gridC_Gid_Notlar";
            this.gridC_Gid_Notlar.Visible = true;
            this.gridC_Gid_Notlar.VisibleIndex = 9;
            // 
            // textE_Gid_Elektrik
            // 
            this.textE_Gid_Elektrik.Location = new System.Drawing.Point(110, 136);
            this.textE_Gid_Elektrik.Name = "textE_Gid_Elektrik";
            this.textE_Gid_Elektrik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textE_Gid_Elektrik.Properties.Appearance.Options.UseFont = true;
            this.textE_Gid_Elektrik.Size = new System.Drawing.Size(166, 24);
            this.textE_Gid_Elektrik.TabIndex = 32;
            // 
            // textE_Gid_Su
            // 
            this.textE_Gid_Su.Location = new System.Drawing.Point(110, 166);
            this.textE_Gid_Su.Name = "textE_Gid_Su";
            this.textE_Gid_Su.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textE_Gid_Su.Properties.Appearance.Options.UseFont = true;
            this.textE_Gid_Su.Size = new System.Drawing.Size(166, 24);
            this.textE_Gid_Su.TabIndex = 33;
            // 
            // Form_Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 673);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridC_Giderler);
            this.Name = "Form_Giderler";
            this.Text = "GİDERLER";
            this.Load += new System.EventHandler(this.Form_Giderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboB_Gid_Ay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboB_Gid_Yıl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Gid_Ekstra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Gid_Doğalgaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Gid_Maaşlar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Gid_İnternet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridC_Giderler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Giderler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Gid_Elektrik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Gid_Su.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richT_Gid_Notlar;
        private DevExpress.XtraEditors.ComboBoxEdit comboB_Gid_Ay;
        private DevExpress.XtraEditors.ComboBoxEdit comboB_Gid_Yıl;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textE_Gid_Su;
        private DevExpress.XtraEditors.TextEdit textE_Gid_Elektrik;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textE_Gid_Ekstra;
        private DevExpress.XtraEditors.SimpleButton simpleB_Gid_Guncel;
        private DevExpress.XtraEditors.SimpleButton simpleB_Gid_Sil;
        private DevExpress.XtraEditors.SimpleButton simpleB_Gid_Kaydet;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textE_Gid_Doğalgaz;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textE_Gid_Maaşlar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textE_Gid_İnternet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridC_Giderler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Giderler;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Gid_Id;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Gid_Ay;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Gid_Yıl;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Gid_Elektrik;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Gid_Su;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Gid_Doğalgaz;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Gid_Internet;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Gid_Maaşlar;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Gid_Ekstra;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Gid_Notlar;
    }
}