using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2____FiFo_Waiting_List
{
    public partial class Form1 : Form
    {
        private WaitingList wl;
        public Form1()
        {
            InitializeComponent();
            wl = new WaitingList("Health Care");
            AddSomeTestStuff();
            DisplayFirst5s();
        }

        public void AddSomeTestStuff()
        {
            wl.InsertAtEnd(new Visitor("Alireza", "Headeach", Preference.DrCarla));
            wl.InsertAtEnd(new Visitor("Fatemeh", "Preganancy", Preference.Nothing));
            wl.InsertAtEnd(new Visitor("Ali", "Leg Pain", Preference.DrCarla));
            wl.InsertAtEnd(new Visitor("Mohammad", "Injury", Preference.DrJohn));
            wl.InsertAtEnd(new Visitor("Navid", "Having cold", Preference.DrCarla));
        }
        public void DisplayFirst5s()
        {
            List<Nodes> first5 = new List<Nodes>();
            LbPeopleinQueue.Items.Clear();
            for (int i = 1; i < 6; i++)
            {
                var temp = wl.FindNodeAt(i);
                first5.Add(temp);
            }

            foreach (var n in first5)
            {
                if (n == null)
                {
                    LbPeopleinQueue.Items.Add("=======================");
                    LbPeopleinQueue.Items.Add("There is no more poeple in the list");
                    break;
                }
                else
                {
                    LbPeopleinQueue.Items.Add($"{first5.IndexOf(n)+1}: {n.GetVisitor.ToString()}");
                }
            }

            lblCount.Text = wl.Count.ToString();
            lblNrJohn.Text = wl.PrefCount[0].ToString();
            lblNrCarl.Text = wl.PrefCount[1].ToString();
            lblNrNoPref.Text = wl.PrefCount[2].ToString();
            lblTotalNr.Text = wl.Count.ToString();
        }
        void UpdateDisplays(string doctor, Nodes n)
        {
            DisplayFirst5s();
            if (n == null)
            {
                if (doctor.Equals("Carla"))
                {
                    lblDrCarlaStatus.Text = "There is no patient for you at the moment";
                }
                else
                {
                    lblDrJohnStatus.Text = "There is no patient for you at the moment";
                }
            }
            else
            {
                if (wl.Count!=0)
                {
                    LbPeopleinQueue.Items.Insert(0, "========");
                }
                LbPeopleinQueue.Items.Insert(0, $"Patient {n.GetVisitor.Name} - please proceed to Dr {doctor} office.");
                if (doctor.Equals("Carla"))
                {
                    lblDrCarlaStatus.Text = n.GetVisitor.ToString();
                }
                else
                {
                    lblDrJohnStatus.Text = n.GetVisitor.ToString();
                }
            }
            }

        
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string name = TbName.Text;
            string reason = TbReason.Text;
            Preference pref = (RbDr_John.Checked) ? Preference.DrJohn :
                (RbDr_Carla.Checked) ? Preference.DrCarla : Preference.Nothing ;
            Visitor temp = new Visitor(name,reason,pref);
            wl.InsertAtEnd(temp);
            DisplayFirst5s();
        }
        private void BtnJohnNext_Click(object sender, EventArgs e)
        {
            var temp = wl.FindNextJohn();
            UpdateDisplays("John", temp);

        }
        private void BtnCarlaNext_Click(object sender, EventArgs e)
        {
            var temp = wl.FindNextCarla();
            UpdateDisplays("Carla",temp);
        }

        private void GbDr_Carla_Enter(object sender, EventArgs e)
        {

        }
    }
}
