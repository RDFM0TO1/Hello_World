using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress;
using DevExpress.XtraEditors;


namespace HelloWorld
{
    
    public partial class Form_Urunler : Form

    {
        
        TicariBaglantiDataContext ticaridbml = new TicariBaglantiDataContext();
        
        public Form_Urunler()
        {
            InitializeComponent();
            show_ur();
            make_null();
            
            
        }
        public void make_null()
        {
            textE_Ur_Ad.EditValue = null;
            textE_Ur_Marka.EditValue = null;
            textE_Ur_Model.EditValue = null;
            maskedT_Ur_Yıl.Text = null;
            textE_Ur_Al.EditValue = null;
            textE_Ur_Sat.EditValue = null;
            numericU_Ur_Adet.Value = 0;
            richT_Ur_Detay.Text = null;
        }
        public void show_ur()
        {
            var urlist = ticaridbml.TBL_URUNLERs.ToList();
            gridC_Ur.DataSource = urlist;
    
        }


        private void simpleB_Ur_Kaydet_Click(object sender, EventArgs e)
        {
            if(textE_Ur_Ad.EditValue == null)
            {
                make_null();
                XtraMessageBox.Show("Tüm boşlukları doldurunuz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            TBL_URUNLER urtbl = new TBL_URUNLER();
            urtbl.URUNAD = Convert.ToString(textE_Ur_Ad.EditValue);
            urtbl.MARKA = Convert.ToString(textE_Ur_Marka.EditValue);
            urtbl.MODEL = Convert.ToString(textE_Ur_Model.EditValue);
            urtbl.YIL = Convert.ToString(maskedT_Ur_Yıl.Text);
            urtbl.ADET = Convert.ToInt16(numericU_Ur_Adet.Value);
            urtbl.ALISFIYAT = Convert.ToDecimal(textE_Ur_Al.EditValue);
            urtbl.SATISFIYAT = Convert.ToDecimal(textE_Ur_Sat.EditValue);
            urtbl.DETAY = Convert.ToString(richT_Ur_Detay.Text);
            ticaridbml.TBL_URUNLERs.InsertOnSubmit(urtbl);
            ticaridbml.SubmitChanges();
            make_null();
            show_ur();
        }

        private void simpleB_Ur_Sil_Click(object sender, EventArgs e)
        {
            List<int> selected_list = new List<int>();
            for(int i = 0; i < gridView1.DataRowCount; i++)
            {
                if (gridView1.IsRowSelected(i))
                {
                    selected_list.Add(i);
                }

            }
            selected_list.Reverse();
            foreach(int i in selected_list)
            {
                int id = int.Parse(gridView1.GetListSourceRowCellValue(i, "ID").ToString());
                TBL_URUNLER selrow = ticaridbml.TBL_URUNLERs.First(p => p.ID == id);
                ticaridbml.TBL_URUNLERs.DeleteOnSubmit(selrow);
                ticaridbml.SubmitChanges();
                show_ur();
            }
        }

        private void simpleB_Ur_Guncel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            TBL_URUNLER urtbl = ticaridbml.TBL_URUNLERs.First(p=> p.ID ==id);
            urtbl.URUNAD = Convert.ToString(textE_Ur_Ad.EditValue);
            urtbl.MARKA = Convert.ToString(textE_Ur_Marka.EditValue);
            urtbl.MODEL = Convert.ToString(textE_Ur_Model.EditValue);
            urtbl.YIL = Convert.ToString(maskedT_Ur_Yıl.Text);
            urtbl.ADET = Convert.ToInt16(numericU_Ur_Adet.Value);
            urtbl.ALISFIYAT = Convert.ToDecimal(textE_Ur_Al.Text);
            urtbl.SATISFIYAT = Convert.ToDecimal(textE_Ur_Sat.Text);
            urtbl.DETAY = Convert.ToString(richT_Ur_Detay.Text);
            ticaridbml.SubmitChanges();
            make_null();
            show_ur();

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            TBL_URUNLER selrow = ticaridbml.TBL_URUNLERs.First(p=> p.ID ==id);
            //TBL_URUNLER selrow = gridView1.GetRow(gridView1.FocusedRowHandle) as TBL_URUNLER;
            textE_Ur_Ad.Text = selrow.URUNAD.ToString();
            textE_Ur_Marka.Text = selrow.MARKA.ToString();
            textE_Ur_Model.Text = selrow.MODEL.ToString();
            maskedT_Ur_Yıl.Text = selrow.YIL.ToString();
            numericU_Ur_Adet.Text = selrow.ADET.ToString();
            textE_Ur_Al.Text = selrow.ALISFIYAT.ToString();
            textE_Ur_Sat.Text = selrow.SATISFIYAT.ToString();
            richT_Ur_Detay.Text = selrow.DETAY.ToString();
            
        }

        private void gridC_Ur_Click(object sender, EventArgs e)
        {

        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void Form_Urunler_Load(object sender, EventArgs e)
        {
            show_ur();
        }
    }
}
