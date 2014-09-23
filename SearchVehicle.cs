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
    public partial class searchveh : Form
    {
        SqlConnection sc1, sc2;
        SqlCommand cmd2;
        string id1;
        public searchveh()
        {
            InitializeComponent();
        }

        private void searchveh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'automobileDataSet21.colour' table. You can move, or remove it, as needed.
            this.colourTableAdapter.Fill(this.automobileDataSet21.colour);
            // TODO: This line of code loads data into the 'automobileDataSet20.varient' table. You can move, or remove it, as needed.
            this.varientTableAdapter.Fill(this.automobileDataSet20.varient);
            // TODO: This line of code loads data into the 'automobileDataSet19.vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.automobileDataSet19.vehicle);

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
                SqlDataAdapter sda = new SqlDataAdapter("select vehicle_id,model,manufacturer,usage,Vcc from vehicle where vehicle_id= '" + textBox1.Text + "'", sc1);
                sda.Fill(ds, "vehicle");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "vehicle";
            }
            catch { }
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
                SqlDataAdapter sda = new SqlDataAdapter("select vehicle_id,model,manufacturer,usage,Vcc from vehicle where model like '" + textBox2.Text + "'", sc1);
                sda.Fill(ds, "vehicle");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "vehicle";
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string temp;
                temp = textBox1.Text;
                sc1 = new SqlConnection();
                sc1.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile ;Integrated Security=true";
                sc1.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter("select vehicle_id,model,manufacturer,usage,Vcc from vehicle where manufacturer like '" + textBox3.Text + "'", sc1);
                sda.Fill(ds, "vehicle");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "vehicle";
            }
            catch { }
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
                SqlDataAdapter sda = new SqlDataAdapter("select vehicle_id,model,manufacturer,usage,Vcc from vehicle where usage like '" + comboBox1.Text + "'", sc1);
                sda.Fill(ds, "vehicle");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "vehicle";
            }
            catch { }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con4 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile ;Integrated Security=true");
                con4.Open();
                cmd2 = new SqlCommand("Select distinct vehicle_id  from vehicle where model ='" + comboBox2.Text + "'", con4);
                SqlDataReader sdr2 = cmd2.ExecuteReader();
                while (sdr2.Read())
                {
                    id1 = Convert.ToString(sdr2["vehicle_id"]);
                    // comboBox2.Text = Convert.ToString(sdr2["Vid"]);
                }
                sdr2.Close();
                con4.Close();
                string temp;
                temp = textBox1.Text;
                sc1 = new SqlConnection();
                sc1.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile ;Integrated Security=true";
                sc1.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter("select vaid,vname,vafeatures,price from varient where vid= '" + id1 + "'", sc1);
                sda.Fill(ds, "varient");
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "varient";
                sc1.Close();


                sc2 = new SqlConnection();
                sc2.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile ;Integrated Security=true";
                sc2.Open();
                DataSet ds2 = new DataSet();
                SqlDataAdapter sda1 = new SqlDataAdapter("select colourid,colour_name from colour where vid= '" + id1 + "'", sc2);
                sda1.Fill(ds2, "colour");
                dataGridView3.DataSource = ds2;
                dataGridView3.DataMember = "colour";
                sc2.Close();
            }
            catch { }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main ac = new Main();
            ac.Show();
        }
    
    }

}

