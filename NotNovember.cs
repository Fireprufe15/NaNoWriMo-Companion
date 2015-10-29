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
    public partial class NotNovember : Form
    {
        Timer countdown = new Timer();
        public NotNovember()
        {
            InitializeComponent();
        }

        private void NotNovember_Load(object sender, EventArgs e)
        {            
            countdown.Tick += new EventHandler(TimerTick);
            countdown.Interval = 1;
            countdown.Start();
        }

        public void TimerTick(Object o, EventArgs e)
        {
            int year = DateTime.Now.Year;
            DateTime nov = new DateTime(year, 11, 1);
            TimeSpan cd = nov - DateTime.Now;            
            if (cd.TotalMilliseconds < 0)
            {
                btnStart.Enabled = true;
                lblNope.Text = "GO! GO! GO!";
                lblCountdown.Text = "IT IS NOVEMBER!";                
            }
            else
            {
                lblCountdown.Text = String.Format("{0}:{1}:{2}:{3}:{4}", cd.Days.ToString(), cd.Hours.ToString(), cd.Minutes.ToString(), cd.Seconds.ToString(), cd.Milliseconds.ToString());
            }
            System.Drawing.Point point = new Point(this.Width / 2 - lblCountdown.Width / 2, lblCountdown.Location.Y);
            lblCountdown.Location = point;
            point = new Point(this.Width / 2 - lblNope.Width / 2, lblNope.Location.Y);
            lblNope.Location = point;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
