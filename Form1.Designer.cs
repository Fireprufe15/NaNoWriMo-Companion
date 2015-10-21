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
            this.lblWC = new System.Windows.Forms.Label();
            this.lblWCNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetWordCount
            // 
            this.btnSetWordCount.Location = new System.Drawing.Point(12, 12);
            this.btnSetWordCount.Name = "btnSetWordCount";
            this.btnSetWordCount.Size = new System.Drawing.Size(134, 23);
            this.btnSetWordCount.TabIndex = 1;
            this.btnSetWordCount.Text = "Update Word Count";
            this.btnSetWordCount.UseVisualStyleBackColor = true;
            this.btnSetWordCount.Click += new System.EventHandler(this.btnSetWordCount_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 182);
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
            this.btnCheckCount.Text = "Refresh Wordcount";
            this.btnCheckCount.UseVisualStyleBackColor = true;
            this.btnCheckCount.Click += new System.EventHandler(this.btnCheckCount_Click);
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
            // lblWC
            // 
            this.lblWC.AutoSize = true;
            this.lblWC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWC.Location = new System.Drawing.Point(14, 67);
            this.lblWC.Name = "lblWC";
            this.lblWC.Size = new System.Drawing.Size(272, 26);
            this.lblWC.TabIndex = 6;
            this.lblWC.Text = "CURRENT WORDCOUNT";
            // 
            // lblWCNum
            // 
            this.lblWCNum.AutoSize = true;
            this.lblWCNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWCNum.Location = new System.Drawing.Point(12, 93);
            this.lblWCNum.Name = "lblWCNum";
            this.lblWCNum.Size = new System.Drawing.Size(70, 76);
            this.lblWCNum.TabIndex = 7;
            this.lblWCNum.Text = "0";
            this.lblWCNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 217);
            this.Controls.Add(this.lblWCNum);
            this.Controls.Add(this.lblWC);
            this.Controls.Add(this.btnCheckOtherWordcount);
            this.Controls.Add(this.btnWordCountHistory);
            this.Controls.Add(this.btnCheckCount);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSetWordCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSetWordCount;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCheckCount;
        private System.Windows.Forms.Button btnWordCountHistory;
        private System.Windows.Forms.Button btnCheckOtherWordcount;
        private System.Windows.Forms.Label lblWC;
        private System.Windows.Forms.Label lblWCNum;
    }
}

