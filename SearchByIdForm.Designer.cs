namespace vpAssignment2
{
    partial class SearchByIdForm
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
            this.enteridlbl = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.enteridTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enteridlbl
            // 
            this.enteridlbl.AutoSize = true;
            this.enteridlbl.Location = new System.Drawing.Point(12, 18);
            this.enteridlbl.Name = "enteridlbl";
            this.enteridlbl.Size = new System.Drawing.Size(110, 17);
            this.enteridlbl.TabIndex = 0;
            this.enteridlbl.Text = "Enter Student Id";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(185, 65);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 1;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            // 
            // enteridTextbox
            // 
            this.enteridTextbox.Location = new System.Drawing.Point(160, 18);
            this.enteridTextbox.Name = "enteridTextbox";
            this.enteridTextbox.Size = new System.Drawing.Size(100, 22);
            this.enteridTextbox.TabIndex = 2;
            // 
            // SearchByIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.enteridTextbox);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.enteridlbl);
            this.Name = "SearchByIdForm";
            this.Text = "SearchByIdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enteridlbl;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox enteridTextbox;
    }
}