using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace WindowsApplication2
{
    public partial class Form1 : Form
    {
        private ManufacturingCompany mc;
        public Form1()
        {
            InitializeComponent();
            mc = new ManufacturingCompany("VDL assembling Mini Cooper");
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
            lbInfo.Items.Add(mc.ToString());
            lbInfo.Items.Add("");
            foreach (Machine m in mc.Machines)
            {
                lbInfo.Items.Add(m.ToString());
            }
        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            try
            {
                Machine m = new Machine(tbMachineName.Text, Convert.ToInt32(tbTemp.Text), Convert.ToInt32(tbPressure.Text));
               
                if (mc.AddMachine(m))
                {
                    MessageBox.Show("Successfully added");
                    m.CriticalState += new Machine.CriticalStateHandler(this.GetInfo);
                }
                else
                {
                    MessageBox.Show("We already have a machine with that name");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in some numbers for temperature and pressure");
            }

        }

        private void btnSimulateTemperature_Click(object sender, EventArgs e)
        {
            try
            {
                Machine m = mc.GetMachine(tbMachineName.Text);
                if (m != null)
                {
                    m.SetTemperature(Convert.ToInt32(tbTemp.Text));
                }
                else
                {
                    MessageBox.Show("We do not have a machine with this name");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in a number for temperature");
            }
        }

        private void btnSimulatePressure_Click(object sender, EventArgs e)
        {
            //todo

            try
            {
                Machine m = mc.GetMachine(tbMachineName.Text);
                if (m != null)
                {
                    m.SetPressure(Convert.ToInt32(tbPressure.Text));
                }
                else
                {
                    MessageBox.Show("We do not have a machine with this name");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill in a number for pressure");
            }
        }

        private void btnLogging_Click(object sender, EventArgs e)
        {
            //todo
            
            try {

                if(btnLogging.Text!="Stop Logging")
                {
                    Machine m = mc.GetMachine(tbMachineName.Text);
                    if (m != null)
                    {
                        m.CriticalState += new Machine.CriticalStateHandler(log);
                    }
                    MessageBox.Show("Loggin Started");
                    btnLogging.Text = "Stop Logging";
                }
                else
                {
                   /* Machine m = mc.GetMachine(tbMachineName.Text);
                    if (m != null)
                    {
                        m.CriticalState -= new Machine.CriticalStateHandler(log);
                    }*/
                    MessageBox.Show("Logging Stopped");
                    btnLogging.Text = "Start Logging";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ooops!!");
            }

        }
        private void log(Machine m , string info)
        {
            string textfile = DateTime.Now + m.ToString() + " Machine : " + "" + info;

           // string fileName = "C:/Users/aimethierry/Desktop";
            
            FileStream fs = new FileStream("../text.txt", FileMode.Append, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(textfile);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //todo

            string fileName = "C:/Users/Ov/Documents/votesFromEindhoven.txt";
            FileStream fs = null;
            BinaryFormatter bf = null;
            foreach (Machine m in mc.Machines)
            {
                m.removeAllCriticalStateHandlers();
            }
            try
            {
                fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, mc);
            }
            catch (IOException) { MessageBox.Show("I/O Error"); }
            catch (SerializationException) { MessageBox.Show("serialization Error"); }
            finally
            {
                if (fs != null) { fs.Close(); }
            }
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //todo
            string fileName = "C:/Users/Ov/Documents/votesFromEindhoven.txt";
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                lbInfo.Items.Clear();
                mc = (ManufacturingCompany)(bf.Deserialize(fs));

            }
            catch (IOException) { MessageBox.Show("I/O Error"); }
            catch (SerializationException) { MessageBox.Show("serialization Error"); }
            finally
            {
                if (fs != null) { fs.Close(); }
            }
        }
        

        private void GetInfo(Machine sender , string reason)
        {
            
            this.lbWarnings.Items.Clear();
            this.lbWarnings.Items.Add(sender.Name +", is malfunctioning, " + "Reason : " +reason);
        }
    }
}