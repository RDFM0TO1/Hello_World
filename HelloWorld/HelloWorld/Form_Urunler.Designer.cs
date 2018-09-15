namespace HelloWorld
{
    partial class Form_Urunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Urunler));
            this.gridC_Ur = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridC_Ur_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Ur_Ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Ur_Marka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Ur_Model = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Ur_Yıl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Ur_Adet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Ur_Al = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Ur_Sat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Ur_Detay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleB_Ur_Guncel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleB_Ur_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleB_Ur_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.richT_Ur_Detay = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.numericU_Ur_Adet = new System.Windows.Forms.NumericUpDown();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textE_Ur_Sat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textE_Ur_Al = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textE_Ur_Model = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textE_Ur_Marka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textE_Ur_Ad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.maskedT_Ur_Yıl = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridC_Ur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericU_Ur_Adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Ur_Sat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Ur_Al.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Ur_Model.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Ur_Marka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Ur_Ad.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridC_Ur
            // 
            this.gridC_Ur.Location = new System.Drawing.Point(0, 0);
            this.gridC_Ur.MainView = this.gridView1;
            this.gridC_Ur.Name = "gridC_Ur";
            this.gridC_Ur.Size = new System.Drawing.Size(1571, 669);
            this.gridC_Ur.TabIndex = 0;
            this.gridC_Ur.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridC_Ur.Click += new System.EventHandler(this.gridC_Ur_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridC_Ur_Id,
            this.gridC_Ur_Ad,
            this.gridC_Ur_Marka,
            this.gridC_Ur_Model,
            this.gridC_Ur_Yıl,
            this.gridC_Ur_Adet,
            this.gridC_Ur_Al,
            this.gridC_Ur_Sat,
            this.gridC_Ur_Detay});
            this.gridView1.GridControl = this.gridC_Ur;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridC_Ur_Id
            // 
            this.gridC_Ur_Id.Caption = "ID";
            this.gridC_Ur_Id.FieldName = "ID";
            this.gridC_Ur_Id.Name = "gridC_Ur_Id";
            this.gridC_Ur_Id.Visible = true;
            this.gridC_Ur_Id.VisibleIndex = 1;
            // 
            // gridC_Ur_Ad
            // 
            this.gridC_Ur_Ad.Caption = "URUNAD";
            this.gridC_Ur_Ad.FieldName = "URUNAD";
            this.gridC_Ur_Ad.Name = "gridC_Ur_Ad";
            this.gridC_Ur_Ad.Visible = true;
            this.gridC_Ur_Ad.VisibleIndex = 2;
            // 
            // gridC_Ur_Marka
            // 
            this.gridC_Ur_Marka.Caption = "MARKA";
            this.gridC_Ur_Marka.FieldName = "MARKA";
            this.gridC_Ur_Marka.Name = "gridC_Ur_Marka";
            this.gridC_Ur_Marka.Visible = true;
            this.gridC_Ur_Marka.VisibleIndex = 3;
            // 
            // gridC_Ur_Model
            // 
            this.gridC_Ur_Model.Caption = "MODEL";
            this.gridC_Ur_Model.FieldName = "MODEL";
            this.gridC_Ur_Model.Name = "gridC_Ur_Model";
            this.gridC_Ur_Model.Visible = true;
            this.gridC_Ur_Model.VisibleIndex = 4;
            // 
            // gridC_Ur_Yıl
            // 
            this.gridC_Ur_Yıl.Caption = "YIL";
            this.gridC_Ur_Yıl.FieldName = "YIL";
            this.gridC_Ur_Yıl.Name = "gridC_Ur_Yıl";
            this.gridC_Ur_Yıl.Visible = true;
            this.gridC_Ur_Yıl.VisibleIndex = 5;
            // 
            // gridC_Ur_Adet
            // 
            this.gridC_Ur_Adet.Caption = "ADET";
            this.gridC_Ur_Adet.FieldName = "ADET";
            this.gridC_Ur_Adet.Name = "gridC_Ur_Adet";
            this.gridC_Ur_Adet.Visible = true;
            this.gridC_Ur_Adet.VisibleIndex = 6;
            // 
            // gridC_Ur_Al
            // 
            this.gridC_Ur_Al.Caption = "ALISFIYAT";
            this.gridC_Ur_Al.FieldName = "ALISFIYAT";
            this.gridC_Ur_Al.Name = "gridC_Ur_Al";
            this.gridC_Ur_Al.Visible = true;
            this.gridC_Ur_Al.VisibleIndex = 7;
            // 
            // gridC_Ur_Sat
            // 
            this.gridC_Ur_Sat.Caption = "SATISFIYAT";
            this.gridC_Ur_Sat.FieldName = "SATISFIYAT";
            this.gridC_Ur_Sat.Name = "gridC_Ur_Sat";
            this.gridC_Ur_Sat.Visible = true;
            this.gridC_Ur_Sat.VisibleIndex = 8;
            // 
            // gridC_Ur_Detay
            // 
            this.gridC_Ur_Detay.Caption = "DETAY";
            this.gridC_Ur_Detay.FieldName = "DETAY";
            this.gridC_Ur_Detay.Name = "gridC_Ur_Detay";
            this.gridC_Ur_Detay.Visible = true;
            this.gridC_Ur_Detay.VisibleIndex = 9;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleB_Ur_Guncel);
            this.groupControl1.Controls.Add(this.simpleB_Ur_Sil);
            this.groupControl1.Controls.Add(this.simpleB_Ur_Kaydet);
            this.groupControl1.Controls.Add(this.richT_Ur_Detay);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.numericU_Ur_Adet);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.textE_Ur_Sat);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.textE_Ur_Al);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.textE_Ur_Model);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textE_Ur_Marka);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textE_Ur_Ad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.maskedT_Ur_Yıl);
            this.groupControl1.Location = new System.Drawing.Point(1611, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(313, 673);
            this.groupControl1.TabIndex = 1;
            // 
            // simpleB_Ur_Guncel
            // 
            this.simpleB_Ur_Guncel.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleB_Ur_Guncel.Appearance.Options.UseFont = true;
            this.simpleB_Ur_Guncel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleB_Ur_Guncel.ImageOptions.Image")));
            this.simpleB_Ur_Guncel.Location = new System.Drawing.Point(108, 460);
            this.simpleB_Ur_Guncel.Name = "simpleB_Ur_Guncel";
            this.simpleB_Ur_Guncel.Size = new System.Drawing.Size(166, 47);
            this.simpleB_Ur_Guncel.TabIndex = 21;
            this.simpleB_Ur_Guncel.Text = "GÜNCELLE";
            this.simpleB_Ur_Guncel.Click += new System.EventHandler(this.simpleB_Ur_Guncel_Click);
            // 
            // simpleB_Ur_Sil
            // 
            this.simpleB_Ur_Sil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleB_Ur_Sil.Appearance.Options.UseFont = true;
            this.simpleB_Ur_Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleB_Ur_Sil.ImageOptions.Image")));
            this.simpleB_Ur_Sil.Location = new System.Drawing.Point(108, 407);
            this.simpleB_Ur_Sil.Name = "simpleB_Ur_Sil";
            this.simpleB_Ur_Sil.Size = new System.Drawing.Size(166, 47);
            this.simpleB_Ur_Sil.TabIndex = 20;
            this.simpleB_Ur_Sil.Text = "SİL";
            this.simpleB_Ur_Sil.Click += new System.EventHandler(this.simpleB_Ur_Sil_Click);
            // 
            // simpleB_Ur_Kaydet
            // 
            this.simpleB_Ur_Kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleB_Ur_Kaydet.Appearance.Options.UseFont = true;
            this.simpleB_Ur_Kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleB_Ur_Kaydet.ImageOptions.Image")));
            this.simpleB_Ur_Kaydet.Location = new System.Drawing.Point(108, 354);
            this.simpleB_Ur_Kaydet.Name = "simpleB_Ur_Kaydet";
            this.simpleB_Ur_Kaydet.Size = new System.Drawing.Size(166, 47);
            this.simpleB_Ur_Kaydet.TabIndex = 19;
            this.simpleB_Ur_Kaydet.Text = "KAYDET";
            this.simpleB_Ur_Kaydet.Click += new System.EventHandler(this.simpleB_Ur_Kaydet_Click);
            // 
            // richT_Ur_Detay
            // 
            this.richT_Ur_Detay.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richT_Ur_Detay.Location = new System.Drawing.Point(108, 252);
            this.richT_Ur_Detay.Name = "richT_Ur_Detay";
            this.richT_Ur_Detay.Size = new System.Drawing.Size(166, 96);
            this.richT_Ur_Detay.TabIndex = 18;
            this.richT_Ur_Detay.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(59, 166);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(42, 18);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "ADET:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(73, 138);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(28, 18);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "YIL:";
            // 
            // numericU_Ur_Adet
            // 
            this.numericU_Ur_Adet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericU_Ur_Adet.Location = new System.Drawing.Point(108, 164);
            this.numericU_Ur_Adet.Name = "numericU_Ur_Adet";
            this.numericU_Ur_Adet.Size = new System.Drawing.Size(166, 26);
            this.numericU_Ur_Adet.TabIndex = 15;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(50, 255);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 18);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "DETAY:";
            // 
            // textE_Ur_Sat
            // 
            this.textE_Ur_Sat.Location = new System.Drawing.Point(108, 221);
            this.textE_Ur_Sat.Name = "textE_Ur_Sat";
            this.textE_Ur_Sat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textE_Ur_Sat.Properties.Appearance.Options.UseFont = true;
            this.textE_Ur_Sat.Size = new System.Drawing.Size(166, 24);
            this.textE_Ur_Sat.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(8, 224);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(94, 18);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "SATIŞ FİYAT:";
            // 
            // textE_Ur_Al
            // 
            this.textE_Ur_Al.Location = new System.Drawing.Point(108, 193);
            this.textE_Ur_Al.Name = "textE_Ur_Al";
            this.textE_Ur_Al.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textE_Ur_Al.Properties.Appearance.Options.UseFont = true;
            this.textE_Ur_Al.Size = new System.Drawing.Size(166, 24);
            this.textE_Ur_Al.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(19, 196);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "ALIŞ FİYAT:";
            // 
            // textE_Ur_Model
            // 
            this.textE_Ur_Model.Location = new System.Drawing.Point(108, 107);
            this.textE_Ur_Model.Name = "textE_Ur_Model";
            this.textE_Ur_Model.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textE_Ur_Model.Properties.Appearance.Options.UseFont = true;
            this.textE_Ur_Model.Size = new System.Drawing.Size(166, 24);
            this.textE_Ur_Model.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(49, 110);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "MODEL:";
            // 
            // textE_Ur_Marka
            // 
            this.textE_Ur_Marka.Location = new System.Drawing.Point(108, 79);
            this.textE_Ur_Marka.Name = "textE_Ur_Marka";
            this.textE_Ur_Marka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textE_Ur_Marka.Properties.Appearance.Options.UseFont = true;
            this.textE_Ur_Marka.Size = new System.Drawing.Size(166, 24);
            this.textE_Ur_Marka.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(49, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "MARKA:";
            // 
            // textE_Ur_Ad
            // 
            this.textE_Ur_Ad.Location = new System.Drawing.Point(108, 51);
            this.textE_Ur_Ad.Name = "textE_Ur_Ad";
            this.textE_Ur_Ad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textE_Ur_Ad.Properties.Appearance.Options.UseFont = true;
            this.textE_Ur_Ad.Size = new System.Drawing.Size(166, 24);
            this.textE_Ur_Ad.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(78, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "AD:";
            // 
            // maskedT_Ur_Yıl
            // 
            this.maskedT_Ur_Yıl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedT_Ur_Yıl.Location = new System.Drawing.Point(108, 135);
            this.maskedT_Ur_Yıl.Mask = "0000";
            this.maskedT_Ur_Yıl.Name = "maskedT_Ur_Yıl";
            this.maskedT_Ur_Yıl.Size = new System.Drawing.Size(166, 26);
            this.maskedT_Ur_Yıl.TabIndex = 2;
            // 
            // Form_Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 673);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridC_Ur);
            this.Name = "Form_Urunler";
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.Form_Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridC_Ur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericU_Ur_Adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Ur_Sat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Ur_Al.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Ur_Model.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Ur_Marka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_Ur_Ad.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridC_Ur;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox richT_Ur_Detay;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.NumericUpDown numericU_Ur_Adet;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textE_Ur_Sat;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textE_Ur_Al;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textE_Ur_Model;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textE_Ur_Marka;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textE_Ur_Ad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox maskedT_Ur_Yıl;
        private DevExpress.XtraEditors.SimpleButton simpleB_Ur_Kaydet;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Ur_Id;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Ur_Ad;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Ur_Marka;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Ur_Model;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Ur_Yıl;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Ur_Adet;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Ur_Al;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Ur_Sat;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Ur_Detay;
        private DevExpress.XtraEditors.SimpleButton simpleB_Ur_Guncel;
        private DevExpress.XtraEditors.SimpleButton simpleB_Ur_Sil;
    }
}