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
    public partial class newuser1 : Form
    {
        int id,id2;
        int count, count1;
        DataRow dr;
        DataSet ds;
        SqlCommand cmd;
        SqlCommandBuilder cmdb;
        SqlDataAdapter da;
        SqlConnection con;
        public newuser1()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true";
            cmd = new SqlCommand("select * from login1", con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "login1");
            con.Close();
        }

        private void newuser1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'automobileDataSet26.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.automobileDataSet26.employee);
            // TODO: This line of code loads data into the 'automobileDataSet25.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.automobileDataSet25.employee);
            count = 01;
            try
            {
                string ConnectionString = "Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True";
                DataSet ds = new DataSet();
                string SQLCommand = "select * from login1 ";
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand, ConnectionString);
                Adapter.Fill(ds, "login1");
                Adapter.SelectCommand.Connection.Close();
                count1 = ds.Tables["login1"].Rows.Count;
                count = count + count1;
                textBox7.Text = Convert.ToString(count);
                textBox7.Enabled = false;
            }
            catch { }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con2 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con2.Open();



                SqlCommand com1 = new SqlCommand("select * from employee where Ename='" + comboBox2.Text + "'", con2);
                SqlDataReader dr1 = com1.ExecuteReader();
                dr1.Read();
                if (dr1.HasRows == true)
                {
                    id = Convert.ToInt32(dr1.GetValue(0));
                }
                //dr1.Close();
                string one, two;

                one = textBox9.Text;
                two = textBox8.Text;

                SqlConnection con3 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con3.Open();

                SqlCommand com2 = new SqlCommand("select * from login1 where eid='" + dr1.GetValue(0) + "'", con3);
                SqlDataReader dr2 = com2.ExecuteReader();
                dr2.Read();
                if (dr2.HasRows == true)
                {
                    //id = Convert.ToInt32(dr2.GetValue(0));
                    MessageBox.Show("Account is already created");
                }
                else
                {
                    if (one == two)
                    {
                        dr = ds.Tables["login1"].NewRow();
                        dr["eid"] = Convert.ToString(id);
                        dr["lid"] = textBox7.Text;
                        dr["usertype"] = comboBox1.Text;
                        dr["username"] = textBox10.Text;
                        dr["password"] = textBox8.Text;

                        ds.Tables["login1"].Rows.Add(dr);
                        da.Update(ds, "login1");

                        //SqlConnection con9 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                        //con9.Open();
                        //SqlCommand cmd5 = new SqlCommand("update employee set Account='created' where Eid=@Eid", con9);
                        //cmd5.Parameters.Add(new SqlParameter("@Eid", id));
                        //cmd5.ExecuteNonQuery();
                        //con9.Close();

                        // textBox1.Text= Convert.ToString(id);
                        MessageBox.Show("New account is created");

                        this.Hide();
                        Main ac = new Main();
                        ac.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password is not matching", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox9.Text = "";
                        textBox8.Text = "";
                        textBox10.Focus();
                    }
                }
            }
            catch { }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con1 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con1.Open();

                SqlCommand com1 = new SqlCommand("select * from employee where Ename='" + comboBox2.Text + "'", con1);
                SqlDataReader dr1 = com1.ExecuteReader();
                dr1.Read();
                if (dr1.HasRows == true)
                {
                    id = Convert.ToInt32(dr1.GetValue(0));
                }
                //dr1.Close();
                SqlConnection con2 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con2.Open();

                SqlCommand com2 = new SqlCommand("select * from login1 where eid='" + dr1.GetValue(1) + "'", con2);
                SqlDataReader dr2 = com2.ExecuteReader();
                dr2.Read();
                if (dr2.HasRows == true)
                {
                    //id = Convert.ToInt32(dr2.GetValue(0));
                    MessageBox.Show("Account is already created");
                }
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
                       this.Hide();
                       Main ll = new Main();

                        ll.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}




