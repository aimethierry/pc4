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
        private SecretCombi sc;
        private int[] guess = new int[4];
        private int Nrtries;
        private int credits = 100;
        public Form1()
        {
            sc = new SecretCombi();
            InitializeComponent();
            var answer = sc.Secret;
            label2.Text = $"{answer[0]},{answer[1]},{answer[2]},{answer[3]}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nrtries++;
            if (Nrtries < 10)
            {
                int score1, score2;
                try
                {
                    guess[0] = Convert.ToInt32(textBox1.Text);
                    guess[1] = Convert.ToInt32(textBox2.Text);
                    guess[2] = Convert.ToInt32(textBox3.Text);
                    guess[3] = Convert.ToInt32(textBox4.Text);
                    bool result = sc.Compare(guess, out score1, out score2);
                    ShowInListBox(guess, score1, score2);
                    Credit(ref credits,score1,score2);
                    if (result)
                    {
                        MessageBox.Show($"Perfect, You gussed the secret combi successfully!\n" +
                                        $"You Score is {credits}");
                        button1.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something goes wrong!\n{ex.Message}");
                    button1.Enabled = false;
                }
            }
            else
            {
                var answer = sc.Secret;
                MessageBox.Show($"You tried {Nrtries} and lost - Game Over\n" +
                                $"You Score is {credits}\n" +
                                $"The answer was {answer[0]},{answer[1]},{answer[2]},{answer[3]}");
                button1.Enabled = false;
            }
            
            
        }

        private void Credit(ref int credit, int score1, int score2)
        {
            if (!(score1 == 4 && score2 == 0))
            {
                int sum = score1 + score2;
                if ( sum >= 3)
                {
                    credit -= 5;
                }
                else if( sum==1 || sum ==2 )
                {
                    credit -= 10;
                }else if (score1 == 0 && score2 == 0)
                {
                    credit -= 15;
                }
            }
        }

        private void ShowInListBox(int[] guess, int a, int b)
        {
            listBox1.Items.Add($"{guess[0]},{guess[1]},{guess[2]},{guess[3]}:\t" +
                               $"Score-1 :  {a}\t" +
                               $"Score-2 :  {b}");
        }
    }
}