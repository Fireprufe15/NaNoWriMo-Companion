using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace NaNoWriMo
{
    class WebManager
    {

        private string userName;
        private string secretKey;
        private WebClient WC = new WebClient();
        private const string WCUPDATEURL = "http://nanowrimo.org/api/wordcount";
        private const string GETWORDCOUNTURL = "http://nanowrimo.org/wordcount_api/wc/";
        private const string GETWORDCOUNTHISTORYURL = "http://nanowrimo.org/modules/wordcount_api/wchistory/";

        public WebManager(string userName, string secretKey)
        {
            this.userName = userName;
            this.secretKey = secretKey;
        }
        public string UpdateWordCount(int wordCount)
        {
            HashAlgorithm sha1Hash = SHA1.Create();
            string sendRequest;
            sendRequest = secretKey.Trim() + userName.Trim() + wordCount.ToString().Trim();
            byte[] encodedRequest = Encoding.UTF8.GetBytes(sendRequest);
            byte[] hashedRequestBytes = sha1Hash.ComputeHash(encodedRequest);
            StringBuilder hashedString = new StringBuilder();
            foreach (byte item in hashedRequestBytes)
            {
                hashedString.Append(item.ToString("X2"));
            }

            NameValueCollection data = new NameValueCollection();
            data.Add("hash",hashedString.ToString().ToLower());
            data.Add("name", this.userName);
            data.Add("wordcount", wordCount.ToString());
            string responseString;
            try
            {
                byte[] response = WC.UploadValues(WCUPDATEURL, "PUT", data);
                responseString = Encoding.UTF8.GetString(response);
            }
            catch (WebException)
            {
                responseString = "400";
            }

            return responseString;
            
        }

        public string getCurrentWordcount()
        {
            string requestURL = GETWORDCOUNTURL + userName;
            string responseString;
            try
            {
                byte[] response = WC.DownloadData(requestURL);
                responseString = Encoding.UTF8.GetString(response);
            }
            catch (WebException)
            {
                responseString = "FAIL";
            }

            return responseString;

        }

    }
}
