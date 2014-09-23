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
    public partial class delemp : Form
    {
        public delemp()
        {
            InitializeComponent();
        }

        private void deleemp_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length == 0)
                    errorProvider1.SetError(textBox1, "Enter id");
                SqlConnection con = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con.Open();
                SqlCommand com = new SqlCommand("select Eid from employee where Eid=@Eid", con);
                com.Parameters.Add(new SqlParameter("@Eid", textBox1.Text));
                SqlDataReader dr = com.ExecuteReader();

                Boolean b = (Boolean)dr.HasRows;
                if (b == false)
                {
                    MessageBox.Show("Invalid ID..Re enter");
                    textBox1.Text = "";
                }
                else
                {
                    con.Close();
                    con.Open();
                    SqlCommand cm = new SqlCommand("DELETE employee WHERE Eid = @Eid", con);
                    cm.Parameters.Add(new SqlParameter("@Eid", textBox1.Text));
                    cm.ExecuteNonQuery();
                    cm.Dispose();
                    con.Close();
                    //clearAll();
                    MessageBox.Show("Deleted");
                    this.Hide();
                    Main ac = new Main();
                    ac.Show();
                }
            }
            catch
            { }
        }

        private void delemp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'automobileDataSet13.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.automobileDataSet13.employee);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length == 0)
                    errorProvider1.SetError(textBox1, "Enter id");
                SqlConnection con = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con.Open();
                SqlCommand com = new SqlCommand("select * from employee where eid='" + textBox1.Text + "'", con);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();

                if (dr.HasRows == true)
                {

                    string tid = Convert.ToString(dr.GetValue(0));
                    // for (int i = 0; i < 14; i++)

                    string tname = Convert.ToString(dr.GetValue(1));
                    string tage = Convert.ToString(dr.GetValue(2));
                    string tgender = Convert.ToString(dr.GetValue(3));
                    string tcontact = Convert.ToString(dr.GetValue(4));
                    string temail = Convert.ToString(dr.GetValue(5));
                    string tresidence = Convert.ToString(dr.GetValue(6));
                    string tstreet = Convert.ToString(dr.GetValue(7));
                    string tcity = Convert.ToString(dr.GetValue(8));
                    string tpin = Convert.ToString(dr.GetValue(9));
                    string tstate = Convert.ToString(dr.GetValue(10));
                    string tdesignation = Convert.ToString(dr.GetValue(11));
                    string texp = Convert.ToString(dr.GetValue(12));
                    string tmstatus = Convert.ToString(dr.GetValue(13));
                    textBox2.Text = tname;
                    textBox13.Text = tage;
                    comboBox2.Text = tgender;
                    textBox9.Text = tcontact;
                    textBox8.Text = temail;
                    textBox5.Text = tresidence;
                    textBox14.Text = tstreet;
                    textBox7.Text = tcity;
                    textBox3.Text = tpin;
                    textBox6.Text = tstate;
                    textBox10.Text = tdesignation;
                    textBox11.Text = texp;
                    comboBox2.Text = tmstatus;
                }
                else
                {
                    MessageBox.Show("Invalid id");
                    textBox1.Text = "";
                }
                con.Close();
            }
            catch
            { }
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Main cs = new Main();
            this.Hide();
            cs.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }
    }
}
