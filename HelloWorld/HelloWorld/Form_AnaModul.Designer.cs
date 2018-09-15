namespace HelloWorld
{
    partial class TicariOtomasyon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicariOtomasyon));
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barAnasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.barUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.barMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.barFirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.barPersoneller = new DevExpress.XtraBars.BarButtonItem();
            this.barRehber = new DevExpress.XtraBars.BarButtonItem();
            this.barStoklar = new DevExpress.XtraBars.BarButtonItem();
            this.barGiderler = new DevExpress.XtraBars.BarButtonItem();
            this.barKasa = new DevExpress.XtraBars.BarButtonItem();
            this.barBankalar = new DevExpress.XtraBars.BarButtonItem();
            this.barNotlar = new DevExpress.XtraBars.BarButtonItem();
            this.barFaturalar = new DevExpress.XtraBars.BarButtonItem();
            this.barAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "TİCARİ OTOMASYON";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowMinimize = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barAnasayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.barUrunler);
            this.ribbonPageGroup1.ItemLinks.Add(this.barMusteriler);
            this.ribbonPageGroup1.ItemLinks.Add(this.barFirmalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barPersoneller);
            this.ribbonPageGroup1.ItemLinks.Add(this.barGiderler);
            this.ribbonPageGroup1.ItemLinks.Add(this.barRehber);
            this.ribbonPageGroup1.ItemLinks.Add(this.barStoklar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barKasa, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBankalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barNotlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barFaturalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barAyarlar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // barAnasayfa
            // 
            this.barAnasayfa.Caption = "ANASAYFA";
            this.barAnasayfa.Id = 5;
            this.barAnasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAnasayfa.ImageOptions.Image")));
            this.barAnasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barAnasayfa.ImageOptions.LargeImage")));
            this.barAnasayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barAnasayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.barAnasayfa.Name = "barAnasayfa";
            // 
            // barUrunler
            // 
            this.barUrunler.Caption = "ÜRÜNLER";
            this.barUrunler.Id = 1;
            this.barUrunler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barUrunler.ImageOptions.Image")));
            this.barUrunler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barUrunler.ImageOptions.LargeImage")));
            this.barUrunler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barUrunler.ItemAppearance.Normal.Options.UseFont = true;
            this.barUrunler.Name = "barUrunler";
            this.barUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barUrunler_ItemClick);
            // 
            // barMusteriler
            // 
            this.barMusteriler.Caption = "MÜŞTERİLER";
            this.barMusteriler.Id = 3;
            this.barMusteriler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barMusteriler.ImageOptions.Image")));
            this.barMusteriler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barMusteriler.ImageOptions.LargeImage")));
            this.barMusteriler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barMusteriler.ItemAppearance.Normal.Options.UseFont = true;
            this.barMusteriler.Name = "barMusteriler";
            this.barMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barMusteriler_ItemClick);
            // 
            // barFirmalar
            // 
            this.barFirmalar.Caption = "FİRMALAR";
            this.barFirmalar.Id = 4;
            this.barFirmalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barFirmalar.ImageOptions.Image")));
            this.barFirmalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barFirmalar.ImageOptions.LargeImage")));
            this.barFirmalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barFirmalar.ItemAppearance.Normal.Options.UseFont = true;
            this.barFirmalar.Name = "barFirmalar";
            this.barFirmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barFirmalar_ItemClick);
            // 
            // barPersoneller
            // 
            this.barPersoneller.Caption = "PERSONELLER";
            this.barPersoneller.Id = 6;
            this.barPersoneller.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barPersoneller.ImageOptions.Image")));
            this.barPersoneller.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barPersoneller.ImageOptions.LargeImage")));
            this.barPersoneller.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barPersoneller.ItemAppearance.Normal.Options.UseFont = true;
            this.barPersoneller.Name = "barPersoneller";
            this.barPersoneller.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barPersoneller_ItemClick);
            // 
            // barRehber
            // 
            this.barRehber.Caption = "REHBER";
            this.barRehber.Id = 11;
            this.barRehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barRehber.ImageOptions.Image")));
            this.barRehber.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barRehber.ImageOptions.LargeImage")));
            this.barRehber.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barRehber.ItemAppearance.Normal.Options.UseFont = true;
            this.barRehber.Name = "barRehber";
            this.barRehber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barRehber_ItemClick);
            // 
            // barStoklar
            // 
            this.barStoklar.Caption = "STOKLAR";
            this.barStoklar.Id = 2;
            this.barStoklar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barStoklar.ImageOptions.Image")));
            this.barStoklar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barStoklar.ImageOptions.LargeImage")));
            this.barStoklar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStoklar.ItemAppearance.Normal.Options.UseFont = true;
            this.barStoklar.Name = "barStoklar";
            // 
            // barGiderler
            // 
            this.barGiderler.Caption = "GİDERLER";
            this.barGiderler.Id = 7;
            this.barGiderler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barGiderler.ImageOptions.Image")));
            this.barGiderler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barGiderler.ImageOptions.LargeImage")));
            this.barGiderler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barGiderler.ItemAppearance.Normal.Options.UseFont = true;
            this.barGiderler.Name = "barGiderler";
            this.barGiderler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barGiderler_ItemClick);
            // 
            // barKasa
            // 
            this.barKasa.Caption = "KASA";
            this.barKasa.Id = 8;
            this.barKasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barKasa.ImageOptions.Image")));
            this.barKasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barKasa.ImageOptions.LargeImage")));
            this.barKasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barKasa.ItemAppearance.Normal.Options.UseFont = true;
            this.barKasa.Name = "barKasa";
            // 
            // barBankalar
            // 
            this.barBankalar.Caption = "BANKALAR";
            this.barBankalar.Id = 10;
            this.barBankalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBankalar.ImageOptions.Image")));
            this.barBankalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBankalar.ImageOptions.LargeImage")));
            this.barBankalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barBankalar.ItemAppearance.Normal.Options.UseFont = true;
            this.barBankalar.Name = "barBankalar";
            // 
            // barNotlar
            // 
            this.barNotlar.Caption = "NOTLAR";
            this.barNotlar.Id = 9;
            this.barNotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barNotlar.ImageOptions.Image")));
            this.barNotlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barNotlar.ImageOptions.LargeImage")));
            this.barNotlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barNotlar.ItemAppearance.Normal.Options.UseFont = true;
            this.barNotlar.Name = "barNotlar";
            // 
            // barFaturalar
            // 
            this.barFaturalar.Caption = "FATURALAR";
            this.barFaturalar.Id = 12;
            this.barFaturalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barFaturalar.ImageOptions.Image")));
            this.barFaturalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barFaturalar.ImageOptions.LargeImage")));
            this.barFaturalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barFaturalar.ItemAppearance.Normal.Options.UseFont = true;
            this.barFaturalar.Name = "barFaturalar";
            // 
            // barAyarlar
            // 
            this.barAyarlar.Caption = "AYARLAR";
            this.barAyarlar.Id = 13;
            this.barAyarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAyarlar.ImageOptions.Image")));
            this.barAyarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barAyarlar.ImageOptions.LargeImage")));
            this.barAyarlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barAyarlar.ItemAppearance.Normal.Options.UseFont = true;
            this.barAyarlar.Name = "barAyarlar";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barUrunler,
            this.barStoklar,
            this.barMusteriler,
            this.barFirmalar,
            this.barAnasayfa,
            this.barPersoneller,
            this.barGiderler,
            this.barKasa,
            this.barNotlar,
            this.barBankalar,
            this.barRehber,
            this.barFaturalar,
            this.barAyarlar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(1920, 177);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // TicariOtomasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "TicariOtomasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticari Otomasyon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TicariOtomasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barAnasayfa;
        private DevExpress.XtraBars.BarButtonItem barUrunler;
        private DevExpress.XtraBars.BarButtonItem barStoklar;
        private DevExpress.XtraBars.BarButtonItem barMusteriler;
        private DevExpress.XtraBars.BarButtonItem barFirmalar;
        private DevExpress.XtraBars.BarButtonItem barPersoneller;
        private DevExpress.XtraBars.BarButtonItem barGiderler;
        private DevExpress.XtraBars.BarButtonItem barKasa;
        private DevExpress.XtraBars.BarButtonItem barNotlar;
        private DevExpress.XtraBars.BarButtonItem barBankalar;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barRehber;
        private DevExpress.XtraBars.BarButtonItem barFaturalar;
        private DevExpress.XtraBars.BarButtonItem barAyarlar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

