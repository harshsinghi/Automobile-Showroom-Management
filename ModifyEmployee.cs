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
    public partial class modifyemp : Form
    {
        public modifyemp()
        {
            InitializeComponent();
        }




        private void modifyemp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'automobileDataSet2.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.automobileDataSet2.employee);
            try
            {
                SqlConnection sc1 = new SqlConnection("Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True");
                sc1.Open();

                SqlCommand scom1 = new SqlCommand("select * from temptable", sc1);

                SqlDataReader dr1 = scom1.ExecuteReader();

                if (dr1.Read())
                {
                    textBox1.Text = Convert.ToString(dr1.GetValue(3));
                }
                sc1.Close();
                SqlConnection sc2 = new SqlConnection("Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True");
                sc2.Open();

                SqlCommand scm2 = new SqlCommand("Select * from employee where Eid = '" + textBox1.Text + "'", sc2);

                SqlDataReader dr = scm2.ExecuteReader();
                dr.Read();
                if (dr.HasRows == true)
                {
                    string tname = Convert.ToString(dr.GetValue(1));
                    string tage = Convert.ToString(dr.GetValue(2));
                    string tgender = Convert.ToString(dr.GetValue(3));
                    string tcontact = Convert.ToString(dr.GetValue(5));
                    string temail = Convert.ToString(dr.GetValue(6));
                    string tresidence = Convert.ToString(dr.GetValue(4));
                    string tstreet = Convert.ToString(dr.GetValue(8));
                    string tcity = Convert.ToString(dr.GetValue(9));
                    string tpin = Convert.ToString(dr.GetValue(10));
                    string tstate = Convert.ToString(dr.GetValue(7));
                    string tdesignation = Convert.ToString(dr.GetValue(11));
                    string texp = Convert.ToString(dr.GetValue(12));
                    string tmstatus = Convert.ToString(dr.GetValue(13));

                    textBox2.Text = tname;
                    textBox13.Text = tage;
                    comboBox1.Text = tgender;
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
            }
            catch { }
        }

        private void modify_Click(object sender, EventArgs e)
        {
          
            }
        

        private void cancel_Click(object sender, EventArgs e)
        {
            Main cs = new Main ();
            this.Hide();
            cs.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == 8  ? false : true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox13.Text == "" || comboBox1.Text == "" || textBox5.Text == "" || textBox14.Text == "" || textBox7.Text == "" || textBox3.Text == "" || textBox9.Text == "" || textBox10.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Null values are not allowed. Re enter");
                    //  valid1();
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true");
                    con.Open();
                    SqlCommand com2 = new SqlCommand("update employee set Ename=@Ename,Eage=@Eage,Egender=@Egender,Econtactno=@Econtactno,Eemail=@Eemail,Eresidence=@Eresidence,Estreet=@Estreet,Ecity=@Ecity,Epin=@Epin,Estate=@Estate,Designation=@Designation,Experience=@Experience,Mem_status=@Mem_status where Eid=ISNULL(@Eid, Eid)", con);
                    com2.Parameters.Add(new SqlParameter("@Eid", textBox1.Text));
                    com2.Parameters.Add(new SqlParameter("@Ename", textBox2.Text));
                    com2.Parameters.Add(new SqlParameter("@Eage", Convert.ToInt32(textBox13.Text)));
                    com2.Parameters.Add(new SqlParameter("@Egender", comboBox1.Text));
                    com2.Parameters.Add(new SqlParameter("@Eresidence", textBox5.Text));
                    com2.Parameters.Add(new SqlParameter("@Econtactno", textBox9.Text));
                    com2.Parameters.Add(new SqlParameter("@Eemail", textBox8.Text));
                    com2.Parameters.Add(new SqlParameter("@Estate", textBox6.Text));
                    com2.Parameters.Add(new SqlParameter("@Estreet", textBox14.Text));
                    com2.Parameters.Add(new SqlParameter("@Ecity", textBox7.Text));
                    com2.Parameters.Add(new SqlParameter("@Epin", textBox3.Text));
                    com2.Parameters.Add(new SqlParameter("@Designation", textBox10.Text));
                    com2.Parameters.Add(new SqlParameter("@Experience", Convert.ToInt32(textBox11.Text)));
                    com2.Parameters.Add(new SqlParameter("@Mem_status", comboBox2.Text));


                    com2.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                    con.Close();
                   

                }
            }
                    catch(System.Exception exec)
                  {
                    MessageBox.Show(exec.Message);
                    }
               }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }         
        }
  }
