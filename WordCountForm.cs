using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaNoWriMo
{
    public partial class WordCountForm : Form
    {
        private int wordCount;
        public int WordCount
        {
            get { return this.wordCount; }
        }
        private string nanoText;
        public string NanoText
        {
            get { return this.nanoText; }
        }
        public WordCountForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            nanoText = rtbWordText.Text;
            MatchCollection collection = Regex.Matches(nanoText, @"[\S]+");
            wordCount = collection.Count;
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
