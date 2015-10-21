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
    public partial class Form1 : Form
    {
        WebManager webInterface;
        FileManager userDataManager;
        user loggedInUser;
        public Form1()
        {
            InitializeComponent();
            userDataManager = new FileManager();
            Login();
            webInterface = new WebManager(loggedInUser.Username, loggedInUser.SecretCode);
        }

        private void btnSetWordCount_Click(object sender, EventArgs e)
        {
                     
        }

        public void Login()
        {
            if (!userDataManager.checkSaveFile())
            {                
                LoginDialog loginDialog = new LoginDialog();
                loginDialog.ShowDialog();
                if (loginDialog.DialogResult == DialogResult.OK)
                {
                    string userName = loginDialog.Username;
                    string secret = loginDialog.SecretCode;
                    userDataManager.createFile(userName, secret);
                    Login();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                loggedInUser = new user(userDataManager.returnValues()[0], userDataManager.returnValues()[1]);
            }            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (userDataManager.checkSaveFile())
            {
                userDataManager.removeSaveFile();                
            }
            Environment.Exit(0);
        }
    }
}
