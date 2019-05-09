using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Store s;

        public Form1()
        {
            InitializeComponent();
            s = new Store();
            this.AddSomeTestingStuff();
            this.ShowStoreInListbox();
        }


        private void btSort1_Click(object sender, EventArgs e)
        {
            this.s.SortById();
            this.ShowStoreInListbox();

        }

        private void btSort2_Click(object sender, EventArgs e)
        {
            this.s.SortByName();
            this.ShowStoreInListbox();
        }

        private void btSort3_Click(object sender, EventArgs e)
        {
            this.s.SortbyNumberOfCredits();
            this.ShowStoreInListbox();
        }

        private void ShowStoreInListbox()
        {
            this.listBox1.Items.Clear();
            this.listBox1.Items.Add("Id  -  name  -  nrOfCredits");
            foreach (Drumble d in this.s.Drumbles)
            {
                this.listBox1.Items.Add(d.ToString());
            }
        }

        private void AddSomeTestingStuff()
        {
            s.AddDrumble(new Drumble(6, "Cristian", 307));
            s.AddDrumble(new Drumble(1, "Laurentiu", 322));
            s.AddDrumble(new Drumble(14, "Matei", 310));
            s.AddDrumble(new Drumble(15, "Filip", 300));
            s.AddDrumble(new Drumble(38, "Dimitrije", 251));
            s.AddDrumble(new Drumble(23, "Eda", 302));
            s.AddDrumble(new Drumble(34, "David", 287));
            s.AddDrumble(new Drumble(35, "Samuel", 285));
            s.AddDrumble(new Drumble(16, "Danas", 320));
            s.AddDrumble(new Drumble(77, "Luc", 300));
            s.AddDrumble(new Drumble(17, "Valerian", 300));
            s.AddDrumble(new Drumble(18, "Abraham", 310));
            s.AddDrumble(new Drumble(20, "Duc", 299));
            s.AddDrumble(new Drumble(27, "Yvan", 260));
            s.AddDrumble(new Drumble(30, "Reno", 400));
            s.AddDrumble(new Drumble(31, "Andonis", 265));
            s.AddDrumble(new Drumble(43, "Aime Thierry", 304));
            s.AddDrumble(new Drumble(42, "Henne", 411));
            s.AddDrumble(new Drumble(32, "Run", 399));
            s.AddDrumble(new Drumble(33, "Yue Kai", 290));
            s.AddDrumble(new Drumble(33, "Mahmoud", 301));
            s.AddDrumble(new Drumble(49, "Camiel", 320));
            s.AddDrumble(new Drumble(72, "Stijn", 315));
            s.AddDrumble(new Drumble(74, "Desislava", 320));
            s.AddDrumble(new Drumble(47, "Chao", 320));
            s.AddDrumble(new Drumble(33, "Sinterklaas", 301));
            s.AddDrumble(new Drumble(65, "Djamali", 301));
            s.AddDrumble(new Drumble(84, "Djamali", 301));
            s.AddDrumble(new Drumble(54, "Flupke", 301));

        }



    }
}
