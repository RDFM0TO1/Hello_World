namespace HelloWorld
{
    partial class Form_Rehber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Rehber));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridC_Reh_Mus = new DevExpress.XtraGrid.GridControl();
            this.gridView_Reh_Mus = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridC_Reh_Mus_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Reh_Mus_Ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Reh_Mus_Soyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Reh_Mus_Telefon1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Reh_Mus_Telefon2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Reh_Mus_Mail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridC_Reh_Fir = new DevExpress.XtraGrid.GridControl();
            this.gridView_Reh_Fir = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridC_Reh_Fir_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Reh_Fir_Ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Reh_Fir_YAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Reh_Fir_Telefon1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Reh_Fir_Telefon2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Reh_Fir_Mail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Reh_Fir_Fax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridC_Reh_Fir_Telefon3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridC_Reh_Mus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Reh_Mus)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridC_Reh_Fir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Reh_Fir)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1924, 673);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridC_Reh_Mus);
            this.xtraTabPage1.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1917, 623);
            this.xtraTabPage1.Text = "Müşteriler";
            // 
            // gridC_Reh_Mus
            // 
            this.gridC_Reh_Mus.Location = new System.Drawing.Point(0, 0);
            this.gridC_Reh_Mus.MainView = this.gridView_Reh_Mus;
            this.gridC_Reh_Mus.Name = "gridC_Reh_Mus";
            this.gridC_Reh_Mus.Size = new System.Drawing.Size(1923, 645);
            this.gridC_Reh_Mus.TabIndex = 3;
            this.gridC_Reh_Mus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Reh_Mus});
            this.gridC_Reh_Mus.Click += new System.EventHandler(this.gridC_Mus_Click);
            // 
            // gridView_Reh_Mus
            // 
            this.gridView_Reh_Mus.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView_Reh_Mus.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView_Reh_Mus.Appearance.Row.Options.UseBackColor = true;
            this.gridView_Reh_Mus.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridC_Reh_Mus_Id,
            this.gridC_Reh_Mus_Ad,
            this.gridC_Reh_Mus_Soyad,
            this.gridC_Reh_Mus_Telefon1,
            this.gridC_Reh_Mus_Telefon2,
            this.gridC_Reh_Mus_Mail});
            this.gridView_Reh_Mus.GridControl = this.gridC_Reh_Mus;
            this.gridView_Reh_Mus.Name = "gridView_Reh_Mus";
            this.gridView_Reh_Mus.OptionsSelection.MultiSelect = true;
            this.gridView_Reh_Mus.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView_Reh_Mus.DoubleClick += new System.EventHandler(this.gridView_Reh_Mus_DoubleClick);
            // 
            // gridC_Reh_Mus_Id
            // 
            this.gridC_Reh_Mus_Id.Caption = "ID";
            this.gridC_Reh_Mus_Id.FieldName = "ID";
            this.gridC_Reh_Mus_Id.Name = "gridC_Reh_Mus_Id";
            // 
            // gridC_Reh_Mus_Ad
            // 
            this.gridC_Reh_Mus_Ad.Caption = "AD";
            this.gridC_Reh_Mus_Ad.FieldName = "AD";
            this.gridC_Reh_Mus_Ad.Name = "gridC_Reh_Mus_Ad";
            this.gridC_Reh_Mus_Ad.Visible = true;
            this.gridC_Reh_Mus_Ad.VisibleIndex = 1;
            // 
            // gridC_Reh_Mus_Soyad
            // 
            this.gridC_Reh_Mus_Soyad.Caption = "SOYAD";
            this.gridC_Reh_Mus_Soyad.FieldName = "SOYAD";
            this.gridC_Reh_Mus_Soyad.Name = "gridC_Reh_Mus_Soyad";
            this.gridC_Reh_Mus_Soyad.Visible = true;
            this.gridC_Reh_Mus_Soyad.VisibleIndex = 2;
            // 
            // gridC_Reh_Mus_Telefon1
            // 
            this.gridC_Reh_Mus_Telefon1.Caption = "TELEFON";
            this.gridC_Reh_Mus_Telefon1.FieldName = "TELEFON";
            this.gridC_Reh_Mus_Telefon1.Name = "gridC_Reh_Mus_Telefon1";
            this.gridC_Reh_Mus_Telefon1.Visible = true;
            this.gridC_Reh_Mus_Telefon1.VisibleIndex = 3;
            // 
            // gridC_Reh_Mus_Telefon2
            // 
            this.gridC_Reh_Mus_Telefon2.Caption = "TELEFON(2)";
            this.gridC_Reh_Mus_Telefon2.FieldName = "TELEFON2";
            this.gridC_Reh_Mus_Telefon2.Name = "gridC_Reh_Mus_Telefon2";
            this.gridC_Reh_Mus_Telefon2.Visible = true;
            this.gridC_Reh_Mus_Telefon2.VisibleIndex = 4;
            // 
            // gridC_Reh_Mus_Mail
            // 
            this.gridC_Reh_Mus_Mail.Caption = "MAIL";
            this.gridC_Reh_Mus_Mail.FieldName = "MAIL";
            this.gridC_Reh_Mus_Mail.Name = "gridC_Reh_Mus_Mail";
            this.gridC_Reh_Mus_Mail.Visible = true;
            this.gridC_Reh_Mus_Mail.VisibleIndex = 5;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridC_Reh_Fir);
            this.xtraTabPage2.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1917, 623);
            this.xtraTabPage2.Text = "Firmalar";
            // 
            // gridC_Reh_Fir
            // 
            this.gridC_Reh_Fir.Location = new System.Drawing.Point(-3, -3);
            this.gridC_Reh_Fir.MainView = this.gridView_Reh_Fir;
            this.gridC_Reh_Fir.Name = "gridC_Reh_Fir";
            this.gridC_Reh_Fir.Size = new System.Drawing.Size(1923, 645);
            this.gridC_Reh_Fir.TabIndex = 4;
            this.gridC_Reh_Fir.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Reh_Fir});
            // 
            // gridView_Reh_Fir
            // 
            this.gridView_Reh_Fir.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView_Reh_Fir.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView_Reh_Fir.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.gridView_Reh_Fir.Appearance.Row.Options.UseBackColor = true;
            this.gridView_Reh_Fir.Appearance.Row.Options.UseBorderColor = true;
            this.gridView_Reh_Fir.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridC_Reh_Fir_Id,
            this.gridC_Reh_Fir_Ad,
            this.gridC_Reh_Fir_YAdSoyad,
            this.gridC_Reh_Fir_Telefon1,
            this.gridC_Reh_Fir_Telefon2,
            this.gridC_Reh_Fir_Mail,
            this.gridC_Reh_Fir_Fax,
            this.gridC_Reh_Fir_Telefon3});
            this.gridView_Reh_Fir.GridControl = this.gridC_Reh_Fir;
            this.gridView_Reh_Fir.Name = "gridView_Reh_Fir";
            this.gridView_Reh_Fir.OptionsSelection.MultiSelect = true;
            this.gridView_Reh_Fir.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView_Reh_Fir.DoubleClick += new System.EventHandler(this.gridView_Reh_Fir_DoubleClick);
            // 
            // gridC_Reh_Fir_Id
            // 
            this.gridC_Reh_Fir_Id.Caption = "ID";
            this.gridC_Reh_Fir_Id.FieldName = "ID";
            this.gridC_Reh_Fir_Id.Name = "gridC_Reh_Fir_Id";
            // 
            // gridC_Reh_Fir_Ad
            // 
            this.gridC_Reh_Fir_Ad.Caption = "AD";
            this.gridC_Reh_Fir_Ad.FieldName = "AD";
            this.gridC_Reh_Fir_Ad.Name = "gridC_Reh_Fir_Ad";
            this.gridC_Reh_Fir_Ad.Visible = true;
            this.gridC_Reh_Fir_Ad.VisibleIndex = 1;
            // 
            // gridC_Reh_Fir_YAdSoyad
            // 
            this.gridC_Reh_Fir_YAdSoyad.Caption = "YETKILI";
            this.gridC_Reh_Fir_YAdSoyad.FieldName = "YETKILIADSOYAD";
            this.gridC_Reh_Fir_YAdSoyad.Name = "gridC_Reh_Fir_YAdSoyad";
            this.gridC_Reh_Fir_YAdSoyad.Visible = true;
            this.gridC_Reh_Fir_YAdSoyad.VisibleIndex = 2;
            // 
            // gridC_Reh_Fir_Telefon1
            // 
            this.gridC_Reh_Fir_Telefon1.Caption = "TELEFON";
            this.gridC_Reh_Fir_Telefon1.FieldName = "TELEFON";
            this.gridC_Reh_Fir_Telefon1.Name = "gridC_Reh_Fir_Telefon1";
            this.gridC_Reh_Fir_Telefon1.Visible = true;
            this.gridC_Reh_Fir_Telefon1.VisibleIndex = 3;
            // 
            // gridC_Reh_Fir_Telefon2
            // 
            this.gridC_Reh_Fir_Telefon2.Caption = "TELEFON(2)";
            this.gridC_Reh_Fir_Telefon2.FieldName = "TELEFON2";
            this.gridC_Reh_Fir_Telefon2.Name = "gridC_Reh_Fir_Telefon2";
            this.gridC_Reh_Fir_Telefon2.Visible = true;
            this.gridC_Reh_Fir_Telefon2.VisibleIndex = 4;
            // 
            // gridC_Reh_Fir_Mail
            // 
            this.gridC_Reh_Fir_Mail.Caption = "MAIL";
            this.gridC_Reh_Fir_Mail.FieldName = "MAIL";
            this.gridC_Reh_Fir_Mail.Name = "gridC_Reh_Fir_Mail";
            this.gridC_Reh_Fir_Mail.Visible = true;
            this.gridC_Reh_Fir_Mail.VisibleIndex = 6;
            // 
            // gridC_Reh_Fir_Fax
            // 
            this.gridC_Reh_Fir_Fax.Caption = "FAX";
            this.gridC_Reh_Fir_Fax.FieldName = "FAX";
            this.gridC_Reh_Fir_Fax.Name = "gridC_Reh_Fir_Fax";
            this.gridC_Reh_Fir_Fax.Visible = true;
            this.gridC_Reh_Fir_Fax.VisibleIndex = 7;
            // 
            // gridC_Reh_Fir_Telefon3
            // 
            this.gridC_Reh_Fir_Telefon3.Caption = "TELEFON(3)";
            this.gridC_Reh_Fir_Telefon3.FieldName = "TELEFON3";
            this.gridC_Reh_Fir_Telefon3.Name = "gridC_Reh_Fir_Telefon3";
            this.gridC_Reh_Fir_Telefon3.Visible = true;
            this.gridC_Reh_Fir_Telefon3.VisibleIndex = 5;
            // 
            // Form_Rehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 673);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "Form_Rehber";
            this.Text = "REHBER";
            this.Activated += new System.EventHandler(this.Form_Rehber_Activated);
            this.Load += new System.EventHandler(this.Form_Rehber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridC_Reh_Mus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Reh_Mus)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridC_Reh_Fir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Reh_Fir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridC_Reh_Mus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Reh_Mus;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Reh_Mus_Id;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Reh_Mus_Ad;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Reh_Mus_Soyad;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Reh_Mus_Telefon1;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Reh_Mus_Telefon2;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Reh_Mus_Mail;
        private DevExpress.XtraGrid.GridControl gridC_Reh_Fir;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Reh_Fir;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Reh_Fir_Id;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Reh_Fir_Ad;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Reh_Fir_YAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Reh_Fir_Telefon1;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Reh_Fir_Telefon2;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Reh_Fir_Mail;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Reh_Fir_Fax;
        private DevExpress.XtraGrid.Columns.GridColumn gridC_Reh_Fir_Telefon3;
    }
}