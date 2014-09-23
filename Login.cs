using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
namespace automobile
{
    
    
    public partial class login1 : Form
    {
        int g1,g2,g3;
                int count, count1;
        DataRow dr;
        DataRow dr3;
        DataSet ds;
        SqlCommand cmd,cmd1,cmd2;
        SqlCommandBuilder cmdb;
        SqlDataAdapter da;
        SqlConnection con;
    //    SqlDataReader dr;
        
        public login1()
        {
            Thread t = new Thread(new ThreadStart(automobile));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true";
            cmd = new SqlCommand("select * from temptable", con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "temptable");
        }

        public void automobile()
        {
            Application.Run(new splashscreen());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuser.Text == "" || txtpassword.Text == "")
                {
                    MessageBox.Show("Required information left blank");

                }
                SqlConnection sconn = new SqlConnection();
                sconn.ConnectionString = "Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True";

                sconn.Open();
                //   type1 = "admin";
                if (rdadmin.Checked)
                {
                    //  SqlCommand cmd1 = new SqlCommand("Select usertype from login where);
                    string userText = txtuser.Text;
                    string passText = txtpassword.Text;

                    //string typeText = comboBox1.Text;
                    SqlCommand cmd = new SqlCommand("SELECT * FROM login1 WHERE username='" + txtuser.Text + "' and password='" + txtpassword.Text + "' and usertype= 'admin'", sconn);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {

                        g1 = Convert.ToInt32(dr.GetValue(1));

                        cmd = new SqlCommand("update temptable set admin=1,eid = '" + g1 + "' ", con);
                        cmd.ExecuteNonQuery();
                        Main mn = new Main();
                        this.Hide();
                        mn.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid input");
                        txtuser.Text = "";
                        txtpassword.Text = "";
                        txtuser.Focus();
                    }
                    dr.Close();
                }

                //sconn.Close();  
                if (rdmanager.Checked)
                {
                    string userText = txtuser.Text;
                    string passText = txtpassword.Text;
                    //string typeText = comboBox1.Text;
                    SqlCommand cmd = new SqlCommand("SELECT * FROM login1 WHERE username='" + txtuser.Text + "' and password='" + txtpassword.Text + "' and usertype='manager'", sconn);
                    SqlDataReader dr = cmd.ExecuteReader();



                    if (dr.Read())
                    {
                        g2 = Convert.ToInt32(dr.GetValue(1));
                        cmd1 = new SqlCommand("update temptable set manager=1,eid = '" + g2 +"' ", con);
                        cmd1.ExecuteNonQuery();
                        this.Hide();
                        Main mn1 = new Main();
                       mn1.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid input");
                        txtuser.Text = "";
                        txtpassword.Text = "";
                        txtuser.Focus();
                    }
                    dr.Close();
                }
                if (rduser.Checked)
                {

                    string userText = txtuser.Text;
                    string passText = txtpassword.Text;
                    //string typeText = comboBox1.Text;
                    SqlCommand cmd = new SqlCommand("SELECT * FROM login1 WHERE username='" + txtuser.Text + "' and password='" + txtpassword.Text + "' and usertype='user'", sconn);
                    SqlDataReader dr = cmd.ExecuteReader();



                    if (dr.Read())
                    {
                        g3 = Convert.ToInt32(dr.GetValue(1));

                        this.Hide();
                        Main mn = new Main();
                        cmd2 = new SqlCommand("update temptable set guest=1,eid = '" + g3 +"'", con);
                        cmd2.ExecuteNonQuery();
                        mn.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid input");
                        txtuser.Text = "";
                        txtpassword.Text = "";
                        txtuser.Focus();
                    }
                    dr.Close();
                }
            }
            catch
            { }
        }

        private void login1_Load(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        }
    }
