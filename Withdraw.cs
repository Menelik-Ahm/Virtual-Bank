using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ATM
{
    public partial class Withdraw : Form
    {
        public string name = "";
        public string cardnum = "";
        public string pin = "";
        public double balance = 0.0;
        public double limit = 0.0;
        public int userid;
        public string type = "Withdraw";
        public Withdraw(string name, string cardnum, string pin, string balance, string limit)
        {
            InitializeComponent();
            this.name = name;
            this.cardnum = cardnum;
            this.pin = pin;
            this.balance = double.Parse(balance);
            this.limit = double.Parse(limit);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ATM(name, cardnum, pin, balance.ToString(), limit.ToString()).Show();
            this.Close();
        }

        private void sat_Click(object sender, EventArgs e)
        {

        }

        private void With_Click(object sender, EventArgs e)
        {
           
            double amount = 0.0;
            try
            {
                amount = double.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid data.");
            }

            if (amount<=0)
            {
                MessageBox.Show("amount Must be > 0ETB");
            }

            else if (amount > balance)
            {
                MessageBox.Show("Dear " + name + " You have insufficient Funds to Make this Transaction");
            }

            else if (amount > limit)
            {
                MessageBox.Show("Dear " + name + " You have reached Your daily limit which is" + limit + "ETB");
            }
            else
            {
                double newbalace = balance - amount;
                string connstr = "Data Source=DESKTOP-C3NKTLU;Initial Catalog=ATM;Integrated Security=True;Trust Server Certificate=True";

                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    conn.Open();
                    string query = "update userdi set Balance = @bal where CardNumber = @cardnum ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@bal", newbalace);
                    cmd.Parameters.AddWithValue("@cardnum", cardnum);
                    cmd.ExecuteNonQuery();

                        SoundPlayer p = new SoundPlayer("C:\\Users\\minos\\OneDrive\\Desktop\\ATM res\\Money Counter - sound effect.wav");
                        p.PlaySync();
                                    
                    MessageBox.Show("Dear " + name + " You Have successfully Withdrawn " + amount + "ETB" + "\n Your remaining Amount is " + newbalace + "ETB" + "\n Thank You For Choosing us");
                    conn.Close();
                }
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    conn.Open();
                    string query = "select UserId from userdi where CardNumber = @cardnum";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cardnum", cardnum);
                    SqlDataReader r = cmd.ExecuteReader();

                    if (r.Read())
                    {
                        userid = int.Parse(r["UserId"].ToString());
                        r.Close();
                    }

                    string tranquery = "INSERT INTO Transactionss (AccountId,TransType ,Amount) VALUES (@userid, @type, @amount)";
                    SqlCommand trancmd = new SqlCommand(tranquery, conn);
                    trancmd.Parameters.AddWithValue("@userid", userid);
                    trancmd.Parameters.AddWithValue("@type", type);
                    trancmd.Parameters.AddWithValue("@amount", amount);
                    trancmd.ExecuteNonQuery();
                    
                }
                new ATM(name, cardnum, pin, newbalace.ToString(), limit.ToString()).Show();
                this.Close();
            }
        }
    }
}
