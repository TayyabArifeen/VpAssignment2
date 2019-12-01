namespace vpAssignment2
{
    partial class createStudentForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addstdntbtn = new System.Windows.Forms.Button();
            this.semesterTextbox = new System.Windows.Forms.TextBox();
            this.cgpaTextbox = new System.Windows.Forms.TextBox();
            this.deptTextbox = new System.Windows.Forms.TextBox();
            this.StdNamelbl = new System.Windows.Forms.Label();
            this.semesterlbl = new System.Windows.Forms.Label();
            this.cgpalbl = new System.Windows.Forms.Label();
            this.deptlbl = new System.Windows.Forms.Label();
            this.unilbl = new System.Windows.Forms.Label();
            this.uniTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.textBox1.Location = new System.Drawing.Point(111, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addstdntbtn
            // 
            this.addstdntbtn.Location = new System.Drawing.Point(185, 198);
            this.addstdntbtn.Name = "addstdntbtn";
            this.addstdntbtn.Size = new System.Drawing.Size(96, 23);
            this.addstdntbtn.TabIndex = 1;
            this.addstdntbtn.Text = "Add Student";
            this.addstdntbtn.UseVisualStyleBackColor = true;
            this.addstdntbtn.Click += new System.EventHandler(this.addstdntbtn_Click);
            // 
            // semesterTextbox
            // 
            this.semesterTextbox.Location = new System.Drawing.Point(111, 43);
            this.semesterTextbox.Name = "semesterTextbox";
            this.semesterTextbox.Size = new System.Drawing.Size(170, 22);
            this.semesterTextbox.TabIndex = 2;
            this.semesterTextbox.TextChanged += new System.EventHandler(this.semesterTextbox_TextChanged);
            // 
            // cgpaTextbox
            // 
            this.cgpaTextbox.Location = new System.Drawing.Point(111, 78);
            this.cgpaTextbox.Name = "cgpaTextbox";
            this.cgpaTextbox.Size = new System.Drawing.Size(170, 22);
            this.cgpaTextbox.TabIndex = 3;
            this.cgpaTextbox.TextChanged += new System.EventHandler(this.cgpaTextbox_TextChanged);
            // 
            // deptTextbox
            // 
            this.deptTextbox.Location = new System.Drawing.Point(111, 118);
            this.deptTextbox.Name = "deptTextbox";
            this.deptTextbox.Size = new System.Drawing.Size(170, 22);
            this.deptTextbox.TabIndex = 4;
            this.deptTextbox.TextChanged += new System.EventHandler(this.deptTextbox_TextChanged);
            // 
            // StdNamelbl
            // 
            this.StdNamelbl.AutoSize = true;
            this.StdNamelbl.Location = new System.Drawing.Point(9, 16);
            this.StdNamelbl.Name = "StdNamelbl";
            this.StdNamelbl.Size = new System.Drawing.Size(96, 17);
            this.StdNamelbl.TabIndex = 5;
            this.StdNamelbl.Text = "Student name";
            // 
            // semesterlbl
            // 
            this.semesterlbl.AutoSize = true;
            this.semesterlbl.Location = new System.Drawing.Point(9, 48);
            this.semesterlbl.Name = "semesterlbl";
            this.semesterlbl.Size = new System.Drawing.Size(68, 17);
            this.semesterlbl.TabIndex = 6;
            this.semesterlbl.Text = "Semester";
            // 
            // cgpalbl
            // 
            this.cgpalbl.AutoSize = true;
            this.cgpalbl.Location = new System.Drawing.Point(12, 83);
            this.cgpalbl.Name = "cgpalbl";
            this.cgpalbl.Size = new System.Drawing.Size(46, 17);
            this.cgpalbl.TabIndex = 7;
            this.cgpalbl.Text = "CGPA";
            // 
            // deptlbl
            // 
            this.deptlbl.AutoSize = true;
            this.deptlbl.Location = new System.Drawing.Point(12, 123);
            this.deptlbl.Name = "deptlbl";
            this.deptlbl.Size = new System.Drawing.Size(82, 17);
            this.deptlbl.TabIndex = 8;
            this.deptlbl.Text = "Department";
            // 
            // unilbl
            // 
            this.unilbl.AutoSize = true;
            this.unilbl.Location = new System.Drawing.Point(12, 162);
            this.unilbl.Name = "unilbl";
            this.unilbl.Size = new System.Drawing.Size(70, 17);
            this.unilbl.TabIndex = 9;
            this.unilbl.Text = "University";
            // 
            // uniTextbox
            // 
            this.uniTextbox.Location = new System.Drawing.Point(111, 157);
            this.uniTextbox.Name = "uniTextbox";
            this.uniTextbox.Size = new System.Drawing.Size(170, 22);
            this.uniTextbox.TabIndex = 10;
            this.uniTextbox.TextChanged += new System.EventHandler(this.uniTextbox_TextChanged);
            // 
            // createStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 254);
            this.Controls.Add(this.uniTextbox);
            this.Controls.Add(this.unilbl);
            this.Controls.Add(this.deptlbl);
            this.Controls.Add(this.cgpalbl);
            this.Controls.Add(this.semesterlbl);
            this.Controls.Add(this.StdNamelbl);
            this.Controls.Add(this.deptTextbox);
            this.Controls.Add(this.cgpaTextbox);
            this.Controls.Add(this.semesterTextbox);
            this.Controls.Add(this.addstdntbtn);
            this.Controls.Add(this.textBox1);
            this.Name = "createStudentForm";
            this.Text = "createStudentForm";
            this.Load += new System.EventHandler(this.createStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addstdntbtn;
        private System.Windows.Forms.TextBox semesterTextbox;
        private System.Windows.Forms.TextBox cgpaTextbox;
        private System.Windows.Forms.TextBox deptTextbox;
        private System.Windows.Forms.Label StdNamelbl;
        private System.Windows.Forms.Label semesterlbl;
        private System.Windows.Forms.Label cgpalbl;
        private System.Windows.Forms.Label deptlbl;
        private System.Windows.Forms.Label unilbl;
        private System.Windows.Forms.TextBox uniTextbox;
    }
}