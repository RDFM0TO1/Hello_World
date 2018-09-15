using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress;

namespace RegistryBook
{
    
    public partial class RegistryBook : Form
    {
        RegistryclasDataContext data = new RegistryclasDataContext();

        public RegistryBook()
        {
            InitializeComponent();
            calender.EditValue = DateTime.Now.ToShortDateString();
            showdata();
            showdata_backup();
        }
        void showdata()//Birinci grid ekranına table'dan veri çekerek ekran güncellemesi yapar
        {
            var listgrid = data.RegistryTBs.Select(p => new
            {
                Id = p.Id,
                Name = Convert.ToString(p.Name),
                Lastname = Convert.ToString(p.Lastname),
                Gsm = Convert.ToString(p.Gsm)
                


            }).ToList();
            grid_registry.DataSource = listgrid;


        }
        void showdata_backup()//İkinci grid ekranına table'dan veri çekerek ekran güncellemesi yapar
        {
            var sellistgrid = data.BackupTBs.Select(p => new
            {
                ID = p.ID,
                NAME = Convert.ToString(p.NAME),
                LASTNAME = Convert.ToString(p.LASTNAME),
                GSM = Convert.ToString(p.GSM)



            }).ToList();
            grid_backup.DataSource = sellistgrid;
        }

            private void delete(int selnumber)// delete butonu kodları(iki grid ekranında da silme işlemi yapar)
        {
            int selnum = selnumber % 2;
            if (selnum == 1)
            {
                List<int> seciligridd = new List<int>();
                for (int i = 0; i <= gridView1.DataRowCount; i++)
                {
                    if (gridView1.IsRowSelected(i))
                    {
                        seciligridd.Add(i);
                    }
                }
                seciligridd.Reverse();
                foreach (int eleman in seciligridd)//Grid ekranında seçilen verileri seçilen table'lara yazar(bu işlemi id değerlerini bulup bunları tabledan işleyerek yapar)

                {

                    int id = int.Parse(gridView1.GetListSourceRowCellValue(eleman, "Id").ToString());
                    RegistryTB selrow = data.RegistryTBs.First(p => p.Id == id);
                    data.RegistryTBs.DeleteOnSubmit(selrow);
                    data.SubmitChanges();
                    showdata();
                }
            }

            else if (selnum == 0)
            {
                List<int> seciligrid2 = new List<int>();
                for (int i = 0; i <= gridView2.DataRowCount; i++)
                {
                    if (gridView2.IsRowSelected(i))
                    {
                        seciligrid2.Add(i);
                    }
                }
                seciligrid2.Reverse();
                foreach (int eleman2 in seciligrid2)
                {

                    int id2 = int.Parse(gridView2.GetListSourceRowCellValue(eleman2, "ID").ToString());
                    BackupTB sel_row = data.BackupTBs.First(p => p.ID == id2);
                    data.BackupTBs.DeleteOnSubmit(sel_row);
                    data.SubmitChanges();
                    showdata_backup();
                    showdata();
                }
            }   
        }
        
        private void save_grid() //Copy(down) butonu kodları(gridler arası veri kopyalama yapar)
        {
            List<int> copygrid = new List<int>();
            for (int i = 0; i <= gridView1.DataRowCount; i++)
            {
                if (gridView1.IsRowSelected(i))
                {
                    copygrid.Add(i);
                }
            }
            foreach(int x in copygrid)//Burada listeden çekilen seçili eleman verisi diğer table üstüne yazılır.
            {
                BackupTB backuptb = new BackupTB();
                int cid = int.Parse(gridView1.GetListSourceRowCellValue(x,"Id").ToString());
                RegistryTB sel_row = data.RegistryTBs.First(p => p.Id == cid);
                backuptb.NAME = sel_row.Name;
                backuptb.LASTNAME = sel_row.Lastname;
                backuptb.GSM = sel_row.Gsm;
                data.BackupTBs.InsertOnSubmit(backuptb);
                data.SubmitChanges();
                showdata();
                showdata_backup();
                
            }

        }
        private void update_grid(int selnumber)//Seçili id'nin değerlerini güncellemeye yarar
        {
            int selnum = selnumber % 2;
            if (selnum == 1)
            {

                for (int i = 0; i <= gridView1.DataRowCount; i++)
                {
                    if (gridView1.IsRowSelected(i))
                    {
                        int id = int.Parse(gridView1.GetRowCellValue(i, "Id").ToString());
                        RegistryTB selrow = data.RegistryTBs.First(p => p.Id == id);
                        selrow.Name = Convert.ToString(textE_name.EditValue);
                        selrow.Lastname = Convert.ToString(textE_lastname.EditValue);
                        selrow.Gsm = Convert.ToString(textE_gsm.EditValue);
                        make_null();
                        data.SubmitChanges();
                        showdata();
                    }
                }
            }
            else if (selnum == 0)
            {

                for (int i = 0; i <= gridView2.DataRowCount; i++)
                {
                    if (gridView2.IsRowSelected(i))
                    {
                        int id = int.Parse(gridView2.GetRowCellValue(i, "ID").ToString());
                        BackupTB selrow = data.BackupTBs.First(p => p.ID == id);
                        selrow.NAME = Convert.ToString(textE_name.EditValue);
                        selrow.LASTNAME = Convert.ToString(textE_lastname.EditValue);
                        selrow.GSM = Convert.ToString(textE_gsm.EditValue);
                        make_null();
                        data.SubmitChanges();
                        showdata_backup();
                    }
                }
            }
        }

        private void make_null()
        {
            textE_name.EditValue = null;
            textE_lastname.EditValue = null;
            textE_gsm.EditValue = null;
        }

        private void saveButton_Click(object sender, EventArgs e)//texteditten alınan veriler database'e kaydedilir.
        {
            if(textE_name.EditValue==null)
            {
                make_null();
                XtraMessageBox.Show("FILL IN THE ALL BLANKS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RegistryTB datatb = new RegistryTB();
            datatb.Name = Convert.ToString(textE_name.EditValue);
            datatb.Lastname = Convert.ToString(textE_lastname.EditValue);
            datatb.Gsm = Convert.ToString(textE_gsm.EditValue);
            data.RegistryTBs.InsertOnSubmit(datatb);
            data.SubmitChanges();
            make_null();
            showdata();
            XtraMessageBox.Show("INSERT IS SUCCED", "SUCCED", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void updateButton1_Click(object sender, EventArgs e)
        {
            update_grid(1);
            update_grid(2);
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            delete(1);
            delete(2);
            
        }
        private void copyButton_Click(object sender, EventArgs e)
        {
            save_grid();
        }

        private void RegistryBook_Load(object sender, EventArgs e)
        {
             
        }


    }
}
