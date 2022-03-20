using DevExpress.XtraEditors;
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

namespace Ticari_Otomasyon
{
    public partial class FrmMail : DevExpress.XtraEditors.XtraForm
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        public string mail;

        private void FrmMail_Load(object sender, EventArgs e)
        {
            txtMailAdresi.Text = mail;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mesajim = new MailMessage();
            SmtpClient istemci = new SmtpClient
            {
                Credentials = new NetworkCredential("kevsercanca@gmail.com", "@#kvsrcnc01"),
                Port = 587,
                Host = "smtp.live.com",
                EnableSsl = true
            };
            mesajim.To.Add(txtMailAdresi.Text);
            mesajim.From = new MailAddress("kevsercanca@gmail.com");
            mesajim.Subject = txtKonu.Text;
            mesajim.Body = txtMesaj.Text;
            istemci.Send(mesajim);
        }
    }
}