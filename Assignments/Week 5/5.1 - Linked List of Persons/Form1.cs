using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._1___Linked_List_of_Persons
{
    public partial class Form1 : Form
    {
        Linked_List linked;
        public Form1()
        {
            InitializeComponent();
            linked = new Linked_List();
            AddSomeTestStuff();
            DisplayPerson();
        }

        public void DisplayPerson()
        {
            listBox1.Items.Clear();
            Person temp = linked.firstPerson;

            if (temp == null)
            {
                listBox1.Items.Add("There is no Person in Linked List");
            }
            else
            {
                while (temp!=null)
                {
                    listBox1.Items.Add($"{temp.Name}");
                    temp = temp.Next;
                }
            }

        }

        public void AddSomeTestStuff()
        {
            linked.AddNewPerson("Ali");
            linked.AddNewPerson("Alireza");
            linked.AddNewPerson("Hossein");
            linked.AddNewPerson("Mohammad");
            linked.AddNewPerson("Navid");
            linked.AddNewPerson("Parsa");
            linked.AddNewPerson("Zahra");
        }
                
        private void BtnNewPerson_Click(object sender, EventArgs e)
        {
            string name = TbName.Text;
            linked.AddNewPerson(name);
            DisplayPerson();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string name = TbName.Text;
            Person temp = linked.FindPerson(name);
            if (temp == null)
            {
                MessageBox.Show($"These is not person with given name of {name}");
            }
            else
            {
                linked.DeletePerson(temp);
                DisplayPerson();                
            }
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            string isAre;
            string s;
            isAre = (linked.count == 1 || linked.count==0) ? "is" : "are" ;
            s = (linked.count == 1 || linked.count == 0) ? "" : "s";
            listBox1.Items.Add($"There {isAre} {linked.count} person{s} in the linked list");
        }

        private void BtnPersonNth_Click(object sender, EventArgs e)
        {
            int Nr = Convert.ToInt32(TbName.Text);
            var temp = linked.FindPersonAt(Nr);
            if (temp == null)
            {
                MessageBox.Show($"There is not person at given index of {Nr}");
            }
            else
            {
                MessageBox.Show($"The name of {Nr} person is : {temp.Name}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
