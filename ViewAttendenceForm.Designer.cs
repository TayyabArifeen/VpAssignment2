namespace vpAssignment2
{
    partial class ViewAttendenceForm
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
            this.attndTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // attndTextbox
            // 
            this.attndTextbox.Location = new System.Drawing.Point(191, 34);
            this.attndTextbox.Multiline = true;
            this.attndTextbox.Name = "attndTextbox";
            this.attndTextbox.Size = new System.Drawing.Size(95, 216);
            this.attndTextbox.TabIndex = 19;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(64, 34);
            this.nameTextbox.Multiline = true;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(121, 216);
            this.nameTextbox.TabIndex = 17;
            // 
            // idTextbox
            // 
            this.idTextbox.Location = new System.Drawing.Point(29, 34);
            this.idTextbox.Multiline = true;
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(16, 216);
            this.idTextbox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Attendence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id";
            // 
            // ViewAttendenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 286);
            this.Controls.Add(this.attndTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.idTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewAttendenceForm";
            this.Text = "ViewAttendenceForm";
            this.Load += new System.EventHandler(this.ViewAttendenceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox attndTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}