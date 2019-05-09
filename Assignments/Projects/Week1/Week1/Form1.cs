using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1
{
    public partial class Form1 : Form
    {
        public String input;
        public Form1()
        {
            InitializeComponent();
        }


        public delegate String ConvertToRequiredString(String s);
        public ConvertToRequiredString GetAnswer;


        private String changeToNextCharacter(String s)
        {
            char[] chars = s.ToCharArray(); //now chars is an array containing all the characters of string s
            for (int i = 0; i < chars.Length; i++)
            {
                char ch = chars[i];
                if ((ch >= 'a' && ch < 'z') || (ch >= 'A' && ch < 'Z'))
                {
                    chars[i]++;
                }
                else
                {
                    if (ch == 'z') { chars[i] = 'a'; }
                    if (ch == 'Z') { chars[i] = 'A'; }
                }
            }
            //now add the characters in the array chars one by one to the answer-string
            String answer = "";
            foreach (char ch in chars) { answer += ch; }
            return answer;
        }

        private String changeToUpper(String s)
        {
           
            return s.ToUpper();
        }
        private String changeToFormerCharacter(String s)
        {
            char[] chars = s.ToCharArray(); //now chars is an array containing all the characters of string s
            for (int i = 0; i < chars.Length; i++)
            {
                char ch = chars[i];
                if ((ch > 'a' && ch <= 'z') || (ch > 'A' && ch <= 'Z'))
                {
                   chars[i]--;
                }
                else
                {
                    if (ch == 'a') { chars[i] = 'z'; }
                    if (ch == 'A') { chars[i] = 'Z'; }
                }
            }
            //now add the characters in the array chars one by one to the answer-string
            String answer = "";
            foreach (char ch in chars) { answer += ch; }
            return answer;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.GetAnswer = new ConvertToRequiredString(changeToUpper);

            label1.Text = "Upper";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.GetAnswer = new ConvertToRequiredString(changeToNextCharacter);

            label1.Text = "Next";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.GetAnswer = new ConvertToRequiredString(changeToFormerCharacter);

            label1.Text = "former";
        }

        private void DOIT_Click(object sender, EventArgs e)
        {
            input = tbinput.Text;
            tboutput.Text = GetAnswer(input);
        }
    }
}
