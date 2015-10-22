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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWordsRemaining = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWPD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRemainingDays = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.btnLogout.Location = new System.Drawing.Point(111, 70);
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
            this.lblWC.Location = new System.Drawing.Point(14, 107);
            this.lblWC.Name = "lblWC";
            this.lblWC.Size = new System.Drawing.Size(272, 26);
            this.lblWC.TabIndex = 6;
            this.lblWC.Text = "CURRENT WORDCOUNT";
            // 
            // lblWCNum
            // 
            this.lblWCNum.AutoSize = true;
            this.lblWCNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWCNum.Location = new System.Drawing.Point(12, 133);
            this.lblWCNum.Name = "lblWCNum";
            this.lblWCNum.Size = new System.Drawing.Size(70, 76);
            this.lblWCNum.TabIndex = 7;
            this.lblWCNum.Text = "0";
            this.lblWCNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 214);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // lblWordsRemaining
            // 
            this.lblWordsRemaining.AutoSize = true;
            this.lblWordsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordsRemaining.Location = new System.Drawing.Point(134, 1);
            this.lblWordsRemaining.Name = "lblWordsRemaining";
            this.lblWordsRemaining.Size = new System.Drawing.Size(23, 25);
            this.lblWordsRemaining.TabIndex = 1;
            this.lblWordsRemaining.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Words Left:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblRemainingDays, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblWordsRemaining, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblWPD, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6789F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6789F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60886F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6789F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6789F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 185);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "WPD To Finish:";
            // 
            // lblWPD
            // 
            this.lblWPD.AutoSize = true;
            this.lblWPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWPD.Location = new System.Drawing.Point(134, 61);
            this.lblWPD.Name = "lblWPD";
            this.lblWPD.Size = new System.Drawing.Size(23, 25);
            this.lblWPD.TabIndex = 3;
            this.lblWPD.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Days Left: ";
            // 
            // lblRemainingDays
            // 
            this.lblRemainingDays.AutoSize = true;
            this.lblRemainingDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRemainingDays.Location = new System.Drawing.Point(134, 31);
            this.lblRemainingDays.Name = "lblRemainingDays";
            this.lblRemainingDays.Size = new System.Drawing.Size(23, 25);
            this.lblRemainingDays.TabIndex = 5;
            this.lblRemainingDays.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 434);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblWCNum);
            this.Controls.Add(this.lblWC);
            this.Controls.Add(this.btnCheckOtherWordcount);
            this.Controls.Add(this.btnWordCountHistory);
            this.Controls.Add(this.btnCheckCount);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSetWordCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblWordsRemaining;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblWPD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRemainingDays;
        private System.Windows.Forms.Label label3;
    }
}

