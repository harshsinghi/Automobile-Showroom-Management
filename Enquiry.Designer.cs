namespace automobile
{
    partial class enquiry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.varientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobileDataSet10 = new automobile.AutomobileDataSet10();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobileDataSet9 = new automobile.AutomobileDataSet9();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.enquiryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ensourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colouridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.followupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enquiryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobileDataSet23 = new automobile.AutomobileDataSet23();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vehicleTableAdapter = new automobile.AutomobileDataSet9TableAdapters.vehicleTableAdapter();
            this.varientTableAdapter = new automobile.AutomobileDataSet10TableAdapters.varientTableAdapter();
            this.enquiryTableAdapter = new automobile.AutomobileDataSet23TableAdapters.enquiryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.varientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Booked ",
            "Bought",
            "Unattended",
            "Active"});
            this.comboBox4.Location = new System.Drawing.Point(745, 528);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(702, 533);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 50;
            this.label7.Text = "Colour";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(872, 528);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "Search";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBox3.DataSource = this.varientBindingSource;
            this.comboBox3.DisplayMember = "vname";
            this.comboBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(745, 474);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.ValueMember = "Vaname";
            // 
            // varientBindingSource
            // 
            this.varientBindingSource.DataMember = "varient";
            this.varientBindingSource.DataSource = this.automobileDataSet10;
            // 
            // automobileDataSet10
            // 
            this.automobileDataSet10.DataSetName = "AutomobileDataSet10";
            this.automobileDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(699, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "Variant";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(872, 474);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "Search";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBox2.DataSource = this.vehicleBindingSource;
            this.comboBox2.DisplayMember = "model";
            this.comboBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(745, 419);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.ValueMember = "Vmodel";
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "vehicle";
            this.vehicleBindingSource.DataSource = this.automobileDataSet9;
            // 
            // automobileDataSet9
            // 
            this.automobileDataSet9.DataSetName = "AutomobileDataSet9";
            this.automobileDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(703, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Model";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(872, 419);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Search";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Active",
            "Booked ",
            "Bought",
            "Inactive",
            "Lost",
            "Unattended"});
            this.comboBox1.Location = new System.Drawing.Point(432, 422);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Enquiry status";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(559, 422);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "Search";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Enquiry id";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(366, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(259, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enquiryidDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.ensourceDataGridViewTextBoxColumn,
            this.endateDataGridViewTextBoxColumn,
            this.entimeDataGridViewTextBoxColumn,
            this.vidDataGridViewTextBoxColumn,
            this.vaidDataGridViewTextBoxColumn,
            this.colouridDataGridViewTextBoxColumn,
            this.enstatusDataGridViewTextBoxColumn,
            this.followupidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.enquiryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(180, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1042, 295);
            this.dataGridView1.TabIndex = 30;
            // 
            // enquiryidDataGridViewTextBoxColumn
            // 
            this.enquiryidDataGridViewTextBoxColumn.DataPropertyName = "enquiry_id";
            this.enquiryidDataGridViewTextBoxColumn.HeaderText = "enquiry_id";
            this.enquiryidDataGridViewTextBoxColumn.Name = "enquiryidDataGridViewTextBoxColumn";
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            // 
            // ensourceDataGridViewTextBoxColumn
            // 
            this.ensourceDataGridViewTextBoxColumn.DataPropertyName = "en_source";
            this.ensourceDataGridViewTextBoxColumn.HeaderText = "en_source";
            this.ensourceDataGridViewTextBoxColumn.Name = "ensourceDataGridViewTextBoxColumn";
            // 
            // endateDataGridViewTextBoxColumn
            // 
            this.endateDataGridViewTextBoxColumn.DataPropertyName = "en_date";
            this.endateDataGridViewTextBoxColumn.HeaderText = "en_date";
            this.endateDataGridViewTextBoxColumn.Name = "endateDataGridViewTextBoxColumn";
            // 
            // entimeDataGridViewTextBoxColumn
            // 
            this.entimeDataGridViewTextBoxColumn.DataPropertyName = "en_time";
            this.entimeDataGridViewTextBoxColumn.HeaderText = "en_time";
            this.entimeDataGridViewTextBoxColumn.Name = "entimeDataGridViewTextBoxColumn";
            // 
            // vidDataGridViewTextBoxColumn
            // 
            this.vidDataGridViewTextBoxColumn.DataPropertyName = "vid";
            this.vidDataGridViewTextBoxColumn.HeaderText = "vid";
            this.vidDataGridViewTextBoxColumn.Name = "vidDataGridViewTextBoxColumn";
            // 
            // vaidDataGridViewTextBoxColumn
            // 
            this.vaidDataGridViewTextBoxColumn.DataPropertyName = "vaid";
            this.vaidDataGridViewTextBoxColumn.HeaderText = "vaid";
            this.vaidDataGridViewTextBoxColumn.Name = "vaidDataGridViewTextBoxColumn";
            // 
            // colouridDataGridViewTextBoxColumn
            // 
            this.colouridDataGridViewTextBoxColumn.DataPropertyName = "colourid";
            this.colouridDataGridViewTextBoxColumn.HeaderText = "colourid";
            this.colouridDataGridViewTextBoxColumn.Name = "colouridDataGridViewTextBoxColumn";
            // 
            // enstatusDataGridViewTextBoxColumn
            // 
            this.enstatusDataGridViewTextBoxColumn.DataPropertyName = "en_status";
            this.enstatusDataGridViewTextBoxColumn.HeaderText = "en_status";
            this.enstatusDataGridViewTextBoxColumn.Name = "enstatusDataGridViewTextBoxColumn";
            // 
            // followupidDataGridViewTextBoxColumn
            // 
            this.followupidDataGridViewTextBoxColumn.DataPropertyName = "followup_id";
            this.followupidDataGridViewTextBoxColumn.HeaderText = "followup_id";
            this.followupidDataGridViewTextBoxColumn.Name = "followupidDataGridViewTextBoxColumn";
            // 
            // enquiryBindingSource
            // 
            this.enquiryBindingSource.DataMember = "enquiry";
            this.enquiryBindingSource.DataSource = this.automobileDataSet23;
            // 
            // automobileDataSet23
            // 
            this.automobileDataSet23.DataSetName = "AutomobileDataSet23";
            this.automobileDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 35);
            this.button3.TabIndex = 29;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 42);
            this.button2.TabIndex = 28;
            this.button2.Text = "Existing Enquiry";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Enquiry";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.BackgroundImage = global::automobile.Properties.Resources.Chevrolet_Camaro_Black_Concept_1920X1200_Widescreen;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-194, -54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1532, 739);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // varientTableAdapter
            // 
            this.varientTableAdapter.ClearBeforeFill = true;
            // 
            // enquiryTableAdapter
            // 
            this.enquiryTableAdapter.ClearBeforeFill = true;
            // 
            // enquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 589);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "enquiry";
            this.Text = "enquiry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.enquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.varientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enquiryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AutomobileDataSet9 automobileDataSet9;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private AutomobileDataSet9TableAdapters.vehicleTableAdapter vehicleTableAdapter;
        private AutomobileDataSet10 automobileDataSet10;
        private System.Windows.Forms.BindingSource varientBindingSource;
        private AutomobileDataSet10TableAdapters.varientTableAdapter varientTableAdapter;
        private AutomobileDataSet23 automobileDataSet23;
        private System.Windows.Forms.BindingSource enquiryBindingSource;
        private AutomobileDataSet23TableAdapters.enquiryTableAdapter enquiryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn enquiryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ensourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colouridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn followupidDataGridViewTextBoxColumn;
    }
}
