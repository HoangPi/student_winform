namespace Student_Management
{
    partial class warningForm
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
            this.levelDropdown = new System.Windows.Forms.ComboBox();
            this.studentList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stdNameLabel = new System.Windows.Forms.Label();
            this.warningInput = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // levelDropdown
            // 
            this.levelDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelDropdown.FormattingEnabled = true;
            this.levelDropdown.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.levelDropdown.Location = new System.Drawing.Point(12, 94);
            this.levelDropdown.Name = "levelDropdown";
            this.levelDropdown.Size = new System.Drawing.Size(121, 24);
            this.levelDropdown.TabIndex = 0;
            // 
            // studentList
            // 
            this.studentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentList.FormattingEnabled = true;
            this.studentList.Location = new System.Drawing.Point(13, 38);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(121, 24);
            this.studentList.TabIndex = 1;
            this.studentList.SelectedIndexChanged += new System.EventHandler(this.studentList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student name:";
            // 
            // stdNameLabel
            // 
            this.stdNameLabel.AutoSize = true;
            this.stdNameLabel.Location = new System.Drawing.Point(251, 46);
            this.stdNameLabel.Name = "stdNameLabel";
            this.stdNameLabel.Size = new System.Drawing.Size(55, 16);
            this.stdNameLabel.TabIndex = 3;
            this.stdNameLabel.Text = "<name>";
            // 
            // warningInput
            // 
            this.warningInput.Location = new System.Drawing.Point(13, 167);
            this.warningInput.Name = "warningInput";
            this.warningInput.Size = new System.Drawing.Size(121, 22);
            this.warningInput.TabIndex = 4;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(13, 223);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(120, 36);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status: ";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(212, 243);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 16);
            this.statusLabel.TabIndex = 8;
            // 
            // warningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.warningInput);
            this.Controls.Add(this.stdNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentList);
            this.Controls.Add(this.levelDropdown);
            this.Name = "warningForm";
            this.Text = "warningForm";
            this.Load += new System.EventHandler(this.warningForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox levelDropdown;
        private System.Windows.Forms.ComboBox studentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stdNameLabel;
        private System.Windows.Forms.TextBox warningInput;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusLabel;
    }
}