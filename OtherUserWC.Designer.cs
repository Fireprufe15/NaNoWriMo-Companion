namespace NaNoWriMo
{
    partial class OtherUserWC
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
            this.txtOtherUserName = new System.Windows.Forms.TextBox();
            this.lblWCNum = new System.Windows.Forms.Label();
            this.lblWC = new System.Windows.Forms.Label();
            this.btnGrab = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRemainingDays = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWordsRemaining = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWPD = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the username you want to spy on:";
            // 
            // txtOtherUserName
            // 
            this.txtOtherUserName.Location = new System.Drawing.Point(7, 29);
            this.txtOtherUserName.Name = "txtOtherUserName";
            this.txtOtherUserName.Size = new System.Drawing.Size(312, 20);
            this.txtOtherUserName.TabIndex = 1;
            // 
            // lblWCNum
            // 
            this.lblWCNum.AutoSize = true;
            this.lblWCNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWCNum.Location = new System.Drawing.Point(28, 149);
            this.lblWCNum.Name = "lblWCNum";
            this.lblWCNum.Size = new System.Drawing.Size(70, 76);
            this.lblWCNum.TabIndex = 9;
            this.lblWCNum.Text = "0";
            this.lblWCNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWC
            // 
            this.lblWC.AutoSize = true;
            this.lblWC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWC.Location = new System.Drawing.Point(30, 123);
            this.lblWC.Name = "lblWC";
            this.lblWC.Size = new System.Drawing.Size(272, 26);
            this.lblWC.TabIndex = 8;
            this.lblWC.Text = "CURRENT WORDCOUNT";
            // 
            // btnGrab
            // 
            this.btnGrab.Location = new System.Drawing.Point(112, 55);
            this.btnGrab.Name = "btnGrab";
            this.btnGrab.Size = new System.Drawing.Size(98, 44);
            this.btnGrab.TabIndex = 10;
            this.btnGrab.Text = "Grab Data";
            this.btnGrab.UseVisualStyleBackColor = true;
            this.btnGrab.Click += new System.EventHandler(this.btnGrab_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblWPD, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 229);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6789F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6789F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60886F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6789F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6789F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 185);
            this.tableLayoutPanel1.TabIndex = 11;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Words Left:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "WPD To Finish:";
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
            // OtherUserWC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnGrab);
            this.Controls.Add(this.lblWCNum);
            this.Controls.Add(this.lblWC);
            this.Controls.Add(this.txtOtherUserName);
            this.Controls.Add(this.label1);
            this.Name = "OtherUserWC";
            this.Text = "OtherUserWC";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOtherUserName;
        private System.Windows.Forms.Label lblWCNum;
        private System.Windows.Forms.Label lblWC;
        private System.Windows.Forms.Button btnGrab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRemainingDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWordsRemaining;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWPD;
    }
}