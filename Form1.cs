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
            checkCount();
        }

        private void btnSetWordCount_Click(object sender, EventArgs e)
        {
            WordCountForm wcDialog = new WordCountForm();
            wcDialog.ShowDialog();
            if (wcDialog.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Updated wordcount to "+wcDialog.WordCount.ToString());
                webInterface.UpdateWordCount(wcDialog.WordCount);
            }            
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

        private void btnCheckCount_Click(object sender, EventArgs e)
        {
            checkCount();
        }

        private void checkCount()
        {
            string response = webInterface.getCurrentWordcount();
            XMLManager xmlResponse = new XMLManager(response);
            Dictionary<string, string> responseParsed = xmlResponse.WordCountValues();
            lblWCNum.Text = responseParsed["user_wordcount"].ToString();
            System.Drawing.Point point = new Point(this.Width / 2 - lblWCNum.Width / 2, lblWCNum.Location.Y);
            lblWCNum.Location = point;
            lblWordsRemaining.Text = (50000 - int.Parse(responseParsed["user_wordcount"])).ToString();
            lblRemainingDays.Text = (30 - DateTime.Now.Day).ToString();
            lblWPD.Text = ((50000 - int.Parse(responseParsed["user_wordcount"])) / (30 - DateTime.Now.Day)).ToString(); ;
        }
    }
}
