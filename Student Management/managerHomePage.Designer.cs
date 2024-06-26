﻿namespace Student_Management
{
    partial class managerHomePage
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.studentSheet = new System.Windows.Forms.DataGridView();
            this.instructorSheet = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add new student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 74);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add new instructor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // studentSheet
            // 
            this.studentSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentSheet.Location = new System.Drawing.Point(12, 258);
            this.studentSheet.Name = "studentSheet";
            this.studentSheet.RowHeadersWidth = 51;
            this.studentSheet.RowTemplate.Height = 24;
            this.studentSheet.Size = new System.Drawing.Size(776, 150);
            this.studentSheet.TabIndex = 3;
            // 
            // instructorSheet
            // 
            this.instructorSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instructorSheet.Location = new System.Drawing.Point(12, 414);
            this.instructorSheet.Name = "instructorSheet";
            this.instructorSheet.RowHeadersWidth = 51;
            this.instructorSheet.RowTemplate.Height = 24;
            this.instructorSheet.Size = new System.Drawing.Size(776, 150);
            this.instructorSheet.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 74);
            this.button3.TabIndex = 5;
            this.button3.Text = "Reset password";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(165, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 73);
            this.button4.TabIndex = 6;
            this.button4.Text = "Add new course";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(311, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 73);
            this.button5.TabIndex = 7;
            this.button5.Text = "Add std to course";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(311, 105);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 73);
            this.button6.TabIndex = 8;
            this.button6.Text = "Remove std from course";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(457, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 73);
            this.button7.TabIndex = 9;
            this.button7.Text = "Edit contact";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(457, 105);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 73);
            this.button8.TabIndex = 10;
            this.button8.Text = "Add warning";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // managerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.instructorSheet);
            this.Controls.Add(this.studentSheet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "managerHomePage";
            this.Text = "managerHomePage";
            this.Load += new System.EventHandler(this.managerHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorSheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView studentSheet;
        private System.Windows.Forms.DataGridView instructorSheet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}