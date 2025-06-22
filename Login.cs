using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Sign_in().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cardnum = 0;
            int pin = 0;
            int cardcheck2, pincheck2;

            string connstr = "Data Source=DESKTOP-C3NKTLU;Initial Catalog=ATM;Integrated Security=True;Trust Server Certificate=True";
            try
            {
                cardnum = int.Parse(textBox1.Text);
                pin = int.Parse(textBox2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid data.");
            }
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                conn.Open();
                string query = "SELECT * FROM userdi WHERE CardNumber = @CardNum AND PIN = @Pin";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CardNum", cardnum);
                cmd.Parameters.AddWithValue("@pin", pin);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var cardcheck = reader["CardNumber"].ToString();
                    var pincheck = reader["PIN"].ToString();
                    var balance = reader["Balance"].ToString();
                    var limit = reader["DailyWithdrawalLimit"].ToString();
                    var name = reader["name"].ToString();
                    new ATM(name, cardcheck, pincheck, balance, limit).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Card Number or PIN ");
                }

            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
