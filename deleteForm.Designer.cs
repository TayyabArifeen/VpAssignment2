namespace vpAssignment2
{
    partial class deleteForm
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
            this.deleteidTextbox = new System.Windows.Forms.TextBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enteridlbl
            // 
            this.enteridlbl.AutoSize = true;
            this.enteridlbl.Location = new System.Drawing.Point(12, 45);
            this.enteridlbl.Name = "enteridlbl";
            this.enteridlbl.Size = new System.Drawing.Size(110, 17);
            this.enteridlbl.TabIndex = 0;
            this.enteridlbl.Text = "Enter Student Id";
            // 
            // deleteidTextbox
            // 
            this.deleteidTextbox.Location = new System.Drawing.Point(145, 42);
            this.deleteidTextbox.Name = "deleteidTextbox";
            this.deleteidTextbox.Size = new System.Drawing.Size(125, 22);
            this.deleteidTextbox.TabIndex = 1;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(195, 88);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            // 
            // deleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.deleteidTextbox);
            this.Controls.Add(this.enteridlbl);
            this.Name = "deleteForm";
            this.Text = "deleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enteridlbl;
        private System.Windows.Forms.TextBox deleteidTextbox;
        private System.Windows.Forms.Button deletebtn;
    }
}