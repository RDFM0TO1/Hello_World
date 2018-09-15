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
    public partial class Form_Personeller : Form
    {
        TicariBaglantiDataContext ticaridbml = new TicariBaglantiDataContext();
        TBL_PERSONELLER pertbl = new TBL_PERSONELLER();
        public Form_Personeller()
        {
            InitializeComponent();
            show_per();
            illercblist();
        }

        public void show_per()
        {
            var perlist = ticaridbml.TBL_PERSONELLERs.ToList();
            gridC_Per.DataSource = perlist;
        }
        public void make_null()
        {
            textE_Per_Ad.EditValue = null;
            textE_Per_Soyad.EditValue = null;
            maskedT_Per_Tel.Text = null;
            maskedT_Per_Tc.Text = null;
            textE_Per_Mail.EditValue = null;
            comboB_Per_Il.Text = null;
            comboB_Per_Ilce.Text = null;
            textE_Per_Gorev.EditValue = null;
            richT_Per_Adres.Text = null;
        }
        public void illercblist()
        {
            var illerlist = ticaridbml.TBL_ILLERs.ToList();
            for (int i = 0; i < illerlist.Count; i++)
            {
                comboB_Per_Il.Properties.Items.Add(illerlist[i].SEHIR);
            }
        }

        private void simpleB_Per_Kaydet_Click(object sender, EventArgs e)
        {

            pertbl.AD = Convert.ToString(textE_Per_Ad.EditValue);
            pertbl.SOYAD = Convert.ToString(textE_Per_Soyad.EditValue);
            pertbl.TELEFON = Convert.ToString(maskedT_Per_Tel.Text);
            pertbl.TC = Convert.ToString(maskedT_Per_Tc.Text);
            pertbl.MAIL = Convert.ToString(textE_Per_Mail.EditValue);
            pertbl.IL = Convert.ToString(comboB_Per_Il.EditValue);
            pertbl.ILCE = Convert.ToString(comboB_Per_Ilce.Text);
            pertbl.GOREV = Convert.ToString(textE_Per_Gorev.EditValue);
            pertbl.ADRES = Convert.ToString(richT_Per_Adres.Text);
            ticaridbml.TBL_PERSONELLERs.InsertOnSubmit(pertbl);
            ticaridbml.SubmitChanges();
            show_per();
            make_null();

        }

        private void gridView_Per_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int id = int.Parse(gridView_Per.GetRowCellValue(gridView_Per.FocusedRowHandle, "ID").ToString());
            TBL_PERSONELLER selrow = ticaridbml.TBL_PERSONELLERs.First(p => p.ID == id);
            //TBL_URUNLER selrow = gridView1.GetRow(gridView1.FocusedRowHandle) as TBL_URUNLER;
            textE_Per_Ad.EditValue = selrow.AD.ToString();
            textE_Per_Soyad.EditValue = selrow.SOYAD.ToString();
            maskedT_Per_Tel.Text = selrow.TELEFON.ToString();
            maskedT_Per_Tc.Text = selrow.TC.ToString();
            textE_Per_Mail.EditValue = selrow.MAIL.ToString();
            comboB_Per_Il.Text = selrow.IL.ToString();
            comboB_Per_Ilce.Text = selrow.ILCE.ToString();
            textE_Per_Gorev.EditValue = selrow.GOREV.ToString();
            richT_Per_Adres.Text = selrow.ADRES.ToString();
        }

        private void simpleB_Per_Sil_Click(object sender, EventArgs e)
        {
            List<int> selected_list = new List<int>();
            for (int i = 0; i < gridView_Per.DataRowCount; i++)
            {
                if (gridView_Per.IsRowSelected(i))
                {
                    selected_list.Add(i);
                }
            }
            selected_list.Reverse();
            foreach (int x in selected_list)
            {
                int id = int.Parse(gridView_Per.GetListSourceRowCellValue(x, "ID").ToString());
                TBL_PERSONELLER selrow = ticaridbml.TBL_PERSONELLERs.First(p => p.ID == id);
                ticaridbml.TBL_PERSONELLERs.DeleteOnSubmit(selrow);
                ticaridbml.SubmitChanges();
                show_per();
                make_null();
            }
        }

        private void simpleB_Per_Guncel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gridView_Per.GetRowCellValue(gridView_Per.FocusedRowHandle, "ID").ToString());
            TBL_PERSONELLER selrow = ticaridbml.TBL_PERSONELLERs.First(p => p.ID == id);
            selrow.AD = Convert.ToString(textE_Per_Ad.EditValue);
            selrow.SOYAD = Convert.ToString(textE_Per_Soyad.EditValue);
            selrow.TELEFON = Convert.ToString(maskedT_Per_Tel.Text);
            selrow.TC = Convert.ToString(maskedT_Per_Tc.Text);
            selrow.MAIL = Convert.ToString(textE_Per_Mail.EditValue);
            selrow.IL = Convert.ToString(comboB_Per_Il.EditValue);
            selrow.ILCE = Convert.ToString(comboB_Per_Ilce.Text);
            selrow.GOREV = Convert.ToString(textE_Per_Gorev.EditValue);
            selrow.ADRES = Convert.ToString(richT_Per_Adres.Text);
            ticaridbml.SubmitChanges();
            show_per();
            make_null();
        }

        private void comboB_Per_Il_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ilcelist = ticaridbml.TBL_ILCELERs.ToList();
            List<int> ilcesirasi = new List<int>();
            int id = comboB_Per_Il.SelectedIndex;

            for (int i = 0; i < ilcelist.Count; i++)
            {
                if (comboB_Per_Il.SelectedIndex + 1 == ilcelist[i].SEHIR)
                {
                    ilcesirasi.Add(i + 1);
                }
            }
            foreach (int x in ilcesirasi)
            {
                TBL_ILCELER selrow = ticaridbml.TBL_ILCELERs.First(p => p.ID == x);
                comboB_Per_Ilce.Properties.Items.Add(selrow.ILCE);
            }
        }

        private void comboB_Per_Il_EditValueChanged(object sender, EventArgs e)
        {
            comboB_Per_Ilce.Properties.Items.Clear();
        }
    }
}
