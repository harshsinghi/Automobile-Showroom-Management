using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace automobile
{
    public partial class addcus : Form
    {

        int  count,count1;
        DataRow dr;
        DataSet ds;

        SqlCommand cmd;
        SqlCommandBuilder cmdb;
        SqlDataAdapter da;
        SqlConnection con;
        public addcus()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true";
            cmd = new SqlCommand("select * from customer", con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "customer");
            con.Close();
        }

        private void valid1()
        {
            if (tid.Text.Length == 0)
                errorProvider1.SetError(tid, "Enter id");
            if (tname.Text.Length == 0)
                errorProvider2.SetError(tname, "Enter name");
            if (tage.Text.Length == 0)
                errorProvider3.SetError(tage, "Enter age");
            if (cgender.Text.Length == 0)
                errorProvider4.SetError(cgender, "Select a gender");
            if (tresidence.Text.Length == 0)
                errorProvider5.SetError(tresidence, "Enter residence");
            if (tlocation.Text.Length == 0)
                errorProvider6.SetError(tlocation, "Enter location");
            if (tcity.Text.Length == 0)
                errorProvider7.SetError(tcity, "Enter city");
            if (tpin.Text.Length == 0)
                errorProvider8.SetError(tpin, "Enter pin code");
            if (tcontact.Text.Length == 0)
                errorProvider9.SetError(tcontact, "Enter contact number");
        }
   
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (tid.Text == "" || tname.Text == "" || tage.Text == "" || cgender.Text == "" || tresidence.Text == "" || tcontact.Text == "" || tlocation.Text == "" || tpin.Text == "")
                {
                    MessageBox.Show("Null values are not allowed. Re enter");
                    valid1();
                }
                else
                {
                    dr = ds.Tables["customer"].NewRow();
                    dr["customer_id"] = tid.Text;
                    dr["customer_name"] = tname.Text;
                    dr["age"] = tage.Text;
                    dr["gender"] = cgender.Text;
                    dr["residence"] = tresidence.Text;
                    dr["contactno"] = tcontact.Text;
                    dr["email"] = temail.Text;
                    dr["street"] = tlocation.Text;
                    dr["state"] = tstate.Text;
                    dr["city"] = tcity.Text;
                    dr["pin"] = tpin.Text;
                    dr["occupation"] = toccupation.Text;
                    ds.Tables["customer"].Rows.Add(dr);
                    da.Update(ds, "customer");

                    MessageBox.Show("New Entry is added");

                    this.Hide();
                    Main ac = new Main();
                    ac.Show();


                }
            }
            catch { }
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void addcus_Load(object sender, EventArgs e)
        {
            try
            {
                count = 3002;
                string ConnectionString = "Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True";
                DataSet ds = new DataSet();
                string SQLCommand = "select * from customer ";
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand, ConnectionString);
                Adapter.Fill(ds, "customer");
                Adapter.SelectCommand.Connection.Close();
                count = ds.Tables["customer"].Rows.Count;
                count = count + count;
                int flag = 0;
                while (flag == 0)
                {

                    con.Close();
                    con.Open();
                    SqlCommand com1 = new SqlCommand("select * from customer where customer_id=@customer_id", con);
                    com1.Parameters.Add(new SqlParameter("@customer_id", Convert.ToString(count)));
                    SqlDataReader dr = com1.ExecuteReader();

                    Boolean b = (Boolean)dr.HasRows;
                    if (b == true)
                        count = count + 1;
                    else
                        break;
                }
                con.Close();
                tid.Text = Convert.ToString(count);

                tid.Enabled = false;
            }
            catch { }
        }
        

        private void clear_Enter(object sender, EventArgs e)
        {

        }

        private void clear_Enter_1(object sender, EventArgs e)
        {

        }

        private void modify_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {

            Main cs = new Main();
            this.Hide();
            cs.Show();
        }

      
        private void tid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tname_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void tname_Validating(object sender, CancelEventArgs e)
        {
            Boolean na = IsValidName(tname.Text);
            if (na == false)
            {
                MessageBox.Show("Invalid name");
                tname.Clear();
            }
        }
        public static bool IsValidName(string strToCheck)
        {
            return Regex.IsMatch(strToCheck, "^[a-zA-Z ]+$");
        }

        private void tage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int numberEntered = int.Parse(tage.Text);
                if (numberEntered < 1 || numberEntered > 100)
                {
                    label2.Text = "You must enter a number";
                    tage.Text = "";

                }
                else
                {
                    label2.Text = "";
                }
            }
            catch (FormatException)
            {

                label2.Text = "you need to enter an integer";
            }
        }

        private void tpin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int numberEntered = int.Parse(tpin.Text);
                if (numberEntered < 100000 || numberEntered > 999999)
                {
                    label3.Text = "You must enter a 6 digit pin";
                }
                else
                {
                    label3.Text = "";
                }
            }
            catch (FormatException)
            {

                label3.Text = "you need to enter an integer";
            }
        }

        private int namec(string c)
        {
            int num = 0;
            foreach (char ch in c)
            {
                if(char.IsLetter(ch))
                {
                num++;
            }
            }
            return num;

        }
        
        

        private int numberpass(string pass)
        {
            int num = 0;
            foreach (char ch in pass)
            {
                if (char.IsDigit(ch))
                {
                    num++;
                }
            }
            return num;
        }

        private void tcontact_TextChanged(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 10;
            string contactno = tcontact.Text;
            if (contactno.Length == MIN_LENGTH && numberpass(contactno) >= 10)
            {
                label4.Text = "";
            }
            else
            {
                label4.Text = "you must enter only a 10 digit number";
            }
            


        }

        private void tname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void tcity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void tstate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void toccupation_TextChanged(object sender, EventArgs e)
        {

        }

        private void toccupation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void tlocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void tresidence_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void tage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }

        private void tpin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }

        private void tcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }
         }
    }

