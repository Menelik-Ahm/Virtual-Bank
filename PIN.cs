using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class PIN : Form
    {
        public string name;
        public string cardnum;
        public string pin;
        public string balance;
        public string limit;
        public int userid;
        public int oldpin;
        public int newpin;
        public PIN(string name, string cardnum, string pin, string balance, string limit)
        {
            this.name = name;
            this.cardnum = cardnum;
            this.pin = pin;
            this.balance = balance;
            this.limit = limit;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                oldpin = int.Parse(textBox1.Text);
                newpin = int.Parse(textBox3.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid PIN.");
            }
            if (oldpin != int.Parse(pin))
            {
                MessageBox.Show("Old pin is not correct");
            }
            else
            {
                string connstr = "Data Source=DESKTOP-C3NKTLU;Initial Catalog=ATM;Integrated Security=True;Trust Server Certificate=True";
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    conn.Open();
                    string query = "update userdi set PIN = @pin where CardNumber = @cardnum";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@pin", newpin);
                    cmd.Parameters.AddWithValue("@cardnum", cardnum);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN Updated Successfully PIN is " + newpin);

                    new ATM(name, cardnum, pin, balance.ToString(), limit.ToString()).Show();
                    this.Hide();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ATM(name, cardnum, pin, balance, limit).Show();
            this.Hide();
        }
    }
}
