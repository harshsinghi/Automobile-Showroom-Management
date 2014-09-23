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
    public partial class enquiry : Form
    {
        SqlConnection sc1;
        int id2, test = 0;
        public enquiry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            enquirybooking hm = new enquirybooking();
            hm.Show();
        }

        private void enquiry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'automobileDataSet23.enquiry' table. You can move, or remove it, as needed.
            this.enquiryTableAdapter.Fill(this.automobileDataSet23.enquiry);
            // TODO: This line of code loads data into the 'automobileDataSet10.varient' table. You can move, or remove it, as needed.
            this.varientTableAdapter.Fill(this.automobileDataSet10.varient);
            // TODO: This line of code loads data into the 'automobileDataSet9.vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.automobileDataSet9.vehicle);
            try
            {
                comboBox4.Items.Clear();
                comboBox3.Text = "";
                comboBox2.Text = "";


                dataGridView1.Visible = false;
                textBox1.Visible = false;
                //textBox2.Visible = false;
                //textBox3.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                label1.Visible = false;
                // label2.Visible = false;
                //label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                button4.Visible = false;
                // button5.Visible = false;
                // button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;

                SqlConnection con1 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con1.Open();
                SqlCommand com8 = new SqlCommand("select distinct colour_name from colour ", con1);
                SqlDataReader dr8 = com8.ExecuteReader();
                while (dr8.Read())
                // if (dr8.HasRows == true)
                {
                    comboBox4.Items.Add(Convert.ToString(dr8.GetValue(0)));
                }
            }
            catch { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string temp;
                temp = textBox1.Text;
                sc1 = new SqlConnection();
                sc1.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile;Integrated Security=true";
                sc1.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter("select enquiry_id,employee_id,customer_id,en_source,en_date,vid,vaid,colourid,followup_id,en_status from enquiry where colourid= '" + comboBox4.Text + "'", sc1);
                sda.Fill(ds, "enquiry");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "enquiry";
            }
            catch { }
            }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (test != 0)
                {
                    dataGridView1.Visible = false;
                    textBox1.Visible = false;
                    //textBox2.Visible = false;
                    //textBox3.Visible = false;
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                    comboBox4.Visible = false;
                    label1.Visible = false;
                    // label2.Visible = false;
                    //label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    button4.Visible = false;
                    //button5.Visible = false;
                    // button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    test = 0;
                }
                else
                {
                    dataGridView1.Visible = true;
                    textBox1.Visible = true;
                    //textBox2.Visible = true;
                    //textBox3.Visible = true;
                    comboBox1.Visible = true;
                    comboBox2.Visible = true;
                    comboBox3.Visible = true;
                    comboBox4.Visible = true;
                    label1.Visible = true;
                    //label2.Visible = true;
                    //label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    button4.Visible = true;
                    //button5.Visible = true;
                    // button6.Visible = true;
                    button7.Visible = true;
                    button8.Visible = true;
                    button9.Visible = true;
                    button10.Visible = true;
                    test = 1;
                }
            }
            catch
            { }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            this.Hide();
            mn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string temp;
                temp = textBox1.Text;
                sc1 = new SqlConnection();
                sc1.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile ;Integrated Security=true";
                sc1.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter("select enquiry_id,employee_id,customer_id,en_source,en_date,vid,vaid,colourid,followup_id,en_status from enquiry where enquiry_id= '" + textBox1.Text + "'", sc1);
                sda.Fill(ds, "enquiry");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "enquiry";
            }
            catch { }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string temp;
                temp = textBox1.Text;
                sc1 = new SqlConnection();
                sc1.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile ;Integrated Security=true";
                sc1.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter("select enquiry_id,employee_id,customer_id,en_source,en_date,vid,vaid,colourid,followup_id,en_status from enquiry where vid= '" + comboBox2.Text + "'", sc1);
                sda.Fill(ds, "enquiry");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "enquiry";
            }
            catch
            { }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string temp;
                temp = textBox1.Text;
                sc1 = new SqlConnection();
                sc1.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile ;Integrated Security=true";
                sc1.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter("select enquiry_id,employee_id,customer_id,en_source,en_date,vid,vaid,colourid,followup_id,en_status from enquiry where vaid= '" + comboBox3.Text + "'", sc1);
                sda.Fill(ds, "enquiry");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "enquiry";
            }
            catch
            { }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string temp;
                temp = textBox1.Text;
                sc1 = new SqlConnection();
                sc1.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile ;Integrated Security=true";
                sc1.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter("select enquiry_id,employee_id,customer_id,en_source,en_date,vid,vaid,colourid,followup_id,en_status from enquiry where en_status= '" + comboBox1.Text + "'", sc1);
                sda.Fill(ds, "enquiry");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "enquiry";

            }
            catch { }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }
    }
}
