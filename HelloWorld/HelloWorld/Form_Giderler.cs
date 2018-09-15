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
    public partial class Form_Giderler : Form
    {
        TicariBaglantiDataContext ticaridbml = new TicariBaglantiDataContext();
        TBL_GIDERLER gidtbl = new TBL_GIDERLER();
        public Form_Giderler()
        {
            InitializeComponent();
            show_giderler();
        }

        public void show_giderler()
        {
            var gidlist = ticaridbml.TBL_GIDERLERs.ToList();
            gridC_Giderler.DataSource = gidlist;
        }

        public void make_null() {

            comboB_Gid_Ay.EditValue = null;
            comboB_Gid_Yıl.EditValue = null;
            textE_Gid_Elektrik.Text = null;
            textE_Gid_Su.Text = null;
            textE_Gid_Doğalgaz.EditValue = null;
            textE_Gid_İnternet.Text = null;
            textE_Gid_Maaşlar.Text = null;
            textE_Gid_Ekstra.EditValue = null;
            richT_Gid_Notlar.Text = null;
        }

        private void Form_Giderler_Load(object sender, EventArgs e)
        {

        }

        private void simpleB_Gid_Kaydet_Click(object sender, EventArgs e)
        {
            gidtbl.AY = Convert.ToString(comboB_Gid_Ay.Text);
            gidtbl.YIL = Convert.ToString(comboB_Gid_Yıl.Text);
            gidtbl.ELEKTRIK = Convert.ToDecimal(textE_Gid_Elektrik.Text);
            gidtbl.SU = Convert.ToDecimal(textE_Gid_Su.Text);
            gidtbl.DOGALGAZ = Convert.ToDecimal(textE_Gid_Doğalgaz.EditValue);
            gidtbl.INTERNET = Convert.ToDecimal(textE_Gid_İnternet.Text);
            gidtbl.EKSTRA = Convert.ToDecimal(textE_Gid_Ekstra.Text);
            gidtbl.MAASLAR = Convert.ToDecimal(textE_Gid_Maaşlar.Text);
            gidtbl.NOTLAR = Convert.ToString(richT_Gid_Notlar.Text);
            ticaridbml.TBL_GIDERLERs.InsertOnSubmit(gidtbl);
            ticaridbml.SubmitChanges();
            show_giderler();
            make_null();
        }

        private void simpleB_Gid_Sil_Click(object sender, EventArgs e)
        {
            List<int> selected_list = new List<int>();
            for (int i = 0; i < gridView_Giderler.DataRowCount; i++)
            {
                if (gridView_Giderler.IsRowSelected(i))
                {
                    selected_list.Add(i);
                }
            }
            selected_list.Reverse();
            foreach (int x in selected_list)
            {
                int id = int.Parse(gridView_Giderler.GetListSourceRowCellValue(x, "ID").ToString());
                TBL_GIDERLER selrow = ticaridbml.TBL_GIDERLERs.First(p => p.ID == id);
                ticaridbml.TBL_GIDERLERs.DeleteOnSubmit(selrow);
                ticaridbml.SubmitChanges();
                show_giderler();
                make_null();
            }
        }

        private void gridView_Giderler_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int id = int.Parse(gridView_Giderler.GetRowCellValue(gridView_Giderler.FocusedRowHandle, "ID").ToString());
            TBL_GIDERLER selrow = ticaridbml.TBL_GIDERLERs.First(p => p.ID == id);
            //TBL_URUNLER selrow = gridView1.GetRow(gridView1.FocusedRowHandle) as TBL_URUNLER;
            comboB_Gid_Ay.EditValue = selrow.AY.ToString();
            comboB_Gid_Yıl.EditValue = selrow.YIL.ToString();
            textE_Gid_Elektrik.Text = selrow.ELEKTRIK.ToString();
            textE_Gid_Su.Text = selrow.SU.ToString();
            textE_Gid_Doğalgaz.EditValue = selrow.DOGALGAZ.ToString();
            textE_Gid_İnternet.Text = selrow.INTERNET.ToString();
            textE_Gid_Maaşlar.Text = selrow.MAASLAR.ToString();
            textE_Gid_Ekstra.EditValue = selrow.EKSTRA.ToString();
            richT_Gid_Notlar.Text = selrow.NOTLAR.ToString();
        }

        private void simpleB_Gid_Guncel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gridView_Giderler.GetRowCellValue(gridView_Giderler.FocusedRowHandle, "ID").ToString());
            TBL_GIDERLER selrow = ticaridbml.TBL_GIDERLERs.First(p => p.ID == id);
            selrow.AY = Convert.ToString(comboB_Gid_Ay.Text);
            selrow.YIL = Convert.ToString(comboB_Gid_Yıl.Text);
            selrow.ELEKTRIK = Convert.ToDecimal(textE_Gid_Elektrik.Text);
            selrow.SU = Convert.ToDecimal(textE_Gid_Su.Text);
            selrow.DOGALGAZ = Convert.ToDecimal(textE_Gid_Doğalgaz.EditValue);
            selrow.INTERNET = Convert.ToDecimal(textE_Gid_İnternet.EditValue);
            selrow.MAASLAR = Convert.ToDecimal(textE_Gid_Maaşlar.Text);
            selrow.EKSTRA = Convert.ToDecimal(textE_Gid_Ekstra.EditValue);
            selrow.NOTLAR = Convert.ToString(richT_Gid_Notlar.Text);
            ticaridbml.SubmitChanges();
            show_giderler();
            make_null();
        }
    }
}
