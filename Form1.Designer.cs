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
            this.txtWordCount = new System.Windows.Forms.TextBox();
            this.btnSetWordCount = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWordCount
            // 
            this.txtWordCount.Location = new System.Drawing.Point(12, 91);
            this.txtWordCount.Name = "txtWordCount";
            this.txtWordCount.Size = new System.Drawing.Size(100, 20);
            this.txtWordCount.TabIndex = 0;
            // 
            // btnSetWordCount
            // 
            this.btnSetWordCount.Location = new System.Drawing.Point(118, 88);
            this.btnSetWordCount.Name = "btnSetWordCount";
            this.btnSetWordCount.Size = new System.Drawing.Size(134, 23);
            this.btnSetWordCount.TabIndex = 1;
            this.btnSetWordCount.Text = "Send Word Count";
            this.btnSetWordCount.UseVisualStyleBackColor = true;
            this.btnSetWordCount.Click += new System.EventHandler(this.btnSetWordCount_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(711, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 505);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSetWordCount);
            this.Controls.Add(this.txtWordCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWordCount;
        private System.Windows.Forms.Button btnSetWordCount;
        private System.Windows.Forms.Button btnLogout;
    }
}

