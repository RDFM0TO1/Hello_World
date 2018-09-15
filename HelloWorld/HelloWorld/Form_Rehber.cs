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
    public partial class Form_Rehber : Form
    {
        TicariBaglantiDataContext ticaridbml = new TicariBaglantiDataContext();
        Form_Mail form_mail = new Form_Mail();
        public Form_Rehber()
        {
            InitializeComponent();
            
        }

       
        private void Form_Rehber_Load(object sender, EventArgs e)
        {
            show_musteriler();
            show_firmalar();
        }

        private void show_musteriler()
        {
            TBL_MUSTERILER mustbl = new TBL_MUSTERILER();
            var muslist = ticaridbml.TBL_MUSTERILERs.Select(p => new
            {
                ID = p.ID,
                AD = p.AD,
                SOYAD = p.SOYAD,
                TELEFON = p.TELEFON,
                TELEFON2 = p.TELEFON2,
                MAIL = p.MAIL
            }).ToList();
            gridC_Reh_Mus.DataSource = muslist;
        }
        
        private void show_firmalar()
        {
            TBL_FIRMALAR firtbl = new TBL_FIRMALAR();
            var firlist = ticaridbml.TBL_FIRMALARs.Select(p => new
            {
                ID = p.ID,
                AD = p.AD,
                YETKILIADSOYAD = p.YETKILIADSOYAD,
                TELEFON1 = p.TELEFON1,
                TELEFON2 = p.TELEFON2,
                TELEFON3 = p.TELEFON3,
                MAIL = p.MAIL,
                FAX = p.FAX
            }).ToList();
            gridC_Reh_Fir.DataSource = firlist;
        }

        private void gridC_Mus_Click(object sender, EventArgs e)
        {

        }

        private void Form_Rehber_Activated(object sender, EventArgs e)//Form_Rehber sekmesine tekrar geçildiğinde ne yapılması gerektiğini gösteren event
        {
            show_musteriler();
            show_firmalar();
        }

        private void gridView_Reh_Mus_DoubleClick(object sender, EventArgs e)
        {
            Form_Mail form_mail = new Form_Mail();
            //form_mail.mail = gridView_Reh_Mus.GetFocusedRowCellValue("MAIL").ToString();//Seçili yerin fieldname değerini değişkene atar
            int id = int.Parse(gridView_Reh_Mus.GetFocusedRowCellValue("ID").ToString());
            TBL_MUSTERILER selrow = ticaridbml.TBL_MUSTERILERs.First(p=> p.ID == id);
            form_mail.mail = selrow.MAIL.ToString();
            form_mail.Show();

        }

        private void gridView_Reh_Fir_DoubleClick(object sender, EventArgs e)
        {
            Form_Mail form_mail = new Form_Mail();
            int id = int.Parse(gridView_Reh_Mus.GetFocusedRowCellValue("ID").ToString());
            TBL_FIRMALAR selrow = ticaridbml.TBL_FIRMALARs.First(p => p.ID == id);
            form_mail.mail = selrow.MAIL.ToString();
            form_mail.Show();
        }
    }
}
