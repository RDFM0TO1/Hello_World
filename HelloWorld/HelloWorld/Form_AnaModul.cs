using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class TicariOtomasyon : Form
    {
        TicariBaglantiDataContext ticaridbml = new TicariBaglantiDataContext();
        Form_Urunler fmur;
        Form_Musteriler fmmus;
        Form_Firmalar fmfir;
        Form_Personeller fmper;
        Form_Rehber fmreh;
        Form_Giderler fmgid;
        public TicariOtomasyon()
        {
            InitializeComponent();
            
        }

        private void barUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fmur == null)
            {
                
                fmur = new Form_Urunler();
                fmur.show_ur();
                fmur.MdiParent = this;
                fmur.Show();
                
            }

        }

        private void TicariOtomasyon_Load(object sender, EventArgs e)
        {

        }

        private void barMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fmmus == null)
            {
                fmmus = new Form_Musteriler();
                fmmus.show_mus();
                fmmus.MdiParent = this;
                fmmus.Show();
                
                
            }
        }

        private void barFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fmfir == null)
            {
                fmfir = new Form_Firmalar();
                fmfir.MdiParent = this;
                fmfir.Show();
            }

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fmper == null)
            {
                fmper = new Form_Personeller();
                fmper.MdiParent = this;
                fmper.Show();
            }
        }

        private void barRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fmreh == null)
            {
                fmreh = new Form_Rehber();
                fmreh.MdiParent = this;
                fmreh.Show();
            }
        }

        private void barGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fmgid == null)
            {
                fmgid = new Form_Giderler();
                fmgid.MdiParent = this;
                fmgid.Show();
            }

        }
    }
}
