using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaNoWriMo
{
    public partial class LoginDialog : Form
    {
        private string username;
        public string Username
        {
            get { return username; }
        }

        private string secretCode;
        public string SecretCode
        {
            get { return secretCode; }
        }
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            secretCode = txtSecret.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
