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
    public partial class followup : Form
    {
        int id2;
        //string da;
        SqlConnection sc1;
        public followup()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con.Open();
                SqlCommand com2 = new SqlCommand("update followup set Fdate=@date,Fndate=@Fndate,fcomments=@comment,foffers=@offers where enid=@enid", con);
                com2.Parameters.Add(new SqlParameter("@enid", textBox2.Text));
                com2.Parameters.Add(new SqlParameter("@date", System.DateTime.Now.ToString()));
                com2.Parameters.Add(new SqlParameter("@Fndate", Convert.ToString(dateTimePicker1.Text)));
                //com2.Parameters.Add(new SqlParameter("@status", comboBox1.Text));
                com2.Parameters.Add(new SqlParameter("@comment", richTextBox1.Text));
                com2.Parameters.Add(new SqlParameter("@offers", richTextBox2.Text));

                com2.ExecuteNonQuery();

                SqlCommand com3 = new SqlCommand("update enquiry set en_status=@status where enquiry_id=@enid", con);
                com3.Parameters.Add(new SqlParameter("@enid", textBox2.Text));
                com3.Parameters.Add(new SqlParameter("@status", comboBox1.Text));
                com3.ExecuteNonQuery();

                MessageBox.Show("Updated");
                con.Close();
                this.Hide();
                Main ac = new Main();
                ac.Show();
            }// clearAll();
            catch
            {}
          
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con.Open();
                SqlCommand com = new SqlCommand("select * from followup where enid='" + textBox2.Text + "'", con);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                if (dr.HasRows == true)
                {

                    string Fid = Convert.ToString(dr.GetValue(0));
                    //string Enid = Convert.ToString(dr.GetValue(1));
                    string date = Convert.ToString(dr.GetValue(2));
                    string ndate = Convert.ToString(dr.GetValue(6));
                    string comment = Convert.ToString(dr.GetValue(4));
                    string offers = Convert.ToString(dr.GetValue(5));
                    textBox1.Text = Fid;
                    // textBox2.Text = Enid;
                    textBox3.Text = date;
                    dateTimePicker1.Text = ndate;
                    richTextBox1.Text = comment;
                    richTextBox2.Text = offers;
                }
                else
                {
                    MessageBox.Show("Invalid id");
                    textBox1.Text = "";
                }
                con.Close();

                SqlConnection con6 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con6.Open();
                SqlCommand com6 = new SqlCommand("select * from enquiry where enquiry_id='" + textBox2.Text + "'", con6);
                SqlDataReader dr6 = com6.ExecuteReader();
                dr6.Read();
                if (dr6.HasRows == true)
                {
                    string Enstat = Convert.ToString(dr6.GetValue(9));
                    comboBox1.Text = Enstat;
                }
                con6.Close();
            }
            catch
            {
            }
        }

        private void followup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'automobileDataSet24.enquiry' table. You can move, or remove it, as needed.
            this.enquiryTableAdapter.Fill(this.automobileDataSet24.enquiry);
            try
            {
                SqlConnection sc1 = new SqlConnection("Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True");
                sc1.Open();

                SqlCommand scom1 = new SqlCommand("select * from temptable", sc1);

                SqlDataReader dr11 = scom1.ExecuteReader();

                if (dr11.Read())
                {
                    textBox8.Text = Convert.ToString(dr11.GetValue(3));
                }
                sc1.Close();
                SqlConnection sc2 = new SqlConnection("Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True");
                sc2.Open();

                SqlCommand scm2 = new SqlCommand("Select * from employee where Eid = '" + textBox8.Text + "'", sc2);

                SqlDataReader dr8 = scm2.ExecuteReader();
                dr8.Read();

                if (dr8.HasRows == true)
                {
                    string tname = Convert.ToString(dr8.GetValue(1));
                    textBox4.Text = tname;
                }
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con.Open();

                SqlCommand com = new SqlCommand("select * from customer where customer_name='" + textBox5.Text + "'", con);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                if (dr.HasRows == true)
                {
                    id2 = Convert.ToInt32(dr.GetValue(0));
                    //textBox1.Text = Convert.ToString(id);
                    string temp;
                    temp = textBox1.Text;
                    sc1 = new SqlConnection();
                    sc1.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile ;Integrated Security=true";
                    sc1.Open();
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter("select enquiry_id,en_source,en_date,vid,vaid,colourid,followup_id,en_status from enquiry where customer_id= '" + dr.GetValue(0) + "'", sc1);
                    sda.Fill(ds, "enquiry");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "enquiry";
                }
                else
                {
                    MessageBox.Show("Customer not found");
                }

                con.Close();
            }
            catch
            {
            }
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
            SqlDataAdapter sda = new SqlDataAdapter("select enquiry_id,en_source,en_date,vid,vaid,colourid,followup_id,en_status from enquiry where enquiry_id= '" + textBox6.Text + "'", sc1);
            sda.Fill(ds, "enquiry");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "enquiry";
            sc1.Close(); 
            }
            catch{}
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Main me = new Main();
            this.Hide();
            me.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }
    }
}
