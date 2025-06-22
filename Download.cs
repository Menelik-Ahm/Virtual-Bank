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

namespace ATM
{
    public partial class Download : Form
    {
        public string cardnum;
        public string pin;
        public string balance;
        public string limit;
        public string name;
        public string owngmail = "minosahm30@gmail.com";
        public string ownpass = "qtsm zaaa qrel fpbh";
        public string Togmailaccount;
        DataTable tbl;

        public Download(string name, string cardnum, string pin, string balance, string limit, DataTable tbl)
        {
            InitializeComponent();
            this.cardnum = cardnum;
            this.pin = pin;
            this.balance = balance;
            this.limit = limit;
            this.name = name;
            this.tbl = tbl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Togmailaccount = textBox1.Text;
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter Valid Data");
            }

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(owngmail);
            mail.Subject = "ATM/BANK Transaction Details";
            mail.To.Add(new MailAddress(Togmailaccount));
            mail.Body = "Dear " + name + " This is your Account Information\n" +
                        "Balance " + balance + "\n" +
                        "Account Limit " + limit + "\n" +
                        "\n" +
                        "Best regards";

            var smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(owngmail, ownpass),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Timeout = 10000
            };

            try
            {
                smtp.Send(mail);
                MessageBox.Show("Email Sent Successfully");
            }
            catch (SmtpException ex)
            {
                MessageBox.Show("Error occured " + ex);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ATM(name, cardnum, pin, balance, limit).Show();
            this.Close();
        }
    }
}
