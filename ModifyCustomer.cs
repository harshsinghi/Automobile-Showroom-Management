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
    public partial class modifycus : Form
    {
        public modifycus()
        {
            InitializeComponent();
            //SqlConnection con1,con2;
        }

        private void modify_Click(object sender, EventArgs e)
        {
           try
            {
                if (tid.Text == "" || tname.Text == "" || tage.Text == "" || cgender.Text == "" || tresidence.Text == "" || tcontact.Text == "" || tlocation.Text == "" || tpin.Text == "")
                {
                    MessageBox.Show("Null values are not allowed. Re enter");

                }
                else
                {
                    SqlConnection con2 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                    con2.Open();
                    SqlCommand com2 = new SqlCommand("update customer set customer_name=@customer_name,age=@age,gender=@gender,contactno=@contactno,email=@email,residence=@residence,street=@street,city=@city,state=@state,pin=@pin,occupation=@occupation where customer_id=@customer_id", con2);
                    com2.Parameters.Add(new SqlParameter("@customer_id", tid.Text));
                    com2.Parameters.Add(new SqlParameter("@customer_name", tname.Text));
                    com2.Parameters.Add(new SqlParameter("@age", tage.Text));
                    com2.Parameters.Add(new SqlParameter("@gender", cgender.Text));
                    com2.Parameters.Add(new SqlParameter("@residence", tresidence.Text));
                    com2.Parameters.Add(new SqlParameter("@contactno", tcontact.Text));
                    com2.Parameters.Add(new SqlParameter("@email", temail.Text));
                    com2.Parameters.Add(new SqlParameter("@street", tlocation.Text));
                    com2.Parameters.Add(new SqlParameter("@state", tstate.Text));
                    com2.Parameters.Add(new SqlParameter("@city", tcity.Text));
                    com2.Parameters.Add(new SqlParameter("@pin", tpin.Text));
                    com2.Parameters.Add(new SqlParameter("@occupation", toccupation.Text));



                    com2.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                    con2.Close();
                    //clearAll();

                    this.Hide();
                    Main ac = new Main();
                    ac.Show();
                }
            }
            catch (System.Exception exce)
            {
                MessageBox.Show(exce.Message);
            }
        }

        private void modifycus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'automobileDataSet14.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.automobileDataSet14.customer);
           
            SqlConnection con = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
            con.Open();
            try
            {
                SqlCommand com = new SqlCommand("select * from customer where customer_id='" + tid.Text + "'", con);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();

                if (dr.HasRows == true)
                {

                    //string  tid= Convert.ToString(dr.GetValue(0));
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

                }
                else
                {
                    MessageBox.Show("Invalid id");
                    //textBox1.Text = "";
                }
                con.Close();
            }
            catch (System.Exception exce)
            {
                MessageBox.Show(exce.Message);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            
            Main cs = new Main();
            this.Hide();
            cs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (tid.Text.Length == 0)
                    errorProvider1.SetError(tid, "Enter id");
                SqlConnection con1 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con1.Open();
                SqlCommand com1 = new SqlCommand("select * from customer where customer_id='" + tid.Text + "'", con1);
                SqlDataReader dr1 = com1.ExecuteReader();
                dr1.Read();
                if (dr1.HasRows == true)
                {

                    // string tid = Convert.ToString(dr1.GetValue(0));
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

                    tname.Text = tname1;
                    tage.Text = tage1;
                    cgender.Text = tgender1;
                    tcontact.Text = tcontact1;
                    temail.Text = temail1;
                    tresidence.Text = tresidence1;
                    tlocation.Text = tstreet1;
                    tcity.Text = tcity1;
                    tpin.Text = tpin1;
                    tstate.Text = tstate1;
                    toccupation.Text = toccupation1;

                }
                else
                {
                    MessageBox.Show("Invalid id");
                    tid.Text = "";
                }
                con1.Close();
            }
            catch (System.Exception exce)
            {
                MessageBox.Show(exce.Message);
            }
        }

        
        private void tname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void tresidence_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void tlocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void tstate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }
        

    }
}
