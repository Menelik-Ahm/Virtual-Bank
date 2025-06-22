using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ATM
{
    public partial class ATM : Form
    {
        public string name = "";
        public string cardnum = "";
        public string pin = "";
        public string balance = "";
        public string limit = "";
        public int userid;
        public ATM(string name, string cardnum, string pin, string balance, string limit)
        {
            InitializeComponent();
            this.name = name;
            this.cardnum = cardnum;
            this.pin = pin;
            this.balance = balance;
            this.limit = limit;

            label3.Text = "Welcome " + name;
        }
        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            new Withdraw(name, cardnum, pin, balance, limit).Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source=DESKTOP-C3NKTLU;Initial Catalog=ATM;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                string query = "select Balance from userdi where CardNumber = @cardnum";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cardnum", cardnum);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.Read())
                {
                    var balance = r["Balance"].ToString();
                    MessageBox.Show("Dear " + name + " Your Balance is " + balance + "ETB" + "\nThank You For Choosing us");
                }

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            new Deposit(name, cardnum, pin, balance, limit).Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Transfer(name, cardnum, pin, balance, limit).Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Transaction(name, cardnum, pin, balance, limit).Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            new PIN(name, cardnum, pin, balance, limit).Show();
            this.Hide();
        }
    }
}

