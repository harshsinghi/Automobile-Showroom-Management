namespace automobile
{
    partial class modifycus
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
            this.modify = new System.Windows.Forms.Button();
            this.tage = new System.Windows.Forms.TextBox();
            this.toccupation = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.custoccupatn = new System.Windows.Forms.Label();
            this.tcontact = new System.Windows.Forms.TextBox();
            this.cgender = new System.Windows.Forms.ComboBox();
            this.tcity = new System.Windows.Forms.TextBox();
            this.tstate = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobileDataSet14 = new automobile.AutomobileDataSet14();
            this.button1 = new System.Windows.Forms.Button();
            this.temail = new System.Windows.Forms.TextBox();
            this.tresidence = new System.Windows.Forms.TextBox();
            this.tlocation = new System.Windows.Forms.TextBox();
            this.tpin = new System.Windows.Forms.TextBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.tid = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.contactno = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.EmpId = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.customerTableAdapter = new automobile.AutomobileDataSet14TableAdapters.customerTableAdapter();
            this.clear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // modify
            // 
            this.modify.Location = new System.Drawing.Point(340, 408);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(142, 28);
            this.modify.TabIndex = 28;
            this.modify.Text = "Modify";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // tage
            // 
            this.tage.Location = new System.Drawing.Point(89, 85);
            this.tage.Name = "tage";
            this.tage.Size = new System.Drawing.Size(77, 25);
            this.tage.TabIndex = 25;
            // 
            // toccupation
            // 
            this.toccupation.Location = new System.Drawing.Point(89, 362);
            this.toccupation.Name = "toccupation";
            this.toccupation.Size = new System.Drawing.Size(233, 25);
            this.toccupation.TabIndex = 23;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(531, 408);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(143, 28);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // custoccupatn
            // 
            this.custoccupatn.AutoSize = true;
            this.custoccupatn.Location = new System.Drawing.Point(18, 365);
            this.custoccupatn.Name = "custoccupatn";
            this.custoccupatn.Size = new System.Drawing.Size(75, 18);
            this.custoccupatn.TabIndex = 22;
            this.custoccupatn.Text = "Occupation:";
            // 
            // tcontact
            // 
            this.tcontact.Location = new System.Drawing.Point(801, 299);
            this.tcontact.Name = "tcontact";
            this.tcontact.Size = new System.Drawing.Size(145, 25);
            this.tcontact.TabIndex = 21;
            // 
            // cgender
            // 
            this.cgender.AllowDrop = true;
            this.cgender.FormattingEnabled = true;
            this.cgender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cgender.Location = new System.Drawing.Point(468, 85);
            this.cgender.Name = "cgender";
            this.cgender.Size = new System.Drawing.Size(96, 26);
            this.cgender.TabIndex = 19;
            // 
            // tcity
            // 
            this.tcity.Location = new System.Drawing.Point(89, 213);
            this.tcity.Name = "tcity";
            this.tcity.Size = new System.Drawing.Size(179, 25);
            this.tcity.TabIndex = 17;
            // 
            // tstate
            // 
            this.tstate.Location = new System.Drawing.Point(468, 213);
            this.tstate.Name = "tstate";
            this.tstate.Size = new System.Drawing.Size(167, 25);
            this.tstate.TabIndex = 16;
            this.tstate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tstate_KeyPress);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clear.Controls.Add(this.dataGridView1);
            this.clear.Controls.Add(this.button1);
            this.clear.Controls.Add(this.modify);
            this.clear.Controls.Add(this.tage);
            this.clear.Controls.Add(this.toccupation);
            this.clear.Controls.Add(this.cancel);
            this.clear.Controls.Add(this.custoccupatn);
            this.clear.Controls.Add(this.tcontact);
            this.clear.Controls.Add(this.temail);
            this.clear.Controls.Add(this.cgender);
            this.clear.Controls.Add(this.tcity);
            this.clear.Controls.Add(this.tstate);
            this.clear.Controls.Add(this.tresidence);
            this.clear.Controls.Add(this.tlocation);
            this.clear.Controls.Add(this.tpin);
            this.clear.Controls.Add(this.tname);
            this.clear.Controls.Add(this.tid);
            this.clear.Controls.Add(this.pin);
            this.clear.Controls.Add(this.email);
            this.clear.Controls.Add(this.contactno);
            this.clear.Controls.Add(this.location);
            this.clear.Controls.Add(this.label8);
            this.clear.Controls.Add(this.state);
            this.clear.Controls.Add(this.address);
            this.clear.Controls.Add(this.age);
            this.clear.Controls.Add(this.Gender);
            this.clear.Controls.Add(this.name);
            this.clear.Controls.Add(this.EmpId);
            this.clear.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(10, 22);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(1150, 630);
            this.clear.TabIndex = 13;
            this.clear.TabStop = false;
            this.clear.Text = "Personal Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.contactnoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.residenceDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.pinDataGridViewTextBoxColumn,
            this.occupationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(88, 460);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 113);
            this.dataGridView1.TabIndex = 30;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "customer_name";
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            // 
            // contactnoDataGridViewTextBoxColumn
            // 
            this.contactnoDataGridViewTextBoxColumn.DataPropertyName = "contactno";
            this.contactnoDataGridViewTextBoxColumn.HeaderText = "contactno";
            this.contactnoDataGridViewTextBoxColumn.Name = "contactnoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // residenceDataGridViewTextBoxColumn
            // 
            this.residenceDataGridViewTextBoxColumn.DataPropertyName = "residence";
            this.residenceDataGridViewTextBoxColumn.HeaderText = "residence";
            this.residenceDataGridViewTextBoxColumn.Name = "residenceDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // pinDataGridViewTextBoxColumn
            // 
            this.pinDataGridViewTextBoxColumn.DataPropertyName = "pin";
            this.pinDataGridViewTextBoxColumn.HeaderText = "pin";
            this.pinDataGridViewTextBoxColumn.Name = "pinDataGridViewTextBoxColumn";
            // 
            // occupationDataGridViewTextBoxColumn
            // 
            this.occupationDataGridViewTextBoxColumn.DataPropertyName = "occupation";
            this.occupationDataGridViewTextBoxColumn.HeaderText = "occupation";
            this.occupationDataGridViewTextBoxColumn.Name = "occupationDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.automobileDataSet14;
            // 
            // automobileDataSet14
            // 
            this.automobileDataSet14.DataSetName = "AutomobileDataSet14";
            this.automobileDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 28);
            this.button1.TabIndex = 29;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // temail
            // 
            this.temail.Location = new System.Drawing.Point(89, 292);
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(234, 25);
            this.temail.TabIndex = 20;
            // 
            // tresidence
            // 
            this.tresidence.Location = new System.Drawing.Point(89, 154);
            this.tresidence.Name = "tresidence";
            this.tresidence.Size = new System.Drawing.Size(344, 25);
            this.tresidence.TabIndex = 15;
            this.tresidence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tresidence_KeyPress);
            // 
            // tlocation
            // 
            this.tlocation.Location = new System.Drawing.Point(801, 158);
            this.tlocation.Name = "tlocation";
            this.tlocation.Size = new System.Drawing.Size(150, 25);
            this.tlocation.TabIndex = 14;
            this.tlocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tlocation_KeyPress);
            // 
            // tpin
            // 
            this.tpin.Location = new System.Drawing.Point(801, 213);
            this.tpin.Name = "tpin";
            this.tpin.Size = new System.Drawing.Size(131, 25);
            this.tpin.TabIndex = 13;
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(89, 34);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(141, 25);
            this.tname.TabIndex = 12;
            this.tname.TextChanged += new System.EventHandler(this.tname_TextChanged);
            this.tname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tname_KeyPress);
            // 
            // tid
            // 
            this.tid.Location = new System.Drawing.Point(801, 34);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(96, 25);
            this.tid.TabIndex = 11;
            // 
            // pin
            // 
            this.pin.AutoSize = true;
            this.pin.Location = new System.Drawing.Point(772, 216);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(31, 18);
            this.pin.TabIndex = 10;
            this.pin.Text = "Pin:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(23, 295);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(71, 18);
            this.email.TabIndex = 9;
            this.email.Text = "E-mail ID:";
            // 
            // contactno
            // 
            this.contactno.AutoSize = true;
            this.contactno.Location = new System.Drawing.Point(727, 302);
            this.contactno.Name = "contactno";
            this.contactno.Size = new System.Drawing.Size(75, 18);
            this.contactno.TabIndex = 8;
            this.contactno.Text = "Contact-No:";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Location = new System.Drawing.Point(735, 161);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(60, 18);
            this.location.TabIndex = 7;
            this.location.Text = "Location:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "City:";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(430, 220);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(41, 18);
            this.state.TabIndex = 5;
            this.state.Text = "State:";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(24, 154);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(69, 18);
            this.address.TabIndex = 4;
            this.address.Text = "Residence:";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(50, 85);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(34, 18);
            this.age.TabIndex = 3;
            this.age.Text = "Age:";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(408, 85);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(54, 18);
            this.Gender.TabIndex = 2;
            this.Gender.Text = "Gender:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(38, 41);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 18);
            this.name.TabIndex = 1;
            this.name.Text = "Name:";
            // 
            // EmpId
            // 
            this.EmpId.AutoSize = true;
            this.EmpId.Location = new System.Drawing.Point(709, 41);
            this.EmpId.Name = "EmpId";
            this.EmpId.Size = new System.Drawing.Size(86, 18);
            this.EmpId.TabIndex = 0;
            this.EmpId.Text = "Customer-ID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // modifycus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::automobile.Properties.Resources.main1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 600);
            this.Controls.Add(this.clear);
            this.Name = "modifycus";
            this.Text = "modifycus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.modifycus_Load);
            this.clear.ResumeLayout(false);
            this.clear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.TextBox tage;
        private System.Windows.Forms.TextBox toccupation;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label custoccupatn;
        private System.Windows.Forms.TextBox tcontact;
        private System.Windows.Forms.ComboBox cgender;
        private System.Windows.Forms.TextBox tcity;
        private System.Windows.Forms.TextBox tstate;
        private System.Windows.Forms.GroupBox clear;
        private System.Windows.Forms.TextBox temail;
        private System.Windows.Forms.TextBox tresidence;
        private System.Windows.Forms.TextBox tlocation;
        private System.Windows.Forms.TextBox tpin;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.Label pin;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label contactno;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label EmpId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private AutomobileDataSet14 automobileDataSet14;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private AutomobileDataSet14TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn;
    }
}
