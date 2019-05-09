using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;                    //because of FileStream
using System.Runtime.Serialization.Formatters.Binary; //because of BinaryFormatter
using System.Runtime.Serialization; //because of SerializationException

namespace AppAboutBinaryFiles
{
    public partial class Form1 : Form
    {
       // private Thing t;
        private BunchOfThings bot;

        public Form1()
        {
            InitializeComponent();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            //t = new Thing("Flupke", 65, true);
            //for next example: C&P from below
            bot = new BunchOfThings("Sensational shelter of lost animals");
            bot.AddThing("flupke", 23, true);
            bot.AddThing("floortje", 95, false);
            bot.AddThing("blubje", 17, true);

        }

        private void btSaveToBinaryFile_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream("../../myTest.txt", FileMode.Create, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, bot);
                listBox1.Items.Add("*************saving is done*********************");
            }
            catch (SerializationException)
            { listBox1.Items.Add("something wrong with Serialization"); }
            catch (IOException)
            { listBox1.Items.Add("something wrong with IO"); }
            finally
            {
                if (fs != null) fs.Close();
            }

            
        }

        private void btLoadFromBinaryFile_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream("../../myTest.txt", FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                bot = (BunchOfThings)(bf.Deserialize(fs));
                //listBox1.Items.Add(t.ToString());
                //for next example: C&P from below
                listBox1.Items.Add("Name is " + bot.GetName());
                listBox1.Items.Add("Number of things in it is " + Convert.ToString(bot.GetNumberOfThings()));
                foreach (Thing t in bot.GetAllThings())
                {
                    listBox1.Items.Add(t.ToString());
                }
            }
            catch (SerializationException)
            { listBox1.Items.Add("something wrong with Serialization"); }
            catch (IOException)
            { listBox1.Items.Add("something wrong with IO"); }
            finally
            {
                if (fs != null) fs.Close();
            }

            listBox1.Items.Add("*************loading is done*********************");
        }

    }
}

//for fast copying, saving typing time

//bot = new BunchOfThings("Sensational shelter of lost animals");
//bot.AddThing("flupke", 23, true);
//bot.AddThing("floortje", 95, false);
//bot.AddThing("blubje", 17, true);


//listBox1.Items.Add("Name is " + bot.GetName());
//listBox1.Items.Add("Number of things in it is " + Convert.ToString(bot.GetNumberOfThings()));
//foreach (Thing t in bot.GetAllThings())
//{
//    listBox1.Items.Add(t.ToString());
//}


