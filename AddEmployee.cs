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
    public partial class addemp : Form
    {
        
        int count, count1;
        DataRow dr;
      //  DataRow dr3;
        DataSet ds;
        SqlCommand cmd;
        SqlCommandBuilder cmdb;
        SqlDataAdapter da;
        SqlConnection con;
        public addemp()
        {
            InitializeComponent();

            con = new SqlConnection();
            con.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true";
            cmd = new SqlCommand("select * from employee", con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "employee");
            con.Close();
        }


        private void add_click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "" || textBox13.Text == "" || comboBox1.Text == "" || textBox5.Text == "" || textBox14.Text == "" || textBox7.Text == "" || textBox3.Text == "" || textBox9.Text == "" || textBox10.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Null values are not allowed. Re enter");
                    // valid1();
                }
                else
                {

                    dr = ds.Tables["employee"].NewRow();
                    dr["Eid"] = count;
                    dr["Ename"] = textBox2.Text;
                    dr["Eage"] = textBox13.Text;
                    dr["Egender"] = comboBox1.Text;
                    dr["Eresidence"] = textBox5.Text;
                    dr["Econtactno"] = textBox9.Text;
                    dr["Eemail"] = textBox8.Text;
                    dr["Estate"] = textBox6.Text;
                    dr["Estreet"] = textBox14.Text;
                    dr["Ecity"] = textBox7.Text;
                    dr["Epin"] = textBox3.Text;
                    dr["Designation"] = textBox10.Text;
                    dr["Experience"] = textBox11.Text;
                    dr["Mem_status"] = comboBox2.Text;
                    ds.Tables["employee"].Rows.Add(dr);
                    da.Update(ds, "employee");

                    MessageBox.Show("New Entry is added");
                    Main ma = new Main();
                    this.Hide();
                    ma.Show();
                }
            }
            catch (System.Exception exce)
            {
                MessageBox.Show(exce.Message);
            }

            // this.Hide();
            //password ac = new password();
            //ac.Show();


        }
        private void clearAll()
        {
           // textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox13.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox14.Text = "";
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Main sd = new Main();
            this.Hide();
            sd.Show();
        }

        private void valid1()
        {
            if (textBox1.Text.Length == 0)
               errorProvider1.SetError(textBox1, "Enter id");
            if (textBox2.Text.Length == 0)
                errorProvider2.SetError(textBox2, "Enter name");
            if (textBox13.Text.Length == 0)
                errorProvider3.SetError(textBox13, "Enter age");
            if (comboBox1.Text.Length == 0)
                errorProvider4.SetError(comboBox1, "Select a gender");
            if (textBox5.Text.Length == 0)
                errorProvider5.SetError(textBox5, "Enter residence");
            if (textBox14.Text.Length == 0)
                errorProvider6.SetError(textBox14, "Enter street");
            if (textBox7.Text.Length == 0)
                errorProvider7.SetError(textBox7, "Enter city");
            if (textBox6.Text.Length == 0)
                errorProvider8.SetError(textBox6, "Enter state");
            if (textBox9.Text.Length == 0)
                errorProvider10.SetError(textBox9, "Enter contact number");
            if (textBox10.Text.Length == 0)
                errorProvider11.SetError(textBox10, "Enter designation");
            if (comboBox2.Text.Length == 0)
                errorProvider12.SetError(comboBox2, "Select a status");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
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
                }
            }
            catch
            { }
        }

       


    void textBox2_Validating(object sender, CancelEventArgs e)
    {
        int numberEntered;

        if (int.TryParse(textBox1.Text, out numberEntered))
        {
            if  (numberEntered < 1 || numberEntered > 10) 
            { 
                MessageBox.Show("You have to enter a number between 1 and 10");
                textBox1.Text = 5.ToString();
            }
        }
        else
        {
            MessageBox.Show("You need to enter an integer");
            textBox1.Text = 5.ToString();
        }
    }

        private void addemp_Load_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con3 = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                con3.Open();


                count = 3002;
                string ConnectionString = "Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True";
                DataSet ds = new DataSet();
                string SQLCommand = "select * from employee ";
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand, ConnectionString);
                Adapter.Fill(ds, "employee");
                Adapter.SelectCommand.Connection.Close();
                count1 = ds.Tables["employee"].Rows.Count;
                count = count + count1;
                textBox1.Text = Convert.ToString(count);
                textBox1.Enabled = false;
                search.Visible = false;
                modify.Visible = false;
                delete.Visible = false;
            }
            catch { }
        }

        private void add_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|" +
              @"0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z]" +
              @"[a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";
            System.Text.RegularExpressions.Match match =
                Regex.Match(textBox8.Text.Trim(), pattern, RegexOptions.IgnoreCase);

            if (match.Success)
            {
                //MessageBox.Show("Success");
            }
            else
                MessageBox.Show("Invalid email id");

        }

        private void textBox9_Validating(object sender, CancelEventArgs e)
        {
            Regex regexObj =
    new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");

            if (regexObj.IsMatch(textBox9.Text))
            {
                string formattedPhoneNumber =
                    regexObj.Replace(textBox9.Text, "($1) $2-$3");
            }
            else
            {
                MessageBox.Show("Invalid phone number");
            }
        }

        //private void textBox2_Validating(object sender, CancelEventArgs e)
        //{
        //    Boolean na = IsValidName(textBox2.Text);
        //    if (na == false)
        //    {
        //        MessageBox.Show("Invalid name");
        //        textBox2.Clear();
        //    }
        //}
        public static bool IsValidName(string strToCheck)
        {
            return Regex.IsMatch(strToCheck, "^[a-zA-Z ]+$");
        }

        private void textBox13_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Boolean ag = IsItNumber(textBox13.Text);
            if (ag == true)
            {
                int no1 = Convert.ToInt32(textBox13.Text);
                if (no1 >= 18 && no1 < 70)
                {
                }
                else
                {
                    errorProvider3.SetError(textBox13, "");
                    MessageBox.Show("Invalid age");
                    textBox13.Clear();
                }
            }
            else if (ag == false)
            {
                MessageBox.Show("Invalid age");
                textBox13.Clear();
            }
        }
        public static bool IsItNumber(string inputvalue)
        {
            Regex isnumber = new Regex("[^0-9]");
            return !isnumber.IsMatch(inputvalue);
        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            errorProvider7.Clear();
        }


        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            errorProvider10.Clear();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider4.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            errorProvider5.Clear();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            errorProvider6.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            Boolean ag = IsItNumber(textBox3.Text);
            if (ag == true)
            {
                int no1 = Convert.ToInt32(textBox3.Text);
                if (no1 >= 600000 && no1 < 999999)
                {
                }
                else
                {
                    MessageBox.Show("Invalid pin");
                    textBox3.Clear();
                }
            }
            else if (ag == false)
            {
                MessageBox.Show("Invalid pin");
                textBox3.Clear();
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }

        private void add_Enter(object sender, EventArgs e)
        {

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }
    }
}
