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
    public partial class vehicle : Form
    {
        int id, log2, count, count1;
        string eid;
        DataRow dr, dr2;
        DataSet ds, ds1, ds2;
        SqlCommand cmd, cmd1, cmd2;
        SqlCommandBuilder cmdb;
        SqlDataAdapter da, da1, da2;
        SqlConnection con, con1, con2, con3;
        public vehicle()
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



        private void save1_Click(object sender, EventArgs e)
        {
            try
            {
                con1 = new SqlConnection();
                con1.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true";
                cmd1 = new SqlCommand("select * from varient", con1);
                con1.Open();
                da1 = new SqlDataAdapter(cmd1);
                cmdb = new SqlCommandBuilder(da1);
                ds1 = new DataSet();
                da1.Fill(ds1, "varient");
                con1.Close();
                dr2 = ds1.Tables["varient"].NewRow();
                dr2["vid"] = id;
                dr2["vaid"] = textBox4.Text;
                dr2["vname"] = textBox7.Text;
                dr2["vafeatures"] = richTextBox1.Text;
                dr2["price"] = textBox6.Text;

                ds1.Tables["varient"].Rows.Add(dr2);
                da1.Update(ds1, "varient");

                MessageBox.Show("New Entry is added");

                this.Hide();
                vehicle ac = new vehicle();
                ac.Show();
            }
            catch (System.Exception exce)
            {
                MessageBox.Show(exce.Message);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                dr = ds.Tables["vehicle"].NewRow();
                dr["vehicle_id"] = count;
                dr["model"] = textBox2.Text;
                dr["manufacturer"] = textBox3.Text;
                dr["usage"] = comboBox1.Text;
                dr["Vcc"] = textBox9.Text;

                ds.Tables["vehicle"].Rows.Add(dr);
                da.Update(ds, "vehicle");

                MessageBox.Show("New Entry is added");

                this.Hide();
                vehicle ac = new vehicle();
                ac.Show();
            }
            catch (System.Exception exce)
            {
                MessageBox.Show(exce.Message);
            }
        }


        private void save2_Click(object sender, EventArgs e)
        {
            try
            {
                con2 = new SqlConnection();
                con2.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true";
                cmd2 = new SqlCommand("select * from colour", con2);
                con2.Open();
                da2 = new SqlDataAdapter(cmd2);
                cmdb = new SqlCommandBuilder(da2);
                ds2 = new DataSet();
                da2.Fill(ds2, "colour");
                con2.Close();
                dr2 = ds2.Tables["colour"].NewRow();
                dr2["vid"] = id;
                dr2["colourid"] = textBox5.Text;
                dr2["colour_name"] = textBox8.Text;

                ds2.Tables["colour"].Rows.Add(dr2);
                da2.Update(ds2, "colour");

                MessageBox.Show("New Entry is added");

                this.Hide();
                vehicle ac = new vehicle();
                ac.Show();
            }
            catch (System.Exception exce)
            {
                MessageBox.Show(exce.Message);
            }
        }

        private void vehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'automobileDataSet6.vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter2.Fill(this.automobileDataSet6.vehicle);
            // TODO: This line of code loads data into the 'automobileDataSet5.vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter1.Fill(this.automobileDataSet5.vehicle);
            // TODO: This line of code loads data into the 'automobileDataSet4.vehicle' table. You can move, or remove it, as needed.
            try
            {
                SqlConnection con3 = new SqlConnection("Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True");
                con3.Open();

                count = 301;
                string ConnectionString = "Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True";
                DataSet ds = new DataSet();
                string SQLCommand = "select * from vehicle ";
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand, ConnectionString);
                Adapter.Fill(ds, "vehicle");
                Adapter.SelectCommand.Connection.Close();
                count1 = ds.Tables["vehicle"].Rows.Count;
                count  = count + count1;
                textBox1.Text = Convert.ToString(count);
                textBox1.Enabled = false;

                comboBox2.Text = "";
                comboBox3.Text = "";

                SqlConnection con7 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con7.Open();
                SqlCommand com7 = new SqlCommand("select * from temptable", con7);
                SqlDataReader dr7 = com7.ExecuteReader();
                // dr3.Read();
                if (dr7.Read())
                {

                    eid = Convert.ToString(dr7.GetString(3));
                }

                SqlCommand com8 = new SqlCommand("select * from employee where Eid ='" + eid + "'", con7);

                SqlDataReader dr8 = com8.ExecuteReader();
                if (dr8.Read())
                {
                    textBox3.Text = Convert.ToString(dr8.GetValue(1));

                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main cs = new Main();
            this.Hide();
            cs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Main cs = new Main();
            this.Hide();
            cs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Main cs = new Main();
            this.Hide();
            cs.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con.Open();

                SqlCommand com = new SqlCommand("select * from vehicle where model='" + comboBox2.Text + "'", con);
                SqlDataReader dr1 = com.ExecuteReader();
                dr1.Read();
                if (dr1.HasRows == true)
                {
                    id = Convert.ToInt32(dr1.GetValue(0));
                    // textBox6.Text = Convert.ToString(id);
                }
                dr1.Close();
            }
            catch { }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con.Open();

                SqlCommand com = new SqlCommand("select * from vehicle where model='" + comboBox3.Text + "'", con);
                SqlDataReader dr1 = com.ExecuteReader();
                dr1.Read();
                if (dr1.HasRows == true)
                {
                    id = Convert.ToInt32(dr1.GetValue(0));
                    // textBox5.Text = Convert.ToString(id);
                }
                dr1.Close();
            }
            catch { }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
