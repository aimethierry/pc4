using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        private SecretCombi mySecretCombi;
        public int credits=100;
        public Form1()
        {
            InitializeComponent();
            mySecretCombi=new SecretCombi();
            mySecretCombi.YouLost += new SecretCombi.LostGame(showinfo); 

        }


        public void showinfo(string s )
        {
            MessageBox.Show(s);
            
        }
        private void btncheckresult_Click(object sender, EventArgs e)
        {
            try
            {
                int gs1, gs2, gs3, gs4;
                gs1 = Convert.ToInt32(tbgs1.Text);
                gs2 = Convert.ToInt32(tbgs2.Text);
                gs3 = Convert.ToInt32(tbgs3.Text);
                gs4 = Convert.ToInt32(tbgs4.Text);
                int[] guess = new[] {gs1, gs2, gs3, gs4};
                bool result = mySecretCombi.guess(guess, out int score1, out int score2,ref credits);
                if(result)
                {
                    MessageBox.Show("You Win My HOmie! Your credits are: "+credits);
                }
                listBox1.Items.Add(string.Join(",", guess) + ":    Score-1: " + score1 +
                                                       "    Score-2: " + score2 + " Your credits are: "+credits);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }
    }
}