using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace ATM 
{
    public partial class Transfer : Form
    {
        public string name;
        public string cardnum;
        public string pin;
        public double balance;
        public double limit;
        public int reciveracc;
        public string recivername = "";
        public double sendAmount;
        public double reciverBalance;
        public double NewBalance;
        public double OwnAccBalance;
        public string type = "Transfer";
        public int userid;

        public Transfer(string name, string cardnum, string pin, string balance, string limit)
        {
            this.name = name;
            this.cardnum = cardnum;
            this.pin = pin;
            this.balance = double.Parse(balance);
            this.limit = double.Parse(limit);

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source=DESKTOP-C3NKTLU;Initial Catalog=ATM;Integrated Security=True;Trust Server Certificate=True";
            try
            {
                reciveracc = int.Parse(textBox1.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter Valid Account Number");
            }
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                string query = "select name from userdi where CardNumber = @Racc";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Racc", reciveracc);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.Read())
                {
                    recivername = r["name"].ToString();
                    textBox3.Enabled = true;
                    textBox2.Text = recivername;
                }
                else { MessageBox.Show("Account Not Found"); }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sendAmount = double.Parse(textBox3.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter Valid Data");
            }
            if (sendAmount > balance)
            {
                MessageBox.Show("Dear " + name + " You have insufficient Funds to Make this Transaction");
            }
            else if (int.Parse(cardnum) == reciveracc)
            {
                MessageBox.Show("Dear " + name + " You Cannot Transfer to own account");
            }
            else if (sendAmount > limit)
            {
                MessageBox.Show("Dear " + name + " Daily limit reached Daily limit is " + limit + "ETB");
            }
            else if (sendAmount > 10)
            {
                string connstr = "Data Source=DESKTOP-C3NKTLU;Initial Catalog=ATM;Integrated Security=True;Trust Server Certificate=True";
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    conn.Open();
                    string query = "select Balance from userdi where CardNumber = @Racc";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Racc", reciveracc);
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        reciverBalance = double.Parse(r["Balance"].ToString());
                    }

                    r.Close();
                    NewBalance = reciverBalance + sendAmount;
                    string updatequery = "update userdi set Balance = @new where CardNumber = @Racc";
                    SqlCommand updcmd = new SqlCommand(updatequery, conn);
                    updcmd.Parameters.AddWithValue("@new", NewBalance);
                    updcmd.Parameters.AddWithValue("@Racc", reciveracc);
                    updcmd.ExecuteNonQuery();

                    OwnAccBalance = balance - sendAmount;
                    string ownquery = "update userdi set Balance = @ownbalance where CardNumber = @cardnum";
                    SqlCommand owncmd = new SqlCommand(ownquery, conn);
                    owncmd.Parameters.AddWithValue("@ownbalance", OwnAccBalance);
                    owncmd.Parameters.AddWithValue("@cardnum", cardnum);
                    owncmd.ExecuteNonQuery();

                    SoundPlayer p = new SoundPlayer("C:\\Users\\minos\\OneDrive\\Desktop\\ATM res\\Apple Pay Success Sound Effect.wav");
                    p.PlaySync();

                    MessageBox.Show("Dear " + name + " You have Successfully Transferred " + sendAmount + "ETB To " + recivername + "\n Your Remaining Amount is " + OwnAccBalance + "ETB " + "Thank You For choosing us");
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
                    trancmd.Parameters.AddWithValue("@amount", sendAmount);
                    trancmd.ExecuteNonQuery();
                    new ATM(name, cardnum, pin, balance.ToString(), limit.ToString()).Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Amount Must be > 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ATM(name, cardnum, pin, balance.ToString(), limit.ToString()).Show();
            this.Hide();

        }
    }
}
