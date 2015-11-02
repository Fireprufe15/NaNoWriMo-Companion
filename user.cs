using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaNoWriMo
{
    public class user
    {

        private string userName;

        public string Username
        {
            get { return userName; }
            set { userName = value.ToLower(); }
        }

        private string secretCode;

        public string SecretCode
        {
            get { return secretCode; }
            set { secretCode = value; }
        }

        private string region;

        public string Region
        {
            get { return region; }
            set { region = value; }
        }
        

        public user(string userName, string secretcode)
        {
            this.userName = userName;
            this.secretCode = secretcode;
        }
        

    }
}
