namespace NaNoWriMo
{
    partial class Form1
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
            this.btnSetWordCount = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCheckCount = new System.Windows.Forms.Button();
            this.btnWordCountHistory = new System.Windows.Forms.Button();
            this.btnCheckOtherWordcount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSetWordCount
            // 
            this.btnSetWordCount.Location = new System.Drawing.Point(12, 12);
            this.btnSetWordCount.Name = "btnSetWordCount";
            this.btnSetWordCount.Size = new System.Drawing.Size(134, 23);
            this.btnSetWordCount.TabIndex = 1;
            this.btnSetWordCount.Text = "Send Word Count";
            this.btnSetWordCount.UseVisualStyleBackColor = true;
            this.btnSetWordCount.Click += new System.EventHandler(this.btnSetWordCount_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 151);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCheckCount
            // 
            this.btnCheckCount.Location = new System.Drawing.Point(12, 41);
            this.btnCheckCount.Name = "btnCheckCount";
            this.btnCheckCount.Size = new System.Drawing.Size(134, 23);
            this.btnCheckCount.TabIndex = 3;
            this.btnCheckCount.Text = "Current Wordcount";
            this.btnCheckCount.UseVisualStyleBackColor = true;
            // 
            // btnWordCountHistory
            // 
            this.btnWordCountHistory.Location = new System.Drawing.Point(152, 12);
            this.btnWordCountHistory.Name = "btnWordCountHistory";
            this.btnWordCountHistory.Size = new System.Drawing.Size(134, 23);
            this.btnWordCountHistory.TabIndex = 4;
            this.btnWordCountHistory.Text = "Word Count History";
            this.btnWordCountHistory.UseVisualStyleBackColor = true;
            // 
            // btnCheckOtherWordcount
            // 
            this.btnCheckOtherWordcount.Location = new System.Drawing.Point(152, 41);
            this.btnCheckOtherWordcount.Name = "btnCheckOtherWordcount";
            this.btnCheckOtherWordcount.Size = new System.Drawing.Size(134, 23);
            this.btnCheckOtherWordcount.TabIndex = 5;
            this.btnCheckOtherWordcount.Text = "Other User Wordcount";
            this.btnCheckOtherWordcount.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 186);
            this.Controls.Add(this.btnCheckOtherWordcount);
            this.Controls.Add(this.btnWordCountHistory);
            this.Controls.Add(this.btnCheckCount);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSetWordCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSetWordCount;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCheckCount;
        private System.Windows.Forms.Button btnWordCountHistory;
        private System.Windows.Forms.Button btnCheckOtherWordcount;
    }
}

