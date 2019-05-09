using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAboutEvents
{
    public partial class FormForPits : Form
    {
        private RacingTeam racingteam;
        public FormForPits(RacingTeam rt)
        {
            InitializeComponent();
            this.racingteam = rt;
            this.Visible = true;
        }

        private void btnBeNotifiedAboutADriver_Click(object sender, EventArgs e)
        {
            Motorbike m = this.racingteam.GetByName(this.textBox1.Text);
            if (m!=null)
            {
                //todo
                m.speedChanged += new Motorbike.SpeedChangedHandler(
                    this.ShowInformationAboutSpeed);
                m.speedTooFast += new Motorbike.SpeedChangedHandler(
                    this.ShowInformationAboutOverSpeedlimit);
            }
   
        }

        private void btnNoLongerNotifiedAboutADriver_Click(object sender, EventArgs e)
        {
            Motorbike m = this.racingteam.GetByName(this.textBox1.Text);
            if (m != null)
            {
                //todo
                m.speedChanged -= new Motorbike.SpeedChangedHandler(
                    this.ShowInformationAboutSpeed);
                m.speedTooFast -= new Motorbike.SpeedChangedHandler(
                    this.ShowInformationAboutOverSpeedlimit);
            }
        }

        private void ShowInformationAboutSpeed(Motorbike m, int s)
        {
            String holder;
            holder = DateTime.Now.ToString() + " " + m.NameOfDriver +
                " current speed is " + s + " km/h.";
            this.listBox1.Items.Add(holder);
        }

        private void ShowInformationAboutOverSpeedlimit(Motorbike m, int s)
        {
            String holder;
            holder = "WARNING   " + DateTime.Now.ToString() + " " + m.NameOfDriver +
                " too fast by " + s + " km/h.";
            this.listBox1.Items.Add(holder);
        }
    }
}
