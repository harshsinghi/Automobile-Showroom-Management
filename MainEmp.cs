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
    public partial class Mainemp : Form
    {
        public Mainemp()
        {
            InitializeComponent();
        }

        private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            vehicle vs = new vehicle();
            this.Hide();
            vs.Show();
        }

        private void employeeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empsearch em = new empsearch();
            this.Hide();
            em.Show();
        }

        private void customerDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cussearch cs = new cussearch();
            this.Hide();
            cs.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addcus ac = new addcus();
            this.Hide();
            ac.Show();
        }

        private void enquiryBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enquirybooking eb = new enquirybooking();
            this.Hide();
            eb.Show();

        }

        private void enquiryMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enquiry em = new enquiry();
            this.Hide();
            em.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            booking bo = new booking();
            this.Hide();
            bo.Show();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void billingSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billing bi = new billing();
            this.Hide();
            bi.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult diag = MessageBox.Show("Are you sure you want to logout this session? ", "the question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (diag == DialogResult.Yes)
            {
                this.Hide();
                login1 us = new login1();
                us.Show();

            }
        }

        private void Mainemp_Load(object sender, EventArgs e)
        {
            SqlConnection sc1 = new SqlConnection("Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True");
            sc1.Open();

            SqlCommand scom1 = new SqlCommand("select * from temptable", sc1);

            SqlDataReader dr11 = scom1.ExecuteReader();

            if (dr11.Read())
            {
                textBox1.Text = Convert.ToString(dr11.GetValue(3));
            }
            sc1.Close();
            SqlConnection sc2 = new SqlConnection("Data Source=HARSH-PC;Initial Catalog=Automobile;Integrated Security=True");
            sc2.Open();

            SqlCommand scm2 = new SqlCommand("Select * from employee where Eid = '" + textBox1.Text + "'", sc2);

            SqlDataReader dr8 = scm2.ExecuteReader();
            dr8.Read();

            if (dr8.HasRows == true)
            {
                string tname = Convert.ToString(dr8.GetValue(1));
                textBox1.Text = tname;
                label1.Text = "Welcome " + textBox1.Text;

            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void viewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            viewvehicle vw = new viewvehicle();
            this.Hide();
            vw.Show();
        }

        private void followupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            followup fu = new followup();
            this.Hide();
            fu.Show();
        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void deliveryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            delivery1 de = new delivery1();
            this.Hide();
            de.Show();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifyemp me = new modifyemp();
            this.Hide();
            me.Show();
        }
    }
}
