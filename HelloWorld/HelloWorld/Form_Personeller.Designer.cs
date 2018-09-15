namespace HelloWorld
{
    partial class Form_Personeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Personeller));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridC_Per_Telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Per_Soyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Per_Ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Per_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView_Per = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridC_Per_Tc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Per_Mail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Per_Il = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Per_Ilce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Per_Gorev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Per_Adres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Per = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.richT_Per_Adres = new System.Windows.Forms.RichTextBox();
            this.comboB_Per_Ilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboB_Per_Il = new DevExpress.XtraEditors.ComboBoxEdit();
            this.maskedT_Per_Tc = new System.Windows.Forms.MaskedTextBox();
            this.maskedT_Per_Tel = new System.Windows.Forms.MaskedTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.textE_Per_Gorev = new DevExpress.XtraEditors.TextEdit();
            this.simpleB_Per_Guncel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleB_Per_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleB_Per_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textE_Per_Mail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textE_Per_Soyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textE_Per_Ad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Per)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridC_Per)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboB_Per_Ilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboB_Per_Il.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Per_Gorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Per_Mail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Per_Soyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Per_Ad.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(47, 323);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 18);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "ADRES:";
            // 
            // gridC_Per_Telefon
            // 
            this.gridC_Per_Telefon.Caption = "TELEFON";
            this.gridC_Per_Telefon.FieldName = "TELEFON";
            this.gridC_Per_Telefon.Name = "gridC_Per_Telefon";
            this.gridC_Per_Telefon.Visible = true;
            this.gridC_Per_Telefon.VisibleIndex = 5;
            // 
            // gridC_Per_Soyad
            // 
            this.gridC_Per_Soyad.Caption = "SOYAD";
            this.gridC_Per_Soyad.FieldName = "SOYAD";
            this.gridC_Per_Soyad.Name = "gridC_Per_Soyad";
            this.gridC_Per_Soyad.Visible = true;
            this.gridC_Per_Soyad.VisibleIndex = 2;
            // 
            // gridC_Per_Ad
            // 
            this.gridC_Per_Ad.Caption = "AD";
            this.gridC_Per_Ad.FieldName = "AD";
            this.gridC_Per_Ad.Name = "gridC_Per_Ad";
            this.gridC_Per_Ad.Visible = true;
            this.gridC_Per_Ad.VisibleIndex = 1;
            // 
            // gridC_Per_Id
            // 
            this.gridC_Per_Id.Caption = "ID";
            this.gridC_Per_Id.FieldName = "ID";
            this.gridC_Per_Id.Name = "gridC_Per_Id";
            // 
            // gridView_Per
            // 
            this.gridView_Per.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView_Per.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView_Per.Appearance.Row.Options.UseBackColor = true;
            this.gridView_Per.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridC_Per_Id,
            this.gridC_Per_Ad,
            this.gridC_Per_Soyad,
            this.gridC_Per_Telefon,
            this.gridC_Per_Tc,
            this.gridC_Per_Mail,
            this.gridC_Per_Il,
            this.gridC_Per_Ilce,
            this.gridC_Per_Gorev,
            this.gridC_Per_Adres});
            this.gridView_Per.GridControl = this.gridC_Per;
            this.gridView_Per.Name = "gridView_Per";
            this.gridView_Per.OptionsSelection.MultiSelect = true;
            this.gridView_Per.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView_Per.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_Per_RowCellClick);
            // 
            // gridC_Per_Tc
            // 
            this.gridC_Per_Tc.Caption = "TC";
            this.gridC_Per_Tc.FieldName = "TC";
            this.gridC_Per_Tc.Name = "gridC_Per_Tc";
            this.gridC_Per_Tc.Visible = true;
            this.gridC_Per_Tc.VisibleIndex = 4;
            // 
            // gridC_Per_Mail
            // 
            this.gridC_Per_Mail.Caption = "MAIL";
            this.gridC_Per_Mail.FieldName = "MAIL";
            this.gridC_Per_Mail.Name = "gridC_Per_Mail";
            this.gridC_Per_Mail.Visible = true;
            this.gridC_Per_Mail.VisibleIndex = 6;
            // 
            // gridC_Per_Il
            // 
            this.gridC_Per_Il.Caption = "IL";
            this.gridC_Per_Il.FieldName = "IL";
            this.gridC_Per_Il.Name = "gridC_Per_Il";
            this.gridC_Per_Il.Visible = true;
            this.gridC_Per_Il.VisibleIndex = 7;
            // 
            // gridC_Per_Ilce
            // 
            this.gridC_Per_Ilce.Caption = "ILCE";
            this.gridC_Per_Ilce.FieldName = "ILCE";
            this.gridC_Per_Ilce.Name = "gridC_Per_Ilce";
            this.gridC_Per_Ilce.Visible = true;
            this.gridC_Per_Ilce.VisibleIndex = 8;
            // 
            // gridC_Per_Gorev
            // 
            this.gridC_Per_Gorev.Caption = "GOREV";
            this.gridC_Per_Gorev.FieldName = "GOREV";
            this.gridC_Per_Gorev.Name = "gridC_Per_Gorev";
            this.gridC_Per_Gorev.Visible = true;
            this.gridC_Per_Gorev.VisibleIndex = 3;
            // 
            // gridC_Per_Adres
            // 
            this.gridC_Per_Adres.Caption = "ADRES";
            this.gridC_Per_Adres.FieldName = "ADRES";
            this.gridC_Per_Adres.Name = "gridC_Per_Adres";
            this.gridC_Per_Adres.Visible = true;
            this.gridC_Per_Adres.VisibleIndex = 9;
            // 
            // gridC_Per
            // 
            this.gridC_Per.Location = new System.Drawing.Point(8, 2);
            this.gridC_Per.MainView = this.gridView_Per;
            this.gridC_Per.Name = "gridC_Per";
            this.gridC_Per.Size = new System.Drawing.Size(1571, 669);
            this.gridC_Per.TabIndex = 4;
            this.gridC_Per.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Per});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.richT_Per_Adres);
            this.groupControl1.Controls.Add(this.comboB_Per_Ilce);
            this.groupControl1.Controls.Add(this.comboB_Per_Il);
            this.groupControl1.Controls.Add(this.maskedT_Per_Tc);
            this.groupControl1.Controls.Add(this.maskedT_Per_Tel);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textE_Per_Gorev);
            this.groupControl1.Controls.Add(this.simpleB_Per_Guncel);
            this.groupControl1.Controls.Add(this.simpleB_Per_Sil);
            this.groupControl1.Controls.Add(this.simpleB_Per_Kaydet);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.textE_Per_Mail);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textE_Per_Soyad);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textE_Per_Ad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(1602, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(314, 661);
            this.groupControl1.TabIndex = 5;
            // 
            // richT_Per_Adres
            // 
            this.richT_Per_Adres.Location = new System.Drawing.Point(108, 322);
            this.richT_Per_Adres.Name = "richT_Per_Adres";
            this.richT_Per_Adres.Size = new System.Drawing.Size(166, 96);
            this.richT_Per_Adres.TabIndex = 31;
            this.richT_Per_Adres.Text = "";
            // 
            // comboB_Per_Ilce
            // 
            this.comboB_Per_Ilce.Location = new System.Drawing.Point(108, 264);
            this.comboB_Per_Ilce.Name = "comboB_Per_Ilce";
            this.comboB_Per_Ilce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.comboB_Per_Ilce.Properties.Appearance.Options.UseFont = true;
            this.comboB_Per_Ilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboB_Per_Ilce.Size = new System.Drawing.Size(166, 24);
            this.comboB_Per_Ilce.TabIndex = 30;
            // 
            // comboB_Per_Il
            // 
            this.comboB_Per_Il.Location = new System.Drawing.Point(108, 234);
            this.comboB_Per_Il.Name = "comboB_Per_Il";
            this.comboB_Per_Il.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.comboB_Per_Il.Properties.Appearance.Options.UseFont = true;
            this.comboB_Per_Il.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboB_Per_Il.Size = new System.Drawing.Size(166, 24);
            this.comboB_Per_Il.TabIndex = 29;
            this.comboB_Per_Il.SelectedIndexChanged += new System.EventHandler(this.comboB_Per_Il_SelectedIndexChanged);
            this.comboB_Per_Il.EditValueChanged += new System.EventHandler(this.comboB_Per_Il_EditValueChanged);
            // 
            // maskedT_Per_Tc
            // 
            this.maskedT_Per_Tc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedT_Per_Tc.Location = new System.Drawing.Point(108, 170);
            this.maskedT_Per_Tc.Mask = "00000000000";
            this.maskedT_Per_Tc.Name = "maskedT_Per_Tc";
            this.maskedT_Per_Tc.Size = new System.Drawing.Size(166, 26);
            this.maskedT_Per_Tc.TabIndex = 28;
            this.maskedT_Per_Tc.ValidatingType = typeof(int);
            // 
            // maskedT_Per_Tel
            // 
            this.maskedT_Per_Tel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedT_Per_Tel.Location = new System.Drawing.Point(108, 136);
            this.maskedT_Per_Tel.Mask = "(999) 000-0000";
            this.maskedT_Per_Tel.Name = "maskedT_Per_Tel";
            this.maskedT_Per_Tel.Size = new System.Drawing.Size(166, 26);
            this.maskedT_Per_Tel.TabIndex = 27;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(50, 295);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(52, 18);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "GOREV:";
            // 
            // textE_Per_Gorev
            // 
            this.textE_Per_Gorev.Location = new System.Drawing.Point(108, 292);
            this.textE_Per_Gorev.Name = "textE_Per_Gorev";
            this.textE_Per_Gorev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textE_Per_Gorev.Properties.Appearance.Options.UseFont = true;
            this.textE_Per_Gorev.Size = new System.Drawing.Size(166, 24);
            this.textE_Per_Gorev.TabIndex = 23;
            // 
            // simpleB_Per_Guncel
            // 
            this.simpleB_Per_Guncel.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleB_Per_Guncel.Appearance.Options.UseFont = true;
            this.simpleB_Per_Guncel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleB_Per_Guncel.ImageOptions.Image")));
            this.simpleB_Per_Guncel.Location = new System.Drawing.Point(108, 553);
            this.simpleB_Per_Guncel.Name = "simpleB_Per_Guncel";
            this.simpleB_Per_Guncel.Size = new System.Drawing.Size(166, 47);
            this.simpleB_Per_Guncel.TabIndex = 21;
            this.simpleB_Per_Guncel.Text = "GÜNCELLE";
            this.simpleB_Per_Guncel.Click += new System.EventHandler(this.simpleB_Per_Guncel_Click);
            // 
            // simpleB_Per_Sil
            // 
            this.simpleB_Per_Sil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleB_Per_Sil.Appearance.Options.UseFont = true;
            this.simpleB_Per_Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleB_Per_Sil.ImageOptions.Image")));
            this.simpleB_Per_Sil.Location = new System.Drawing.Point(108, 500);
            this.simpleB_Per_Sil.Name = "simpleB_Per_Sil";
            this.simpleB_Per_Sil.Size = new System.Drawing.Size(166, 47);
            this.simpleB_Per_Sil.TabIndex = 20;
            this.simpleB_Per_Sil.Text = "SİL";
            this.simpleB_Per_Sil.Click += new System.EventHandler(this.simpleB_Per_Sil_Click);
            // 
            // simpleB_Per_Kaydet
            // 
            this.simpleB_Per_Kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleB_Per_Kaydet.Appearance.Options.UseFont = true;
            this.simpleB_Per_Kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleB_Per_Kaydet.ImageOptions.Image")));
            this.simpleB_Per_Kaydet.Location = new System.Drawing.Point(108, 447);
            this.simpleB_Per_Kaydet.Name = "simpleB_Per_Kaydet";
            this.simpleB_Per_Kaydet.Size = new System.Drawing.Size(166, 47);
            this.simpleB_Per_Kaydet.TabIndex = 19;
            this.simpleB_Per_Kaydet.Text = "KAYDET";
            this.simpleB_Per_Kaydet.Click += new System.EventHandler(this.simpleB_Per_Kaydet_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(78, 173);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 18);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "TC:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(67, 265);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(35, 18);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "ILCE:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(78, 235);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(18, 18);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "IL:";
            // 
            // textE_Per_Mail
            // 
            this.textE_Per_Mail.Location = new System.Drawing.Point(108, 202);
            this.textE_Per_Mail.Name = "textE_Per_Mail";
            this.textE_Per_Mail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textE_Per_Mail.Properties.Appearance.Options.UseFont = true;
            this.textE_Per_Mail.Size = new System.Drawing.Size(166, 24);
            this.textE_Per_Mail.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(63, 205);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "MAIL:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(35, 139);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "TELEFON:";
            // 
            // textE_Per_Soyad
            // 
            this.textE_Per_Soyad.Location = new System.Drawing.Point(108, 106);
            this.textE_Per_Soyad.Name = "textE_Per_Soyad";
            this.textE_Per_Soyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textE_Per_Soyad.Properties.Appearance.Options.UseFont = true;
            this.textE_Per_Soyad.Size = new System.Drawing.Size(166, 24);
            this.textE_Per_Soyad.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(49, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "SOYAD:";
            // 
            // textE_Per_Ad
            // 
            this.textE_Per_Ad.Location = new System.Drawing.Point(108, 76);
            this.textE_Per_Ad.Name = "textE_Per_Ad";
            this.textE_Per_Ad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textE_Per_Ad.Properties.Appearance.Options.UseFont = true;
            this.textE_Per_Ad.Size = new System.Drawing.Size(166, 24);
            this.textE_Per_Ad.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(78, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "AD:";
            // 
            // Form_Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 673);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridC_Per);
            this.Name = "Form_Personeller";
            this.Text = "PERSONELLER";
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Per)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridC_Per)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboB_Per_Ilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboB_Per_Il.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Per_Gorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Per_Mail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Per_Soyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Per_Ad.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Per_Telefon;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Per_Soyad;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Per_Ad;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Per_Id;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Per;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Per_Tc;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Per_Mail;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Per_Il;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Per_Ilce;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Per_Gorev;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Per_Adres;
        private DevExpress.XtraGrid.GridControl gridC_Per;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox richT_Per_Adres;
        private DevExpress.XtraEditors.ComboBoxEdit comboB_Per_Ilce;
        private DevExpress.XtraEditors.ComboBoxEdit comboB_Per_Il;
        private System.Windows.Forms.MaskedTextBox maskedT_Per_Tc;
        private System.Windows.Forms.MaskedTextBox maskedT_Per_Tel;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit textE_Per_Gorev;
        private DevExpress.XtraEditors.SimpleButton simpleB_Per_Guncel;
        private DevExpress.XtraEditors.SimpleButton simpleB_Per_Sil;
        private DevExpress.XtraEditors.SimpleButton simpleB_Per_Kaydet;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textE_Per_Mail;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textE_Per_Soyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textE_Per_Ad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}