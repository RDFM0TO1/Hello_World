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
    public partial class Form_Firmalar : Form
    {
        TicariBaglantiDataContext ticaridbml = new TicariBaglantiDataContext();
        public Form_Firmalar()
        {
            InitializeComponent();
            illercblist();
            
        }
        public void illercblist()
        {
            var illerlist = ticaridbml.TBL_ILLERs.ToList();
            for (int i = 0; i < illerlist.Count; i++)
            {
                comboB_Fir_Il.Properties.Items.Add(illerlist[i].SEHIR);
            }

        }

        public void show_fir()
        {
            var firmalist = ticaridbml.TBL_FIRMALARs.ToList();
            gridC_Firm.DataSource = firmalist;
        }
        
        void make_null()
        {
            textE_Fir_Ad.Text = null;
            textE_Fir_Sektör.Text = null;
            textE_Fir_Yetkili.Text = null;
            textE_Fir_YGörev.Text = null;
            maskedT_Fir_YTc.Text = null;
            maskedT_Fir_Tel1.Text = null;
            maskedT_Fir_Tel2.Text = null;
            maskedT_Fir_Tel3.Text = null;
            maskedT_Fir_Fax.Text = null;
            textE_Fir_Mail.Text = null;
            comboB_Fir_Il.Text = null;
            comboB_Fir_Ilce.Text = null;
            textE_Fir_VDaire.Text = null;
            richT_Fir_Adres.Text = null;
            textE_Fir_Kod1.Text = null;
            textE_Fir_Kod2.Text = null;
            textE_Fir_Kod3.Text = null;
        }

        public void ozelkodgöster()
        {
            TBL_OZELKODLAR selrow = ticaridbml.TBL_OZELKODLARs.First(p => p.ID == 1);
            richT_Fir_Kod1.Text = selrow.FIRMAKOD1.ToString();
        }

        private void Form_Firmalar_Load(object sender, EventArgs e)
        {
            show_fir();
            ozelkodgöster();
        }

        private void gridView_Firm_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int id = int.Parse(gridView_Firm.GetRowCellValue(gridView_Firm.FocusedRowHandle, "ID").ToString());
            TBL_FIRMALAR selrow = ticaridbml.TBL_FIRMALARs.First(p => p.ID == id);
            //TBL_URUNLER selrow = gridView1.GetRow(gridView1.FocusedRowHandle) as TBL_URUNLER;
            textE_Fir_Ad.Text = selrow.AD.ToString();
            textE_Fir_Sektör.Text = selrow.SEKTOR.ToString();
            textE_Fir_Yetkili.Text = selrow.YETKILIADSOYAD.ToString();
            textE_Fir_YGörev.Text = selrow.YETKILISTATU.ToString();
            maskedT_Fir_YTc.Text = selrow.YETKILITC.ToString();
            maskedT_Fir_Tel1.Text = selrow.TELEFON1.ToString();
            maskedT_Fir_Tel2.Text = selrow.TELEFON2.ToString();
            maskedT_Fir_Tel3.Text = selrow.TELEFON3.ToString();
            maskedT_Fir_Fax.Text = selrow.FAX.ToString();
            textE_Fir_Mail.Text = selrow.MAIL.ToString();
            comboB_Fir_Il.Text = selrow.IL.ToString();
            comboB_Fir_Ilce.Text = selrow.ILCE.ToString();
            textE_Fir_VDaire.Text = selrow.VERGIDAIRE.ToString();
            richT_Fir_Adres.Text = selrow.ADRES.ToString();
            textE_Fir_Kod1.Text = selrow.OZELKOD1.ToString();
            textE_Fir_Kod2.Text = selrow.OZELKOD2.ToString();
            textE_Fir_Kod3.Text = selrow.OZELKOD3.ToString();
            

        }

        private void simpleB_Fir_Kaydet_Click(object sender, EventArgs e)
        {
            TBL_FIRMALAR firmtbl = new TBL_FIRMALAR();
            firmtbl.AD = Convert.ToString(textE_Fir_Ad.Text);
            firmtbl.SEKTOR = Convert.ToString(textE_Fir_Sektör.Text);
            firmtbl.YETKILIADSOYAD = Convert.ToString(textE_Fir_Yetkili.Text);
            firmtbl.YETKILISTATU = Convert.ToString(textE_Fir_YGörev.Text);
            firmtbl.YETKILITC = Convert.ToString(maskedT_Fir_YTc.Text);
            firmtbl.TELEFON1 = Convert.ToString(maskedT_Fir_Tel1.Text);
            firmtbl.TELEFON2 = Convert.ToString(maskedT_Fir_Tel2.Text);
            firmtbl.TELEFON3 = Convert.ToString(maskedT_Fir_Tel3.Text);
            firmtbl.FAX = Convert.ToString(maskedT_Fir_Fax.Text);
            firmtbl.MAIL = Convert.ToString(textE_Fir_Mail.Text);
            firmtbl.IL = Convert.ToString(comboB_Fir_Il.Text);
            firmtbl.ILCE = Convert.ToString(comboB_Fir_Ilce.Text);
            firmtbl.VERGIDAIRE = Convert.ToString(textE_Fir_VDaire.Text);
            firmtbl.ADRES = Convert.ToString(richT_Fir_Adres.Text);
            firmtbl.OZELKOD1 = Convert.ToString(textE_Fir_Kod1.Text);
            firmtbl.OZELKOD2 = Convert.ToString(textE_Fir_Kod2.Text);
            firmtbl.OZELKOD3 = Convert.ToString(textE_Fir_Kod3.Text);
            ticaridbml.TBL_FIRMALARs.InsertOnSubmit(firmtbl);
            ticaridbml.SubmitChanges();
            make_null();
            show_fir();
        }

        private void simpleB_Fir_Guncel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gridView_Firm.GetRowCellValue(gridView_Firm.FocusedRowHandle, "ID").ToString());
            TBL_FIRMALAR firmtbl = ticaridbml.TBL_FIRMALARs.First(p => p.ID == id);
            firmtbl.AD = Convert.ToString(textE_Fir_Ad.Text);
            firmtbl.SEKTOR = Convert.ToString(textE_Fir_Sektör.Text);
            firmtbl.YETKILIADSOYAD = Convert.ToString(textE_Fir_Yetkili.Text);
            firmtbl.YETKILISTATU = Convert.ToString(textE_Fir_YGörev.Text);
            firmtbl.YETKILITC = Convert.ToString(maskedT_Fir_YTc.Text);
            firmtbl.TELEFON1 = Convert.ToString(maskedT_Fir_Tel1.Text);
            firmtbl.TELEFON2 = Convert.ToString(maskedT_Fir_Tel2.Text);
            firmtbl.TELEFON3 = Convert.ToString(maskedT_Fir_Tel3.Text);
            firmtbl.FAX = Convert.ToString(maskedT_Fir_Fax.Text);
            firmtbl.MAIL = Convert.ToString(textE_Fir_Mail.Text);
            firmtbl.IL = Convert.ToString(comboB_Fir_Il.Text);
            firmtbl.ILCE = Convert.ToString(comboB_Fir_Ilce.Text);
            firmtbl.VERGIDAIRE = Convert.ToString(textE_Fir_VDaire.Text);
            firmtbl.ADRES = Convert.ToString(richT_Fir_Adres.Text);
            firmtbl.OZELKOD1 = Convert.ToString(textE_Fir_Kod1.Text);
            firmtbl.OZELKOD2 = Convert.ToString(textE_Fir_Kod2.Text);
            firmtbl.OZELKOD3 = Convert.ToString(textE_Fir_Kod3.Text);
            ticaridbml.SubmitChanges();
            make_null();
            show_fir();
        }

        private void simpleB_Fir_Sil_Click(object sender, EventArgs e)
        {
            List<int> selected_list = new List<int>();
            for (int i = 0; i < gridView_Firm.DataRowCount; i++)
            {
                if (gridView_Firm.IsRowSelected(i))
                {
                    selected_list.Add(i);
                }

            }
            selected_list.Reverse();
            foreach (int i in selected_list)
            {
                int id = int.Parse(gridView_Firm.GetListSourceRowCellValue(i, "ID").ToString());
                TBL_FIRMALAR selrow = ticaridbml.TBL_FIRMALARs.First(p => p.ID == id);
                ticaridbml.TBL_FIRMALARs.DeleteOnSubmit(selrow);
                ticaridbml.SubmitChanges();
                show_fir();
                make_null();
            }
        }

        private void comboB_Fir_Il_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ilcelist = ticaridbml.TBL_ILCELERs.ToList();
            List<int> ilcesirasi = new List<int>();
            int id = comboB_Fir_Il.SelectedIndex;
            for (int i = 0; i < ilcelist.Count; i++)
            {
                if (comboB_Fir_Il.SelectedIndex + 1 == ilcelist[i].SEHIR)
                {
                    ilcesirasi.Add(i + 1);
                }
            }
            foreach (int x in ilcesirasi)
            {
                TBL_ILCELER selrow = ticaridbml.TBL_ILCELERs.First(p => p.ID == x);
                comboB_Fir_Ilce.Properties.Items.Add(selrow.ILCE);
            }
        }

        private void comboB_Fir_Il_EditValueChanged(object sender, EventArgs e)
        {
            comboB_Fir_Ilce.Properties.Items.Clear();
        }
    }
}
