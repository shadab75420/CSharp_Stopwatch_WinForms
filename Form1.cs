using System;
using System.Windows.Forms;

namespace Stopwatch2
{
    public partial class Form1 : Form
    {
        int milliseconds = 0;
        int seconds = 0;
        int minutes = 0;
        int lapCount = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            milliseconds += 10;

            if (milliseconds == 1000)
            {
                milliseconds = 0;
                seconds++;
            }

            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
            }

            lblMainTime.Text = $"{minutes:D2}:{seconds:D2}:{milliseconds / 10:D2}";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                ((Button)sender).Text = "Start";
            }
            else
            {
                timer1.Start();
                ((Button)sender).Text = "Stop";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            milliseconds = 0;
            seconds = 0;
            minutes = 0;

            lblMainTime.Text = "00:00:00";
        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            lstLaps.Items.Add("Lap " + lapCount++ + " - " + lblMainTime.Text);
        }
    }
}