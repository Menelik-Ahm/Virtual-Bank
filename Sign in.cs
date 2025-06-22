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
using System.Net.Mail;
using System.Net;

namespace ATM
{
    public partial class Sign_in : Form
    {
        string name = "";
        int pin, pin2;
        double deposit;
        string phoneNum = "";
        string connstr;
        string email;
        int userverififcation;
        public string owngmail = "minosahm30@gmail.com";
        public string ownpass = "qtsm zaaa qrel fpbh";
        public Sign_in()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                name = textBox1.Text;
                pin = int.Parse(textBox3.Text);
                pin2 = int.Parse(textBox5.Text);
                phoneNum = (textBox2.Text);
                deposit = double.Parse(textBox4.Text);
                email = textBox6.Text;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid data.");

            } 
            if (deposit < 10)
            {
                MessageBox.Show("Deposit Amount Must be > 10ETB");
            }
            else if (!pin.Equals(pin2))
            {
                MessageBox.Show("Enter Correct PIN");
            }
            else
            {     
                connstr = "Data Source=DESKTOP-C3NKTLU;Initial Catalog=ATM;Integrated Security=True;Trust Server Certificate=True";
                using (SqlConnection con = new SqlConnection(connstr))
                {
             
                    Random random = new Random();
                        StringBuilder cardNumber = new StringBuilder();
                        for (int i = 0; i < 6; i++)
                        {
                            cardNumber.Append(random.Next(0, 10));
                        }

                        string card = cardNumber.ToString();
                        try
                        {
                            con.Open();
                            string userquery = "INSERT INTO userdi(name, PhoneNum, Balance, CardNumber, PIN) VALUES (@name, @phoneNum, @Balance, @cardNum, @pin)";
                            SqlCommand cmd = new SqlCommand(userquery, con);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@phoneNum", phoneNum);
                            cmd.Parameters.AddWithValue("@Balance", deposit);
                            cmd.Parameters.AddWithValue("@cardNum", card);
                            cmd.Parameters.AddWithValue("@pin", pin2);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Account Created Successfully" + "\n" + "Account Number is: " + card);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Please enter valid data." + "in each inputs");
                        }
                }
            }
        }
        private void Sign_in_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        
    }
}
