namespace Student_Management
{
    partial class addCourse
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
            this.instructorDropDown = new System.Windows.Forms.ComboBox();
            this.creditDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.instructorLabel = new System.Windows.Forms.Label();
            this.courseNameInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructorDropDown
            // 
            this.instructorDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instructorDropDown.FormattingEnabled = true;
            this.instructorDropDown.Location = new System.Drawing.Point(80, 78);
            this.instructorDropDown.Name = "instructorDropDown";
            this.instructorDropDown.Size = new System.Drawing.Size(121, 24);
            this.instructorDropDown.TabIndex = 0;
            this.instructorDropDown.SelectedIndexChanged += new System.EventHandler(this.instructorDropDown_SelectedIndexChanged);
            this.instructorDropDown.TabIndexChanged += new System.EventHandler(this.instructorDropDown_TabIndexChanged);
            // 
            // creditDropDown
            // 
            this.creditDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creditDropDown.FormattingEnabled = true;
            this.creditDropDown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.creditDropDown.Location = new System.Drawing.Point(82, 162);
            this.creditDropDown.Name = "creditDropDown";
            this.creditDropDown.Size = new System.Drawing.Size(121, 24);
            this.creditDropDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Instructor id: ";
            // 
            // instructorLabel
            // 
            this.instructorLabel.AutoSize = true;
            this.instructorLabel.Location = new System.Drawing.Point(328, 85);
            this.instructorLabel.Name = "instructorLabel";
            this.instructorLabel.Size = new System.Drawing.Size(41, 16);
            this.instructorLabel.TabIndex = 3;
            this.instructorLabel.Text = "name";
            // 
            // courseNameInput
            // 
            this.courseNameInput.Location = new System.Drawing.Point(82, 221);
            this.courseNameInput.Name = "courseNameInput";
            this.courseNameInput.Size = new System.Drawing.Size(100, 22);
            this.courseNameInput.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // addCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.courseNameInput);
            this.Controls.Add(this.instructorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.creditDropDown);
            this.Controls.Add(this.instructorDropDown);
            this.Name = "addCourse";
            this.Text = "addCourse";
            this.Load += new System.EventHandler(this.addCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox instructorDropDown;
        private System.Windows.Forms.ComboBox creditDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label instructorLabel;
        private System.Windows.Forms.TextBox courseNameInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}