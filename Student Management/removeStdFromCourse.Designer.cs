namespace Student_Management
{
    partial class removeStdFromCourse
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.stdIdLabel = new System.Windows.Forms.Label();
            this.courseidLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stdNameDropdown = new System.Windows.Forms.ComboBox();
            this.courseNameDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Status";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stdIdLabel
            // 
            this.stdIdLabel.AutoSize = true;
            this.stdIdLabel.Location = new System.Drawing.Point(289, 131);
            this.stdIdLabel.Name = "stdIdLabel";
            this.stdIdLabel.Size = new System.Drawing.Size(44, 16);
            this.stdIdLabel.TabIndex = 13;
            this.stdIdLabel.Text = "label4";
            this.stdIdLabel.Click += new System.EventHandler(this.stdIdLabel_Click);
            // 
            // courseidLabel
            // 
            this.courseidLabel.AutoSize = true;
            this.courseidLabel.Location = new System.Drawing.Point(289, 36);
            this.courseidLabel.Name = "courseidLabel";
            this.courseidLabel.Size = new System.Drawing.Size(44, 16);
            this.courseidLabel.TabIndex = 12;
            this.courseidLabel.Text = "label3";
            this.courseidLabel.Click += new System.EventHandler(this.courseidLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Student id: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Course id: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stdNameDropdown
            // 
            this.stdNameDropdown.FormattingEnabled = true;
            this.stdNameDropdown.Location = new System.Drawing.Point(52, 128);
            this.stdNameDropdown.Name = "stdNameDropdown";
            this.stdNameDropdown.Size = new System.Drawing.Size(122, 24);
            this.stdNameDropdown.TabIndex = 9;
            this.stdNameDropdown.SelectedIndexChanged += new System.EventHandler(this.stdNameDropdown_SelectedIndexChanged);
            // 
            // courseNameDropdown
            // 
            this.courseNameDropdown.FormattingEnabled = true;
            this.courseNameDropdown.Location = new System.Drawing.Point(53, 33);
            this.courseNameDropdown.Name = "courseNameDropdown";
            this.courseNameDropdown.Size = new System.Drawing.Size(121, 24);
            this.courseNameDropdown.TabIndex = 8;
            this.courseNameDropdown.SelectedIndexChanged += new System.EventHandler(this.courseNameDropdown_SelectedIndexChanged);
            // 
            // removeStdFromCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stdIdLabel);
            this.Controls.Add(this.courseidLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stdNameDropdown);
            this.Controls.Add(this.courseNameDropdown);
            this.Name = "removeStdFromCourse";
            this.Text = "removeStdFromCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label stdIdLabel;
        private System.Windows.Forms.Label courseidLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stdNameDropdown;
        private System.Windows.Forms.ComboBox courseNameDropdown;
    }
}