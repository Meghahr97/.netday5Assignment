namespace day5assignment
{
    partial class Form1
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
            this.lbselect = new System.Windows.Forms.ListBox();
            this.cbroll = new System.Windows.Forms.ComboBox();
            this.studentinformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentinformationDataSet = new day5assignment.studentinformationDataSet();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.btnfind = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.cbsemester = new System.Windows.Forms.ComboBox();
            this.cbcourse = new System.Windows.Forms.ComboBox();
            this.cbdepartment = new System.Windows.Forms.ComboBox();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.txtnane = new System.Windows.Forms.TextBox();
            this.txtrollno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentinformationTableAdapter = new day5assignment.studentinformationDataSetTableAdapters.studentinformationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentinformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinformationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbselect
            // 
            this.lbselect.FormattingEnabled = true;
            this.lbselect.Location = new System.Drawing.Point(528, 44);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(149, 82);
            this.lbselect.TabIndex = 53;
            // 
            // cbroll
            // 
            this.cbroll.DataSource = this.studentinformationBindingSource;
            this.cbroll.DisplayMember = "name";
            this.cbroll.FormattingEnabled = true;
            this.cbroll.Location = new System.Drawing.Point(127, 12);
            this.cbroll.Name = "cbroll";
            this.cbroll.Size = new System.Drawing.Size(133, 21);
            this.cbroll.TabIndex = 54;
            this.cbroll.ValueMember = "Rollno";
            // 
            // studentinformationBindingSource
            // 
            this.studentinformationBindingSource.DataMember = "studentinformation";
            this.studentinformationBindingSource.DataSource = this.studentinformationDataSet;
            // 
            // studentinformationDataSet
            // 
            this.studentinformationDataSet.DataSetName = "studentinformationDataSet";
            this.studentinformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpdate
            // 
            this.dtpdate.Location = new System.Drawing.Point(193, 129);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(156, 20);
            this.dtpdate.TabIndex = 52;
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(46, 12);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 23);
            this.btnfind.TabIndex = 51;
            this.btnfind.Text = "find";
            this.btnfind.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(422, 428);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 50;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(308, 428);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 49;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(217, 428);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 48;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(122, 428);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 47;
            this.btnadd.Text = "Add new";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(193, 369);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(157, 20);
            this.txtphone.TabIndex = 46;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(193, 343);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(136, 20);
            this.txtaddress.TabIndex = 45;
            // 
            // cbsemester
            // 
            this.cbsemester.FormattingEnabled = true;
            this.cbsemester.Items.AddRange(new object[] {
            "first",
            "second",
            "third",
            "fourth"});
            this.cbsemester.Location = new System.Drawing.Point(193, 301);
            this.cbsemester.Name = "cbsemester";
            this.cbsemester.Size = new System.Drawing.Size(157, 21);
            this.cbsemester.TabIndex = 44;
            // 
            // cbcourse
            // 
            this.cbcourse.FormattingEnabled = true;
            this.cbcourse.Items.AddRange(new object[] {
            "maths",
            "physics",
            "computerscience"});
            this.cbcourse.Location = new System.Drawing.Point(193, 256);
            this.cbcourse.Name = "cbcourse";
            this.cbcourse.Size = new System.Drawing.Size(117, 21);
            this.cbcourse.TabIndex = 43;
            // 
            // cbdepartment
            // 
            this.cbdepartment.FormattingEnabled = true;
            this.cbdepartment.Items.AddRange(new object[] {
            "maths",
            "physics",
            "computerscience"});
            this.cbdepartment.Location = new System.Drawing.Point(193, 208);
            this.cbdepartment.Name = "cbdepartment";
            this.cbdepartment.Size = new System.Drawing.Size(144, 21);
            this.cbdepartment.TabIndex = 42;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(276, 169);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(56, 17);
            this.rbfemale.TabIndex = 41;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(174, 169);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(47, 17);
            this.rbmale.TabIndex = 40;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // txtnane
            // 
            this.txtnane.Location = new System.Drawing.Point(193, 94);
            this.txtnane.Name = "txtnane";
            this.txtnane.Size = new System.Drawing.Size(135, 20);
            this.txtnane.TabIndex = 39;
            this.txtnane.TextChanged += new System.EventHandler(this.txtnane_TextChanged);
            // 
            // txtrollno
            // 
            this.txtrollno.Location = new System.Drawing.Point(193, 47);
            this.txtrollno.Name = "txtrollno";
            this.txtrollno.Size = new System.Drawing.Size(144, 20);
            this.txtrollno.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Phone No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Semester";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Course";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Date of ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Roll NO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "student profile";
            // 
            // studentinformationTableAdapter
            // 
            this.studentinformationTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 446);
            this.Controls.Add(this.lbselect);
            this.Controls.Add(this.cbroll);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.cbsemester);
            this.Controls.Add(this.cbcourse);
            this.Controls.Add(this.cbdepartment);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.txtnane);
            this.Controls.Add(this.txtrollno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentinformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinformationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbselect;
        private System.Windows.Forms.ComboBox cbroll;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.ComboBox cbsemester;
        private System.Windows.Forms.ComboBox cbcourse;
        private System.Windows.Forms.ComboBox cbdepartment;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.TextBox txtnane;
        private System.Windows.Forms.TextBox txtrollno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private studentinformationDataSet studentinformationDataSet;
        private System.Windows.Forms.BindingSource studentinformationBindingSource;
        private studentinformationDataSetTableAdapters.studentinformationTableAdapter studentinformationTableAdapter;
    }
}

