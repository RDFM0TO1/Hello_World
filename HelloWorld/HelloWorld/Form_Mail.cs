using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace HelloWorld
{
    public partial class Form_Mail : Form
    {
        Form_Mail frmmail;
        public String mail;
        public Form_Mail()
        {
            InitializeComponent();
        }

        private void Form_Mail_Load(object sender, EventArgs e)
        {
            textE_Mail_Mail.Text=mail;
            
        }

        private void simpleB_Mail_Gönder_Click(object sender, EventArgs e)
        {
            frmmail = new Form_Mail();
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("tolgahan.baki@hotmail.com", "tolgahan,1996");
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesaj.To.Add(textE_Mail_Mail.Text);
            mesaj.From = new MailAddress("tolgahan.baki@hotmail.com");
            mesaj.Subject = textE_Mail_Konu.Text;
            mesaj.Body = richT_Mail_Mesaj.Text;
            istemci.Send(mesaj);
            MessageBox.Show("Mesajınız Başarıyla Gönderildi","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            textE_Mail_Konu.Text = null;
            textE_Mail_Mail.Text = null;
            richT_Mail_Mesaj.Text = null;
        }
    }
}
