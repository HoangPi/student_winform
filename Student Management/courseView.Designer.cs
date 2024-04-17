namespace Student_Management
{
    partial class courseView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stdNameInput = new System.Windows.Forms.TextBox();
            this.score1Input = new System.Windows.Forms.TextBox();
            this.score2Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updateScoreBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // stdNameInput
            // 
            this.stdNameInput.Location = new System.Drawing.Point(28, 13);
            this.stdNameInput.Name = "stdNameInput";
            this.stdNameInput.ReadOnly = true;
            this.stdNameInput.Size = new System.Drawing.Size(223, 22);
            this.stdNameInput.TabIndex = 1;
            // 
            // score1Input
            // 
            this.score1Input.Location = new System.Drawing.Point(40, 107);
            this.score1Input.Name = "score1Input";
            this.score1Input.Size = new System.Drawing.Size(100, 22);
            this.score1Input.TabIndex = 2;
            // 
            // score2Input
            // 
            this.score2Input.Location = new System.Drawing.Point(40, 180);
            this.score2Input.Name = "score2Input";
            this.score2Input.Size = new System.Drawing.Size(100, 22);
            this.score2Input.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "score 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "score 2";
            // 
            // updateScoreBtn
            // 
            this.updateScoreBtn.Location = new System.Drawing.Point(186, 143);
            this.updateScoreBtn.Name = "updateScoreBtn";
            this.updateScoreBtn.Size = new System.Drawing.Size(140, 59);
            this.updateScoreBtn.TabIndex = 6;
            this.updateScoreBtn.Text = "update";
            this.updateScoreBtn.UseVisualStyleBackColor = true;
            this.updateScoreBtn.Click += new System.EventHandler(this.updateScoreBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // courseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateScoreBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score2Input);
            this.Controls.Add(this.score1Input);
            this.Controls.Add(this.stdNameInput);
            this.Controls.Add(this.dataGridView1);
            this.Name = "courseView";
            this.Text = "courseView";
            this.Load += new System.EventHandler(this.courseView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox stdNameInput;
        private System.Windows.Forms.TextBox score1Input;
        private System.Windows.Forms.TextBox score2Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateScoreBtn;
        private System.Windows.Forms.Label label3;
    }
}