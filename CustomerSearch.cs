using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace automobile
{
    public partial class cussearch : Form
    {
        SqlConnection sc1;
        public cussearch()
        {
           
            InitializeComponent();
        }

        private void cussearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'automobileDataSet1.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.automobileDataSet1.customer);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main mnn = new Main();
            this.Hide();
            mnn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string temp;
                temp = textBox1.Text;
                sc1 = new SqlConnection();
                sc1.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile ;Integrated Security=true";
                sc1.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter("select customer_id,customer_name,age,gender,contactno,email,residence,street from customer where customer_name= '" + textBox1.Text + "'", sc1);
                sda.Fill(ds, "customer");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "customer";
            }
            catch
            { }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string temp;
                temp = textBox1.Text;
                sc1 = new SqlConnection();
                sc1.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile ;Integrated Security=true";
                sc1.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter("select customer_id,customer_name,age,gender,contactno,email,residence,street from customer where customer_id= '" + textBox2.Text + "'", sc1);
                sda.Fill(ds, "customer");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "customer";
            }
            catch
            { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            cussearch ac = new cussearch();
            ac.Show();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }
    }
}
