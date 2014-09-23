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

    public partial class empsearch : Form
    {
        SqlConnection sc1;
        DataTable dt;
        DataView dv;
        CurrencyManager CM;
        public empsearch()
        {
            
            InitializeComponent();
        }

      
        private void empsearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'automobileDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.automobileDataSet.employee);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string temp;
                temp = textBox2.Text;
                sc1 = new SqlConnection();
                sc1.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile ;Integrated Security=true";
                sc1.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter("select Eid,Ename,Eage,Egender,Econtactno,Eemail,Estate,Eresidence,Estreet,Ecity,Epin,Designation,Experience,Mem_status from employee where Eid= '" + textBox2.Text + "'", sc1);
                sda.Fill(ds, "employee");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "employee";
            }
            catch
            { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            empsearch ac = new empsearch();
            ac.Show();
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
                SqlDataAdapter sda = new SqlDataAdapter("select Eid,Ename,Eage,Egender,Econtactno,Eemail,Estate,Eresidence,Estreet,Ecity,Epin,Designation,Experience,Mem_status from employee where Ename= '" + textBox1.Text + "'", sc1);
                sda.Fill(ds, "employee");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "employee";
            }
            catch
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Main cs = new Main();
            this.Hide();
            cs.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32 ? false : true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }
    }
}
