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
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.searchListbtn);
            this.Controls.Add(this.searchNamebtn);
            this.Controls.Add(this.searchIdbtn);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchIdbtn;
        private System.Windows.Forms.Button searchNamebtn;
        private System.Windows.Forms.Button searchListbtn;
        private System.Windows.Forms.Button backbtn;
    }
}