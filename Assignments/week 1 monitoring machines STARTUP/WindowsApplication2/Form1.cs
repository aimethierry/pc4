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
            mc = new ManufacturingCompany("VOL");
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;

        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            try
            {
                lbInfo.Items.Clear();
                lbInfo.Items.Add(mc.ToString());
                lbInfo.Items.Add("");
                foreach (Machine m in mc.Machines)
                {
                    lbInfo.Items.Add(m.ToString());
                }
            }
            catch (Exception) { }
        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            try
            {
                Machine m = new Machine(tbMachineName.Text, Convert.ToInt32(tbTemp.Text), Convert.ToInt32(tbPressure.Text));

                if (mc.AddMachine(m))
                {
                    MessageBox.Show("Successfully added");
                    m.CriticalState += new Machine.CriticalStateHandler(this.ShowWarning);
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
            try
            {
                if (btnLogging.Text != "Stop Logging")
                {
                    Machine m = mc.GetMachine(tbMachineName.Text);
                    if (m != null)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {

                            m.CriticalState += new Machine.CriticalStateHandler(LogText);

                            MessageBox.Show("logging started!");

                            btnLogging.Text = "Stop Logging";
                        }
                        else
                        {
                            MessageBox.Show("You have canceled");
                        }

                    }
                    else
                    {
                        MessageBox.Show("We do not have a machine with this name");
                    }
                }
                else
                {
                    Machine m = mc.GetMachine(tbMachineName.Text);
                    if (m != null)
                    {


                        m.CriticalState -= new Machine.CriticalStateHandler(LogText);

                        MessageBox.Show("logging stopped!");

                        btnLogging.Text = "start Logging";


                    }
                    else
                    {
                        MessageBox.Show("We do not have a machine with this name");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.ShowDialog();
            if (savefile.FileName != "")
            {
                foreach (Machine m in mc.Machines)
                {
                    m.removeAllCriticalStateHandlers();
                }
                FileStream fs = null;
                BinaryFormatter bf = null;
                try
                {
                    fs = new FileStream(savefile.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    bf = new BinaryFormatter();
                    bf.Serialize(fs, mc);
                }
                catch (IOException) { MessageBox.Show("I/O Error"); }
                catch (SerializationException) { MessageBox.Show("serialization Error"); }
                finally
                {
                    if (fs != null) { fs.Close(); MessageBox.Show("Saving Done"); }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                BinaryFormatter bf = null;
                try
                {
                    fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    bf = new BinaryFormatter();
                    lbInfo.Items.Clear();
                    mc = (ManufacturingCompany)(bf.Deserialize(fs));
                    btnShowInfo.PerformClick();
                    
                }
                catch (IOException) { MessageBox.Show("I/O Error"); }
                catch (SerializationException) { MessageBox.Show("serialization Error Maybe wrong file"); }
                finally
                {
                    if (fs != null) { fs.Close(); MessageBox.Show("loading Done"); }
                }
            }
        }

        private void ShowWarning(Machine m, String extraInfo)
        {
            this.lbWarnings.Items.Add(m.Name + " " + extraInfo.ToString() + "!!");
        }
        private void LogText(Machine m, String extraInfo)
        {

            string log = DateTime.Now + " " + extraInfo.ToString() + "!!" + " " + m.ToString();
            GenerateTextFileReport(saveFileDialog1.FileName, log);



        }
        public void GenerateTextFileReport(string filename, string log)
        {
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);

                sw.WriteLine(log);




            }
            catch (IOException)
            {
                MessageBox.Show("I/O Exception Was Thrown!");
            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();


            }

        }


    }
}