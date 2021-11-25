
namespace SirUmarLabTaskWk8
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
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_ai = new System.Windows.Forms.RadioButton();
            this.rb_gc = new System.Windows.Forms.RadioButton();
            this.btn_upload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_f = new System.Windows.Forms.RadioButton();
            this.rb_m = new System.Windows.Forms.RadioButton();
            this.chk_pakistani = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgv_degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Board = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_courses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_obtained = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_addtogrid = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_obtained = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lb_courses = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_courses = new System.Windows.Forms.TextBox();
            this.cb_board = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_degree = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_details = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eligibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_savedetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_dob
            // 
            this.dtp_dob.Location = new System.Drawing.Point(578, 136);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(200, 20);
            this.dtp_dob.TabIndex = 0;
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(12, 12);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(100, 88);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbox.TabIndex = 1;
            this.picbox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_ai);
            this.groupBox1.Controls.Add(this.rb_gc);
            this.groupBox1.Location = new System.Drawing.Point(145, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apply For";
            // 
            // rb_ai
            // 
            this.rb_ai.AutoSize = true;
            this.rb_ai.Location = new System.Drawing.Point(166, 34);
            this.rb_ai.Name = "rb_ai";
            this.rb_ai.Size = new System.Drawing.Size(58, 17);
            this.rb_ai.TabIndex = 1;
            this.rb_ai.TabStop = true;
            this.rb_ai.Text = "BS (AI)";
            this.rb_ai.UseVisualStyleBackColor = true;
            // 
            // rb_gc
            // 
            this.rb_gc.AutoSize = true;
            this.rb_gc.Location = new System.Drawing.Point(23, 34);
            this.rb_gc.Name = "rb_gc";
            this.rb_gc.Size = new System.Drawing.Size(63, 17);
            this.rb_gc.TabIndex = 0;
            this.rb_gc.TabStop = true;
            this.rb_gc.Text = "BS (GC)";
            this.rb_gc.UseVisualStyleBackColor = true;
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(25, 106);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 3;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Father\'s Name";
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(323, 137);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(140, 20);
            this.txt_fname.TabIndex = 6;
            this.txt_fname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(523, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(74, 174);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(140, 20);
            this.txt_address.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_f);
            this.groupBox2.Controls.Add(this.rb_m);
            this.groupBox2.Location = new System.Drawing.Point(224, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 43);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // rb_f
            // 
            this.rb_f.AutoSize = true;
            this.rb_f.Location = new System.Drawing.Point(178, 19);
            this.rb_f.Name = "rb_f";
            this.rb_f.Size = new System.Drawing.Size(59, 17);
            this.rb_f.TabIndex = 1;
            this.rb_f.TabStop = true;
            this.rb_f.Text = "Female";
            this.rb_f.UseVisualStyleBackColor = true;
            // 
            // rb_m
            // 
            this.rb_m.AutoSize = true;
            this.rb_m.Location = new System.Drawing.Point(8, 19);
            this.rb_m.Name = "rb_m";
            this.rb_m.Size = new System.Drawing.Size(48, 17);
            this.rb_m.TabIndex = 0;
            this.rb_m.TabStop = true;
            this.rb_m.Text = "Male";
            this.rb_m.UseVisualStyleBackColor = true;
            // 
            // chk_pakistani
            // 
            this.chk_pakistani.AutoSize = true;
            this.chk_pakistani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_pakistani.Location = new System.Drawing.Point(578, 193);
            this.chk_pakistani.Name = "chk_pakistani";
            this.chk_pakistani.Size = new System.Drawing.Size(82, 20);
            this.chk_pakistani.TabIndex = 11;
            this.chk_pakistani.Text = "Pakistani";
            this.chk_pakistani.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv);
            this.groupBox3.Controls.Add(this.btn_addtogrid);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_obtained);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_total);
            this.groupBox3.Controls.Add(this.lb_courses);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_courses);
            this.groupBox3.Controls.Add(this.cb_board);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cb_degree);
            this.groupBox3.Location = new System.Drawing.Point(11, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(777, 288);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Educational Details";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_degree,
            this.dgv_Board,
            this.dgv_courses,
            this.dgv_total,
            this.dgv_obtained,
            this.dgv_percentage,
            this.dgv_delete});
            this.dgv.Location = new System.Drawing.Point(6, 172);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(746, 110);
            this.dgv.TabIndex = 21;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgv_degree
            // 
            this.dgv_degree.HeaderText = "Degree";
            this.dgv_degree.Name = "dgv_degree";
            // 
            // dgv_Board
            // 
            this.dgv_Board.HeaderText = "Board";
            this.dgv_Board.Name = "dgv_Board";
            // 
            // dgv_courses
            // 
            this.dgv_courses.HeaderText = "Courses";
            this.dgv_courses.Name = "dgv_courses";
            // 
            // dgv_total
            // 
            this.dgv_total.HeaderText = "Total";
            this.dgv_total.Name = "dgv_total";
            // 
            // dgv_obtained
            // 
            this.dgv_obtained.HeaderText = "Obtained";
            this.dgv_obtained.Name = "dgv_obtained";
            // 
            // dgv_percentage
            // 
            this.dgv_percentage.HeaderText = "Percentage";
            this.dgv_percentage.Name = "dgv_percentage";
            // 
            // dgv_delete
            // 
            this.dgv_delete.HeaderText = "Delete";
            this.dgv_delete.Name = "dgv_delete";
            this.dgv_delete.Text = "Delete";
            this.dgv_delete.ToolTipText = "Delete";
            // 
            // btn_addtogrid
            // 
            this.btn_addtogrid.Location = new System.Drawing.Point(63, 129);
            this.btn_addtogrid.Name = "btn_addtogrid";
            this.btn_addtogrid.Size = new System.Drawing.Size(98, 23);
            this.btn_addtogrid.TabIndex = 20;
            this.btn_addtogrid.Text = "Add to Grid";
            this.btn_addtogrid.UseVisualStyleBackColor = true;
            this.btn_addtogrid.Click += new System.EventHandler(this.btn_addtogrid_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(466, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Obtained";
            // 
            // txt_obtained
            // 
            this.txt_obtained.Location = new System.Drawing.Point(533, 83);
            this.txt_obtained.Name = "txt_obtained";
            this.txt_obtained.Size = new System.Drawing.Size(140, 20);
            this.txt_obtained.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(466, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(533, 57);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(140, 20);
            this.txt_total.TabIndex = 16;
            // 
            // lb_courses
            // 
            this.lb_courses.FormattingEnabled = true;
            this.lb_courses.Location = new System.Drawing.Point(300, 57);
            this.lb_courses.Name = "lb_courses";
            this.lb_courses.Size = new System.Drawing.Size(133, 95);
            this.lb_courses.TabIndex = 15;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(213, 57);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(54, 23);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Courses";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Board";
            // 
            // txt_courses
            // 
            this.txt_courses.Location = new System.Drawing.Point(63, 60);
            this.txt_courses.Name = "txt_courses";
            this.txt_courses.Size = new System.Drawing.Size(140, 20);
            this.txt_courses.TabIndex = 12;
            // 
            // cb_board
            // 
            this.cb_board.FormattingEnabled = true;
            this.cb_board.Location = new System.Drawing.Point(312, 19);
            this.cb_board.Name = "cb_board";
            this.cb_board.Size = new System.Drawing.Size(121, 21);
            this.cb_board.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Degree";
            // 
            // cb_degree
            // 
            this.cb_degree.FormattingEnabled = true;
            this.cb_degree.Items.AddRange(new object[] {
            "Matric",
            "Intermediate"});
            this.cb_degree.Location = new System.Drawing.Point(82, 19);
            this.cb_degree.Name = "cb_degree";
            this.cb_degree.Size = new System.Drawing.Size(121, 21);
            this.cb_degree.TabIndex = 0;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(74, 137);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(140, 20);
            this.txt_name.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // dgv_details
            // 
            this.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.fname,
            this.picpath,
            this.age,
            this.nationality,
            this.eligibility});
            this.dgv_details.Location = new System.Drawing.Point(58, 579);
            this.dgv_details.Name = "dgv_details";
            this.dgv_details.Size = new System.Drawing.Size(644, 110);
            this.dgv_details.TabIndex = 22;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // fname
            // 
            this.fname.HeaderText = "FName";
            this.fname.Name = "fname";
            // 
            // picpath
            // 
            this.picpath.HeaderText = "Pic Path";
            this.picpath.Name = "picpath";
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            // 
            // nationality
            // 
            this.nationality.HeaderText = "Nationality";
            this.nationality.Name = "nationality";
            // 
            // eligibility
            // 
            this.eligibility.HeaderText = "Eligibility";
            this.eligibility.Name = "eligibility";
            // 
            // btn_savedetails
            // 
            this.btn_savedetails.Location = new System.Drawing.Point(74, 535);
            this.btn_savedetails.Name = "btn_savedetails";
            this.btn_savedetails.Size = new System.Drawing.Size(98, 23);
            this.btn_savedetails.TabIndex = 22;
            this.btn_savedetails.Text = "Save Details";
            this.btn_savedetails.UseVisualStyleBackColor = true;
            this.btn_savedetails.Click += new System.EventHandler(this.btn_savedetails_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 749);
            this.Controls.Add(this.btn_savedetails);
            this.Controls.Add(this.dgv_details);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chk_pakistani);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.dtp_dob);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_ai;
        private System.Windows.Forms.RadioButton rb_gc;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_f;
        private System.Windows.Forms.RadioButton rb_m;
        private System.Windows.Forms.CheckBox chk_pakistani;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_obtained;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.ListBox lb_courses;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_courses;
        private System.Windows.Forms.ComboBox cb_board;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_degree;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_addtogrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Board;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_courses;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_obtained;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_percentage;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_delete;
        private System.Windows.Forms.DataGridView dgv_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn picpath;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn eligibility;
        private System.Windows.Forms.Button btn_savedetails;
    }
}

