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
    public partial class Main : Form
    {
        int alog,mlog,ulog;
        int count, count1;
        DataRow dr;
        DataRow dr3;
        DataSet ds;
        SqlCommand cmd,cmd3;
        SqlCommandBuilder cmdb;
        SqlDataAdapter da;
        SqlConnection con;
       // SqlDataReader dr1;
        public Main()
        {
            
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=HARSH-PC; Initial Catalog=Automobile; Integrated Security=true";
            cmd = new SqlCommand("select * from temptable", con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "temptable");

        }

        private void employeeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empsearch emsearch = new empsearch();
            
            emsearch.Show();
            this.Hide();
        }

        private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newuser1 nw = new newuser1();
            
            nw.Show();
            this.Hide();

        }

        private void Main_Load(object sender, EventArgs e)
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
            this.menuStrip1.Items[0].Enabled = false;
            this.menuStrip1.Items[1].Enabled = false;
            this.menuStrip1.Items[2].Enabled = false;
            
            this.menuStrip1.Items[6].Enabled = false;
            this.menuStrip1.Items[11].Enabled = false;
            //this.menuStrip1.Items[2, 1].Enabled = false;

            cmd = new SqlCommand("select * from temptable", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                alog = Convert.ToInt32(dr["admin"]);
                mlog = Convert.ToInt32(dr["manager"]);
                ulog = Convert.ToInt32(dr["guest"]);
            }

            if (alog == 1)
            {
                menuStrip1.Items[0].Enabled = true;
                menuStrip1.Items[1].Enabled = true;
                menuStrip1.Items[2].Enabled = true;
                menuStrip1.Items[6].Enabled = true;
                menuStrip1.Items[7].Enabled = false;
                menuStrip1.Items[3].Enabled = false;
                menuStrip1.Items[4].Enabled = false;
                menuStrip1.Items[5].Enabled = false;
                menuStrip1.Items[9].Enabled = false;
                menuStrip1.Items[11].Enabled = true;
            }
            if (mlog == 1)
            {
                menuStrip1.Items[0].Enabled = false;
                menuStrip1.Items[2].Enabled = false;
                menuStrip1.Items[4].Enabled = true;
                menuStrip1.Items[5].Enabled = true;
                menuStrip1.Items[8].Enabled = true;
                menuStrip1.Items[9].Enabled = true;
                menuStrip1.Items[1].Enabled = true;
                menuStrip1.Items[7].Enabled = true;
                menuStrip1.Items[6].Enabled = true;
                menuStrip1.Items[10].Enabled = true;
                menuStrip1.Items[3].Enabled = true;
                menuStrip1.Items[11].Enabled = false;
            }
            con.Close();
            //this.menuStrip1.Items[0].Enabled = false;
        }


       private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addcus ad = new addcus();
            
            ad.Show();
            this.Hide(); 
       }


        private void billingSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billing bill = new billing();
           
            bill.Show();
            this.Hide();
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            booking book = new booking();
            
            book.Show();
            this.Hide();
        }

        private void enquiryBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enquirybooking ebook = new enquirybooking();
            
            ebook.Show();
            this.Hide();
        }

        private void enquiryMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enquiry enq = new enquiry();
            
            enq.Show();
            this.Hide();
        }

        private void customerDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cussearch custs = new cussearch();
            
            custs.Show();
            this.Hide();

        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addemp addem = new addemp();
            
            addem.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            delemp delem = new delemp();
            
            delem.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            vehicle veh = new vehicle();
            
            veh.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd3 = new SqlCommand("update temptable set manager = 0,admin=0,guest=0 ", con);
            cmd3.ExecuteNonQuery();
            con.Close();
           
            DialogResult diag=  MessageBox.Show("Are you sure you want to logout this session? ","the question",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if(diag == DialogResult.Yes)
            {
                this.Hide();
                login1 us = new login1();
                us.Show();

            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users us = new Users();
           
            us.Show();
            this.Hide();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifyemp cs = new modifyemp();
            
            cs.Show();
            this.Hide();
        }

        private void modifyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            modifycus mc = new modifycus();
            
            mc.Show();
            this.Hide();
        }

        
        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewvehicle vw = new viewvehicle();
            
            vw.Show();
            this.Hide();
        }

        
        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            empsearch em = new empsearch();
            
            em.Show();
            this.Hide();
        }

        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchveh sv = new searchveh();
            
            sv.Show();
            this.Hide();
        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delivery1 ds = new delivery1();
            
            ds.Show();
            this.Hide();
        }

        
        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            modifyemp me1 = new modifyemp();
            
            me1.Show();
            this.Hide();
        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            
            f1.Show();
            this.Hide();
        }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            
            f3.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            
            f2.Show();
            this.Hide();
        }

        private void employeeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            delemp de = new delemp();
            
            de.Show();
            this.Hide();
        }

        private void followupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            followup fu = new followup();
            fu.Show();
            this.Hide();
        }

    

        private void billingSectionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            billing bi = new billing();
            bi.Show();
            this.Hide();
        }

     

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addcus ac = new addcus();
            ac.Show();
            this.Hide();
        }
    }
}
