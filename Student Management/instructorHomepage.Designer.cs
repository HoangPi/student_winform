﻿namespace Student_Management
{
    partial class instructorHomepage
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
            this.courseGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // courseGridView
            // 
            this.courseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGridView.Location = new System.Drawing.Point(16, 236);
            this.courseGridView.Name = "courseGridView";
            this.courseGridView.RowHeadersWidth = 51;
            this.courseGridView.RowTemplate.Height = 24;
            this.courseGridView.Size = new System.Drawing.Size(772, 150);
            this.courseGridView.TabIndex = 1;
            this.courseGridView.DoubleClick += new System.EventHandler(this.courseGridView_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Edit contact";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // instructorHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.courseGridView);
            this.Controls.Add(this.label1);
            this.Name = "instructorHomepage";
            this.Text = "instructorHomepage";
            this.Load += new System.EventHandler(this.instructorHomepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView courseGridView;
        private System.Windows.Forms.Button button1;
    }
}