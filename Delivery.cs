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
    public partial class delivery1 : Form
    {
             
        public delivery1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Visible = true;
                label3.Visible = true;

                SqlConnection con = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con.Open();
                SqlCommand com = new SqlCommand("select * from delivery where Billno='" + textBox1.Text + "'", con);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                if (dr.HasRows == true)
                {

                    //string Fid = Convert.ToString(dr.GetValue(0));
                    //string Enid = Convert.ToString(dr.GetValue(1));
                    string date = Convert.ToString(dr.GetValue(2));
                    string ndate = Convert.ToString(dr.GetValue(4));
                    string status = Convert.ToString(dr.GetValue(3));
                    string reason = Convert.ToString(dr.GetValue(5));
                    textBox2.Text = date;
                    comboBox1.Text = status;
                    richTextBox1.Text = reason;
              
                }
                dr.Close();
                con.Close();
            }
            catch
            {
            }
        }

        private void delivery1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'automobileDataSet29.billing' table. You can move, or remove it, as needed.
            this.billingTableAdapter.Fill(this.automobileDataSet29.billing);
            // TODO: This line of code loads data into the 'automobileDataSet28.delivery' table. You can move, or remove it, as needed.
            this.deliveryTableAdapter.Fill(this.automobileDataSet28.delivery);
            // TODO: This line of code loads data into the 'automobileDataSet27.billing' table. You can move, or remove it, as needed.
          //  this.billingTableAdapter1.Fill(this.automobileDataSet27.billing);

            try
            {
                SqlConnection con3 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con3.Open();
                SqlCommand com3 = new SqlCommand("select * from delivery where Billno='" + textBox1.Text + "' and Dstatus='yes'", con3);
                SqlDataReader dr2 = com3.ExecuteReader();
                dr2.Read();
                if (dr2.HasRows == true)
                {
                    button2.Visible = false;
                }
            }
            catch
            { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.Text == "yes")
                {
                    textBox3.Visible = true;
                    label3.Visible = true;
                    textBox3.Text = Convert.ToString(System.DateTime.Now);
                    textBox3.Enabled = true;

                }
                else
                {
                    textBox3.Visible = false;
                    label3.Visible = false;
                    textBox3.Text = "";
                }
            }
            catch
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con5 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con5.Open();
                // string date2 = Convert.ToString(dateTimePicker1.Text );
                SqlCommand com9 = new SqlCommand("update delivery set Dstatus=@status,ndate=@ndate,reason=@reason where Billno=@bno", con5);
                com9.Parameters.Add(new SqlParameter("@bno", textBox1.Text));
                com9.Parameters.Add(new SqlParameter("@ndate", textBox3.Text));
                com9.Parameters.Add(new SqlParameter("@status", comboBox1.Text));
                com9.Parameters.Add(new SqlParameter("@reason", richTextBox1.Text));

                com9.ExecuteNonQuery();
                MessageBox.Show("Updated");
                con5.Close();
                this.Hide();
                Main ac = new Main();
                ac.Show();
                // clearAll();
            }
            catch
            {
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main me = new Main();
            this.Hide();
            me.Show();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }

        
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }
    }
}
