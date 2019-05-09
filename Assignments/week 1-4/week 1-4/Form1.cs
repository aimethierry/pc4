using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_1_4
{
    public partial class Form1 : Form
    {
        
        Clock c;
        alarms alarms;
        public Form1()
        {
            InitializeComponent();
            alarms = new alarms("Myalarms");

            tbhrs.Text = DateTime.Now.Hour.ToString();
            tbmin.Text = DateTime.Now.Minute.ToString();
            //
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnincrhr_Click(object sender, EventArgs e)
        {
            c.incrementHour();
            tbhrs.Text = c.Hour.ToString();
        }

        private void min_Click(object sender, EventArgs e)
        {
            c.incrementMinute();

            tbhrs.Text = c.Hour.ToString();
            tbmin.Text = c.Minute.ToString();
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            c = new Clock(DateTime.Now.Hour, DateTime.Now.Minute,Convert.ToInt32(tbsethr.Text), Convert.ToInt32(tbsetmin.Text));
            alarms.AddAlarm(new Person(tbname.Text, c));
            tbhrs.Text = c.Hour.ToString();
            tbmin.Text = c.Minute.ToString();

            //p.AddAlarm(new Person(tbname.Text, c));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(Person p in alarms.GetAllAlarms())
            {
                listBox1.Items.Add(p.Info);
            }
        }
    }
}
