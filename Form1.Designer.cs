namespace vpAssignment2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.top3btn = new System.Windows.Forms.Button();
            this.markattndbtn = new System.Windows.Forms.Button();
            this.viewattndbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Student Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(76, 59);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(160, 23);
            this.searchbtn.TabIndex = 1;
            this.searchbtn.Text = "Search Student";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(76, 88);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(160, 23);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "Delete Student Record";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // top3btn
            // 
            this.top3btn.Location = new System.Drawing.Point(76, 117);
            this.top3btn.Name = "top3btn";
            this.top3btn.Size = new System.Drawing.Size(160, 23);
            this.top3btn.TabIndex = 3;
            this.top3btn.Text = "List Top 3 of Class";
            this.top3btn.UseVisualStyleBackColor = true;
            // 
            // markattndbtn
            // 
            this.markattndbtn.Location = new System.Drawing.Point(76, 146);
            this.markattndbtn.Name = "markattndbtn";
            this.markattndbtn.Size = new System.Drawing.Size(160, 23);
            this.markattndbtn.TabIndex = 4;
            this.markattndbtn.Text = "Mark Attendence";
            this.markattndbtn.UseVisualStyleBackColor = true;
            // 
            // viewattndbtn
            // 
            this.viewattndbtn.Location = new System.Drawing.Point(76, 175);
            this.viewattndbtn.Name = "viewattndbtn";
            this.viewattndbtn.Size = new System.Drawing.Size(160, 23);
            this.viewattndbtn.TabIndex = 5;
            this.viewattndbtn.Text = "View Attendence";
            this.viewattndbtn.UseVisualStyleBackColor = true;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(217, 218);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 6;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 263);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.viewattndbtn);
            this.Controls.Add(this.markattndbtn);
            this.Controls.Add(this.top3btn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Attendence ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button top3btn;
        private System.Windows.Forms.Button markattndbtn;
        private System.Windows.Forms.Button viewattndbtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}

