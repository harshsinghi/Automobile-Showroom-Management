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
    public partial class enquirybooking : Form
    {
        SqlConnection sc1;
        int count, count1, no;
        string id1;
        DataRow dr, dr1;
        DataSet ds, ds1;
        SqlCommand cmd, cmd1, cmd2, cmd3;
        SqlCommandBuilder cmdb;
        SqlDataAdapter da, da1;
        SqlConnection con, con1;
        //SqlDataReader sdr2;
        string id;
        public enquirybooking()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true";
            cmd = new SqlCommand("select * from enquiry", con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "enquiry");
            con.Close();
        }

        private void valid1()
        {

            if (comboBox5.Text.Length == 0)
                errorProvider2.SetError(comboBox5, "Select a source");
            if (comboBox2.Text.Length == 0)
                errorProvider3.SetError(comboBox2, "Select a model");
            if (comboBox3.Text.Length == 0)
                errorProvider4.SetError(comboBox3, "Select a variant");
            if (comboBox1.Text.Length == 0)
                errorProvider5.SetError(comboBox1, "Select a colour");
            if (textBox4.Text.Length == 0)
                errorProvider6.SetError(textBox4, "Enter Customer id");

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd2 = new SqlCommand("Select distinct vehicle_id  from vehicle where model ='" + comboBox2.Text + "'", con);
                SqlDataReader sdr2 = cmd2.ExecuteReader();
                while (sdr2.Read())
                {
                    id = Convert.ToString(sdr2["vehicle_id"]);
                    // comboBox2.Text = Convert.ToString(sdr2["Vid"]);
                }
                sdr2.Close();
                con.Close();

                if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Null values are not allowed. Re enter");
                    
                }
                else
                {
                    dr = ds.Tables["enquiry"].NewRow();
                    dr["enquiry_id"] = textBox1.Text;
                    dr["employee_id"] = textBox3.Text;
                    dr["customer_id"] = textBox4.Text;
                    dr["en_source"] = comboBox5.Text;
                    dr["en_date"] = System.DateTime.Now;//dateTimePicker1.Text;
                    //dr["en_time"] = System.DateTime.Now;//dateTimePicker2.Text;
                    dr["vid"] = comboBox2.Text;
                    dr["vaid"] = comboBox3.Text;
                    dr["colourid"] = comboBox1.Text;

                    dr["followup_id"] = textBox2.Text;
                    dr["en_status"] = "Active";
                    // dr["Endate"] = dateTimePicker3.Text;

                    ds.Tables["enquiry"].Rows.Add(dr);
                    da.Update(ds, "enquiry");

                    con1 = new SqlConnection();
                    con1.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true";
                    cmd3 = new SqlCommand("select * from followup", con1);
                    con1.Open();
                    da1 = new SqlDataAdapter(cmd3);
                    cmdb = new SqlCommandBuilder(da1);
                    ds1 = new DataSet();
                    da1.Fill(ds1, "followup");
                    //combo();
                    con1.Close();


                    dr1 = ds1.Tables["followup"].NewRow();
                    dr1["enid"] = count;
                    dr1["followup_id"] = textBox2.Text;
                    dr1["Fdate"] = dateTimePicker3.Text;
                    // dr1["Fstatus"] = "active";
                    dr1["fcomments"] = richTextBox1.Text;
                    dr1["foffers"] = richTextBox2.Text;
                    ds1.Tables["followup"].Rows.Add(dr1);
                    da1.Update(ds1, "followup");

                    MessageBox.Show("New Entry is added");
                    this.Hide();
                    enquiry ac = new enquiry();
                    ac.Show();
                    //this.Hide();
                    //home ac = new home();
                    //ac.Show();
                }
            }
            catch 
            {
                MessageBox.Show("New Entry is added");
            }
        }

        private void enquirybooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'automobileDataSet8.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.automobileDataSet8.customer);
            // TODO: This line of code loads data into the 'automobileDataSet7.vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.automobileDataSet7.vehicle);
            SqlConnection sc1 = new SqlConnection("Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True");
            sc1.Open();

            SqlCommand scom1 = new SqlCommand("select * from temptable", sc1);

            SqlDataReader dr11 = scom1.ExecuteReader();

            if (dr11.Read())
            {
                textBox3.Text = Convert.ToString(dr11.GetValue(3));
            }
           
            count = 1001;
            try
            {
                string ConnectionString = "Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True";
                DataSet ds = new DataSet();
                string SQLCommand = "select * from enquiry ";
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand, ConnectionString);
                Adapter.Fill(ds, "enquiry");
                Adapter.SelectCommand.Connection.Close();
                count1 = ds.Tables["enquiry"].Rows.Count;
                count = count + count1;
                int flag = 0;
                while (flag == 0)
                {
                    //string Con4 = "Data Source=lalu-HP;Initial Catalog=showroom;Integrated Security=True";
                    con.Close();
                    con.Open();
                    SqlCommand com = new SqlCommand("select * from enquiry where enquiry_id=@enquiry_id", con);
                    com.Parameters.Add(new SqlParameter("@enquiry_id", Convert.ToString(count)));
                    SqlDataReader dr = com.ExecuteReader();

                    Boolean b = (Boolean)dr.HasRows;
                    if (b == true)
                        count = count + 1;
                    else
                        break;
                }
                con.Close();
                textBox1.Text = Convert.ToString(count);
                textBox1.Enabled = false;
                textBox2.Text = Convert.ToString(count);
                textBox2.Enabled = false;

                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox5.Text = "";
                dateTimePicker3.Text = "";

                //SqlConnection con4 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                //con4.Open();
                //SqlCommand com4 = new SqlCommand("select * from employee where Eid='" + textBox3.Text + "'", con4);
                //SqlDataReader dr4 = com4.ExecuteReader();
                //// dr3.Read();
                //if (dr4.Read())
                //{
                //    //int no = Convert.ToInt32(dr4.GetString(1));
                //    textBox3.Text = Convert.ToString(dr4.GetString(1));
                //    textBox3.Enabled = false;
                //    //comboBox6.Items.Add(dr3["Ename"].ToString());
                //    //textBox1.Text = Convert.ToString(id);
                //}

            }
            catch
            { }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
                comboBox3.Items.Clear();
                comboBox1.Items.Clear();
                cmd2 = new SqlCommand("Select distinct vehicle_id  from vehicle where model ='" + comboBox2.Text + "'", con);
                SqlDataReader sdr2 = cmd2.ExecuteReader();
                while (sdr2.Read())
                {
                    id1 = Convert.ToString(sdr2["vehicle_id"]);
                    // comboBox2.Text = Convert.ToString(sdr2["Vid"]);
                }
                sdr2.Close();
                con.Close();

                con.Open();
                cmd1 = new SqlCommand("Select vname from varient where vid=@id", con);
                cmd1.Parameters.Add(new SqlParameter("@id", id1));
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                while (sdr1.Read())
                {
                    comboBox3.Items.Add(sdr1["vname"]);
                    // comboBox2.Items.Add(sdr1["Destination"]);
                }
                sdr1.Close();
                con.Close();

                con.Open();
                cmd1 = new SqlCommand("Select colour_name from colour where vid=@id", con);
                cmd1.Parameters.Add(new SqlParameter("@id", id1));
                SqlDataReader sdr5 = cmd1.ExecuteReader();
                while (sdr5.Read())
                {
                    comboBox1.Items.Add(sdr5["colour_name"]);
                    // comboBox2.Items.Add(sdr1["Destination"]);
                }
                sdr5.Close();
                con.Close();
            }
            catch
            { }
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
                SqlDataAdapter sda = new SqlDataAdapter("select customer_id,customer_name,gender,contactno,email,residence,street from customer where customer_name= '" + textBox5.Text + "'", sc1);
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
                SqlDataAdapter sda = new SqlDataAdapter("select customer_id,customer_name,gender,contactno,email,residence,street from customer where customer_id= '" + textBox6.Text + "'", sc1);
                sda.Fill(ds, "customer");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "customer";
            }
            catch { }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox1.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox5.Text = "";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            enquiry ac = new enquiry();
            ac.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar)|| char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 37 ? false : true;
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }
        
    }
}
