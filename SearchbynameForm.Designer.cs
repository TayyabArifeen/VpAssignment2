namespace vpAssignment2
{
    partial class SearchbynameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.enternameTextbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uniTextbox = new System.Windows.Forms.TextBox();
            this.deptTextbox = new System.Windows.Forms.TextBox();
            this.cgpaTextbox = new System.Windows.Forms.TextBox();
            this.semTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.unilbl = new System.Windows.Forms.Label();
            this.deptlbl = new System.Windows.Forms.Label();
            this.cgpalbl = new System.Windows.Forms.Label();
            this.semesterlbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student Name";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(176, 80);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 1;
            this.searchbtn.Text = "Seach";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // enternameTextbox
            // 
            this.enternameTextbox.Location = new System.Drawing.Point(154, 24);
            this.enternameTextbox.Name = "enternameTextbox";
            this.enternameTextbox.Size = new System.Drawing.Size(116, 22);
            this.enternameTextbox.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.Controls.Add(this.uniTextbox, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.deptTextbox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.semTextbox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameTextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.unilbl, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.deptlbl, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cgpalbl, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.semesterlbl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.namelbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.idlbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.idTextbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cgpaTextbox, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(656, 241);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Visible = false;
            // 
            // uniTextbox
            // 
            this.uniTextbox.Location = new System.Drawing.Point(442, 20);
            this.uniTextbox.Multiline = true;
            this.uniTextbox.Name = "uniTextbox";
            this.uniTextbox.Size = new System.Drawing.Size(70, 40);
            this.uniTextbox.TabIndex = 11;
            // 
            // deptTextbox
            // 
            this.deptTextbox.Location = new System.Drawing.Point(338, 20);
            this.deptTextbox.Multiline = true;
            this.deptTextbox.Name = "deptTextbox";
            this.deptTextbox.Size = new System.Drawing.Size(46, 40);
            this.deptTextbox.TabIndex = 10;
            // 
            // cgpaTextbox
            // 
            this.cgpaTextbox.Location = new System.Drawing.Point(259, 20);
            this.cgpaTextbox.Multiline = true;
            this.cgpaTextbox.Name = "cgpaTextbox";
            this.cgpaTextbox.Size = new System.Drawing.Size(26, 40);
            this.cgpaTextbox.TabIndex = 9;
            // 
            // semTextbox
            // 
            this.semTextbox.Location = new System.Drawing.Point(180, 20);
            this.semTextbox.Multiline = true;
            this.semTextbox.Name = "semTextbox";
            this.semTextbox.Size = new System.Drawing.Size(38, 40);
            this.semTextbox.TabIndex = 8;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(30, 20);
            this.nameTextbox.Multiline = true;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(144, 40);
            this.nameTextbox.TabIndex = 7;
            // 
            // unilbl
            // 
            this.unilbl.AutoSize = true;
            this.unilbl.Location = new System.Drawing.Point(442, 0);
            this.unilbl.Name = "unilbl";
            this.unilbl.Size = new System.Drawing.Size(70, 17);
            this.unilbl.TabIndex = 5;
            this.unilbl.Text = "University";
            this.unilbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deptlbl
            // 
            this.deptlbl.AutoSize = true;
            this.deptlbl.Location = new System.Drawing.Point(338, 0);
            this.deptlbl.Name = "deptlbl";
            this.deptlbl.Size = new System.Drawing.Size(82, 17);
            this.deptlbl.TabIndex = 4;
            this.deptlbl.Text = "Department";
            this.deptlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cgpalbl
            // 
            this.cgpalbl.AutoSize = true;
            this.cgpalbl.Location = new System.Drawing.Point(259, 0);
            this.cgpalbl.Name = "cgpalbl";
            this.cgpalbl.Size = new System.Drawing.Size(46, 17);
            this.cgpalbl.TabIndex = 3;
            this.cgpalbl.Text = "CGPA";
            this.cgpalbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // semesterlbl
            // 
            this.semesterlbl.AutoSize = true;
            this.semesterlbl.Location = new System.Drawing.Point(180, 0);
            this.semesterlbl.Name = "semesterlbl";
            this.semesterlbl.Size = new System.Drawing.Size(68, 17);
            this.semesterlbl.TabIndex = 2;
            this.semesterlbl.Text = "Semester";
            this.semesterlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(30, 0);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(45, 17);
            this.namelbl.TabIndex = 1;
            this.namelbl.Text = "Name";
            this.namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Location = new System.Drawing.Point(3, 0);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(21, 17);
            this.idlbl.TabIndex = 0;
            this.idlbl.Text = "ID";
            this.idlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idTextbox
            // 
            this.idTextbox.Location = new System.Drawing.Point(3, 20);
            this.idTextbox.Multiline = true;
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(21, 40);
            this.idTextbox.TabIndex = 6;
            // 
            // SearchbynameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 393);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.enternameTextbox);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.label1);
            this.Name = "SearchbynameForm";
            this.Text = "SearchbynameForm";
            this.Load += new System.EventHandler(this.SearchbynameForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox enternameTextbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox uniTextbox;
        private System.Windows.Forms.TextBox deptTextbox;
        private System.Windows.Forms.TextBox semTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label unilbl;
        private System.Windows.Forms.Label deptlbl;
        private System.Windows.Forms.Label cgpalbl;
        private System.Windows.Forms.Label semesterlbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.TextBox cgpaTextbox;
    }
}