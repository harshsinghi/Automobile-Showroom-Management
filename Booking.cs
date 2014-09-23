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
    public partial class booking : Form
    {
        int id2;
        SqlConnection sc1;
        int count, count1, no;
        string id1;
        DataRow dr;
        DataSet ds;
        SqlCommand cmd, cmd2, cmd1;
        SqlCommandBuilder cmdb;
        SqlDataAdapter da;
        SqlConnection con;

        public booking()
        {
            InitializeComponent();
            
            // creates connection to SQl database
            
            con = new SqlConnection();
            con.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true";
            cmd = new SqlCommand("select * from booking", con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "booking");
            con.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || textBox5.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "")
                {
                    MessageBox.Show("Null values are not allowed. Re enter");

                }
                else
                {
                    // updates customer related information into database
                
                    SqlConnection con2 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                    con2.Open();
                    SqlCommand com2 = new SqlCommand("update customer set customer_name=@customer_name,contactno=@contactno,email=@email,residence=@residence,street=@street,city=@city,state=@state,pin=@pin where customer_id=@customer_id", con2);
                    // SqlCommand com2 = new SqlCommand("update customer set customer_name=@customer_name,contactno=@contactno,email=@email,residence=@residence,street=@street,city=@city,state=@state,pin=@pin where customer_id=@ccustomer_id", con2);
                    com2.Parameters.Add(new SqlParameter("@customer_id", textBox5.Text));
                    com2.Parameters.Add(new SqlParameter("@customer_name", textBox3.Text));
                    com2.Parameters.Add(new SqlParameter("@residence", textBox8.Text));
                    com2.Parameters.Add(new SqlParameter("@contactno", Convert.ToDouble(textBox4.Text)));
                    com2.Parameters.Add(new SqlParameter("@email", textBox13.Text));
                    com2.Parameters.Add(new SqlParameter("@street", textBox9.Text));
                    com2.Parameters.Add(new SqlParameter("@state", textBox11.Text));
                    com2.Parameters.Add(new SqlParameter("@city", textBox10.Text));
                    com2.Parameters.Add(new SqlParameter("@pin", Convert.ToInt32(textBox12.Text)));




                    com2.ExecuteNonQuery();
                    //MessageBox.Show("Updated");
                    con2.Close();

                    // ctr = ctr + 1;
                    dr = ds.Tables["booking"].NewRow();
                    dr["booking_id"] = textBox1.Text;
                    dr["customer_id"] = textBox5.Text;
                    dr["employee_id"] = textBox2.Text;
                    dr["enquiry_id"] = comboBox4.Text;
                    dr["bdate"] = System.DateTime.Now;
                    // dr["Btime"] = dateTimePicker2.Text;
                    dr["bmodel"] = comboBox1.Text;
                    dr["bvariant"] = comboBox2.Text;
                    dr["colourid"] = comboBox3.Text;
                    dr["bamount"] = textBox7.Text;

                    ds.Tables["booking"].Rows.Add(dr);
                    da.Update(ds, "booking");



                    SqlConnection con6 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                    con6.Open();
                    
                    // Updates the status of enquiry to 'Booked' for the customer
                    
                    SqlCommand com6 = new SqlCommand("update enquiry set en_status='Booked' where enquiry_id=@enquiry_id", con6);
                    com6.Parameters.Add(new SqlParameter("@enquiry_id", comboBox4.Text));
                    MessageBox.Show("Booking is done successfully");
                    com6.ExecuteNonQuery();
                    con6.Close();

                    this.Hide();
                    Main ac = new Main();

                    ac.Show();
                }
            }
            catch
            { }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main ac = new Main();
            ac.Show();
        }

        private void booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'automobileDataSet17.enquiry' table. You can move, or remove it, as needed.
            this.enquiryTableAdapter.Fill(this.automobileDataSet17.enquiry);
            // TODO: This line of code loads data into the 'automobileDataSet16.vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.automobileDataSet16.vehicle);
            try
            {
                
                SqlConnection sc1 = new SqlConnection("Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True");
                sc1.Open();

                SqlCommand scom1 = new SqlCommand("select * from temptable", sc1);

                SqlDataReader dr11 = scom1.ExecuteReader();

                if (dr11.Read())
                {
                    textBox16.Text = Convert.ToString(dr11.GetValue(3));
                }
                sc1.Close();
                SqlConnection sc2 = new SqlConnection("Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True");
                sc2.Open();
                
                // get the employee related information 
                
                SqlCommand scm2 = new SqlCommand("Select * from employee where Eid = '" + txtEmployee.Text + "'", sc2);

                SqlDataReader dr8 = scm2.ExecuteReader();
                dr8.Read();

                if (dr8.HasRows == true)
                {
                    string tname = Convert.ToString(dr8.GetValue(0));
                    textBox2.Text = tname;
                }
                count = 5001;
                string ConnectionString = "Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True";
                DataSet ds = new DataSet();
                
                // Get the booking details from booking table
                
                string SQLCommand = "select * from booking ";
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand, ConnectionString);
                Adapter.Fill(ds, "booking");
                Adapter.SelectCommand.Connection.Close();
                count1 = ds.Tables["booking"].Rows.Count;
                count = count + count1;
                int flag = 0;
                while (flag == 0)
                {
                    con.Close();
                    con.Open();
                    
                    // gets the booking information for a particular customer 
                    
                    SqlCommand com = new SqlCommand("select * from booking where booking_id=@booking_id", con);
                    com.Parameters.Add(new SqlParameter("@booking_id", Convert.ToString(count)));
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

                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";

                SqlConnection con4 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con4.Open();
                SqlCommand com4 = new SqlCommand("select * from employee where Eid='" + textBox2.Text + "'", con4);
                SqlDataReader dr4 = com4.ExecuteReader();

                if (dr4.Read())
                {
                    textBox2.Text = Convert.ToString(dr4.GetString(1));
                    textBox2.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void cBoxVehicleModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
                
                cBoxVehicleModel.Items.Clear();
                cmd2 = new SqlCommand("Select distinct vehicle_id  from vehicle where model ='" + cBoxVehicleModel.Text + "'", con);
                SqlDataReader sdr2 = cmd2.ExecuteReader();
                while (sdr2.Read())
                {
                    id1 = Convert.ToString(sdr2["vehicle_id"]);
                   
                }
                sdr2.Close();
                con.Close();

                con.Open();
                cmd1 = new SqlCommand("Select vname from varient where vid=@id", con);
                cmd1.Parameters.Add(new SqlParameter("@id", id1));
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                while (sdr1.Read())
                {
                    cBoxVehicleModel.Items.Add(sdr1["vname"]);
                  
                }
                sdr1.Close();
                con.Close();

                con.Open();
                cmd1 = new SqlCommand("Select colour_name from colour where vid=@id", con);
                cmd1.Parameters.Add(new SqlParameter("@id", id1));
                SqlDataReader sdr5 = cmd1.ExecuteReader();
                while (sdr5.Read())
                {
                    comboBox3.Items.Add(sdr5["colour_name"]);
                    
                }
                sdr5.Close();
                con.Close();
            }
            catch
            { }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con.Open();

                SqlCommand com = new SqlCommand("select * from customer where customer_name='" + txtCustomer.Text + "'", con);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                if (dr.HasRows == true)
                {
                    id2 = Convert.ToInt32(dr.GetValue(0));
                    string temp;
                    temp = textBox1.Text;
                    sc1 = new SqlConnection();
                    sc1.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile ;Integrated Security=true";
                    sc1.Open();
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter("select enquiry_id,customer_id,en_source,en_date,vid,vaid,colourid,followup_id,en_status from enquiry where customer_id= '" + dr.GetValue(0) + "'", sc1);
                    sda.Fill(ds, "enquiry");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "enquiry";
                }
                else
                {
                    MessageBox.Show("Customer not found");
                }
            }
            catch
            { }
        }

        private void cBoxEnquiry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";

                SqlConnection con5 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con5.Open();
                
                // gets the enquiry related infromation for the selected enquiry
                
                SqlCommand com5 = new SqlCommand("select * from enquiry where enquiry_id='" + cBoxEnquiry.Text + "'", con5);
                SqlDataReader dr5 = com5.ExecuteReader();
                dr5.Read();
                if (dr5.HasRows == true)
                {

                    string tid = Convert.ToString(dr5.GetValue(0));
                    string vehicle = Convert.ToString(dr5.GetValue(6));
                    string variant = Convert.ToString(dr5.GetValue(7));
                    string color = Convert.ToString(dr5.GetValue(8));
                }
                else
                {
                    MessageBox.Show("Invalid id");
                  
                }
            }
            catch
            { }
   }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = "";
                textBox4.Text = "";
                textBox13.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox12.Text = "";
                textBox11.Text = "";

                SqlConnection con1 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con1.Open();
                SqlCommand com1 = new SqlCommand("select * from customer where customer_id='" + txtCustomer.Text + "'", con1);
                SqlDataReader dr1 = com1.ExecuteReader();
                dr1.Read();
                if (dr1.HasRows == true)
                {
                    string tname1 = Convert.ToString(dr1.GetValue(1));
                    string tage1 = Convert.ToString(dr1.GetValue(2));
                    string tgender1 = Convert.ToString(dr1.GetValue(3));
                    string tcontact1 = Convert.ToString(dr1.GetValue(4));
                    string temail1 = Convert.ToString(dr1.GetValue(5));
                    string tresidence1 = Convert.ToString(dr1.GetValue(6));
                    string tstreet1 = Convert.ToString(dr1.GetValue(7));
                    string tcity1 = Convert.ToString(dr1.GetValue(8));
                    string tstate1 = Convert.ToString(dr1.GetValue(9));
                    string tpin1 = Convert.ToString(dr1.GetValue(10));

                    string toccupation1 = Convert.ToString(dr1.GetValue(11));

                }

                con1.Close();


                con.Open();
                
                cmd2 = new SqlCommand("Select * from enquiry where customer_id ='" + txtCustomer.Text + "'", con);
                SqlDataReader sdr3 = cmd2.ExecuteReader();
                while (sdr3.Read())
                {
                  
                    cboxEnquiry.Items.Add(sdr3["enquiry_id"]);
                }
                sdr3.Close();
                con.Close();
            }
            catch
            { }
        }

        


        private void txtCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }
