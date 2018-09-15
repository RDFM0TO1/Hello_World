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
    public partial class Form_Kullanici : Form
    {
        TicariBaglantiDataContext data = new TicariBaglantiDataContext();
        public Form_Kullanici()
        {
            InitializeComponent();
        }

        private void simpleB_Kul_Giris_Click(object sender, EventArgs e)
        {
            TBL_KULLANICILAR kultb = new TBL_KULLANICILAR();
            TicariOtomasyon fam = new TicariOtomasyon();
            var adminlist = data.TBL_KULLANICILARs.ToList();
            for (int i = 0; i < adminlist.Count; i++)
            {
                if(adminlist[i].Name == textE_Kul_Ad.Text && adminlist[i].Password == textE_Kul_Sifre.Text)
                {
                    fam.Show();
                    this.Hide();
                    MessageBox.Show($"Giriş Başarılı. Hoşgeldin {adminlist[i].Name} ", "Hoşgeldiniz", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            textE_Kul_Ad.Text = null;
            textE_Kul_Sifre.Text = null;
            MessageBox.Show("Giriş Başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form_Kullanici_Load(object sender, EventArgs e)
        {

        }
    }
}
