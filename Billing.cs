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
    public partial class billing : Form
    {
        int count, count1, no, cc,no10,no15,no20;
        int tax2, reg, id2, log,total;
        double cess2, ins2, price2;
        string id1, van, variant;
        DataRow dr, dr1;
        DataSet ds, ds1;
        SqlCommand cmd, cmd2, cmd1, cmd9, cmd15;
        SqlCommandBuilder cmdb, cmdb1;
        SqlDataAdapter da, da1;
        SqlConnection con;
        public billing()
        {
            InitializeComponent();
            con = new SqlConnection();
            
            // Creates and open a new connection to database and gets the billing and delivery details 
            
            con.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true";
            cmd = new SqlCommand("select * from billing", con);
            cmd1 = new SqlCommand("select * from delivery", con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            da1 = new SqlDataAdapter(cmd1);
            cmdb = new SqlCommandBuilder(da);
            cmdb1 = new SqlCommandBuilder(da1);
            ds = new DataSet();
            ds1 = new DataSet();
            da.Fill(ds, "billing");
            da1.Fill(ds1, "delivery");
            con.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Main cs = new Main();
            this.Hide();
            cs.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox17.Text != "")
                {
                    textBox6.Text = "";
                    reg = 0;
                    if (radioButton1.Checked)
                        reg = 100;
                    else if (radioButton2.Checked)
                        reg = 450;
                    if (checkBox1.Checked)
                    {
                        reg = 2100;
                    }
                    
                    // Calculation related to final amount after adding tax 
                    
                    double price = Convert.ToDouble(textBox4.Text);
                    double tax = Convert.ToDouble(textBox1.Text);

                    double tax1 = (price * tax) / 100;

                    double ins = Convert.ToDouble(textBox8.Text);
                    if (textBox5.Text == "")
                        textBox5.Text = Convert.ToString(0);
                    double discount = Convert.ToDouble(textBox5.Text);
                    if (textBox7.Text == "")
                        textBox7.Text = Convert.ToString(1);

                    double no3 = ((price + tax1 + ins + reg - discount) * no);
                    textBox6.Text = Convert.ToString(no3);

                    dr = ds.Tables["Billing"].NewRow();
                    dr["Billno"] = count;
                    dr["Cid"] = textBox13.Text;
                    dr["Eid"] = no;
                    dr["Enid"] = comboBox4.Text;
                    dr["Billdate"] = dateTimePicker1.Text;
                    dr["Price"] = textBox4.Text;
                    dr["Number"] = textBox7.Text;
                    dr["Insurance"] = textBox8.Text;
                    dr["Registration"] = textBox17.Text;
                    dr["Discount"] = textBox5.Text;
                    dr["Total"] = textBox6.Text;
                    ds.Tables["Billing"].Rows.Add(dr);
                    da.Update(ds, "Billing");

                    dr1 = ds1.Tables["delivery"].NewRow();
                    dr1["Did"] = count;
                    dr1["Billno"] = count;
                    dr1["Ddate"] = dateTimePicker2.Text;
                    dr1["Dstatus"] = "Pending";
                    ds1.Tables["delivery"].Rows.Add(dr1);
                    da1.Update(ds1, "delivery");

                    
                    SqlConnection con6 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                    con6.Open();
                    SqlCommand com6 = new SqlCommand("update enquiry set en_status='Bought' where enquiry_id=@Enid", con6);
                    com6.Parameters.Add(new SqlParameter("@Enid", comboBox4.Text));
                    MessageBox.Show("Bill is generated successfully");
                    com6.ExecuteNonQuery();
                    
                    con6.Close();
                    this.Hide();
                    Main ac = new Main();
                    ac.Show();
                    
                }
                else
                {
                    MessageBox.Show("Enter registration part");

                }
            }
            catch(System.Exception exce) 
            {
                MessageBox.Show(exce.Message);
            }
        }

        private void billing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'automobileDataSet30.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.automobileDataSet30.customer);
            // TODO: This line of code loads data into the 'automobileDataSet12.vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.automobileDataSet12.vehicle);
            try
            {
                SqlConnection sc1 = new SqlConnection("Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True");
                sc1.Open();

                SqlCommand scom1 = new SqlCommand("select * from temptable", sc1);

                SqlDataReader dr11 = scom1.ExecuteReader();

                if (dr11.Read())
                {
                    textBox14.Text = Convert.ToString(dr11.GetValue(3));
                }
                sc1.Close();
                SqlConnection sc2 = new SqlConnection("Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True");
                sc2.Open();
                
                // gets the employee related information
                
                SqlCommand scm2 = new SqlCommand("Select * from employee where Eid = '" + textBox14.Text + "'", sc2);

                SqlDataReader dr8 = scm2.ExecuteReader();
                dr11.Close();
                dr8.Read();

                if (dr8.HasRows == true)
                {
                    string tname = Convert.ToString(dr8.GetValue(1));
                    textBox3.Text = tname;
                }
                dr8.Close();
                count = 10001;
                string ConnectionString = "Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True";
                DataSet ds = new DataSet();
                string SQLCommand = "select * from temptable ";
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand, ConnectionString);
                Adapter.Fill(ds, "billing");
                Adapter.SelectCommand.Connection.Close();
                count1 = ds.Tables["billing"].Rows.Count;
                count = count + count1;
                int flag = 0;


                while (flag == 0)
                {
                    con.Close();
                    con.Open();
                    SqlCommand com1 = new SqlCommand("select * from billing  where billno=@billno", con);
                    com1.Parameters.Add(new SqlParameter("@billno", Convert.ToString(count)));
                    SqlDataReader dr = com1.ExecuteReader();

                    Boolean b = (Boolean)dr.HasRows;
                    if (b == true)
                        count = count + 1;
                    else
                        break;
                }
                con.Close();
                bno.Text = Convert.ToString(count);
                bno.Enabled = false;
               
            }
            catch { }
        }

        private void cBoxCarModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
               
                cmd2 = new SqlCommand("Select * from vehicle where model ='" + cBoxCarModel.Text + "'", con);
                SqlDataReader sdr2 = cmd2.ExecuteReader();
                while (sdr2.Read())
                {
                    id1 = Convert.ToString(sdr2["vid"]);
                    cc = Convert.ToInt32(sdr2["vcc"]);
                }
                sdr2.Close();
                con.Close();

                con.Open();
                cmd1 = new SqlCommand("Select vaname from variant where vid=@id", con);
                cmd1.Parameters.Add(new SqlParameter("@id", id1));
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                while (sdr1.Read())
                {
                    cBoxCarModel.Items.Add(sdr1["vaname"]);
                    van = Convert.ToString(sdr1["vaname"]);
                }
                sdr1.Close();
                con.Close();

                con.Open();
                cmd1 = new SqlCommand("Select colour_name from colour where vid=@id", con);
                cmd1.Parameters.Add(new SqlParameter("@id", id1));
                SqlDataReader sdr5 = cmd1.ExecuteReader();
                while (sdr5.Read())
                {
                    cBoxColor.Items.Add(sdr5["colour_name"]);
                    // comboBox2.Items.Add(sdr1["Destination"]);
                }
                sdr5.Close();
                con.Close();

                if (cc < 1500)
                {
                    SqlConnection con10 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                    con10.Open();
                    SqlCommand com10 = new SqlCommand("select * from temptable where no=5", con10);
                    SqlDataReader dr10 = com10.ExecuteReader();
                    if (dr10.Read())
                    {
                        tax2 = Convert.ToInt32(dr10.GetString(1));
                        textBox1.Text = Convert.ToString(dr10.GetString(1));
                        double total = (price2 * tax2) / 100;
                        textBox15.Text = Convert.ToString(total);
                    }
                    con10.Close();
                }
                else
                {
                    SqlConnection con10 = new SqlConnection("Data Source=lalu-HP; Initial Catalog=showroom; Integrated Security=true");
                    con10.Open();
                    SqlCommand com10 = new SqlCommand("select * from temptable where no=6", con10);
                    SqlDataReader dr10 = com10.ExecuteReader();
                    // dr3.Read();
                    if (dr10.Read())
                    {
                        tax2 = Convert.ToInt32(dr10.GetString(1));
                        textBox1.Text = Convert.ToString(dr10.GetString(1));
                        double total = (price2 * tax2) / 100;
                        textBox15.Text = Convert.ToString(total);
                    }
                    con10.Close();
                }

               
            }
            catch
            {
            }
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con6 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con6.Open();
                SqlCommand com6 = new SqlCommand("select * from customer where customer_id='" + txtCustomer.Text + "'", con6);
                SqlDataReader dr6 = com6.ExecuteReader();
                dr6.Read();
                if (dr6.HasRows == true)
                {
                    string tname1 = Convert.ToString(dr6.GetValue(1));
                    string tcontact1 = Convert.ToString(dr6.GetValue(4));
                    string tresidence1 = Convert.ToString(dr6.GetValue(6));
                    string tstreet1 = Convert.ToString(dr6.GetValue(7));

                    textBox9.Text = tname1;
                    textBox12.Text = tcontact1;
                    textBox10.Text = tresidence1;
                    textBox11.Text = tstreet1;
                }
                
                con6.Close();

                SqlConnection con9 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con9.Open();
                //comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                cmd9 = new SqlCommand("Select * from enquiry where customer_id ='" + textBox13.Text + "'", con9);
                SqlDataReader sdr9 = cmd9.ExecuteReader();
                while (sdr9.Read())
                {
                    comboBox4.Items.Add(sdr9["enquiry_id"]);
                }
                sdr9.Close();
                con9.Close();
            }
            catch { }
        }

        private void cboxEnquiry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";

                SqlConnection con5 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con5.Open();
                SqlCommand com5 = new SqlCommand("select * from enquiry where enquiry_id='" + cboxEnquiry.Text + "'", con5);
                SqlDataReader dr5 = com5.ExecuteReader();
                dr5.Read();
                if (dr5.HasRows == true)
                {

                    string tid = Convert.ToString(dr5.GetValue(0));
                    string vehicle = Convert.ToString(dr5.GetValue(6));
                    variant = Convert.ToString(dr5.GetValue(7));
                    string color = Convert.ToString(dr5.GetValue(8));
                    textBox4.Text = variant;

                    //textBox6.Text = tid;
                    comboBox1.Text = vehicle;
                    comboBox2.Text = variant;
                    comboBox3.Text = color;
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Invalid id");
                    //tid.Text = "";
                }
                con5.Close();
                //textBox4.Text = "";
                SqlConnection con15 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con15.Open();
                // comboBox2.Enabled = true;
                cmd15 = new SqlCommand("Select Price from varient where vname=@van", con15);
                cmd15.Parameters.Add(new SqlParameter("@van", variant));
                SqlDataReader sdr15 = cmd15.ExecuteReader();
                while (sdr15.Read())
                {
                    textBox4.Text = Convert.ToString(sdr15["price"]);
                    price2 = Convert.ToDouble(sdr15["price"]);
                }
                sdr15.Close();
                con15.Close();

                con.Open();
                cmd2 = new SqlCommand("Select * from vehicle where model ='" + cBoxModel.Text + "'", con);
                SqlDataReader sdr2 = cmd2.ExecuteReader();
                while (sdr2.Read())
                {
                    cc = Convert.ToInt32(sdr2["Vcc"]);
                }
                sdr2.Close();
                con.Close();

            }
            catch { }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            reg = 2100;
            textBox17.Text = Convert.ToString(reg);
        }

        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int no8, no9;
            no8 = Convert.ToInt32(textBox4.Text);
            no9 = Convert.ToInt32(textBox7.Text);
            total =Convert.ToInt32(no8 * no9);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int no12;
            int no13;
            int no14;
            
            no12 = Convert.ToInt32(textBox1.Text);
            no13 = Convert.ToInt32(textBox6.Text);
            no14 = no12 * no13;
            no15 = no14 / 100;
            textBox15.Text = Convert.ToString(no15);

        }

    }

