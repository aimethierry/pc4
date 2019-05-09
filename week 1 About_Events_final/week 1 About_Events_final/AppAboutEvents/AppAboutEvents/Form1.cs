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
    public partial class Form1 : Form
    {
        private RacingTeam yamahaTeam;

        public Form1()
        {
            InitializeComponent();
            this.yamahaTeam = new RacingTeam();
        }

        private void btnStartTheMotors_Click(object sender, EventArgs e)
        {   // create a display for Valentino Rossi's motorbike
            // make sure from now on Valentino Rossi's display will show
            // information about his speed
            // and about exceeding the speedlimit.
            Motorbike m = this.yamahaTeam.GetByName("Rossi");
            FormDisplayOnMotorbike f = new FormDisplayOnMotorbike(m);
            // also create a window form to be used in the pits
            FormForPits ffp = new FormForPits(this.yamahaTeam);

            m.speedChanged += new Motorbike.SpeedChangedHandler(f.ShowCurrentSpeed);
            m.speedTooFast += new Motorbike.SpeedChangedHandler(f.ShowWarning);

        }

        private void btnChangeSpeed_Click(object sender, EventArgs e)
        {
            Motorbike m = this.yamahaTeam.GetByName("Rossi");
            m.Accelerate(Convert.ToInt32(this.textBox1.Text));
        }
    }
}
