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
    public partial class Form_Musteriler : Form
    {
        TicariBaglantiDataContext ticaridbml = new TicariBaglantiDataContext();
        TBL_MUSTERILER mustbl = new TBL_MUSTERILER();

        public Form_Musteriler()
        {
            InitializeComponent();
        }

        public void show_mus()
        {
            var muslist = ticaridbml.TBL_MUSTERILERs.ToList();
            gridC_Mus.DataSource = muslist;
        }

        public void illercblist()
        {
            var illerlist = ticaridbml.TBL_ILLERs.ToList();
            for(int i = 0; i < illerlist.Count; i++)
            {
                comboB_Mus_Il.Properties.Items.Add(illerlist[i].SEHIR);
            }
            
        }

        public void make_null()
        {
            textE_Mus_Ad.EditValue = null;
            textE_Mus_Soyad.EditValue = null;
            maskedT_Mus_Tel.Text = null;
            maskedT_Mus_Tel2.Text = null;
            maskedT_Mus_Tc.Text = null;
            textE_Mus_Mail.EditValue = null;
            comboB_Mus_Il.Text = null;
            comboB_Mus_Ilce.Text = null;
            textE_Mus_VergiD.EditValue = null;
            richT_Mus_Adres.Text = null;
        }

        private void gridC_Ur_Click(object sender, EventArgs e)
        {

        }

        private void Form_Musteriler_Load(object sender, EventArgs e)
        {
            show_mus();
            illercblist();
        }

        private void comboB_Mus_Il_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ilcelist = ticaridbml.TBL_ILCELERs.ToList();
            List<int> ilcesirasi = new List<int>();
            int id = comboB_Mus_Il.SelectedIndex;
            for (int i = 0; i < ilcelist.Count; i++)
            {
                if (comboB_Mus_Il.SelectedIndex+1 == ilcelist[i].SEHIR)
                {
                    ilcesirasi.Add(i+1);  
                }
            }
            foreach(int x in ilcesirasi)
            {
                TBL_ILCELER selrow = ticaridbml.TBL_ILCELERs.First(p => p.ID == x);
                comboB_Mus_Ilce.Properties.Items.Add(selrow.ILCE);
            }
            


        }
        private void comboB_Mus_Il_EditValueChanged(object sender, EventArgs e)
        {
            comboB_Mus_Ilce.Properties.Items.Clear();
        }

        private void comboB_Mus_Il_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleB_Mus_Kaydet_Click(object sender, EventArgs e)
        {
            if (textE_Mus_Ad.EditValue == null)
            {
                
                MessageBox.Show("Tüm boşlukları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TBL_MUSTERILER mustbl = new TBL_MUSTERILER();
            mustbl.AD = Convert.ToString(textE_Mus_Ad.EditValue);
            mustbl.SOYAD = Convert.ToString(textE_Mus_Soyad.EditValue);
            mustbl.TELEFON = Convert.ToString(maskedT_Mus_Tel.Text);
            mustbl.TELEFON2 = Convert.ToString(maskedT_Mus_Tel2.Text);
            mustbl.TC = Convert.ToString(maskedT_Mus_Tc.Text);
            mustbl.MAIL = Convert.ToString(textE_Mus_Mail.EditValue);
            mustbl.IL = Convert.ToString(comboB_Mus_Il.EditValue);
            mustbl.ILCE = Convert.ToString(comboB_Mus_Ilce.Text);
            mustbl.VERGIDAIRE = Convert.ToString(textE_Mus_VergiD.EditValue);
            mustbl.ADRES = Convert.ToString(richT_Mus_Adres.Text);
            ticaridbml.TBL_MUSTERILERs.InsertOnSubmit(mustbl);
            ticaridbml.SubmitChanges();
            show_mus();
            make_null();
        }

        private void simpleB_Mus_Sil_Click(object sender, EventArgs e)
        {
            List<int> selected_list = new List<int>();
            for (int i = 0; i < gridView_Mus.DataRowCount; i++)
            {
                if (gridView_Mus.IsRowSelected(i))
                {
                    selected_list.Add(i);
                }

            }
            selected_list.Reverse();
            foreach (int i in selected_list)
            {
                int id = int.Parse(gridView_Mus.GetListSourceRowCellValue(i, "ID").ToString());
                TBL_MUSTERILER selrow = ticaridbml.TBL_MUSTERILERs.First(p => p.ID == id);
                ticaridbml.TBL_MUSTERILERs.DeleteOnSubmit(selrow);
                ticaridbml.SubmitChanges();
                show_mus();
            }
        }

        private void simpleB_Mus_Guncel_Click(object sender, EventArgs e)
        {
            
            int id = int.Parse(gridView_Mus.GetRowCellValue(gridView_Mus.FocusedRowHandle, "ID").ToString());
            TBL_MUSTERILER mustbl = ticaridbml.TBL_MUSTERILERs.First(p => p.ID == id);
            mustbl.AD = Convert.ToString(textE_Mus_Ad.EditValue);
            mustbl.SOYAD = Convert.ToString(textE_Mus_Soyad.EditValue);
            mustbl.TELEFON = Convert.ToString(maskedT_Mus_Tel.Text);
            mustbl.TELEFON2 = Convert.ToString(maskedT_Mus_Tel2.Text);
            mustbl.TC= Convert.ToString(maskedT_Mus_Tc.Text);
            mustbl.MAIL = Convert.ToString(textE_Mus_Mail.Text);
            mustbl.IL = Convert.ToString(comboB_Mus_Il.EditValue);
            mustbl.ILCE = Convert.ToString(comboB_Mus_Ilce.EditValue);
            mustbl.VERGIDAIRE = Convert.ToString(textE_Mus_VergiD.Text);
            mustbl.ADRES = Convert.ToString(richT_Mus_Adres.Text);
            ticaridbml.SubmitChanges();
            make_null();
            show_mus();
        }

        private void gridView_Mus_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int id = int.Parse(gridView_Mus.GetRowCellValue(gridView_Mus.FocusedRowHandle, "ID").ToString());
            TBL_MUSTERILER selrow = ticaridbml.TBL_MUSTERILERs.First(p => p.ID == id);
            //TBL_URUNLER selrow = gridView1.GetRow(gridView1.FocusedRowHandle) as TBL_URUNLER;
            textE_Mus_Ad.EditValue = selrow.AD.ToString();
            textE_Mus_Soyad.EditValue = selrow.SOYAD.ToString();
            maskedT_Mus_Tel.Text = selrow.TELEFON.ToString();
            maskedT_Mus_Tel2.Text = selrow.TELEFON2.ToString();
            maskedT_Mus_Tc.Text = selrow.TC.ToString();
            textE_Mus_Mail.EditValue = selrow.MAIL.ToString();
            comboB_Mus_Il.Text = selrow.IL.ToString();
            comboB_Mus_Ilce.Text = selrow.ILCE.ToString();
            textE_Mus_VergiD.EditValue = selrow.VERGIDAIRE.ToString();
            richT_Mus_Adres.Text = selrow.ADRES.ToString();
        }
    }
}
