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
        /// <summary>
        /// Tato metoda inicializuje všechny komponenty formuláře, včetně grafických prvků a událostí.
        /// </summary>
        public Contact()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Tato metoda slouží k odeslání e-mailu pomocí SMTP protokolu. Metoda přijímá tři parametry: příjemce (to), předmět e-mailu (subject)
        /// a text zprávy (body). Metoda vytvoří objekt třídy MailMessage s danými parametry a nastaví adresu odesílatele a SMTP server,
        /// pomocí kterého se e-mail odesílá. Poté odesílá e-mail pomocí metody Send třídy SmtpClient.
        /// </summary>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
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

        /// <summary>
        /// Tato metoda slouží k odeslání e-mailu. Metoda získá předmět a text zprávy z odpovídajících textboxů a zavolá metodu SendEmail().
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
