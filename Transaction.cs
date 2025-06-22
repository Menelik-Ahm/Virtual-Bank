using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Transaction : Form
    {
        public int userid;
        public string cardnum;
        public string pin;
        public string balance;
        public string limit;
        string name;
        DataTable tbl2;
        public Transaction(string name, string cardnum, string pin, string balance, string limit)
        {

            this.cardnum = cardnum;
            this.pin = pin;
            this.balance = balance;
            this.limit = limit;
            this.name = name;

            InitializeComponent();
            string connstr = "Data Source=DESKTOP-C3NKTLU;Initial Catalog=ATM;Integrated Security=True;Trust Server Certificate=True";

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
                }
                r.Close();

                string transquery = "select * from Transactionss where AccountId = @userid";
                SqlCommand trancmd = new SqlCommand(transquery, conn);
                trancmd.Parameters.AddWithValue("@userid", userid);

                var reader = trancmd.ExecuteReader();
                DataTable tbl = new DataTable();
                tbl.Load(reader);

                dataGridView1.DataSource = tbl;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ATM(name, cardnum, pin, balance, limit).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Download(name, cardnum, pin, balance, limit, tbl2).Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
