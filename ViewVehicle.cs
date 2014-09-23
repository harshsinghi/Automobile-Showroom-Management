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
    public partial class viewvehicle : Form
    {
        int ctr;
        DataRow dr;
        DataSet ds;
        SqlCommand cmd;
        SqlCommandBuilder cmdb;
        SqlDataAdapter da;
        SqlConnection con;
        public viewvehicle()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true";
            cmd = new SqlCommand("select * from vehicle", con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "vehicle");
            con.Close();
        }

        private void clearAll()
        {
            comboBox4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con.Open();
                SqlCommand com = new SqlCommand("select * from vehicle where vehicle_id='" + comboBox4.Text + "'", con);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                if (dr.HasRows == true)
                {

                    string Vmodel = Convert.ToString(dr.GetValue(1));
                    // for (int i = 0; i < 14; i++)

                    string Vmanufacturer = Convert.ToString(dr.GetValue(2));
                    string Vusage = Convert.ToString(dr.GetValue(3));
                    textBox1.Text = Vmodel;
                    textBox2.Text = Vmanufacturer;
                    textBox3.Text = Vusage;
                }
                else
                {
                    MessageBox.Show("Invalid id");
                    textBox1.Text = "";
                }
                con.Close();
            }
            catch (System.Exception exce)
            {
                MessageBox.Show(exce.Message);
            }

        }

        private void viewvehicle_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
            con.Open();
            SqlCommand com = new SqlCommand("select * from carpoolcabs ", con);
            SqlDataReader dr = com.ExecuteReader();
            //dr.Read();
            while (dr.Read())
            {
                comboBox4.Items.Add(dr.GetValue(0));
                //dr.NextResult();
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctr = ctr + 1;
            dr = ds.Tables["vehicle"].NewRow();
            dr["model"] = textBox1.Text;
            dr["manufacturer"] = textBox2.Text;
            dr["usage"] = textBox3.Text;
            da.Update(ds, "vehicle");

            MessageBox.Show("New Entry is added");            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            this.Hide();
            mn.Show();
        }
    }
}
