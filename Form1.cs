using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSleep
{
    public partial class Form1 : Form
    {
        //in seconds
        private int timer;
        private TimeSpan timeUnilSleep;

        public Form1()
        {
            InitializeComponent();
            buttonAction.Left = (this.ClientSize.Width - buttonAction.Width) / 2;
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {

            if (buttonAction.Text == "Sleep")
            {
                DialogResult r = DialogResult.Cancel;
                if (radioButtonHours.Checked)
                {
                    r = MessageBox.Show("Are you sure you want to put you System to sleep in " + Math.Round(this.numericUpDown1.Value).ToString() + " hours", "Warning", MessageBoxButtons.OKCancel);
                }
                else if (radioButtonMiuntes.Checked)
                {
                    r = MessageBox.Show("Are you sure you want to put you System to sleep in " + Math.Round(this.numericUpDown1.Value).ToString() + " minutes", "Warning", MessageBoxButtons.OKCancel);
                }
                if (r == DialogResult.OK)
                {
                    if (radioButtonHours.Checked)
                    {
                        timer = (Convert.ToInt32(numericUpDown1.Value) * 60) * 60;
                    }
                    else if (radioButtonMiuntes.Checked)
                    {
                        timer = Convert.ToInt32(numericUpDown1.Value) * 60;
                    }
                    timer1.Tick += new EventHandler(Timer_Tick);
                    timeUnilSleep = TimeSpan.FromSeconds(timer);
                    timer1.Interval = 1000;
                    this.buttonAction.Text = "Cancel";
                    this.radioButtonHours.Enabled = false;
                    this.radioButtonMiuntes.Enabled = false;
                    this.numericUpDown1.Enabled = false;
                    timer1.Start();
                }
            }
            else if (buttonAction.Text == "Cancel")
            {
                this.buttonAction.Text = "Sleep";
                this.radioButtonHours.Enabled = true;
                this.radioButtonMiuntes.Enabled = true;
                this.numericUpDown1.Value = 0;
                this.numericUpDown1.Enabled = true;
                this.label1.Text = "no Timer set";
                label1.Left = (this.ClientSize.Width - label1.Width) / 2;
                timer1.Stop();
            }
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            if (sender == timer1)
            {
                if (timeUnilSleep.TotalMinutes > 0)
                {
                    label1.Text = timeUnilSleep.ToString(@"hh\:mm\:ss");
                    label1.Left = (this.ClientSize.Width - label1.Width) / 2;
                    timeUnilSleep = timeUnilSleep.Subtract(TimeSpan.FromSeconds(1));
                }
                else
                {
                    timer1.Stop();
                    Application.SetSuspendState(PowerState.Suspend, true, true);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if ((sender as NumericUpDown).Value <= 0)
            {
                this.buttonAction.Enabled = false;
            }
            else if ((sender as NumericUpDown).Value > 0)
            {
                this.buttonAction.Enabled = true;
            }
        }
    }
}
