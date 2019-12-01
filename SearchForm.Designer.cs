namespace vpAssignment2
{
    partial class SearchForm
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
            this.searchIdbtn = new System.Windows.Forms.Button();
            this.searchNamebtn = new System.Windows.Forms.Button();
            this.searchListbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uniTextbox = new System.Windows.Forms.TextBox();
            this.deptTextbox = new System.Windows.Forms.TextBox();
            this.semTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.unilbl = new System.Windows.Forms.Label();
            this.deptlbl = new System.Windows.Forms.Label();
            this.cgpalbl = new System.Windows.Forms.Label();
            this.semesterlbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.cgpaTextbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchIdbtn
            // 
            this.searchIdbtn.Location = new System.Drawing.Point(44, 59);
            this.searchIdbtn.Name = "searchIdbtn";
            this.searchIdbtn.Size = new System.Drawing.Size(185, 23);
            this.searchIdbtn.TabIndex = 0;
            this.searchIdbtn.Text = "Search By Id";
            this.searchIdbtn.UseVisualStyleBackColor = true;
            this.searchIdbtn.Click += new System.EventHandler(this.searchIdbtn_Click);
            // 
            // searchNamebtn
            // 
            this.searchNamebtn.Location = new System.Drawing.Point(44, 103);
            this.searchNamebtn.Name = "searchNamebtn";
            this.searchNamebtn.Size = new System.Drawing.Size(185, 23);
            this.searchNamebtn.TabIndex = 1;
            this.searchNamebtn.Text = "Search By Name";
            this.searchNamebtn.UseVisualStyleBackColor = true;
            this.searchNamebtn.Click += new System.EventHandler(this.searchNamebtn_Click);
            // 
            // searchListbtn
            // 
            this.searchListbtn.Location = new System.Drawing.Point(44, 147);
            this.searchListbtn.Name = "searchListbtn";
            this.searchListbtn.Size = new System.Drawing.Size(185, 23);
            this.searchListbtn.TabIndex = 2;
            this.searchListbtn.Text = "List Number of Students";
            this.searchListbtn.UseVisualStyleBackColor = true;
            this.searchListbtn.Click += new System.EventHandler(this.searchListbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(185, 201);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 3;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.Controls.Add(this.unilbl, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.deptlbl, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cgpalbl, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.semesterlbl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.namelbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cgpaTextbox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.idTextbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.idlbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.semTextbox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameTextbox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(656, 241);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Visible = false;
            // 
            // uniTextbox
            // 
            this.uniTextbox.Location = new System.Drawing.Point(416, 20);
            this.uniTextbox.Multiline = true;
            this.uniTextbox.Name = "uniTextbox";
            this.uniTextbox.Size = new System.Drawing.Size(82, 221);
            this.uniTextbox.TabIndex = 11;
            // 
            // deptTextbox
            // 
            this.deptTextbox.Location = new System.Drawing.Point(312, 20);
            this.deptTextbox.Multiline = true;
            this.deptTextbox.Name = "deptTextbox";
            this.deptTextbox.Size = new System.Drawing.Size(55, 221);
            this.deptTextbox.TabIndex = 10;
            // 
            // semTextbox
            // 
            this.semTextbox.Location = new System.Drawing.Point(154, 20);
            this.semTextbox.Multiline = true;
            this.semTextbox.Name = "semTextbox";
            this.semTextbox.Size = new System.Drawing.Size(35, 221);
            this.semTextbox.TabIndex = 8;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(32, 20);
            this.nameTextbox.Multiline = true;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(116, 221);
            this.nameTextbox.TabIndex = 7;
            // 
            // unilbl
            // 
            this.unilbl.AutoSize = true;
            this.unilbl.Location = new System.Drawing.Point(416, 0);
            this.unilbl.Name = "unilbl";
            this.unilbl.Size = new System.Drawing.Size(70, 17);
            this.unilbl.TabIndex = 5;
            this.unilbl.Text = "University";
            this.unilbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deptlbl
            // 
            this.deptlbl.AutoSize = true;
            this.deptlbl.Location = new System.Drawing.Point(312, 0);
            this.deptlbl.Name = "deptlbl";
            this.deptlbl.Size = new System.Drawing.Size(82, 17);
            this.deptlbl.TabIndex = 4;
            this.deptlbl.Text = "Department";
            this.deptlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cgpalbl
            // 
            this.cgpalbl.AutoSize = true;
            this.cgpalbl.Location = new System.Drawing.Point(233, 0);
            this.cgpalbl.Name = "cgpalbl";
            this.cgpalbl.Size = new System.Drawing.Size(46, 17);
            this.cgpalbl.TabIndex = 3;
            this.cgpalbl.Text = "CGPA";
            this.cgpalbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // semesterlbl
            // 
            this.semesterlbl.AutoSize = true;
            this.semesterlbl.Location = new System.Drawing.Point(154, 0);
            this.semesterlbl.Name = "semesterlbl";
            this.semesterlbl.Size = new System.Drawing.Size(68, 17);
            this.semesterlbl.TabIndex = 2;
            this.semesterlbl.Text = "Semester";
            this.semesterlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(32, 0);
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
            this.idTextbox.Size = new System.Drawing.Size(23, 221);
            this.idTextbox.TabIndex = 6;
            // 
            // cgpaTextbox
            // 
            this.cgpaTextbox.Location = new System.Drawing.Point(233, 20);
            this.cgpaTextbox.Multiline = true;
            this.cgpaTextbox.Name = "cgpaTextbox";
            this.cgpaTextbox.Size = new System.Drawing.Size(32, 221);
            this.cgpaTextbox.TabIndex = 9;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 275);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.searchListbtn);
            this.Controls.Add(this.searchNamebtn);
            this.Controls.Add(this.searchIdbtn);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchIdbtn;
        private System.Windows.Forms.Button searchNamebtn;
        private System.Windows.Forms.Button searchListbtn;
        private System.Windows.Forms.Button backbtn;
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