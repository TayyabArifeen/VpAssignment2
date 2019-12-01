namespace vpAssignment2
{
    partial class MarkAttendenceForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.attnd1Textbox = new System.Windows.Forms.TextBox();
            this.attndTextbox = new System.Windows.Forms.TextBox();
            this.id1Textbox = new System.Windows.Forms.TextBox();
            this.name1Textbox = new System.Windows.Forms.TextBox();
            this.id2Textbox = new System.Windows.Forms.TextBox();
            this.name2Textbox = new System.Windows.Forms.TextBox();
            this.attnd2Textbox = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mark Attendence";
            // 
            // idTextbox
            // 
            this.idTextbox.Location = new System.Drawing.Point(2, 29);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(29, 22);
            this.idTextbox.TabIndex = 3;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(50, 29);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(89, 22);
            this.nameTextbox.TabIndex = 5;
            // 
            // attnd1Textbox
            // 
            this.attnd1Textbox.Location = new System.Drawing.Point(177, 57);
            this.attnd1Textbox.Name = "attnd1Textbox";
            this.attnd1Textbox.Size = new System.Drawing.Size(99, 22);
            this.attnd1Textbox.TabIndex = 6;
            // 
            // attndTextbox
            // 
            this.attndTextbox.Location = new System.Drawing.Point(177, 29);
            this.attndTextbox.Name = "attndTextbox";
            this.attndTextbox.Size = new System.Drawing.Size(99, 22);
            this.attndTextbox.TabIndex = 7;
            // 
            // id1Textbox
            // 
            this.id1Textbox.Location = new System.Drawing.Point(2, 57);
            this.id1Textbox.Name = "id1Textbox";
            this.id1Textbox.Size = new System.Drawing.Size(29, 22);
            this.id1Textbox.TabIndex = 8;
            // 
            // name1Textbox
            // 
            this.name1Textbox.Location = new System.Drawing.Point(50, 57);
            this.name1Textbox.Name = "name1Textbox";
            this.name1Textbox.Size = new System.Drawing.Size(89, 22);
            this.name1Textbox.TabIndex = 9;
            // 
            // id2Textbox
            // 
            this.id2Textbox.Location = new System.Drawing.Point(2, 85);
            this.id2Textbox.Name = "id2Textbox";
            this.id2Textbox.Size = new System.Drawing.Size(29, 22);
            this.id2Textbox.TabIndex = 10;
            // 
            // name2Textbox
            // 
            this.name2Textbox.Location = new System.Drawing.Point(50, 85);
            this.name2Textbox.Name = "name2Textbox";
            this.name2Textbox.Size = new System.Drawing.Size(89, 22);
            this.name2Textbox.TabIndex = 11;
            // 
            // attnd2Textbox
            // 
            this.attnd2Textbox.Location = new System.Drawing.Point(177, 85);
            this.attnd2Textbox.Name = "attnd2Textbox";
            this.attnd2Textbox.Size = new System.Drawing.Size(99, 22);
            this.attnd2Textbox.TabIndex = 12;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(214, 209);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 13;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // MarkAttendenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 256);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.attnd2Textbox);
            this.Controls.Add(this.name2Textbox);
            this.Controls.Add(this.id2Textbox);
            this.Controls.Add(this.name1Textbox);
            this.Controls.Add(this.id1Textbox);
            this.Controls.Add(this.attndTextbox);
            this.Controls.Add(this.attnd1Textbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.idTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MarkAttendenceForm";
            this.Text = "MarkAttendenceForm";
            this.Load += new System.EventHandler(this.MarkAttendenceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox attnd1Textbox;
        private System.Windows.Forms.TextBox attndTextbox;
        private System.Windows.Forms.TextBox id1Textbox;
        private System.Windows.Forms.TextBox name1Textbox;
        private System.Windows.Forms.TextBox id2Textbox;
        private System.Windows.Forms.TextBox name2Textbox;
        private System.Windows.Forms.TextBox attnd2Textbox;
        private System.Windows.Forms.Button savebtn;
    }
}