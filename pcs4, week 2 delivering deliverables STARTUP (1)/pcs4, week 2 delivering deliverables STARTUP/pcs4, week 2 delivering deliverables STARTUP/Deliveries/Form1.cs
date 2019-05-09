using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  //because we are using files
namespace Deliveries
{
    public partial class Form1 : Form
    {
        TransportCompany t;
        string filename;
        string filenamed;
        public Form1()
        {
            InitializeComponent();
            t = new TransportCompany();
            
            /*t.AddPerson(new Person(22, "Mr. Blue", "Zaragossastraat", 41, "5688DH", "Eindhoven"));
            t.AddPerson(new Person(11, "Sven Krame", "Mainstreet", 33, "5688G", "Eindhoven"));
            t.AddPerson(new Person(33, "Naomi van As", "Mainstreet", 33, "5688GE", "Eindhoven"));
            t.AddPerson(new Person(77, "Bruno Mars", "Kerkstraat", 39, "5693DE", "Eindhoven"));
            t.AddPerson(new Person(55, "Anouk", "Kerkstraat", 10, "5693DE", "Eindhoven"));


            t.AddDeliverable(new Deliverable(2, 700, new Person(11, "Sven Krame", "Mainstreet", 33, "5688G", "Eindhoven")));
            t.AddDeliverable(new Deliverable(1, 700, new Person(22, "Sven Kramer", "Mainstreet", 33, "5688G", "Eindhoven")));
         
            t.AddDeliverable(new Deliverable(3, 360, new Person(33, "Naomi van As", "Mainstreet", 33, "5688GE", "Eindhoven")));
            t.AddDeliverable(new Deliverable(4, 500, new Person(77, "Bruno Mars", "Kerkstraat", 39, "5693DE", "Eindhoven")));
            t.AddDeliverable(new Deliverable(5, 900, new Person(55, "Anouk", "Kerkstraat", 10, "5693DE", "Eindhoven"))); */
        }

        public void Getfilename()
        {
            SaveFileDialog f = new SaveFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                filename = f.FileName;
            }
            else
            {
                MessageBox.Show("you choosed for cancel ");
            }

        }


        public void Getfilenamederivalable()
        {
            SaveFileDialog f = new SaveFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                filenamed = f.FileName;
            }
            else
            {
                MessageBox.Show("you choosed for cancel ");
            }

        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            this.Getfilename();
            t.LoadPersonsFromFile(filename);


            Getfilenamederivalable();
            t.LoadDeliverablesFromFile(filenamed);

            Showdata();
        }



        private void btSortByWeight_Click(object sender, EventArgs e)
        {
            t.SortByWeight();
            Showdata();
        }

        private void btSortByName_Click(object sender, EventArgs e)
        {
            t.SortByName();
            Showdata();

        }

        private void btSortById_Click(object sender, EventArgs e)
        {
            t.SortById();
            Showdata();
        }

        private void btSortByAddress_Click(object sender, EventArgs e)
        {
            t.SortByAddress();
            Showdata();
        }

        private void btSortForPostman_Click(object sender, EventArgs e)
        {
            t.SortForPostman();
            Showdata();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Getfilenamederivalable();
            t.LoadDeliverablesFromFile(filenamed);
           
        }

        private void Showdata()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < t.GetDeliverables().Length; i++)
            {
                listBox1.Items.Add(t.GetDeliverables()[i].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
