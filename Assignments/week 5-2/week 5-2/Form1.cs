using System;
using System.Windows.Forms;

namespace week_5_2
{
    public partial class Form1 : Form
    {
        private WaitingList waitinglist;
        public Form1()
        {
            InitializeComponent();
            waitinglist = new WaitingList();
            waitinglist.AddPatient(new Patient("Subhi", "I can't see when my eyes are closed", "Carla"));
            waitinglist.AddPatient(new Patient("Musti", "I can't walk while i am lying in my bed", "Carla"));

            waitinglist.AddPatient(new Patient("Gael", "Sometimes I can't Sleep", "Any"));
            waitinglist.AddPatient(new Patient("Robot", "My battery dries really fast", "John"));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbCarla.Checked)
                {
                    waitinglist.AddPatient(new Patient(tbname.Text, tbreason.Text, "Carla"));
                }
                else if (rbJohn.Checked)
                {
                    waitinglist.AddPatient(new Patient(tbname.Text, tbreason.Text, "John"));
                }
                else if (rbany.Checked)
                {
                    waitinglist.AddPatient(new Patient(tbname.Text, tbreason.Text, "Any"));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btntest_Click(object sender, EventArgs e)
        {
            lbDisplay.Items.Clear();

            if (waitinglist.GetAllNode() != null)
            {
                if (waitinglist.GetAllNode().Count < 5)
                {
                    lbDisplay.Items.Add("There are only " + waitinglist.GetAllNode().Count + " waiting in the queue!");
                    lbDisplay.Items.Add("&^&&^&&^&&^&&^&&^&&^&&^&&^&");
                    foreach (Node v in waitinglist.GetAllNode())
                    {
                        if (v != null)
                        {
                            lbDisplay.Items.Add(v.GetPatient());
                        }
                    }
                }
                else
                {
                    lbDisplay.Items.Add("There are " + waitinglist.GetAllNode().Count + " waiting in the queue!");
                    lbDisplay.Items.Add("The First 5 to go are: ");
                    for (int i = 0; i < 5; i++)
                    {
                        lbDisplay.Items.Add(
                            ((Node) waitinglist.GetAllNode()[i]).GetPatient());
                    }
                }
            }




        }

        private void btnNextJohn_Click(object sender, EventArgs e)
        {
            Patient temp = waitinglist.GetPatient("John");
            if (temp != null)
            {
                lblJohnName.Text=temp.Name;
                lblReasonJhon.Text=temp.Reason;
                waitinglist.RemoveName(temp);
                lblnamenext.Text = temp.Name;
                lbldoctrnext.Text = "John";
                btntest.PerformClick();
            }
            else
            {
                lblJohnName.Text = "No More Patients";
            }
        }

        private void btnNextCarla_Click(object sender, EventArgs e)
        {
            Patient temp = waitinglist.GetPatient("Carla");
            if (temp != null)
            {
                lblCarlaName.Text=temp.Name;
                lblReasonCarla.Text=temp.Reason;
                waitinglist.RemoveName(temp);
                lblnamenext.Text = temp.Name;
                lbldoctrnext.Text = "Carla";
                btntest.PerformClick();
            }
            else
            {
                lblCarlaName.Text = "No More Patients";
            }
        }
    }
}

