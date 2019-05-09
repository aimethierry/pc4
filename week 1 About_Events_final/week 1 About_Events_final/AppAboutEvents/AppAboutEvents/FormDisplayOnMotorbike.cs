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
    public partial class FormDisplayOnMotorbike : Form
    {
        public FormDisplayOnMotorbike(Motorbike m)
        {
            InitializeComponent();
            this.lblNameOfDriver.Text = m.NameOfDriver;
            this.Visible = true;
        }

        public void ShowCurrentSpeed(Motorbike m, int extraInfo)
        {
            this.lblCurrentSpeed.Text = "speed: " + m.Speed.ToString();
            this.lblWarning.Visible = (m.Speed > m.MaxSpeed);
        }

        public void ShowWarning(Motorbike m, int extraInfo)
        {
            this.lblWarning.Text = "Slow down! " +
                                   extraInfo.ToString() +
                                   " km/h over the limit!!!";
        }

        private void FormDisplayOnMotorbike_Load(object sender, EventArgs e)
        {

        }
    }
}
