using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScitaniLidu
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }
        public void SendEmail(string to, string subject, string body)
        {
            var fromAddress = new MailAddress("info@michalsivicek.cz", "Sčítání lidu");
            var toAddress = new MailAddress(to);
            const string fromPassword = "Niggod";
            const string smtpServer = "smtp.endora.cz";
            const int smtpPort = 587;

            var smtp = new SmtpClient
            {
                Host = smtpServer,
                Port = smtpPort,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var to = "gamesluxuslp@gmail.com";
            var subject = textBoxSubject.Text;
            var body = richTextBoxZprava.Text;

            SendEmail(to, subject, body);

            textBoxSubject.Text = "";
            richTextBoxZprava.Text = "";

            MessageBox.Show("E-mail byl úspěšně odeslán.");
        }

    }
}
