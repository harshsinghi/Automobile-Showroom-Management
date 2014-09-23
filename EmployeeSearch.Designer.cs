namespace automobile
{
    partial class empsearch
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
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eresidenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.econtactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobileDataSet = new automobile.AutomobileDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new automobile.AutomobileDataSetTableAdapters.employeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(616, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(473, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(996, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Employee Database";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eidDataGridViewTextBoxColumn,
            this.enameDataGridViewTextBoxColumn,
            this.eageDataGridViewTextBoxColumn,
            this.egenderDataGridViewTextBoxColumn,
            this.eresidenceDataGridViewTextBoxColumn,
            this.econtactnoDataGridViewTextBoxColumn,
            this.eemailDataGridViewTextBoxColumn,
            this.estateDataGridViewTextBoxColumn,
            this.estreetDataGridViewTextBoxColumn,
            this.ecityDataGridViewTextBoxColumn,
            this.epinDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.memstatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 324);
            this.dataGridView1.TabIndex = 9;
            // 
            // eidDataGridViewTextBoxColumn
            // 
            this.eidDataGridViewTextBoxColumn.DataPropertyName = "Eid";
            this.eidDataGridViewTextBoxColumn.HeaderText = "Eid";
            this.eidDataGridViewTextBoxColumn.Name = "eidDataGridViewTextBoxColumn";
            this.eidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enameDataGridViewTextBoxColumn
            // 
            this.enameDataGridViewTextBoxColumn.DataPropertyName = "Ename";
            this.enameDataGridViewTextBoxColumn.HeaderText = "Ename";
            this.enameDataGridViewTextBoxColumn.Name = "enameDataGridViewTextBoxColumn";
            this.enameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eageDataGridViewTextBoxColumn
            // 
            this.eageDataGridViewTextBoxColumn.DataPropertyName = "Eage";
            this.eageDataGridViewTextBoxColumn.HeaderText = "Eage";
            this.eageDataGridViewTextBoxColumn.Name = "eageDataGridViewTextBoxColumn";
            this.eageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // egenderDataGridViewTextBoxColumn
            // 
            this.egenderDataGridViewTextBoxColumn.DataPropertyName = "Egender";
            this.egenderDataGridViewTextBoxColumn.HeaderText = "Egender";
            this.egenderDataGridViewTextBoxColumn.Name = "egenderDataGridViewTextBoxColumn";
            this.egenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eresidenceDataGridViewTextBoxColumn
            // 
            this.eresidenceDataGridViewTextBoxColumn.DataPropertyName = "Eresidence";
            this.eresidenceDataGridViewTextBoxColumn.HeaderText = "Eresidence";
            this.eresidenceDataGridViewTextBoxColumn.Name = "eresidenceDataGridViewTextBoxColumn";
            this.eresidenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // econtactnoDataGridViewTextBoxColumn
            // 
            this.econtactnoDataGridViewTextBoxColumn.DataPropertyName = "Econtactno";
            this.econtactnoDataGridViewTextBoxColumn.HeaderText = "Econtactno";
            this.econtactnoDataGridViewTextBoxColumn.Name = "econtactnoDataGridViewTextBoxColumn";
            this.econtactnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eemailDataGridViewTextBoxColumn
            // 
            this.eemailDataGridViewTextBoxColumn.DataPropertyName = "Eemail";
            this.eemailDataGridViewTextBoxColumn.HeaderText = "Eemail";
            this.eemailDataGridViewTextBoxColumn.Name = "eemailDataGridViewTextBoxColumn";
            this.eemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estateDataGridViewTextBoxColumn
            // 
            this.estateDataGridViewTextBoxColumn.DataPropertyName = "Estate";
            this.estateDataGridViewTextBoxColumn.HeaderText = "Estate";
            this.estateDataGridViewTextBoxColumn.Name = "estateDataGridViewTextBoxColumn";
            this.estateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estreetDataGridViewTextBoxColumn
            // 
            this.estreetDataGridViewTextBoxColumn.DataPropertyName = "Estreet";
            this.estreetDataGridViewTextBoxColumn.HeaderText = "Estreet";
            this.estreetDataGridViewTextBoxColumn.Name = "estreetDataGridViewTextBoxColumn";
            this.estreetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ecityDataGridViewTextBoxColumn
            // 
            this.ecityDataGridViewTextBoxColumn.DataPropertyName = "Ecity";
            this.ecityDataGridViewTextBoxColumn.HeaderText = "Ecity";
            this.ecityDataGridViewTextBoxColumn.Name = "ecityDataGridViewTextBoxColumn";
            this.ecityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // epinDataGridViewTextBoxColumn
            // 
            this.epinDataGridViewTextBoxColumn.DataPropertyName = "Epin";
            this.epinDataGridViewTextBoxColumn.HeaderText = "Epin";
            this.epinDataGridViewTextBoxColumn.Name = "epinDataGridViewTextBoxColumn";
            this.epinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            this.experienceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memstatusDataGridViewTextBoxColumn
            // 
            this.memstatusDataGridViewTextBoxColumn.DataPropertyName = "Mem_status";
            this.memstatusDataGridViewTextBoxColumn.HeaderText = "Mem_status";
            this.memstatusDataGridViewTextBoxColumn.Name = "memstatusDataGridViewTextBoxColumn";
            this.memstatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.automobileDataSet;
            // 
            // automobileDataSet
            // 
            this.automobileDataSet.DataSetName = "AutomobileDataSet";
            this.automobileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Id:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(123, 611);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // empsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::automobile.Properties.Resources.main1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 663);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "empsearch";
            this.Text = "empsearch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.empsearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private AutomobileDataSet automobileDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private AutomobileDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eresidenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn econtactnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memstatusDataGridViewTextBoxColumn;

    }
}
