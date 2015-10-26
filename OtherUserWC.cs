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
    public partial class OtherUserWC : Form
    {
        WebManager webInterface;
        public OtherUserWC(user currentUser)
        {
            InitializeComponent();
            txtOtherUserName.Text = currentUser.Username;
            webInterface = new WebManager(txtOtherUserName.Text, "");
            checkCount();
             
        }

        private void btnGrab_Click(object sender, EventArgs e)
        {
             webInterface = new WebManager(txtOtherUserName.Text,"");
             checkCount();
        }

        private void checkCount()
        {
            string response = webInterface.getCurrentWordcount();
            if (response != "FAIL" && checkValidUser())
            {
                XMLManager xmlResponse = new XMLManager(response);
                Dictionary<string, string> responseParsed = xmlResponse.WordCountValues();
                lblWCNum.Text = responseParsed["user_wordcount"].ToString();
                System.Drawing.Point point = new Point(this.Width / 2 - lblWCNum.Width / 2, lblWCNum.Location.Y);
                lblWCNum.Location = point;
                lblWordsRemaining.Text = (50000 - int.Parse(responseParsed["user_wordcount"])).ToString();
                lblRemainingDays.Text = (30 - DateTime.Now.Day).ToString();
                lblWPD.Text = ((50000 - int.Parse(responseParsed["user_wordcount"])) / (30 - DateTime.Now.Day)).ToString();
            }
            else
            {
                MessageBox.Show("Failed to retrieve wordcount data.");
            }
        }

        private bool checkValidUser()
        {
            WebManager wm = new WebManager(txtOtherUserName.Text, "");
            XMLManager xmlUser = new XMLManager(wm.getCurrentWordcount());
            return xmlUser.CheckErrorReturn();
        }
    }
}
