namespace Student_Management
{
    partial class courseManager
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
            this.courseNameDropdown = new System.Windows.Forms.ComboBox();
            this.stdNameDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseidLabel = new System.Windows.Forms.Label();
            this.stdIdLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseNameDropdown
            // 
            this.courseNameDropdown.FormattingEnabled = true;
            this.courseNameDropdown.Location = new System.Drawing.Point(44, 51);
            this.courseNameDropdown.Name = "courseNameDropdown";
            this.courseNameDropdown.Size = new System.Drawing.Size(121, 24);
            this.courseNameDropdown.TabIndex = 0;
            this.courseNameDropdown.SelectedIndexChanged += new System.EventHandler(this.courseNameDropdown_SelectedIndexChanged);
            // 
            // stdNameDropdown
            // 
            this.stdNameDropdown.FormattingEnabled = true;
            this.stdNameDropdown.Location = new System.Drawing.Point(43, 146);
            this.stdNameDropdown.Name = "stdNameDropdown";
            this.stdNameDropdown.Size = new System.Drawing.Size(122, 24);
            this.stdNameDropdown.TabIndex = 1;
            this.stdNameDropdown.SelectedIndexChanged += new System.EventHandler(this.stdNameDropdown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course id: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student id: ";
            // 
            // courseidLabel
            // 
            this.courseidLabel.AutoSize = true;
            this.courseidLabel.Location = new System.Drawing.Point(280, 54);
            this.courseidLabel.Name = "courseidLabel";
            this.courseidLabel.Size = new System.Drawing.Size(44, 16);
            this.courseidLabel.TabIndex = 4;
            this.courseidLabel.Text = "label3";
            // 
            // stdIdLabel
            // 
            this.stdIdLabel.AutoSize = true;
            this.stdIdLabel.Location = new System.Drawing.Point(280, 149);
            this.stdIdLabel.Name = "stdIdLabel";
            this.stdIdLabel.Size = new System.Drawing.Size(44, 16);
            this.stdIdLabel.TabIndex = 5;
            this.stdIdLabel.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status";
            // 
            // courseManager
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
            this.Name = "courseManager";
            this.Text = "courseManager";
            this.Load += new System.EventHandler(this.courseManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox courseNameDropdown;
        private System.Windows.Forms.ComboBox stdNameDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label courseidLabel;
        private System.Windows.Forms.Label stdIdLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}